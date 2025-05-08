using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace InventoryManagement
{
    internal class DataLoader
    {
        public void DeleteAll(DataGridView _dataGridView)
        {
            string connectionString = @"Data Source=..\..\Files\inventory.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Product";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Debug.WriteLine("All rows deleted successfully");
                    }
                    else
                    {
                        Debug.WriteLine("Couldn't Delete All Rows");
                    }
                }

                LoadData(_dataGridView);
            }
        }

        public void CreateRow(string _name, string _category, int _quantity, double _price, string _supplier, DataGridView dataGridView)
        {
            _price = Math.Round(_price, 2);

            string connectionString = @"Data Source=..\..\Files\inventory.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                int finalID;

                finalID = GeneratePin(conn);

                // Create the row here
                string query = $"INSERT INTO Product (ID, Name, Category, Quantity, Price, Supplier) VALUES (@ID, @Name, @Category, @Quantity, @Price, @Supplier)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", finalID);
                    cmd.Parameters.AddWithValue("@Name", _name);
                    cmd.Parameters.AddWithValue("@Category", _category);
                    cmd.Parameters.AddWithValue("@Quantity", _quantity);
                    cmd.Parameters.AddWithValue("@Price", _price);
                    cmd.Parameters.AddWithValue("@Supplier", _supplier);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Row inserted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Failed to Insert Row");
                    }
                }

                LoadData(dataGridView);
            }
        }

        int GeneratePin(SQLiteConnection _conn)
        {
            // Gets a random 4 digit pin
            Random random = new Random();
            int pin = random.Next(1000, 10000);

            // make a command to check if id already exists
            string idQuery = $"SELECT ID FROM Product WHERE ID = {pin}";
            SQLiteCommand cmd = new SQLiteCommand(idQuery, _conn);

            object result = cmd.ExecuteScalar();
            int count = Convert.ToInt32(result);

            if (count > 0)
            {
                // Id already exists
                Debug.WriteLine($"ID ALREADY EXISTS : {pin}");
                GeneratePin(_conn);
            }
            else
            {
                Debug.WriteLine($"FOUND UNIQUE PIN : {pin}");
                return pin;
            }

            Debug.WriteLine($"ENDING FUNCTION : {pin}");
            return count;
        }


        public void LoadData(DataGridView _dataGridView)
        {
            string connectionString = @"Data Source=..\..\Files\inventory.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Product";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                _dataGridView.DataSource = dataSet.Tables[0];
            }
        }
        
    }
}
