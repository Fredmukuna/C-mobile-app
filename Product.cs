using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;   // ____________ DATABASE NAMESPACE ____________

namespace MultiBranchInventory
{
    public partial class Product : Form
    {
        private DataTable productTable = new DataTable();
        // ____________ DATABASE CONNECTION STRING ____________
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=MultiBranchInventoryDB;Trusted_Connection=True;Encrypt=False;";

        public Product()
        {
            InitializeComponent();

            this.Load += Product_Load;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnRemove.Click += btnRemove_Click;
            btnBack.Click += btnBack_Click;
            btnIncreaseStock.Click += btnIncreaseStock_Click;
            btnDecreaseStock.Click += btnDecreaseStock_Click;
            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;

            // ____________ LOAD PRODUCTS INTO DATAGRIDVIEW ____________
            LoadProducts();
        }
        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ProductID, ProductName, Category, Price, Stock FROM Products", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewProducts.DataSource = dt;
            }
        }


        private void Product_Load(object sender, EventArgs e)
        {
            // Define columns
            productTable.Columns.Add("Product Name", typeof(string));
            productTable.Columns.Add("Category", typeof(string));
            productTable.Columns.Add("Price", typeof(decimal));
            productTable.Columns.Add("Stock", typeof(int));

            // Link to grid
            dataGridViewProducts.AutoGenerateColumns = true;
            dataGridViewProducts.DataSource = productTable;

            // Optional formatting
            if (dataGridViewProducts.Columns["Price"] != null)
                dataGridViewProducts.Columns["Price"].DefaultCellStyle.Format = "N2";

            // ---- ADD THIS BLOCK TO FILL COLUMNS AND ROWS ----
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Columns fill width
            dataGridViewProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;   // Rows fill height of content
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.AllowUserToAddRows = false;
            // ---- END OF BLOCK ----
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtCategory.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all product details.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Products (ProductName, Category, Price, Stock) VALUES (@ProductName, @Category, @Price, @Stock)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Stock", (int)numStock.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // ✅ Refresh DataGridView to show the new product immediately
                LoadProducts();

                // ✅ Optional: Clear input fields
                txtProductName.Clear();
                txtCategory.Clear();
                txtPrice.Clear();
                numStock.Value = 0;

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Select a product to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int rowIndex = dataGridViewProducts.CurrentRow.Index;

                string name = txtProductName.Text.Trim();
                string category = txtCategory.Text.Trim();
                decimal price;
                int stock = (int)numStock.Value;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category) ||
                    !decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out price))
                {
                    MessageBox.Show("Please fill Name, Category, and a valid Price.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                productTable.Rows[rowIndex]["Product Name"] = name;
                productTable.Rows[rowIndex]["Category"] = category;
                productTable.Rows[rowIndex]["Price"] = price;
                productTable.Rows[rowIndex]["Stock"] = stock;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Select a product to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rowIndex = dataGridViewProducts.CurrentRow.Index;
            productTable.Rows.RemoveAt(rowIndex);
        }

        private void btnIncreaseStock_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Select a product to increase stock.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int adjust = (int)numAdjust.Value;
            int rowIndex = dataGridViewProducts.CurrentRow.Index;
            int currentStock = Convert.ToInt32(productTable.Rows[rowIndex]["Stock"]);
            productTable.Rows[rowIndex]["Stock"] = currentStock + adjust;

            PopulateInputsFromSelection(rowIndex);
        }

        private void btnDecreaseStock_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Select a product to decrease stock.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int adjust = (int)numAdjust.Value;
            int rowIndex = dataGridViewProducts.CurrentRow.Index;
            int currentStock = Convert.ToInt32(productTable.Rows[rowIndex]["Stock"]);
            int newStock = currentStock - adjust;

            if (newStock < 0)
            {
                MessageBox.Show("Stock cannot go below zero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            productTable.Rows[rowIndex]["Stock"] = newStock;
            PopulateInputsFromSelection(rowIndex);
        }

        private void DataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null) return;

            int rowIndex = dataGridViewProducts.CurrentRow.Index;
            PopulateInputsFromSelection(rowIndex);
        }

        private void PopulateInputsFromSelection(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= productTable.Rows.Count) return;

            var row = productTable.Rows[rowIndex];
            txtProductName.Text = row["Product Name"].ToString();
            txtCategory.Text = row["Category"].ToString();
            txtPrice.Text = Convert.ToDecimal(row["Price"]).ToString("0.00", CultureInfo.InvariantCulture);
            numStock.Value = Convert.ToInt32(row["Stock"]);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchForm branchForm = new BranchForm();
            branchForm.ShowDialog();
            this.Close();
        }

        private void Product_Load_1(object sender, EventArgs e)
        {

        }
    }
}
