namespace LMS
{
    partial class AddCourseForm
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
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseDescription = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lblDeleteCourseID = new System.Windows.Forms.Label();
            this.txtDeleteCourseID = new System.Windows.Forms.TextBox();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(53, 49);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(64, 16);
            this.lblCourseID.TabIndex = 0;
            this.lblCourseID.Text = "Course Id";
            this.lblCourseID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(53, 93);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(90, 16);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourseDescription
            // 
            this.lblCourseDescription.AutoSize = true;
            this.lblCourseDescription.Location = new System.Drawing.Point(53, 133);
            this.lblCourseDescription.Name = "lblCourseDescription";
            this.lblCourseDescription.Size = new System.Drawing.Size(75, 16);
            this.lblCourseDescription.TabIndex = 2;
            this.lblCourseDescription.Text = "Description";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(53, 172);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(41, 16);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Class";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(53, 213);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 16);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(154, 49);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(100, 22);
            this.txtCourseID.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(154, 90);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 22);
            this.txtCourseName.TabIndex = 6;
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(154, 133);
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(100, 22);
            this.txtCourseDescription.TabIndex = 7;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(154, 172);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 22);
            this.txtClass.TabIndex = 8;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(154, 213);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 22);
            this.txtTime.TabIndex = 9;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(56, 264);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(198, 36);
            this.btnAddCourse.TabIndex = 10;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // lblDeleteCourseID
            // 
            this.lblDeleteCourseID.AutoSize = true;
            this.lblDeleteCourseID.Location = new System.Drawing.Point(356, 55);
            this.lblDeleteCourseID.Name = "lblDeleteCourseID";
            this.lblDeleteCourseID.Size = new System.Drawing.Size(66, 16);
            this.lblDeleteCourseID.TabIndex = 11;
            this.lblDeleteCourseID.Text = "Course ID";
            // 
            // txtDeleteCourseID
            // 
            this.txtDeleteCourseID.Location = new System.Drawing.Point(462, 52);
            this.txtDeleteCourseID.Name = "txtDeleteCourseID";
            this.txtDeleteCourseID.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteCourseID.TabIndex = 12;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(359, 113);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(149, 51);
            this.btnDeleteCourse.TabIndex = 13;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(392, 248);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(335, 150);
            this.dgvCourses.TabIndex = 14;
            this.dgvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellContentClick);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.txtDeleteCourseID);
            this.Controls.Add(this.lblDeleteCourseID);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtCourseDescription);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblCourseDescription);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseID);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseDescription;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label lblDeleteCourseID;
        private System.Windows.Forms.TextBox txtDeleteCourseID;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.DataGridView dgvCourses;
    }
}