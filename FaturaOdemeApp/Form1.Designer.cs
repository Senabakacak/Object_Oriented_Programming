namespace FaturaOdemeApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.btndogalgaz = new System.Windows.Forms.Button();
            this.btnSu = new System.Windows.Forms.Button();
            this.btnElektrik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tutar:";
            // 
            // txttutar
            // 
            this.txttutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttutar.Location = new System.Drawing.Point(188, 146);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(360, 35);
            this.txttutar.TabIndex = 1;
            // 
            // btndogalgaz
            // 
            this.btndogalgaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndogalgaz.Location = new System.Drawing.Point(407, 190);
            this.btndogalgaz.Name = "btndogalgaz";
            this.btndogalgaz.Size = new System.Drawing.Size(141, 50);
            this.btndogalgaz.TabIndex = 2;
            this.btndogalgaz.Text = "Doğal Gaz";
            this.btndogalgaz.UseVisualStyleBackColor = true;
            this.btndogalgaz.Click += new System.EventHandler(this.btndogalgaz_Click);
            // 
            // btnSu
            // 
            this.btnSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSu.Location = new System.Drawing.Point(301, 190);
            this.btnSu.Name = "btnSu";
            this.btnSu.Size = new System.Drawing.Size(100, 50);
            this.btnSu.TabIndex = 3;
            this.btnSu.Text = "Su";
            this.btnSu.UseVisualStyleBackColor = true;
            this.btnSu.Click += new System.EventHandler(this.btnSu_Click);
            // 
            // btnElektrik
            // 
            this.btnElektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnElektrik.Location = new System.Drawing.Point(188, 190);
            this.btnElektrik.Name = "btnElektrik";
            this.btnElektrik.Size = new System.Drawing.Size(107, 50);
            this.btnElektrik.TabIndex = 4;
            this.btnElektrik.Text = "Elektrik";
            this.btnElektrik.UseVisualStyleBackColor = true;
            this.btnElektrik.Click += new System.EventHandler(this.btnElektrik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnElektrik);
            this.Controls.Add(this.btnSu);
            this.Controls.Add(this.btndogalgaz);
            this.Controls.Add(this.txttutar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Button btndogalgaz;
        private System.Windows.Forms.Button btnSu;
        private System.Windows.Forms.Button btnElektrik;
    }
}

