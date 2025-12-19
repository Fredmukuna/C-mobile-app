using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBranchInventory
{
    public partial class Stock : Form
    {
        // Counter for summary labels
        private int transferCount = 0;

        // Simulated products and branches
        List<string> products = new List<string> { "Phone", "Fridge", "Clothes" };
        List<string> branches = new List<string> { "Main Branch", "Town Branch", "Kabwe Branch" };

        // In-memory transfer log
        List<(string Product, string From, string To, int Quantity)> transferLog = new List<(string, string, string, int)>();

        public Stock()
        {
            InitializeComponent();
            btnBack.Click += btnBack_Click;


        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string product = cmbProduct.SelectedItem.ToString();
            string fromBranch = cmbFromBranch.SelectedItem.ToString();
            string toBranch = cmbToBranch.SelectedItem.ToString();

            // Validation
            if (fromBranch == toBranch)
            {
                lblStatus.Text = "Source and destination branch cannot be the same!";
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                lblStatus.Text = "Enter a valid quantity!";
                return;
            }

            // Add to in-memory transfer log
            transferLog.Add((product, fromBranch, toBranch, quantity));

            // Update DataGridView
            dgvTransferLog.Rows.Add(product, fromBranch, toBranch, quantity);

            lblStatus.Text = "Stock transfer recorded!";
            txtQuantity.Clear();
            AddTransferToSummary(product, quantity, fromBranch, toBranch);
        }


        private void Stock_Load(object sender, EventArgs e)
        {
            // Load ComboBoxes
            cmbProduct.DataSource = products;
            cmbFromBranch.DataSource = new List<string>(branches);
            cmbToBranch.DataSource = new List<string>(branches);

            // Setup DataGridView columns
            dgvTransferLog.ColumnCount = 4;
            dgvTransferLog.Columns[0].Name = "Product";
            dgvTransferLog.Columns[1].Name = "From Branch";
            dgvTransferLog.Columns[2].Name = "To Branch";
            dgvTransferLog.Columns[3].Name = "Quantity";

            // Fill the tab nicely
            dgvTransferLog.Dock = DockStyle.Fill;
            dgvTransferLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransferLog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransferLog.RowHeadersVisible = false;
            dgvTransferLog.AllowUserToAddRows = false;
            dgvTransferLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            tabControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            tabControl1.BackColor = System.Drawing.Color.AliceBlue;
            



        }

        private void lblProduct_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl1.TabPages[e.Index];
            Rectangle tabBounds = tabControl1.GetTabRect(e.Index);

            // Background Color for tab headers
            e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), tabBounds);

            // Font style
            TextRenderer.DrawText(e.Graphics, tabPage.Text,
                new Font("Segoe UI", 11, FontStyle.Bold),
                tabBounds,
                Color.Black,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void AddTransferToSummary(string itemName, int quantity, string fromBranch, string toBranch)
        {
            transferCount++;

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9);
            lbl.Text = $"{transferCount}. {quantity} x {itemName} moved from {fromBranch} → {toBranch}";
            lbl.Location = new Point(10, 20 + (transferCount * 25));

            grpStockSummary.Controls.Add(lbl);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchForm branchForm = new BranchForm();
            branchForm.ShowDialog();
            this.Close();
        }
    }
}



