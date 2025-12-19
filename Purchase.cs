using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MultiBranchInventory
{
    public partial class Purchase : Form
    {
        private DataTable orderItems = new DataTable();
        // ____________ DATABASE CONNECTION STRING ____________
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=MultiBranchInventoryDB;Trusted_Connection=True;Encrypt=False;";
        public Purchase()
        {
            InitializeComponent();

            // Define columns for the order items table
            orderItems.Columns.Add("Item Name", typeof(string));
            orderItems.Columns.Add("Quantity", typeof(int));
            orderItems.Columns.Add("Price", typeof(decimal));
            orderItems.Columns.Add("Total", typeof(decimal));

            // Bind the DataTable to the DataGridView
            dataGridViewOrderItems.DataSource = orderItems;

            // Make columns fill the width of the DataGridView
            dataGridViewOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Make rows adjust their height to fit content
            dataGridViewOrderItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Optional: make headers bold for readability
            dataGridViewOrderItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Optional: prevent user from adding blank rows manually
            dataGridViewOrderItems.AllowUserToAddRows = false;

            // Optional: make entire row selectable
            dataGridViewOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // ____________ LOAD PRODUCTS INTO AUTOCOMPLETE ____________
            LoadProducts();
        }
        // ____________ LOAD PRODUCTS FROM DATABASE ____________
        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductName FROM Products", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    collection.Add(reader["ProductName"].ToString());
                }

                txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProductName.AutoCompleteCustomSource = collection;
            }
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Check if product name is entered
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name first.");
                return;
            }

            // Get values from controls
            string name = txtProductName.Text.Trim();

            // Convert price and quantity safely
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            int quantity = (int)numQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            // Calculate total
            decimal total = price * quantity;

            // Add row to DataTable
            orderItems.Rows.Add(name, quantity, price, total);
            // ____________ SAVE TO DATABASE ____________
            SaveOrder(name, quantity, total);

            // Clear inputs after adding
            txtProductName.Clear();
            txtPrice.Clear();
            numQuantity.Value = 1;
        }
        // ____________ SAVE ORDER TO DATABASE ____________
        private void SaveOrder(string productName, int quantity, decimal total)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get ProductID
                SqlCommand cmdGetId = new SqlCommand("SELECT ProductID, Price FROM Products WHERE ProductName=@name", conn);
                cmdGetId.Parameters.AddWithValue("@name", productName);
                var reader = cmdGetId.ExecuteReader();

                if (reader.Read())
                {
                    int productId = (int)reader["ProductID"];
                    reader.Close();

                    // Insert into Orders
                    SqlCommand cmdInsert = new SqlCommand(
                        "INSERT INTO Orders (ProductID, Quantity, Total) VALUES (@pid, @qty, @total)", conn);
                    cmdInsert.Parameters.AddWithValue("@pid", productId);
                    cmdInsert.Parameters.AddWithValue("@qty", quantity);
                    cmdInsert.Parameters.AddWithValue("@total", total);
                    cmdInsert.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Product not found in database.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchForm branchForm = new BranchForm();
            branchForm.ShowDialog();
            this.Close();
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic for supplier name changes
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
