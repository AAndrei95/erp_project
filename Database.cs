using System.Data.SQLite;

namespace Digital_Shop_Software
{
    internal class Database
    {
        private Database() { }
        public static SQLiteConnection CreateConnection()
        {
            // Getting database file path
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(
                currentPath,
                @"..\..\..\Digital Shop Database\Digital Shop Database.db"
            );
            string sFilePath = Path.GetFullPath(sFile);
            //Creating a new connection and opening it
            string connectionString = "Data Source=" + sFilePath + ";Version=3;";
            
            return new SQLiteConnection(connectionString);
        }
    }
}
