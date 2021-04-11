namespace KnjizaraGUI
{
    partial class frmKnjizaraGUI
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lsbListaKnjiga = new System.Windows.Forms.ListBox();
            this.radAutor = new System.Windows.Forms.RadioButton();
            this.radNaziv = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRacun = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            this.lsbRacun = new System.Windows.Forms.ListBox();
            this.btnPregledRacuna = new System.Windows.Forms.Button();
            this.cmbDodajKategorija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDodajPopust = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDodajCena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDodajAutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDodajNaziv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.RefreshListuKnjiga);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(246, 22);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(108, 21);
            this.cmbKategorija.TabIndex = 1;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.RefreshListuKnjiga);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numKolicina);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.lsbListaKnjiga);
            this.groupBox1.Controls.Add(this.radAutor);
            this.groupBox1.Controls.Add(this.radNaziv);
            this.groupBox1.Controls.Add(this.cmbKategorija);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Knjiga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kolicina:";
            // 
            // numKolicina
            // 
            this.numKolicina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numKolicina.Location = new System.Drawing.Point(203, 400);
            this.numKolicina.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numKolicina.Size = new System.Drawing.Size(37, 20);
            this.numKolicina.TabIndex = 5;
            this.numKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(247, 400);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 20);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj u korpu -->";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lsbListaKnjiga
            // 
            this.lsbListaKnjiga.FormattingEnabled = true;
            this.lsbListaKnjiga.HorizontalScrollbar = true;
            this.lsbListaKnjiga.Location = new System.Drawing.Point(7, 71);
            this.lsbListaKnjiga.Name = "lsbListaKnjiga";
            this.lsbListaKnjiga.Size = new System.Drawing.Size(348, 316);
            this.lsbListaKnjiga.TabIndex = 4;
            // 
            // radAutor
            // 
            this.radAutor.AutoSize = true;
            this.radAutor.Location = new System.Drawing.Point(97, 48);
            this.radAutor.Name = "radAutor";
            this.radAutor.Size = new System.Drawing.Size(76, 17);
            this.radAutor.TabIndex = 3;
            this.radAutor.TabStop = true;
            this.radAutor.Text = "Ime Autora";
            this.radAutor.UseVisualStyleBackColor = true;
            this.radAutor.CheckedChanged += new System.EventHandler(this.radAutor_CheckedChanged);
            // 
            // radNaziv
            // 
            this.radNaziv.AutoSize = true;
            this.radNaziv.Location = new System.Drawing.Point(7, 48);
            this.radNaziv.Name = "radNaziv";
            this.radNaziv.Size = new System.Drawing.Size(84, 17);
            this.radNaziv.TabIndex = 2;
            this.radNaziv.TabStop = true;
            this.radNaziv.Text = "Naviz Knjige";
            this.radNaziv.UseVisualStyleBackColor = true;
            this.radNaziv.CheckedChanged += new System.EventHandler(this.RefreshListuKnjiga);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRacun);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUkloni);
            this.groupBox2.Controls.Add(this.btnKupi);
            this.groupBox2.Controls.Add(this.lsbRacun);
            this.groupBox2.Location = new System.Drawing.Point(379, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 426);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Racun";
            // 
            // lblRacun
            // 
            this.lblRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacun.Location = new System.Drawing.Point(63, 395);
            this.lblRacun.Name = "lblRacun";
            this.lblRacun.Size = new System.Drawing.Size(292, 25);
            this.lblRacun.TabIndex = 7;
            this.lblRacun.Text = "0.00 RSD";
            this.lblRacun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cena:";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(7, 22);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(170, 30);
            this.btnUkloni.TabIndex = 6;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(185, 22);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(170, 30);
            this.btnKupi.TabIndex = 4;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // lsbRacun
            // 
            this.lsbRacun.FormattingEnabled = true;
            this.lsbRacun.HorizontalScrollbar = true;
            this.lsbRacun.Location = new System.Drawing.Point(7, 71);
            this.lsbRacun.Name = "lsbRacun";
            this.lsbRacun.Size = new System.Drawing.Size(348, 316);
            this.lsbRacun.TabIndex = 5;
            // 
            // btnPregledRacuna
            // 
            this.btnPregledRacuna.Location = new System.Drawing.Point(753, 407);
            this.btnPregledRacuna.Name = "btnPregledRacuna";
            this.btnPregledRacuna.Size = new System.Drawing.Size(275, 30);
            this.btnPregledRacuna.TabIndex = 8;
            this.btnPregledRacuna.Text = "Pregled racuna";
            this.btnPregledRacuna.UseVisualStyleBackColor = true;
            this.btnPregledRacuna.Click += new System.EventHandler(this.btnPregledRacuna_Click);
            // 
            // cmbDodajKategorija
            // 
            this.cmbDodajKategorija.FormattingEnabled = true;
            this.cmbDodajKategorija.Location = new System.Drawing.Point(124, 243);
            this.cmbDodajKategorija.Name = "cmbDodajKategorija";
            this.cmbDodajKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbDodajKategorija.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kategorija: *";
            // 
            // txtDodajPopust
            // 
            this.txtDodajPopust.Location = new System.Drawing.Point(124, 203);
            this.txtDodajPopust.Name = "txtDodajPopust";
            this.txtDodajPopust.Size = new System.Drawing.Size(121, 20);
            this.txtDodajPopust.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Popust (%): *";
            // 
            // txtDodajCena
            // 
            this.txtDodajCena.Location = new System.Drawing.Point(124, 163);
            this.txtDodajCena.Name = "txtDodajCena";
            this.txtDodajCena.Size = new System.Drawing.Size(121, 20);
            this.txtDodajCena.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cena (RSD): *";
            // 
            // txtDodajAutor
            // 
            this.txtDodajAutor.Location = new System.Drawing.Point(124, 123);
            this.txtDodajAutor.Name = "txtDodajAutor";
            this.txtDodajAutor.Size = new System.Drawing.Size(121, 20);
            this.txtDodajAutor.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Autor:";
            // 
            // txtDodajNaziv
            // 
            this.txtDodajNaziv.Location = new System.Drawing.Point(124, 83);
            this.txtDodajNaziv.Name = "txtDodajNaziv";
            this.txtDodajNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtDodajNaziv.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Naziv:";
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.Location = new System.Drawing.Point(40, 283);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(205, 35);
            this.btnDodajKnjigu.TabIndex = 11;
            this.btnDodajKnjigu.Text = "Dodaj Knjigu u Bazu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            this.btnDodajKnjigu.Click += new System.EventHandler(this.btnDodajKnjigu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbDodajKategorija);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnDodajKnjigu);
            this.groupBox3.Controls.Add(this.txtDodajPopust);
            this.groupBox3.Controls.Add(this.txtDodajNaziv);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDodajCena);
            this.groupBox3.Controls.Add(this.txtDodajAutor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(753, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 387);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodaj Novu Knjigu";
            // 
            // frmKnjizaraGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPregledRacuna);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmKnjizaraGUI";
            this.Text = "Knjizara";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lsbListaKnjiga;
        private System.Windows.Forms.RadioButton radAutor;
        private System.Windows.Forms.RadioButton radNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRacun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.ListBox lsbRacun;
        private System.Windows.Forms.Button btnPregledRacuna;
        private System.Windows.Forms.ComboBox cmbDodajKategorija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDodajPopust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDodajCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDodajAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDodajNaziv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

