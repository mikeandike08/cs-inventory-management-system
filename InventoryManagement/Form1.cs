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
        DataLoader _dataLoader = new DataLoader();

        public Form1()
        {
            InitializeComponent();
            _dataLoader.LoadData(DataView);
        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            //double price = 24.99;
            //_dataLoader.CreateRow("USB", "Tech", 1, Math.Round(price, 2),"Amazon", DataView);

            RowInput.Visible = true;

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
    }
}
