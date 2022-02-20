namespace Abstraction
{
    partial class ProductPage
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
            this.GrpCreateProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreateDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.GrpUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.txtupdateprice = new System.Windows.Forms.TextBox();
            this.txtupdatedescription = new System.Windows.Forms.TextBox();
            this.txtupdateName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GrpDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteproduct = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtupdatestock = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrpCreateProduct.SuspendLayout();
            this.GrpUpdate.SuspendLayout();
            this.GrpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpCreateProduct
            // 
            this.GrpCreateProduct.Controls.Add(this.btnCreate);
            this.GrpCreateProduct.Controls.Add(this.txtCreateName);
            this.GrpCreateProduct.Controls.Add(this.txtStock);
            this.GrpCreateProduct.Controls.Add(this.txtPrice);
            this.GrpCreateProduct.Controls.Add(this.txtCreateDescription);
            this.GrpCreateProduct.Controls.Add(this.label4);
            this.GrpCreateProduct.Controls.Add(this.label3);
            this.GrpCreateProduct.Controls.Add(this.label2);
            this.GrpCreateProduct.Controls.Add(this.label1);
            this.GrpCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpCreateProduct.Location = new System.Drawing.Point(12, 12);
            this.GrpCreateProduct.Name = "GrpCreateProduct";
            this.GrpCreateProduct.Size = new System.Drawing.Size(414, 277);
            this.GrpCreateProduct.TabIndex = 0;
            this.GrpCreateProduct.TabStop = false;
            this.GrpCreateProduct.Text = "Create Product";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock:";
            // 
            // txtCreateDescription
            // 
            this.txtCreateDescription.Location = new System.Drawing.Point(141, 79);
            this.txtCreateDescription.Name = "txtCreateDescription";
            this.txtCreateDescription.Size = new System.Drawing.Size(233, 30);
            this.txtCreateDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(141, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(233, 30);
            this.txtPrice.TabIndex = 5;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(141, 166);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(233, 30);
            this.txtStock.TabIndex = 6;
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(141, 38);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(233, 30);
            this.txtCreateName.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(141, 211);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(233, 35);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // GrpUpdate
            // 
            this.GrpUpdate.Controls.Add(this.btnFind);
            this.GrpUpdate.Controls.Add(this.txtupdatestock);
            this.GrpUpdate.Controls.Add(this.label9);
            this.GrpUpdate.Controls.Add(this.btnUpdate);
            this.GrpUpdate.Controls.Add(this.txtFindById);
            this.GrpUpdate.Controls.Add(this.txtupdateprice);
            this.GrpUpdate.Controls.Add(this.txtupdatedescription);
            this.GrpUpdate.Controls.Add(this.txtupdateName);
            this.GrpUpdate.Controls.Add(this.label5);
            this.GrpUpdate.Controls.Add(this.label6);
            this.GrpUpdate.Controls.Add(this.label7);
            this.GrpUpdate.Controls.Add(this.label8);
            this.GrpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpUpdate.Location = new System.Drawing.Point(451, 12);
            this.GrpUpdate.Name = "GrpUpdate";
            this.GrpUpdate.Size = new System.Drawing.Size(414, 277);
            this.GrpUpdate.TabIndex = 1;
            this.GrpUpdate.TabStop = false;
            this.GrpUpdate.Text = "Update Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(82, 217);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(233, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtFindById
            // 
            this.txtFindById.Location = new System.Drawing.Point(82, 32);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(233, 30);
            this.txtFindById.TabIndex = 7;
            // 
            // txtupdateprice
            // 
            this.txtupdateprice.Location = new System.Drawing.Point(82, 144);
            this.txtupdateprice.Name = "txtupdateprice";
            this.txtupdateprice.Size = new System.Drawing.Size(233, 30);
            this.txtupdateprice.TabIndex = 6;
            // 
            // txtupdatedescription
            // 
            this.txtupdatedescription.Location = new System.Drawing.Point(137, 109);
            this.txtupdatedescription.Name = "txtupdatedescription";
            this.txtupdatedescription.Size = new System.Drawing.Size(233, 30);
            this.txtupdatedescription.TabIndex = 5;
            // 
            // txtupdateName
            // 
            this.txtupdateName.Location = new System.Drawing.Point(82, 68);
            this.txtupdateName.Name = "txtupdateName";
            this.txtupdateName.Size = new System.Drawing.Size(233, 30);
            this.txtupdateName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Id:";
            // 
            // GrpDelete
            // 
            this.GrpDelete.Controls.Add(this.btnDelete);
            this.GrpDelete.Controls.Add(this.txtDeleteproduct);
            this.GrpDelete.Controls.Add(this.label12);
            this.GrpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpDelete.Location = new System.Drawing.Point(888, 12);
            this.GrpDelete.Name = "GrpDelete";
            this.GrpDelete.Size = new System.Drawing.Size(414, 151);
            this.GrpDelete.TabIndex = 2;
            this.GrpDelete.TabStop = false;
            this.GrpDelete.Text = "Delete Product";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(102, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(233, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteproduct
            // 
            this.txtDeleteproduct.Location = new System.Drawing.Point(102, 41);
            this.txtDeleteproduct.Name = "txtDeleteproduct";
            this.txtDeleteproduct.Size = new System.Drawing.Size(233, 30);
            this.txtDeleteproduct.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Stock:";
            // 
            // txtupdatestock
            // 
            this.txtupdatestock.Location = new System.Drawing.Point(82, 185);
            this.txtupdatestock.Name = "txtupdatestock";
            this.txtupdatestock.Size = new System.Drawing.Size(233, 30);
            this.txtupdatestock.TabIndex = 10;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(320, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 35);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(853, 281);
            this.dataGridView1.TabIndex = 3;
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 586);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrpDelete);
            this.Controls.Add(this.GrpUpdate);
            this.Controls.Add(this.GrpCreateProduct);
            this.Name = "ProductPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductPage_Load);
            this.GrpCreateProduct.ResumeLayout(false);
            this.GrpCreateProduct.PerformLayout();
            this.GrpUpdate.ResumeLayout(false);
            this.GrpUpdate.PerformLayout();
            this.GrpDelete.ResumeLayout(false);
            this.GrpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpCreateProduct;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCreateDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpUpdate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtupdatestock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtFindById;
        private System.Windows.Forms.TextBox txtupdateprice;
        private System.Windows.Forms.TextBox txtupdatedescription;
        private System.Windows.Forms.TextBox txtupdateName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GrpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteproduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

