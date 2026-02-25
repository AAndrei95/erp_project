using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Shop_Software
{
    internal class Database
    {
        public static SQLiteConnection instance;
        private Database() { }
        public static SQLiteConnection GetInstance()
        {
            if (instance == null)
            {
                // Getting database file path
                string currentPath = AppDomain.CurrentDomain.BaseDirectory;
                string sFile = System.IO.Path.Combine(currentPath, @"..\..\..\Digital Shop Database\Digital Shop Database.db");
                string sFilePath = Path.GetFullPath(sFile);
                //Creating a new connection and opening it
                instance = new SQLiteConnection("Data Source="+sFilePath+";Versio=3;");
            }
            return instance;
        }
    }
}


