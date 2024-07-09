﻿namespace LMS
{
    partial class ProfessorDashboardForm
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
            this.btnManageCourse = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewCourseStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageCourse
            // 
            this.btnManageCourse.Location = new System.Drawing.Point(220, 230);
            this.btnManageCourse.Name = "btnManageCourse";
            this.btnManageCourse.Size = new System.Drawing.Size(120, 30);
            this.btnManageCourse.TabIndex = 0;
            this.btnManageCourse.Text = "Manage Course";
            this.btnManageCourse.UseVisualStyleBackColor = true;
            this.btnManageCourse.Click += new System.EventHandler(this.BtnManageCourse_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(350, 230);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(460, 230);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnViewCourseStudents
            // 
            this.btnViewCourseStudents.Location = new System.Drawing.Point(270, 270);
            this.btnViewCourseStudents.Name = "btnViewCourseStudents";
            this.btnViewCourseStudents.Size = new System.Drawing.Size(150, 30);
            this.btnViewCourseStudents.TabIndex = 3;
            this.btnViewCourseStudents.Text = "View Course Students";
            this.btnViewCourseStudents.UseVisualStyleBackColor = true;
            this.btnViewCourseStudents.Click += new System.EventHandler(this.BtnViewCourseStudents_Click);
            // 
            // ProfessorDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 550);
            this.Controls.Add(this.btnManageCourse);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewCourseStudents);
            this.Name = "ProfessorDashboardForm";
            this.Text = "Professor Dashboard";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnManageCourse;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewCourseStudents;
    }
}