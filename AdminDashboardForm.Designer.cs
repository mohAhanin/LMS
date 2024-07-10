namespace LMS
{
    partial class AdminDashboardForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnLoadUsers = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblStdID = new System.Windows.Forms.Label();
            this.lblStdName = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtStdID = new System.Windows.Forms.TextBox();
            this.txtStdName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblDeleteStdID = new System.Windows.Forms.Label();
            this.txtDeleteStdID = new System.Windows.Forms.TextBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(84, 85);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(306, 150);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // btnLoadUsers
            // 
            this.btnLoadUsers.Location = new System.Drawing.Point(168, 27);
            this.btnLoadUsers.Name = "btnLoadUsers";
            this.btnLoadUsers.Size = new System.Drawing.Size(122, 30);
            this.btnLoadUsers.TabIndex = 1;
            this.btnLoadUsers.Text = "Load User";
            this.btnLoadUsers.UseVisualStyleBackColor = true;
            this.btnLoadUsers.Click += new System.EventHandler(this.btnLoadUsers_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(575, 33);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(49, 16);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "UserID";
            this.lblUserID.Click += new System.EventHandler(this.lblUserID_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(664, 33);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.Location = new System.Drawing.Point(771, 33);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(68, 16);
            this.lblStdID.TabIndex = 4;
            this.lblStdID.Text = "Student ID";
            this.lblStdID.Click += new System.EventHandler(this.lblStdID_Click);
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Location = new System.Drawing.Point(889, 33);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(92, 16);
            this.lblStdName.TabIndex = 5;
            this.lblStdName.Text = "Student Name";
            this.lblStdName.Click += new System.EventHandler(this.lblStdName_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(578, 85);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(46, 22);
            this.txtUserID.TabIndex = 6;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(667, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(64, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtStdID
            // 
            this.txtStdID.Location = new System.Drawing.Point(774, 85);
            this.txtStdID.Name = "txtStdID";
            this.txtStdID.Size = new System.Drawing.Size(65, 22);
            this.txtStdID.TabIndex = 8;
            this.txtStdID.TextChanged += new System.EventHandler(this.txtStdID_TextChanged);
            // 
            // txtStdName
            // 
            this.txtStdName.Location = new System.Drawing.Point(892, 85);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.Size = new System.Drawing.Size(89, 22);
            this.txtStdName.TabIndex = 9;
            this.txtStdName.TextChanged += new System.EventHandler(this.txtStdName_TextChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(667, 140);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(172, 40);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // lblDeleteStdID
            // 
            this.lblDeleteStdID.AutoSize = true;
            this.lblDeleteStdID.Location = new System.Drawing.Point(702, 265);
            this.lblDeleteStdID.Name = "lblDeleteStdID";
            this.lblDeleteStdID.Size = new System.Drawing.Size(95, 16);
            this.lblDeleteStdID.TabIndex = 11;
            this.lblDeleteStdID.Text = "Delete Student";
            this.lblDeleteStdID.Click += new System.EventHandler(this.lblDeleteStdID_Click);
            // 
            // txtDeleteStdID
            // 
            this.txtDeleteStdID.Location = new System.Drawing.Point(699, 306);
            this.txtDeleteStdID.Name = "txtDeleteStdID";
            this.txtDeleteStdID.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteStdID.TabIndex = 12;
            this.txtDeleteStdID.Text = "student id";
            this.txtDeleteStdID.TextChanged += new System.EventHandler(this.txtDeleteStdID_TextChanged);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(696, 349);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(107, 44);
            this.btnDeleteStudent.TabIndex = 13;
            this.btnDeleteStudent.Text = "Delete student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(84, 394);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(306, 150);
            this.dgvData.TabIndex = 14;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(168, 345);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(122, 34);
            this.btnLoadData.TabIndex = 15;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // AdminDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1068, 608);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.txtDeleteStdID);
            this.Controls.Add(this.lblDeleteStdID);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtStdName);
            this.Controls.Add(this.txtStdID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblStdName);
            this.Controls.Add(this.lblStdID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnLoadUsers);
            this.Controls.Add(this.dgvUsers);
            this.Name = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnLoadUsers;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtStdID;
        private System.Windows.Forms.TextBox txtStdName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblDeleteStdID;
        private System.Windows.Forms.TextBox txtDeleteStdID;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnLoadData;
    }

    }