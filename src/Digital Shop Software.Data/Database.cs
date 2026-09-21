using System.Data.SQLite;

namespace Digital_Shop_Software.Data
{
    internal class Database
    {
        private Database() { }

        private static string? configuredConnectionString;

        public static void Configure(string connectionString)
        {
            configuredConnectionString = connectionString;
        }

        public static void ResetConfiguration()
        {
            configuredConnectionString = null;
        }

        public static SQLiteConnection CreateConnection()
        {
            if (configuredConnectionString != null)
            {
                return new SQLiteConnection(configuredConnectionString);
            }

            string currentPath = AppDomain.CurrentDomain.BaseDirectory;

            string sFile = System.IO.Path.Combine(
                currentPath,
                @"..\..\..\Digital Shop Database\Digital Shop Database.db"
            );

            string sFilePath = Path.GetFullPath(sFile);

            string connectionString =
                "Data Source=" + sFilePath + ";Version=3;";

            return new SQLiteConnection(connectionString);
        }
    }
}
