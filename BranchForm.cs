using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;


namespace MultiBranchInventory
{
    public partial class BranchForm : Form
    {
        DataTable branchTable = new DataTable();
        private int fadeValue = 0; // 0..255
        private Image fadeImage;

        public BranchForm()
        {
            InitializeComponent();
            fadeImage = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            string branchName = txtBranchName.Text.Trim();

            if (string.IsNullOrWhiteSpace(branchName))
            {
                MessageBox.Show("Please enter a branch name.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new row to DataTable
            branchTable.Rows.Add(branchName);
            txtBranchName.Clear();
            txtBranchName.Focus();
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            branchTable.Columns.Add("Branch Name");

            // Link the DataTable to a DataGridView (e.g., dataGridViewBranches)
            dataGridViewBranches.DataSource = branchTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewBranches.CurrentRow == null)
            {
                MessageBox.Show("Select a branch to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // remove using DataGridView index
            int idx = dataGridViewBranches.CurrentRow.Index;
            if (idx >= 0 && idx < branchTable.Rows.Count)
                branchTable.Rows.RemoveAt(idx);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            // Open Product form
            Product productForm = new Product();
            productForm.ShowDialog();

            // Close Branch form after returning
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            // Open Stock form
            Stock stockForm = new Stock();
            stockForm.ShowDialog();

            // Close Branch form after returning
            this.Close();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            // Open Purchase form
            Purchase purchaseForm = new Purchase();
            purchaseForm.ShowDialog();

            // Close Branch form after returning
            this.Close();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            // Open Purchase form
            Supplier supplierForm = new Supplier();
            supplierForm.ShowDialog();

            // Close Branch form after returning
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            // Show the login form again
            Form Form = new Form();
            Form.ShowDialog();

            // After login form closes, close this form too
            this.Close();
        }
    }
}
   