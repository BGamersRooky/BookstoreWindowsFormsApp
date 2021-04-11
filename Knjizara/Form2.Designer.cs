namespace Knjizara
{
    partial class ListaRacuna
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
            this.datePocetak = new System.Windows.Forms.DateTimePicker();
            this.dateKraj = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbListaRacuna = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // datePocetak
            // 
            this.datePocetak.Location = new System.Drawing.Point(58, 12);
            this.datePocetak.Name = "datePocetak";
            this.datePocetak.Size = new System.Drawing.Size(200, 20);
            this.datePocetak.TabIndex = 0;
            this.datePocetak.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.datePocetak.ValueChanged += new System.EventHandler(this.RefreshujListu);
            // 
            // dateKraj
            // 
            this.dateKraj.Location = new System.Drawing.Point(58, 38);
            this.dateKraj.Name = "dateKraj";
            this.dateKraj.Size = new System.Drawing.Size(200, 20);
            this.dateKraj.TabIndex = 1;
            this.dateKraj.Value = new System.DateTime(2020, 9, 22, 0, 0, 0, 0);
            this.dateKraj.ValueChanged += new System.EventHandler(this.RefreshujListu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Do:";
            // 
            // lsbListaRacuna
            // 
            this.lsbListaRacuna.FormattingEnabled = true;
            this.lsbListaRacuna.Location = new System.Drawing.Point(13, 65);
            this.lsbListaRacuna.Name = "lsbListaRacuna";
            this.lsbListaRacuna.Size = new System.Drawing.Size(245, 329);
            this.lsbListaRacuna.TabIndex = 4;
            // 
            // ListaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 409);
            this.Controls.Add(this.lsbListaRacuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateKraj);
            this.Controls.Add(this.datePocetak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaRacuna";
            this.Text = "Dodaj Knjigu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmDodajKnjigu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePocetak;
        private System.Windows.Forms.DateTimePicker dateKraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbListaRacuna;
    }
}