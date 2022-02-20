namespace Abstraction
{
    partial class CategoryPage
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
            this.GrpCreateCategory = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.txtCreateDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpdeletecategory = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtdelete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpUpdateCategory = new System.Windows.Forms.GroupBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrpCreateCategory.SuspendLayout();
            this.grpdeletecategory.SuspendLayout();
            this.grpUpdateCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpCreateCategory
            // 
            this.GrpCreateCategory.Controls.Add(this.btnCreate);
            this.GrpCreateCategory.Controls.Add(this.txtCreateName);
            this.GrpCreateCategory.Controls.Add(this.txtCreateDescription);
            this.GrpCreateCategory.Controls.Add(this.label2);
            this.GrpCreateCategory.Controls.Add(this.label1);
            this.GrpCreateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpCreateCategory.Location = new System.Drawing.Point(12, 12);
            this.GrpCreateCategory.Name = "GrpCreateCategory";
            this.GrpCreateCategory.Size = new System.Drawing.Size(414, 177);
            this.GrpCreateCategory.TabIndex = 1;
            this.GrpCreateCategory.TabStop = false;
            this.GrpCreateCategory.Text = "Create Category";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(141, 115);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(233, 35);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(141, 38);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(233, 30);
            this.txtCreateName.TabIndex = 7;
            // 
            // txtCreateDescription
            // 
            this.txtCreateDescription.Location = new System.Drawing.Point(141, 79);
            this.txtCreateDescription.Name = "txtCreateDescription";
            this.txtCreateDescription.Size = new System.Drawing.Size(233, 30);
            this.txtCreateDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grpdeletecategory
            // 
            this.grpdeletecategory.Controls.Add(this.btndelete);
            this.grpdeletecategory.Controls.Add(this.txtdelete);
            this.grpdeletecategory.Controls.Add(this.label4);
            this.grpdeletecategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpdeletecategory.Location = new System.Drawing.Point(852, 12);
            this.grpdeletecategory.Name = "grpdeletecategory";
            this.grpdeletecategory.Size = new System.Drawing.Size(414, 177);
            this.grpdeletecategory.TabIndex = 2;
            this.grpdeletecategory.TabStop = false;
            this.grpdeletecategory.Text = "Delete Category";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(141, 84);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(233, 35);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtdelete
            // 
            this.txtdelete.Location = new System.Drawing.Point(141, 38);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(233, 30);
            this.txtdelete.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id:";
            // 
            // grpUpdateCategory
            // 
            this.grpUpdateCategory.Controls.Add(this.btnUpdateCategory);
            this.grpUpdateCategory.Controls.Add(this.txtUpdateName);
            this.grpUpdateCategory.Controls.Add(this.txtUpdateDescription);
            this.grpUpdateCategory.Controls.Add(this.label5);
            this.grpUpdateCategory.Controls.Add(this.label6);
            this.grpUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUpdateCategory.Location = new System.Drawing.Point(432, 12);
            this.grpUpdateCategory.Name = "grpUpdateCategory";
            this.grpUpdateCategory.Size = new System.Drawing.Size(414, 177);
            this.grpUpdateCategory.TabIndex = 3;
            this.grpUpdateCategory.TabStop = false;
            this.grpUpdateCategory.Text = "Update Category";
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(141, 115);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(233, 35);
            this.btnUpdateCategory.TabIndex = 8;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(141, 38);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(233, 30);
            this.txtUpdateName.TabIndex = 7;
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(141, 79);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(233, 30);
            this.txtUpdateDescription.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(842, 378);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 594);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpUpdateCategory);
            this.Controls.Add(this.grpdeletecategory);
            this.Controls.Add(this.GrpCreateCategory);
            this.Name = "CategoryPage";
            this.Text = "CategoryPage";
            this.Load += new System.EventHandler(this.CategoryPage_Load);
            this.GrpCreateCategory.ResumeLayout(false);
            this.GrpCreateCategory.PerformLayout();
            this.grpdeletecategory.ResumeLayout(false);
            this.grpdeletecategory.PerformLayout();
            this.grpUpdateCategory.ResumeLayout(false);
            this.grpUpdateCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpCreateCategory;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.TextBox txtCreateDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpdeletecategory;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtdelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpUpdateCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}