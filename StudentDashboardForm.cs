using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class StudentDashboardForm : Form
    {
        private string userID;
        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;Initial Catalog=DBLABPROJECT;User ID=sa;Password=123";

        public StudentDashboardForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadStudentData();
            this.FormClosed += new FormClosedEventHandler(StudentDashboardForm_FormClosed);

        }
        private void StudentDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadStudentData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to select enrolled courses for the student
                    string query = @"SELECT c.CourseID, c.CourseName, c.CourseDescription, c.Class, c.Time, p.PName
                                     FROM Courses c
                                     JOIN Professors p ON c.PID = p.PID
                                     JOIN Enrollments e ON c.CourseID = e.CourseID
                                     JOIN Students s ON e.StdID = s.StdID
                                     WHERE s.userID = @UserID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message);
            }
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            // Additional initialization code if needed
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert Course ID from text to integer
                int courseID = int.Parse(txtCourseID.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to select course details
                    string query = @"DECLARE @CourseID INT;
                                     SET @CourseID = @CourseIDInput;

                                     SELECT CourseID, CourseName, CourseDescription, Class, Time, p.PName
                                     FROM Courses c
                                     JOIN Professors p ON c.PID = p.PID
                                     WHERE CourseID = @CourseID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CourseIDInput", courseID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridViewCourses.DataSource = dataTable;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Course ID. Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course details: " + ex.Message);
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnenroll_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert Student ID and Course ID from text to integer
                int studentID = int.Parse(txtStudentID.Text);
                int courseID = int.Parse(txtCourseIDUnenroll.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to unenroll a student from a course
                    string query = @"DECLARE @StdID INT, @CourseID INT;
                             SET @StdID = @StdIDInput;
                             SET @CourseID = @CourseIDInput;

                             DELETE FROM Enrollments
                             WHERE StdID = @StdID AND CourseID = @CourseID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StdIDInput", studentID);
                    command.Parameters.AddWithValue("@CourseIDInput", courseID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully unenrolled from the course.");
                        // Refresh the grid showing the courses of the student
                        LoadStudentData();
                    }
                    else
                    {
                        MessageBox.Show("Unenrollment failed. Please check the Student ID and Course ID.");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Student ID or Course ID. Please enter valid integers.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error unenrolling from the course: " + ex.Message);
            }
        }
    }
}
