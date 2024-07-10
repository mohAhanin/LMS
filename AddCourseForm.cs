using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class AddCourseForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;Initial Catalog=DBLABPROJECT;User ID=sa;Password=123";
        private string userID;

        public AddCourseForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadCourses();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCourseID.Text, out int courseID) ||
                !TimeSpan.TryParse(txtTime.Text, out TimeSpan time))
            {
                MessageBox.Show("Invalid input. Please enter a valid integer for Course ID and a valid time.");
                return;
            }

            string courseName = txtCourseName.Text;
            string courseDescription = txtCourseDescription.Text;
            string classInfo = txtClass.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Courses (CourseID, CourseName, CourseDescription, Class, Time, PID) VALUES (@CourseID, @CourseName, @CourseDescription, @Class, @Time, @PID)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CourseID", courseID);
                    cmd.Parameters.AddWithValue("@CourseName", courseName);
                    cmd.Parameters.AddWithValue("@CourseDescription", courseDescription);
                    cmd.Parameters.AddWithValue("@Class", classInfo);
                    cmd.Parameters.AddWithValue("@Time", time);
                    cmd.Parameters.AddWithValue("@PID", userID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Course added successfully!");
                    LoadCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDeleteCourseID.Text, out int courseID))
            {
                MessageBox.Show("Invalid Course ID. Please enter a valid integer.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Courses WHERE CourseID = @CourseID";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CourseID", courseID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Course deleted successfully!");
                    LoadCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            // Add your code here if you want something to happen when the form loads
        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add your code here if you want something to happen when a cell in the dgvCourses grid is clicked
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Add your code here if you want something to happen when the label is clicked
        }


        private void LoadCourses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Courses";

                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Set DataGridView source to DataTable
                    dgvCourses.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }


}
