namespace SatrancV2
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
            this.cmbBoyut = new System.Windows.Forms.ComboBox();
            this.btnCiz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBoyut
            // 
            this.cmbBoyut.FormattingEnabled = true;
            this.cmbBoyut.Items.AddRange(new object[] {
            "5x5",
            "6x6",
            "7x7",
            "8x8",
            "9x9"});
            this.cmbBoyut.Location = new System.Drawing.Point(375, 455);
            this.cmbBoyut.Name = "cmbBoyut";
            this.cmbBoyut.Size = new System.Drawing.Size(59, 21);
            this.cmbBoyut.TabIndex = 5;
            this.cmbBoyut.Text = "Seçiniz";
            // 
            // btnCiz
            // 
            this.btnCiz.Location = new System.Drawing.Point(375, 482);
            this.btnCiz.Name = "btnCiz";
            this.btnCiz.Size = new System.Drawing.Size(59, 23);
            this.btnCiz.TabIndex = 4;
            this.btnCiz.Text = "Çiz";
            this.btnCiz.UseVisualStyleBackColor = true;
            this.btnCiz.Click += new System.EventHandler(this.btnCiz_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sıfırla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBoyut);
            this.Controls.Add(this.btnCiz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoyut;
        private System.Windows.Forms.Button btnCiz;
        private System.Windows.Forms.Button button1;
    }
}

