using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class AdminDashboardForm : Form
    {
        // Connection string to your database
        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;Initial Catalog=DBLABPROJECT;User ID=sa;Password=123";
        private string userID;

        public AdminDashboardForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.FormClosed += new FormClosedEventHandler(AdminDashboardForm_FormClosed);
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);


        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT userID, Role FROM Users";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Set DataGridView source to DataTable
                    dgvUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // Add your code here if you want something to happen when the form loads
        }
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add your code here if you want something to happen when a cell in the dgvUsers grid is clicked
        }
        private void AdminDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblStdID_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void lblStdName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(txtUserID.Text);
            string password = txtPassword.Text;
            int stdID = int.Parse(txtStdID.Text);
            string stdName = txtStdName.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "INSERT INTO Users (userID, Password, Role) VALUES (@userID, @Password, 'student')";
                    string query2 = "INSERT INTO Students (userID, StdID, StdName) VALUES (@userID, @StdID, @StdName)";

                    SqlCommand cmd1 = new SqlCommand(query1, connection);
                    cmd1.Parameters.AddWithValue("@userID", userID);
                    cmd1.Parameters.AddWithValue("@Password", password);

                    SqlCommand cmd2 = new SqlCommand(query2, connection);
                    cmd2.Parameters.AddWithValue("@userID", userID);
                    cmd2.Parameters.AddWithValue("@StdID", stdID);
                    cmd2.Parameters.AddWithValue("@StdName", stdName);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Student added successfully!");

                    // Refresh the DataGridView
                    btnLoadUsers_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void lblDeleteStdID_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            int stdID = int.Parse(txtDeleteStdID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "DELETE FROM Enrollments WHERE StdID = @StdID";
                    string query2 = "DELETE FROM Students WHERE StdID = @StdID";
                    string query3 = "DELETE FROM Users WHERE userID = (SELECT userID FROM Students WHERE StdID = @StdID)";

                    SqlCommand cmd1 = new SqlCommand(query1, connection);
                    cmd1.Parameters.AddWithValue("@StdID", stdID);

                    SqlCommand cmd2 = new SqlCommand(query2, connection);
                    cmd2.Parameters.AddWithValue("@StdID", stdID);

                    SqlCommand cmd3 = new SqlCommand(query3, connection);
                    cmd3.Parameters.AddWithValue("@StdID", stdID);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Student deleted successfully!");

                    // Refresh the DataGridView
                    btnLoadUsers_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }





        private void txtDeleteStdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string[] queries = {
                        "SELECT * FROM Users",
                        "SELECT * FROM Students",
                        "SELECT * FROM Professors",
                        "SELECT * FROM Admins",
                        "SELECT * FROM Courses",
                        "SELECT * FROM Enrollments"
                    };

                    DataTable dt = new DataTable();

                    foreach (string query in queries)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, connection);
                        da.Fill(dt);
                    }

                    // Set DataGridView source to DataTable
                    dgvData.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    

    private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
