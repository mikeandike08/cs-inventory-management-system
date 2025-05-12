using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        bool isAddingStock;

        DataLoader _dataLoader = new DataLoader();

        public Form1()
        {
            InitializeComponent();
            _dataLoader.LoadData(DataView);
            // Formats the cells
            DataView.CellFormatting += DataView_CellFormatting;
        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            RowInput.Visible = true;
            TextBox[] fields = { NameInput, CategoryInput, QuantityInput, PriceInput, SupplierInput };
            clearFields(fields);
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            _dataLoader.DeleteAll(DataView);
        }

        private void NameText_Click(object sender, EventArgs e)
        {

        }

        private void RowMenExitBtn_Click(object sender, EventArgs e)
        {
            RowInput.Visible = false;
        }

        private void ConfirmRowBtn_Click(object sender, EventArgs e)
        {
            // Initialize the local variables
            string name, category, supplier;
            double price;
            int quantity;

            // Assign the variables from each text input field
            // ----------TODO add null checks and prompt user to input something---------
            name = NameInput.Text.Trim();
            category = CategoryInput.Text.Trim();
            supplier = SupplierInput.Text.Trim();

            price = double.Parse(PriceInput.Text.Trim());
            quantity = int.Parse(QuantityInput.Text.Trim());

            _dataLoader.CreateRow(name, category, quantity, price, supplier, DataView);
            RowInput.Visible = false;
        }

        private void AddStockBtn_Click(object sender, EventArgs e)
        {
            _dataLoader.loadAddStockValues(DataView, NameField, IDInput, CurrentQuant);

            // Anytime the text is changed, call this function
            IDInput.TextChanged += IDInput_TextChanged;

            StockIncrement.Visible = true;
            isAddingStock = true;
            TextBox[] fields = { NameField, IDInput, StockAmount };
            clearFields(fields);
            AddStock.Text = "Add Stock";
            AddText.Text = "Add Stock";
        }

        private void IDInput_TextChanged(object sender, EventArgs e)
        {
            _dataLoader.loadAddStockValues(DataView, NameField, IDInput, CurrentQuant);
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string search = SearchBar.Text;
            string type = TypeDropdown.SelectedItem.ToString();
            _dataLoader.searchData(DataView, search, type);
        }

        private void CloseAddStockMenu_Click(object sender, EventArgs e)
        {
            StockIncrement.Visible = false;
        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            int quantity;
            try
            {
                quantity = Convert.ToInt32(StockAmount.Text);
            }
            catch
            {
                MessageBox.Show("An Error Occurred: Make Sure To Have A Quantity Inputed");
                return;
            }

            if (isAddingStock)
            {
                _dataLoader.addStock(DataView, quantity, IDInput);
            }
            else
            {
                _dataLoader.removeStock(DataView, quantity, IDInput);
            }

            StockIncrement.Visible = false;
        }

        private void RowInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RemoveStockBtn_Click(object sender, EventArgs e)
        {
            _dataLoader.loadAddStockValues(DataView, NameField, IDInput, CurrentQuant);

            // Anytime the text is changed, call this function
            IDInput.TextChanged += IDInput_TextChanged;

            StockIncrement.Visible = true;
            TextBox[] fields = { NameField, IDInput, StockAmount };
            clearFields(fields);
            isAddingStock = false;
            AddStock.Text = "Remove Stock";
            AddText.Text = "Remove Stock";
        }

        // Clears the field so its empty textboxes for next use
        private void clearFields(TextBox[] fields)
        {
            foreach (TextBox field in fields)
            {
                field.Clear();
            }
        }

        public void DataView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int quantity;
            if (int.TryParse(e.Value.ToString(), out quantity))
            {
                if (quantity <= 5 && e.ColumnIndex == 3)
                {
                    e.CellStyle.BackColor = Color.LightPink;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (quantity >= 20 && e.ColumnIndex == 3)
                {
                    e.CellStyle.BackColor = Color.LightSeaGreen;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (e.ColumnIndex == 3)
                {
                    e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        // Allow Tabs to be dragged

        bool dragging = false;
        Point dragCursorPoint;
        Point dragPanelPoint;

        private void RowInput_MouseDown_1(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragPanelPoint = RowInput.Location;
        }

        private void RowInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                RowInput.Location = Point.Add(dragPanelPoint, new Size(diff));
            }
        }

        private void RowInput_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void StockIncrement_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragPanelPoint = StockIncrement.Location;
        }

        private void StockIncrement_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                StockIncrement.Location = Point.Add(dragPanelPoint, new Size(diff));
            }
        }

        private void StockIncrement_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void CSVExport_Click(object sender, EventArgs e)
        {
            _dataLoader.SaveDataToCSV(DataView);
        }

        private void GenReport_Click(object sender, EventArgs e)
        {
            _dataLoader.GenerateReport(DataView);
        }
    }   
}
