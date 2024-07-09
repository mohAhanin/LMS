using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form1 : Form
    {
        // Connection string to your database
        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;Initial Catalog=DBLABPROJECT;User ID=sa;Password=123";
        public Form1()
        {
            InitializeComponent();
        }

        private void lblUserID_Click(object sender, EventArgs e)
        {
            // Event handler code for lblUserID click, if needed
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            // Event handler code for lblPassword click, if needed
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Event handler code for txtPassword text changed, if needed
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text;
            string password = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Role FROM Users WHERE userID = @userID AND Password = @password";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@password", password);

                    object role = cmd.ExecuteScalar();
                    if (role != null)
                    {
                        string userRole = role.ToString();
                        // Redirect to respective dashboard based on role (Student, Professor, Admin)
                        if (userRole == "student")
                        {
                            // Open Student Dashboard Form
                            StudentDashboardForm studentDashboard = new StudentDashboardForm(userID);
                            studentDashboard.Show();
                        }
                        else if (userRole == "professor")
                        {
                            // Open Professor Dashboard Form
                            ProfessorDashboardForm professorDashboard = new ProfessorDashboardForm(userID);
                            professorDashboard.Show();
                        }
                        else if (userRole == "admin")
                        {
                            // Open Admin Dashboard Form
                            AdminDashboardForm adminDashboard = new AdminDashboardForm(userID);
                            adminDashboard.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid userID or Password. Please try again.");
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
