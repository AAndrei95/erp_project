using Digital_Shop_Software.Data;
using System.Data.SQLite;

namespace Digital_Shop_Software.Tests
{
    public static class TestDatabase
    {
        private static string databasePath = "";

        public static void Initialize()
        {
            databasePath = Path.Combine(
                Path.GetTempPath(),
                $"erp_test_{Guid.NewGuid()}.db");

            string connectionString =
                $"Data Source={databasePath};Version=3;";

            Database.Configure(connectionString);

            using SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                """
                CREATE TABLE Users (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    Position TEXT NOT NULL,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    DoB NUMERIC NOT NULL,
                    Sex TEXT,
                    Email TEXT,
                    PhoneNumber TEXT,
                    SecurityQuestion TEXT NOT NULL,
                    SQAnswer TEXT NOT NULL
                );
                """,
                connection);

            command.ExecuteNonQuery();

            using SQLiteCommand clientCommand = new SQLiteCommand(
                """
                CREATE TABLE Client (
                    ClientId INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    Email TEXT,
                    PhoneNumber TEXT,
                    Registered INTEGER,
                    OrderDate INTEGER,
                    LastOrder INTEGER,
                    UserId INTEGER
                );
                """,
                connection);

            clientCommand.ExecuteNonQuery();

            using SQLiteCommand supplierCommand = new SQLiteCommand(
                """
                CREATE TABLE Supplier (
                    SupplierId INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    SupplierName TEXT,
                    Description TEXT,
                    Email TEXT,
                    PhoneNumber TEXT,
                    Representative TEXT
                );
                """,
                connection);

            supplierCommand.ExecuteNonQuery();

            using SQLiteCommand productCommand = new SQLiteCommand(
                """
                CREATE TABLE Product (
                    ProductId INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    Name TEXT,
                    Category TEXT,
                    Description TEXT,
                    SupplierPrice NUMERIC,
                    SalePrice NUMERIC,
                    Qty INTEGER,
                    OnOrder INTEGER,
                    OnOrderQty INTEGER,
                    DeliveryDate INTEGER,
                    fk_SupplierId INTEGER,
                    fk_UserId INTEGER
                );
                """,
                connection);

            productCommand.ExecuteNonQuery();
        }

        public static void Cleanup()
        {
            Database.ResetConfiguration();

            if (File.Exists(databasePath))
            {
                File.Delete(databasePath);
            }
        }
    }
}
