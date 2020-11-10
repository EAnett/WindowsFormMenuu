namespace WindowsFormMenuu
{
    partial class TagModositas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Azonodito = new System.Windows.Forms.TextBox();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.textBox_Szulev = new System.Windows.Forms.TextBox();
            this.textBox_Irszam = new System.Windows.Forms.TextBox();
            this.comboBox_Orszag = new System.Windows.Forms.ComboBox();
            this.button_Modositas = new System.Windows.Forms.Button();
            this.button_Vissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(245, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tagok adatainak modositasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Azonosító:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szülev:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Irszam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Orszag:";
            // 
            // textBox_Azonodito
            // 
            this.textBox_Azonodito.Location = new System.Drawing.Point(266, 119);
            this.textBox_Azonodito.Name = "textBox_Azonodito";
            this.textBox_Azonodito.Size = new System.Drawing.Size(100, 22);
            this.textBox_Azonodito.TabIndex = 6;
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(210, 169);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(213, 22);
            this.textBox_Nev.TabIndex = 7;
            // 
            // textBox_Szulev
            // 
            this.textBox_Szulev.Location = new System.Drawing.Point(210, 227);
            this.textBox_Szulev.Name = "textBox_Szulev";
            this.textBox_Szulev.Size = new System.Drawing.Size(213, 22);
            this.textBox_Szulev.TabIndex = 8;
            // 
            // textBox_Irszam
            // 
            this.textBox_Irszam.Location = new System.Drawing.Point(210, 289);
            this.textBox_Irszam.Name = "textBox_Irszam";
            this.textBox_Irszam.Size = new System.Drawing.Size(213, 22);
            this.textBox_Irszam.TabIndex = 9;
            // 
            // comboBox_Orszag
            // 
            this.comboBox_Orszag.FormattingEnabled = true;
            this.comboBox_Orszag.Items.AddRange(new object[] {
            "H",
            "A",
            "RO",
            "HR"});
            this.comboBox_Orszag.Location = new System.Drawing.Point(210, 344);
            this.comboBox_Orszag.Name = "comboBox_Orszag";
            this.comboBox_Orszag.Size = new System.Drawing.Size(213, 24);
            this.comboBox_Orszag.TabIndex = 10;
            // 
            // button_Modositas
            // 
            this.button_Modositas.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modositas.Location = new System.Drawing.Point(238, 402);
            this.button_Modositas.Name = "button_Modositas";
            this.button_Modositas.Size = new System.Drawing.Size(156, 36);
            this.button_Modositas.TabIndex = 11;
            this.button_Modositas.Text = "Módosítás";
            this.button_Modositas.UseVisualStyleBackColor = true;
            this.button_Modositas.Click += new System.EventHandler(this.button_Modositas_Click);
            // 
            // button_Vissza
            // 
            this.button_Vissza.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Vissza.Location = new System.Drawing.Point(559, 319);
            this.button_Vissza.Name = "button_Vissza";
            this.button_Vissza.Size = new System.Drawing.Size(140, 49);
            this.button_Vissza.TabIndex = 12;
            this.button_Vissza.Text = "Vissza";
            this.button_Vissza.UseVisualStyleBackColor = true;
            this.button_Vissza.Click += new System.EventHandler(this.button_Vissza_Click);
            // 
            // TagModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Vissza);
            this.Controls.Add(this.button_Modositas);
            this.Controls.Add(this.comboBox_Orszag);
            this.Controls.Add(this.textBox_Irszam);
            this.Controls.Add(this.textBox_Szulev);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.textBox_Azonodito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TagModositas";
            this.Text = "TagModositas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TagModositas_FormClosing);
            this.Load += new System.EventHandler(this.TagModositas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Azonodito;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.TextBox textBox_Szulev;
        private System.Windows.Forms.TextBox textBox_Irszam;
        private System.Windows.Forms.ComboBox comboBox_Orszag;
        private System.Windows.Forms.Button button_Modositas;
        private System.Windows.Forms.Button button_Vissza;
    }
}