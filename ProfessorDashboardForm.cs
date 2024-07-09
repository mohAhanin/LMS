using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace LMS
{
    public partial class ProfessorDashboardForm : Form
    {
        private string userID;
        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;Initial Catalog=DBLABPROJECT;User ID=sa;Password=123";

        // UI Components not in the designer
        private DataGridView dataGridViewCourses;
        private Label lblCourseID;
        private TextBox txtCourseID;
        private Label lblCourseIDStudents;
        private TextBox txtCourseIDStudents;
        private DataGridView dataGridViewCourseStudents;

        public ProfessorDashboardForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;

            InitializeAdditionalComponents();
            LoadProfessorData();
        }

        private void InitializeAdditionalComponents()
        {
            // Initialize UI Components not in the designer
            this.dataGridViewCourses = new DataGridView
            {
                Location = new Point(20, 20),
                Size = new Size(600, 200),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            lblCourseID = new Label
            {
                Text = "Course ID:",
                Location = new Point(20, 230),
                AutoSize = true
            };

            txtCourseID = new TextBox
            {
                Location = new Point(100, 230),
                Size = new Size(100, 20)
            };

            lblCourseIDStudents = new Label
            {
                Text = "Course ID for Students:",
                Location = new Point(20, 270),
                AutoSize = true
            };

            txtCourseIDStudents = new TextBox
            {
                Location = new Point(160, 270),
                Size = new Size(100, 20)
            };

            this.dataGridViewCourseStudents = new DataGridView
            {
                Location = new Point(20, 310),
                Size = new Size(600, 200),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            // Add UI Components to the form
            this.Controls.Add(dataGridViewCourses);
            this.Controls.Add(lblCourseID);
            this.Controls.Add(txtCourseID);
            this.Controls.Add(lblCourseIDStudents);
            this.Controls.Add(txtCourseIDStudents);
            this.Controls.Add(dataGridViewCourseStudents);

            // Set form properties
            this.Text = "Professor Dashboard";
            this.Size = new Size(660, 550);
        }

        private void LoadProfessorData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT CourseID, CourseName, CourseDescription, Class, Time
                        FROM Courses
                        WHERE PID = (SELECT PID FROM Professors WHERE userID = @userID)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userID", userID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Bind the DataTable to the DataGridView
                    dataGridViewCourses.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void BtnManageCourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseID.Text))
            {
                MessageBox.Show("Please enter a Course ID.");
                return;
            }

            if (!int.TryParse(txtCourseID.Text, out int courseID))
            {
                MessageBox.Show("Invalid Course ID. Please enter a valid integer.");
                return;
            }

            MessageBox.Show($"Opening management form for Course ID: {courseID}");
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadProfessorData();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnViewCourseStudents_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCourseIDStudents.Text))
                {
                    MessageBox.Show("Please enter a Course ID for students.");
                    return;
                }

                int courseID = int.Parse(txtCourseIDStudents.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT c.CourseID, c.CourseName, c.CourseDescription, s.StdID, s.StdName
                        FROM Courses c
                        JOIN Enrollments e ON c.CourseID = e.CourseID
                        JOIN Students s ON e.StdID = s.StdID
                        WHERE c.CourseID = @CourseID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CourseID", courseID);

                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No students found for this course.");
                    }
                    else
                    {
                        dataGridViewCourseStudents.DataSource = dataTable;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Course ID. Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course details and enrolled students: " + ex.Message);
            }
        }
    }
}