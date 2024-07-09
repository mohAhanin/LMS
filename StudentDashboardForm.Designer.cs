namespace LMS
{
    partial class StudentDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblUnenroll = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtCourseIDUnenroll = new System.Windows.Forms.TextBox();
            this.btnUnenroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(181, 260);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(159, 22);
            this.txtCourseID.TabIndex = 2;
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.Location = new System.Drawing.Point(181, 320);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(159, 30);
            this.btnViewCourse.TabIndex = 3;
            this.btnViewCourse.Text = "View Course Details";
            this.btnViewCourse.UseVisualStyleBackColor = true;
            this.btnViewCourse.Click += new System.EventHandler(this.btnViewCourse_Click);
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(12, 386);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(577, 66);
            this.dataGridViewCourses.TabIndex = 4;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(178, 226);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(103, 16);
            this.lblCourseID.TabIndex = 5;
            this.lblCourseID.Text = "Enter Course ID:";
            // 
            // lblUnenroll
            // 
            this.lblUnenroll.AutoSize = true;
            this.lblUnenroll.Location = new System.Drawing.Point(224, 490);
            this.lblUnenroll.Name = "lblUnenroll";
            this.lblUnenroll.Size = new System.Drawing.Size(57, 16);
            this.lblUnenroll.TabIndex = 6;
            this.lblUnenroll.Text = "Unenroll";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(211, 529);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtStudentID.TabIndex = 7;
            this.txtStudentID.Text = "stdid";
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // txtCourseIDUnenroll
            // 
            this.txtCourseIDUnenroll.Location = new System.Drawing.Point(211, 571);
            this.txtCourseIDUnenroll.Name = "txtCourseIDUnenroll";
            this.txtCourseIDUnenroll.Size = new System.Drawing.Size(100, 22);
            this.txtCourseIDUnenroll.TabIndex = 8;
            this.txtCourseIDUnenroll.Text = "courseid";
            // 
            // btnUnenroll
            // 
            this.btnUnenroll.Location = new System.Drawing.Point(227, 626);
            this.btnUnenroll.Name = "btnUnenroll";
            this.btnUnenroll.Size = new System.Drawing.Size(75, 23);
            this.btnUnenroll.TabIndex = 9;
            this.btnUnenroll.Text = "Unenroll";
            this.btnUnenroll.UseVisualStyleBackColor = true;
            this.btnUnenroll.Click += new System.EventHandler(this.btnUnenroll_Click);
            // 
            // StudentDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1062, 683);
            this.Controls.Add(this.btnUnenroll);
            this.Controls.Add(this.txtCourseIDUnenroll);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblUnenroll);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.btnViewCourse);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentDashboardForm";
            this.Load += new System.EventHandler(this.StudentDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblUnenroll;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtCourseIDUnenroll;
        private System.Windows.Forms.Button btnUnenroll;
    }
}