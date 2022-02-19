namespace Constructor
{
    partial class Form1
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
            this.btnConstructor1 = new System.Windows.Forms.Button();
            this.btnConstructor2 = new System.Windows.Forms.Button();
            this.btnConstructor3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConstructor1
            // 
            this.btnConstructor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConstructor1.ForeColor = System.Drawing.Color.Red;
            this.btnConstructor1.Location = new System.Drawing.Point(121, 49);
            this.btnConstructor1.Name = "btnConstructor1";
            this.btnConstructor1.Size = new System.Drawing.Size(252, 57);
            this.btnConstructor1.TabIndex = 0;
            this.btnConstructor1.Text = "Constructor1";
            this.btnConstructor1.UseVisualStyleBackColor = true;
            this.btnConstructor1.Click += new System.EventHandler(this.btnConstructor1_Click);
            // 
            // btnConstructor2
            // 
            this.btnConstructor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConstructor2.ForeColor = System.Drawing.Color.Red;
            this.btnConstructor2.Location = new System.Drawing.Point(121, 137);
            this.btnConstructor2.Name = "btnConstructor2";
            this.btnConstructor2.Size = new System.Drawing.Size(252, 61);
            this.btnConstructor2.TabIndex = 1;
            this.btnConstructor2.Text = "Constructor2";
            this.btnConstructor2.UseVisualStyleBackColor = true;
            this.btnConstructor2.Click += new System.EventHandler(this.btnConstructor2_Click);
            // 
            // btnConstructor3
            // 
            this.btnConstructor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConstructor3.ForeColor = System.Drawing.Color.Red;
            this.btnConstructor3.Location = new System.Drawing.Point(121, 225);
            this.btnConstructor3.Name = "btnConstructor3";
            this.btnConstructor3.Size = new System.Drawing.Size(252, 69);
            this.btnConstructor3.TabIndex = 2;
            this.btnConstructor3.Text = "Constructor3";
            this.btnConstructor3.UseVisualStyleBackColor = true;
            this.btnConstructor3.Click += new System.EventHandler(this.btnConstructor3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 351);
            this.Controls.Add(this.btnConstructor3);
            this.Controls.Add(this.btnConstructor2);
            this.Controls.Add(this.btnConstructor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConstructor1;
        private System.Windows.Forms.Button btnConstructor2;
        private System.Windows.Forms.Button btnConstructor3;
    }
}

