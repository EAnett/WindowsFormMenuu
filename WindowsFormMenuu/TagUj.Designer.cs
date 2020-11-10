namespace WindowsFormMenuu
{
    partial class TagUj
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Irszam = new System.Windows.Forms.TextBox();
            this.textBox_Szulev = new System.Windows.Forms.TextBox();
            this.comboBox_Orszag = new System.Windows.Forms.ComboBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Azonosito = new System.Windows.Forms.TextBox();
            this.button_Vissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(193, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új tag felvétele";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(168, 152);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(227, 22);
            this.textBox_Nev.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Szulev";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Irszam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Orszag";
            // 
            // textBox_Irszam
            // 
            this.textBox_Irszam.Location = new System.Drawing.Point(168, 247);
            this.textBox_Irszam.Name = "textBox_Irszam";
            this.textBox_Irszam.Size = new System.Drawing.Size(227, 22);
            this.textBox_Irszam.TabIndex = 7;
            this.textBox_Irszam.TextChanged += new System.EventHandler(this.textBox_Irszam_TextChanged);
            // 
            // textBox_Szulev
            // 
            this.textBox_Szulev.Location = new System.Drawing.Point(168, 199);
            this.textBox_Szulev.Name = "textBox_Szulev";
            this.textBox_Szulev.Size = new System.Drawing.Size(227, 22);
            this.textBox_Szulev.TabIndex = 8;
            // 
            // comboBox_Orszag
            // 
            this.comboBox_Orszag.FormattingEnabled = true;
            this.comboBox_Orszag.Items.AddRange(new object[] {
            "H",
            "A",
            "RO",
            "HR"});
            this.comboBox_Orszag.Location = new System.Drawing.Point(168, 299);
            this.comboBox_Orszag.Name = "comboBox_Orszag";
            this.comboBox_Orszag.Size = new System.Drawing.Size(227, 24);
            this.comboBox_Orszag.TabIndex = 9;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(223, 378);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 34);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Azonosító";
            // 
            // textBox_Azonosito
            // 
            this.textBox_Azonosito.Location = new System.Drawing.Point(223, 98);
            this.textBox_Azonosito.Name = "textBox_Azonosito";
            this.textBox_Azonosito.Size = new System.Drawing.Size(100, 22);
            this.textBox_Azonosito.TabIndex = 12;
            // 
            // button_Vissza
            // 
            this.button_Vissza.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Vissza.Location = new System.Drawing.Point(511, 197);
            this.button_Vissza.Name = "button_Vissza";
            this.button_Vissza.Size = new System.Drawing.Size(162, 42);
            this.button_Vissza.TabIndex = 13;
            this.button_Vissza.Text = "Vissza";
            this.button_Vissza.UseVisualStyleBackColor = true;
            this.button_Vissza.Click += new System.EventHandler(this.button_Vissza_Click);
            // 
            // TagUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Vissza);
            this.Controls.Add(this.textBox_Azonosito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox_Orszag);
            this.Controls.Add(this.textBox_Szulev);
            this.Controls.Add(this.textBox_Irszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TagUj";
            this.Text = "TagUj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TagUj_FromClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Irszam;
        private System.Windows.Forms.TextBox textBox_Szulev;
        private System.Windows.Forms.ComboBox comboBox_Orszag;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Azonosito;
        private System.Windows.Forms.Button button_Vissza;
    }
}