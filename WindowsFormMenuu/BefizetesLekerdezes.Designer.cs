namespace WindowsFormMenuu
{
    partial class BefizetesLekerdezes
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
            this.dataGridView_Lekerdez = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lekerdez)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Befizetés Lekérdezése";
            // 
            // dataGridView_Lekerdez
            // 
            this.dataGridView_Lekerdez.AllowUserToAddRows = false;
            this.dataGridView_Lekerdez.AllowUserToDeleteRows = false;
            this.dataGridView_Lekerdez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lekerdez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Lekerdez.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Lekerdez.Name = "dataGridView_Lekerdez";
            this.dataGridView_Lekerdez.ReadOnly = true;
            this.dataGridView_Lekerdez.RowHeadersWidth = 51;
            this.dataGridView_Lekerdez.RowTemplate.Height = 24;
            this.dataGridView_Lekerdez.Size = new System.Drawing.Size(800, 450);
            this.dataGridView_Lekerdez.TabIndex = 1;
            // 
            // BefizetesLekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Lekerdez);
            this.Controls.Add(this.label1);
            this.Name = "BefizetesLekerdezes";
            this.Text = "BefizetesLekerdezes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BefizetesLekerdezes_FormClosing);
            this.Load += new System.EventHandler(this.BefizetesLekerdezes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lekerdez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Lekerdez;
    }
}