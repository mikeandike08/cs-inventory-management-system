using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Linq;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace InventoryManagement
{
    internal class DataLoader
    { 

        public void loadAddStockValues(DataGridView _dataGridView, TextBox nameField, TextBox idField, TextBox quantText)
        {
            DataGridViewRow selectedRow = null;

            string selectedName = "";
            string selectedID = "";
            string currentQuant = "";

            // Checks if a row is selected and if so, gets the name
            if (_dataGridView.SelectedRows.Count != 0)
            {
                selectedRow = _dataGridView.SelectedRows[0];

                selectedName = selectedRow.Cells["Name"].Value.ToString();

                // Gets the unique id from that 
                selectedID = selectedRow.Cells["ID"].Value.ToString();

                currentQuant = selectedRow.Cells["Quantity"].Value.ToString();

                nameField.Text = selectedName;
                idField.Text = selectedID;
                quantText.Text = currentQuant;
            }
            else
            {
                // If a row wasn't selected, try to get the names from ID
                int typedID = 0;
                try
                {
                    if (idField.TextLength == 0) return;
                    typedID = Convert.ToInt32(idField.Text);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }

                string connectionString = @"Data Source=..\..\Files\inventory.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = $"SELECT Name, Quantity FROM Product WHERE ID = {typedID}";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        string name = "";
                        int quant = 0;
                        // Try to execute the query (most likely failure is a valid ID not being typed yet)
                        try
                        {
                            SQLiteDataReader results = cmd.ExecuteReader();

                            // Loops through each of the results
                            while (results.Read())
                            {
                                // Sets each of the strings
                                name = results.GetString(0);
                                quant = results.GetInt32(1);
                            }

                            nameField.Text = name;
                            quantText.Text = quant.ToString();
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show(e.Message);
                            return;
                        }                     
                    }
                }
            }
        }

        public void removeStock(DataGridView _dataGridView, int amount, TextBox idField)
        {
            string connectionString = @"Data Source=..\..\Files\inventory.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                int ID = 0;

                // Try to get ID from the text field, if its empty then throw an error
                try
                {
                    ID = Convert.ToInt32(idField.Text);
                }
                catch
                {
                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    MessageBox.Show("An Error Occurred: Make sure To Have An ID In The Field", "Error", button);
                    return;
                }


                string query = $"UPDATE Product SET Quantity = Quantity - {amount} WHERE ID = {ID} AND Quantity > {amount}";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Executes the Query
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show($"Successfully Removed {amount} from ID : {ID}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WriteLog(ID.ToString(), "", $"Removed {amount} Stock from {ID.ToString()}");
                    }
                    else
                    {
                        MessageBox.Show("An Error Occurred: Make Sure The Info Is Typed Correctly.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                }

                LoadData(_dataGridView);
            }
        }

        public void addStock(DataGridView _dataGridView, int amount, TextBox idField)
        {
            string connectionString = @"Data Source=..\..\Files\inventory.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                int ID = 0;

                // Try to get ID from the text field, if its empty then throw an error
                try
                {
                    ID = Convert.ToInt32(idField.Text);
                }
                catch
                {
                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    MessageBox.Show("An Error Occurred: Make sure To Have An ID In The Field", "Error", button);
                    return;
                }


                string query = $"UPDATE Product SET Quantity = Quantity + {amount} WHERE ID = {ID}";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Executes the Query
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show($"Successfully Added {amount} To ID : {ID}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WriteLog(ID.ToString(), "", $"Added {amount} Stock to {ID}");
                    }
                    else
                    {
                        MessageBox.Show("An Error Occurred: Make Sure The Info Is Typed Correctly.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                }

                LoadData(_dataGridView);
            }
        }

        public void DeleteAll(DataGridView _dataGridView)
        {
            string connectionString = @"Data Source=..\..\Files\inventory.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Gets the selected row
                DataGridViewRow selectedRow = null;
                try
                {
                    selectedRow = _dataGridView.SelectedRows[0];
                }
                catch (Exception e)
                {

                    MessageBox.Show($"An Error Occurred: Make Sure To Select A Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gets the unique id from that row
                var selectedID = selectedRow.Cells["ID"].Value;

                string query = $"DELETE FROM Product WHERE ID = {selectedID}";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Executes the Query
                    int result = 0;
                    try { result = cmd.ExecuteNonQuery(); }
                    catch (Exception e)
                    {
                        MessageBox.Show($"An Error Occurred: Cannot Delete That Row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (result > 0)
                    {
                        WriteLog(selectedID.ToString(), "", "Deleted Row");
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
                        WriteLog(finalID.ToString(), _name, "Created Row");
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

        public void searchData(DataGridView _dataGridView, string search, string type)
        {
            string connectionString = @"Data Source=..\..\Files\inventory.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = $"SELECT * FROM Product WHERE {type} LIKE '%{search}%'";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    try
                    {
                        SQLiteDataReader results = cmd.ExecuteReader();

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        _dataGridView.DataSource = dataTable;
                    }
                    catch
                    {
                        return;
                    }
                }
            }
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
        
        // Saves the data to a CSV file
        public void SaveDataToCSV(DataGridView _dataGridView)
        {
            SaveFileDialog _saveFileDialoge = new SaveFileDialog();
            _saveFileDialoge.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            _saveFileDialoge.Title = "Save the Inventory file";

            if(_saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                string filePath = _saveFileDialoge.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Gather all data from DataView

                    // Loop through each row
                    foreach (DataGridViewRow row in _dataGridView.Rows)
                    {
                        // Check if the row is not emtpy
                        if(!row.IsNewRow)
                        {
                            // Loop through each cell
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value?.ToString() ?? "");

                                if (i < row.Cells.Count - 1)
                                {
                                    writer.Write(",");
                                }
                            }
                            // Move on to the next line after each row
                            writer.WriteLine();
                        }
                    }
                }
            }

            MessageBox.Show("Successfully Saved CSV File!", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void WriteLog(string ID, string Name, string Event)
        {
            if (File.Exists("log.txt"))
            {
                // If the file already exists, just open and append to it
                using (FileStream fs = new FileStream("log.txt", FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        // Append To File
                        writer.WriteLine($"{ID} : {Name} was {Event} at {DateTime.Now},");
                    }
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("log.txt"))
                {
                    // Write to file
                    writer.WriteLine($"{ID} : {Name} was {Event} at {DateTime.Now},");
                }
            }
        }

        public void GenerateReport(DataGridView _dataGridView)
        {
            double totalInvVlaue = 0;

            SaveFileDialog _saveFileDialoge = new SaveFileDialog();
            _saveFileDialoge.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            _saveFileDialoge.Title = "Save the Inventory file";

            Dictionary<string, int> sales = new Dictionary<string, int>();

            if (File.Exists("log.txt"))
            { 
                // Reads the file and returns each ID's sales
                using (StreamReader reader = new StreamReader("log.txt"))
                {
                    // Find each ID that Event has keyword 'Removed'
                    // Log the number after Removed as a sale

                    // Create dictionary that holds ID - Sale

                    // Loop through each line
                    string s;
                    while ((s = reader.ReadLine()) != null)
                    {
                        // ID is always the first 4 chars
                        Debug.WriteLine(s);
                        string id = "";
                        if (s.Length >= 4)
                        {
                            id = s.Substring(0, 4);
                        }

                        // Gets the index of the word Removed
                        int RemovedIndex = s.IndexOf("Removed");

                        int saleNumber = 0;
                        string saleNumberString = "";

                        // Loop through each char in the string
                        if(s.Length >= 4)
                        {
                            foreach (char _char in s.Substring(RemovedIndex + "Removed".Length).Trim())
                            {
                                // Checks if the character is a digit
                                if (Char.IsDigit(_char))
                                {
                                    saleNumberString += _char.ToString();
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(saleNumberString))
                        {
                            saleNumber = Convert.ToInt32(saleNumberString);
                            if (sales.ContainsKey(id))
                            {
                                sales[id] += saleNumber;
                            }
                            else
                            {
                                sales.Add(id, saleNumber);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Report will be missing values due to missing log.txt file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Get total value of the inventory

            // Loop through each row
            for (int i = 0; i < _dataGridView.Rows.Count; i++)
            {
                // Get the price and quantity value of the row
                var PriceValue = Convert.ToDouble(_dataGridView.Rows[i].Cells[4].Value);
                var QuantityValue = Convert.ToDouble(_dataGridView.Rows[i].Cells[3].Value);

                // Get the total value by how many quantity there is
                double totalPrice = PriceValue * QuantityValue;

                totalInvVlaue += totalPrice;
            }

            // Open a file based on location
            if (_saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                string filePath = _saveFileDialoge.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Make sure sales contains something
                    if (sales.Count >= 1)
                    {
                        // Sort by descending (highest on top)
                        var sortedSales = sales.OrderByDescending(kvp => kvp.Value).ToList();

                        foreach(var kvp in sortedSales)
                        {
                            writer.WriteLine($"ID: {kvp.Key} reported {kvp.Value} sales!");
                        }
                    }

                    writer.WriteLine($"The total Inventory Value is {totalInvVlaue:C}!!");
                }
            }
        }

    }
}
