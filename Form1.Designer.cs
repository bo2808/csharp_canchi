namespace csharp_canchi
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
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.lbsDANHSACH = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Can Chi";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(211, 152);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(120, 20);
            this.txtnam.TabIndex = 3;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(211, 206);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(120, 20);
            this.txtkq.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Năm";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(94, 213);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(46, 13);
            this.lblkq.TabIndex = 8;
            this.lblkq.Text = "Kết Quả";
            // 
            // lbsDANHSACH
            // 
            this.lbsDANHSACH.FormattingEnabled = true;
            this.lbsDANHSACH.Location = new System.Drawing.Point(384, 109);
            this.lbsDANHSACH.Name = "lbsDANHSACH";
            this.lbsDANHSACH.Size = new System.Drawing.Size(323, 212);
            this.lbsDANHSACH.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(236, 249);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Tính";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(211, 118);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbsDANHSACH);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.ListBox lbsDANHSACH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

