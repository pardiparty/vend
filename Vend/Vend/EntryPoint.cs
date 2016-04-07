using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend
{
	class EntryPoint
	{
		/**
		 * Basic entry point for application.
		 */
		public static void Main(string[] args)
		{
			string dir = System.Reflection.Assembly.GetEntryAssembly().Location;
			string dbPath = dir + "\\..\\db\\test.db";
			SQLiteConnection conn = new SQLiteConnection("Data Source='" + dbPath + "';Version=3");
			conn.Open();

			string sql = "SELECT * FROM `Monster_Names`;";
			SQLiteCommand command = new SQLiteCommand(sql, conn);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Console.WriteLine("Name: " + reader["name"]);
			}

			Console.ReadKey();
		}
	}
}
