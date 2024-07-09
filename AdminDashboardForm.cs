using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class AdminDashboardForm : Form
    {
        private string userID;
        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;Initial Catalog=DBLABPROJECT;User ID=sa;Password=123";
        public AdminDashboardForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadAdminData();
        }

        private void LoadAdminData()
        {
            // Implement admin-specific data loading logic here
            // For now, let's just display a welcome message
            MessageBox.Show("Welcome, Admin!");
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // This method will handle the Load event of the form
            // You can add additional initialization code here if needed
        }
    }
}
