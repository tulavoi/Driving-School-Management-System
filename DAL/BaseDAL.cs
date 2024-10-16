using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseDAL<T>
    {
        protected abstract IEnumerable<dynamic> QueryAllData();

        protected abstract IEnumerable<dynamic> QueryDataByKeyword(string keyword);

        protected abstract IEnumerable<dynamic> QueryDataByFilter(string filterString);


        protected List<T> MapToList(IEnumerable<dynamic> data, Func<dynamic, T> mapFunction)
        {
            if (data == null) return new List<T>();

            return data.Select(mapFunction).ToList();
        }

        protected List<T> ExecuteQuery(Func<IEnumerable<dynamic>> queryFunction, Func<dynamic, T> mapFunction)
        {
            var data = queryFunction();
            return MapToList(data, mapFunction);
        }

        public List<T> GetAll(Func<dynamic, T> mapFunction)
        {
            return this.ExecuteQuery(QueryAllData, mapFunction);
        }

        public List<T> SearchData(string keyword, Func<dynamic, T> mapFunction)
        {
            var data = QueryDataByKeyword(keyword);
            return this.ExecuteQuery(() => QueryDataByKeyword(keyword), mapFunction);
        }

        public List<T> FilterData(string filterString, Func<dynamic, T> mapFunction)
        {
            var data = QueryDataByFilter(filterString);
            return this.ExecuteQuery(() => QueryDataByFilter(filterString), mapFunction);
        }
    }
}
