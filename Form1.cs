namespace MultiBranchInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Event wiring (if you didn’t double-click in designer)
            button1.Click += button1_Click;
            btnExit.Click += btnExit_Click;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

            // Hide password by default
            PasswordTb.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            PasswordTb.UseSystemPasswordChar = !checkBox1.Checked;
        }


        private void label3_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // simple example: just check hardcoded credentials
            string username = UnameTb.Text;
            string password = PasswordTb.Text;

            // Optional: you can check if fields are empty (for realism)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // hide the login form
            this.Hide();

            // open BranchForm directly
            BranchForm branchForm = new BranchForm();
            branchForm.ShowDialog();

            // after BranchForm closes, exit the application
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to exit?",
        "Exit Application",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}