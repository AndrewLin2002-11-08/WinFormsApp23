namespace WinFormsApp23
{
    partial class Form1penambahanform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1telp = new System.Windows.Forms.TextBox();
            this.textBox2alamat = new System.Windows.Forms.TextBox();
            this.textBox3nama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telp:";
            // 
            // textBox1telp
            // 
            this.textBox1telp.Location = new System.Drawing.Point(162, 166);
            this.textBox1telp.Name = "textBox1telp";
            this.textBox1telp.Size = new System.Drawing.Size(531, 31);
            this.textBox1telp.TabIndex = 3;
            // 
            // textBox2alamat
            // 
            this.textBox2alamat.Location = new System.Drawing.Point(162, 106);
            this.textBox2alamat.Name = "textBox2alamat";
            this.textBox2alamat.Size = new System.Drawing.Size(531, 31);
            this.textBox2alamat.TabIndex = 4;
            // 
            // textBox3nama
            // 
            this.textBox3nama.Location = new System.Drawing.Point(162, 57);
            this.textBox3nama.Name = "textBox3nama";
            this.textBox3nama.Size = new System.Drawing.Size(531, 31);
            this.textBox3nama.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lihat Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1penambahanform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3nama);
            this.Controls.Add(this.textBox2alamat);
            this.Controls.Add(this.textBox1telp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1penambahanform";
            this.Text = "Form Penambahan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1telp;
        private TextBox textBox2alamat;
        private TextBox textBox3nama;
        private Button button1;
        private Button button2;
    }
}