using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class DataAccessBLL
	{
		public bool SetupConnection(string serverName, string databaseName)
		{
			DataAccessDAL.SetConnectionString(serverName, databaseName);
			return DataAccessDAL.TestConnection();
		}
	}
}
