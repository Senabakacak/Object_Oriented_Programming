namespace Abstract2
{
    partial class AppUserPage
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
            this.grpCreateUser = new System.Windows.Forms.GroupBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUpdateUser = new System.Windows.Forms.GroupBox();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDeleteUser = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpFindByRole = new System.Windows.Forms.GroupBox();
            this.cmbFindByRole = new System.Windows.Forms.ComboBox();
            this.btnGetRole = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCreateUser.SuspendLayout();
            this.grpUpdateUser.SuspendLayout();
            this.grpDeleteUser.SuspendLayout();
            this.grpFindByRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCreateUser
            // 
            this.grpCreateUser.Controls.Add(this.btnCreateUser);
            this.grpCreateUser.Controls.Add(this.cmbRole);
            this.grpCreateUser.Controls.Add(this.txtFirstName);
            this.grpCreateUser.Controls.Add(this.txtLastName);
            this.grpCreateUser.Controls.Add(this.label3);
            this.grpCreateUser.Controls.Add(this.label2);
            this.grpCreateUser.Controls.Add(this.label1);
            this.grpCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCreateUser.Location = new System.Drawing.Point(12, 12);
            this.grpCreateUser.Name = "grpCreateUser";
            this.grpCreateUser.Size = new System.Drawing.Size(333, 261);
            this.grpCreateUser.TabIndex = 0;
            this.grpCreateUser.TabStop = false;
            this.grpCreateUser.Text = "Create User";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(138, 162);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(187, 42);
            this.btnCreateUser.TabIndex = 6;
            this.btnCreateUser.Text = "CREATE";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(138, 123);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(187, 33);
            this.cmbRole.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(138, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(187, 30);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(138, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(187, 30);
            this.txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // grpUpdateUser
            // 
            this.grpUpdateUser.Controls.Add(this.cmbUpdateRole);
            this.grpUpdateUser.Controls.Add(this.label10);
            this.grpUpdateUser.Controls.Add(this.txtUpdateLastName);
            this.grpUpdateUser.Controls.Add(this.btnFind);
            this.grpUpdateUser.Controls.Add(this.btnUpdate);
            this.grpUpdateUser.Controls.Add(this.txtId);
            this.grpUpdateUser.Controls.Add(this.txtUpdateFirstName);
            this.grpUpdateUser.Controls.Add(this.label4);
            this.grpUpdateUser.Controls.Add(this.label5);
            this.grpUpdateUser.Controls.Add(this.label6);
            this.grpUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUpdateUser.Location = new System.Drawing.Point(363, 12);
            this.grpUpdateUser.Name = "grpUpdateUser";
            this.grpUpdateUser.Size = new System.Drawing.Size(425, 261);
            this.grpUpdateUser.TabIndex = 1;
            this.grpUpdateUser.TabStop = false;
            this.grpUpdateUser.Text = "Update User";
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Location = new System.Drawing.Point(128, 159);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(187, 33);
            this.cmbUpdateRole.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Role:";
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(128, 123);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(187, 30);
            this.txtUpdateLastName.TabIndex = 8;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(321, 36);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 45);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 42);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(187, 30);
            this.txtId.TabIndex = 4;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(128, 83);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(187, 30);
            this.txtUpdateFirstName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id:";
            // 
            // grpDeleteUser
            // 
            this.grpDeleteUser.Controls.Add(this.btnDelete);
            this.grpDeleteUser.Controls.Add(this.txtDeleteId);
            this.grpDeleteUser.Controls.Add(this.label9);
            this.grpDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDeleteUser.Location = new System.Drawing.Point(803, 12);
            this.grpDeleteUser.Name = "grpDeleteUser";
            this.grpDeleteUser.Size = new System.Drawing.Size(333, 133);
            this.grpDeleteUser.TabIndex = 2;
            this.grpDeleteUser.TabStop = false;
            this.grpDeleteUser.Text = "Delete User";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(101, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(101, 38);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(187, 30);
            this.txtDeleteId.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Id:";
            // 
            // grpFindByRole
            // 
            this.grpFindByRole.Controls.Add(this.cmbFindByRole);
            this.grpFindByRole.Controls.Add(this.btnGetRole);
            this.grpFindByRole.Controls.Add(this.label7);
            this.grpFindByRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpFindByRole.Location = new System.Drawing.Point(803, 151);
            this.grpFindByRole.Name = "grpFindByRole";
            this.grpFindByRole.Size = new System.Drawing.Size(333, 122);
            this.grpFindByRole.TabIndex = 3;
            this.grpFindByRole.TabStop = false;
            this.grpFindByRole.Text = "Fınd By Role";
            // 
            // cmbFindByRole
            // 
            this.cmbFindByRole.FormattingEnabled = true;
            this.cmbFindByRole.Location = new System.Drawing.Point(101, 32);
            this.cmbFindByRole.Name = "cmbFindByRole";
            this.cmbFindByRole.Size = new System.Drawing.Size(187, 33);
            this.cmbFindByRole.TabIndex = 11;
            // 
            // btnGetRole
            // 
            this.btnGetRole.Location = new System.Drawing.Point(101, 74);
            this.btnGetRole.Name = "btnGetRole";
            this.btnGetRole.Size = new System.Drawing.Size(187, 42);
            this.btnGetRole.TabIndex = 6;
            this.btnGetRole.Text = "GET";
            this.btnGetRole.UseVisualStyleBackColor = true;
            this.btnGetRole.Click += new System.EventHandler(this.btnGetRole_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Role:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 248);
            this.dataGridView1.TabIndex = 12;
            // 
            // AppUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpFindByRole);
            this.Controls.Add(this.grpDeleteUser);
            this.Controls.Add(this.grpUpdateUser);
            this.Controls.Add(this.grpCreateUser);
            this.Name = "AppUserPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AppUserPage_Load);
            this.grpCreateUser.ResumeLayout(false);
            this.grpCreateUser.PerformLayout();
            this.grpUpdateUser.ResumeLayout(false);
            this.grpUpdateUser.PerformLayout();
            this.grpDeleteUser.ResumeLayout(false);
            this.grpDeleteUser.PerformLayout();
            this.grpFindByRole.ResumeLayout(false);
            this.grpFindByRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreateUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpUpdateUser;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpDeleteUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpFindByRole;
        private System.Windows.Forms.ComboBox cmbFindByRole;
        private System.Windows.Forms.Button btnGetRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

