using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;


namespace TinahBridals
{
    internal class DatabaseHelper
    {
        private string connectionString = "Data Source=TinahBridal.db;Version=3";
        public void InitializeDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Transactions (ID INTEGER PRIMARY KEY AUTOINCREMENT,itemName TEXT NOT NULL, unitPrice REAL NOT NULL, Quantity INTEGER NOT NULL, totalAmount REAL NOT NULL, amountPaid REAL NOT NULL, Balance REAL NOT NULL, transactionDate TEXT NOT NULL)";
                SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void SaveTransactions(string itemName, double unitPrice, int quantity, double totalAmount, double amountPaid, double balance, string date)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Transactions(itemName, unitPrice, Quantity,totalAmount, amountPaid, Balance, transactionDate) VALUES(@name, @price, @quantity, @totalamount, @amountpaid, @balance, @date)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", itemName);
                cmd.Parameters.AddWithValue("@price", unitPrice);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@totalamount", totalAmount);
                cmd.Parameters.AddWithValue("@amountpaid", amountPaid);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
            }

        }
        public DataTable GetAllTransactions()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Transactions";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        
    }    
}
