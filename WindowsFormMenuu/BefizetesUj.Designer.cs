namespace WindowsFormMenuu
{
    partial class BefizetesUj
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
            this.textBox_Azonosito2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Datum = new System.Windows.Forms.DateTimePicker();
            this.textBox_Osszeg = new System.Windows.Forms.TextBox();
            this.button_Befizet = new System.Windows.Forms.Button();
            this.button_Vissza2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(315, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új Befizetés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Azonosító:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dátum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Összeg:";
            // 
            // textBox_Azonosito2
            // 
            this.textBox_Azonosito2.Location = new System.Drawing.Point(315, 149);
            this.textBox_Azonosito2.Name = "textBox_Azonosito2";
            this.textBox_Azonosito2.Size = new System.Drawing.Size(127, 22);
            this.textBox_Azonosito2.TabIndex = 4;
            // 
            // dateTimePicker_Datum
            // 
            this.dateTimePicker_Datum.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker_Datum.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Datum.Location = new System.Drawing.Point(241, 222);
            this.dateTimePicker_Datum.Name = "dateTimePicker_Datum";
            this.dateTimePicker_Datum.Size = new System.Drawing.Size(269, 25);
            this.dateTimePicker_Datum.TabIndex = 5;
            // 
            // textBox_Osszeg
            // 
            this.textBox_Osszeg.Location = new System.Drawing.Point(249, 299);
            this.textBox_Osszeg.Name = "textBox_Osszeg";
            this.textBox_Osszeg.Size = new System.Drawing.Size(254, 22);
            this.textBox_Osszeg.TabIndex = 6;
            // 
            // button_Befizet
            // 
            this.button_Befizet.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Befizet.Location = new System.Drawing.Point(320, 380);
            this.button_Befizet.Name = "button_Befizet";
            this.button_Befizet.Size = new System.Drawing.Size(126, 29);
            this.button_Befizet.TabIndex = 7;
            this.button_Befizet.Text = "Befizetés";
            this.button_Befizet.UseVisualStyleBackColor = true;
            this.button_Befizet.Click += new System.EventHandler(this.button_Befizet_Click);
            // 
            // button_Vissza2
            // 
            this.button_Vissza2.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Vissza2.Location = new System.Drawing.Point(618, 380);
            this.button_Vissza2.Name = "button_Vissza2";
            this.button_Vissza2.Size = new System.Drawing.Size(123, 29);
            this.button_Vissza2.TabIndex = 8;
            this.button_Vissza2.Text = "Vissza";
            this.button_Vissza2.UseVisualStyleBackColor = true;
            this.button_Vissza2.Click += new System.EventHandler(this.button_Vissza2_Click);
            // 
            // BefizetesUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Vissza2);
            this.Controls.Add(this.button_Befizet);
            this.Controls.Add(this.textBox_Osszeg);
            this.Controls.Add(this.dateTimePicker_Datum);
            this.Controls.Add(this.textBox_Azonosito2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BefizetesUj";
            this.Text = "BefizetesUj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Azonosito2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Datum;
        private System.Windows.Forms.TextBox textBox_Osszeg;
        private System.Windows.Forms.Button button_Befizet;
        private System.Windows.Forms.Button button_Vissza2;
    }
}