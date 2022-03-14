namespace WinFormsApp23
{
    partial class Form2tampilandata
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
            this.textBox3nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2alamat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1telp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1kembali = new System.Windows.Forms.Button();
            this.button2prevdata = new System.Windows.Forms.Button();
            this.button3nextdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3nama
            // 
            this.textBox3nama.Location = new System.Drawing.Point(156, 73);
            this.textBox3nama.Name = "textBox3nama";
            this.textBox3nama.Size = new System.Drawing.Size(531, 31);
            this.textBox3nama.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nama:";
            // 
            // textBox2alamat
            // 
            this.textBox2alamat.Location = new System.Drawing.Point(156, 127);
            this.textBox2alamat.Name = "textBox2alamat";
            this.textBox2alamat.Size = new System.Drawing.Size(531, 31);
            this.textBox2alamat.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alamat:";
            // 
            // textBox1telp
            // 
            this.textBox1telp.Location = new System.Drawing.Point(156, 184);
            this.textBox1telp.Name = "textBox1telp";
            this.textBox1telp.Size = new System.Drawing.Size(531, 31);
            this.textBox1telp.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telp:";
            // 
            // button1kembali
            // 
            this.button1kembali.Location = new System.Drawing.Point(69, 246);
            this.button1kembali.Name = "button1kembali";
            this.button1kembali.Size = new System.Drawing.Size(112, 34);
            this.button1kembali.TabIndex = 12;
            this.button1kembali.Text = "Kembali";
            this.button1kembali.UseVisualStyleBackColor = true;
            this.button1kembali.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2prevdata
            // 
            this.button2prevdata.Location = new System.Drawing.Point(211, 246);
            this.button2prevdata.Name = "button2prevdata";
            this.button2prevdata.Size = new System.Drawing.Size(112, 34);
            this.button2prevdata.TabIndex = 13;
            this.button2prevdata.Text = "Prev Data";
            this.button2prevdata.UseVisualStyleBackColor = true;
            // 
            // button3nextdata
            // 
            this.button3nextdata.Location = new System.Drawing.Point(360, 246);
            this.button3nextdata.Name = "button3nextdata";
            this.button3nextdata.Size = new System.Drawing.Size(112, 34);
            this.button3nextdata.TabIndex = 14;
            this.button3nextdata.Text = "Next Data";
            this.button3nextdata.UseVisualStyleBackColor = true;
            // 
            // Form2tampilandata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3nextdata);
            this.Controls.Add(this.button2prevdata);
            this.Controls.Add(this.button1kembali);
            this.Controls.Add(this.textBox1telp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2alamat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3nama);
            this.Controls.Add(this.label1);
            this.Name = "Form2tampilandata";
            this.Text = "Form Tampilan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox3nama;
        private Label label1;
        private TextBox textBox2alamat;
        private Label label2;
        private TextBox textBox1telp;
        private Label label3;
        private Button button1kembali;
        private Button button2prevdata;
        private Button button3nextdata;
    }
}