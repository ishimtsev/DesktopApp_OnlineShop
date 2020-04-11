using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DesktopApp_OnlineShop
{
	public static class DataBase
	{
		public static NpgsqlConnection connection;

		public static void connect()
		{
			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Config.ConnString))
				{
					cn.Open();
					connection = cn;
				}
			}
			catch (Exception er)
			{
				//обработка
			}
		}

		public static void disconnect()
		{
			connection.Close();
		}
	}
}
