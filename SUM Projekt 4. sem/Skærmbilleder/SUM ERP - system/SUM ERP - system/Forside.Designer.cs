namespace SUM_ERP___system
{
    partial class Forside
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kartotekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kunderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varegrupperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leverandørToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medarbejderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAntal = new System.Windows.Forms.ComboBox();
            this.btnSletProdukt = new System.Windows.Forms.Button();
            this.dgvIndkoebskurv = new System.Windows.Forms.DataGridView();
            this.VareNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varenavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rabat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntGemOrdre = new System.Windows.Forms.Button();
            this.btnSoegVare = new System.Windows.Forms.Button();
            this.btnsoegKunde = new System.Windows.Forms.Button();
            this.btnTilføj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKundeNr = new System.Windows.Forms.TextBox();
            this.textVareNr = new System.Windows.Forms.TextBox();
            this.textRabat = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndkoebskurv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartotekToolStripMenuItem,
            this.statistikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kartotekToolStripMenuItem
            // 
            this.kartotekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kunderToolStripMenuItem,
            this.varegrupperToolStripMenuItem,
            this.varerToolStripMenuItem,
            this.leverandørToolStripMenuItem,
            this.medarbejderToolStripMenuItem});
            this.kartotekToolStripMenuItem.Name = "kartotekToolStripMenuItem";
            this.kartotekToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.kartotekToolStripMenuItem.Text = "Kartotek";
            // 
            // kunderToolStripMenuItem
            // 
            this.kunderToolStripMenuItem.Name = "kunderToolStripMenuItem";
            this.kunderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.kunderToolStripMenuItem.Text = "Kunder";
            // 
            // varegrupperToolStripMenuItem
            // 
            this.varegrupperToolStripMenuItem.Name = "varegrupperToolStripMenuItem";
            this.varegrupperToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.varegrupperToolStripMenuItem.Text = "Varegrupper";
            // 
            // varerToolStripMenuItem
            // 
            this.varerToolStripMenuItem.Name = "varerToolStripMenuItem";
            this.varerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.varerToolStripMenuItem.Text = "Varer";
            // 
            // leverandørToolStripMenuItem
            // 
            this.leverandørToolStripMenuItem.Name = "leverandørToolStripMenuItem";
            this.leverandørToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.leverandørToolStripMenuItem.Text = "Leverandør";
            // 
            // medarbejderToolStripMenuItem
            // 
            this.medarbejderToolStripMenuItem.Name = "medarbejderToolStripMenuItem";
            this.medarbejderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.medarbejderToolStripMenuItem.Text = "Medarbejder";
            // 
            // statistikToolStripMenuItem
            // 
            this.statistikToolStripMenuItem.Name = "statistikToolStripMenuItem";
            this.statistikToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.statistikToolStripMenuItem.Text = "Statistik";
            // 
            // cbAntal
            // 
            this.cbAntal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAntal.FormattingEnabled = true;
            this.cbAntal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbAntal.Location = new System.Drawing.Point(542, 76);
            this.cbAntal.Name = "cbAntal";
            this.cbAntal.Size = new System.Drawing.Size(103, 21);
            this.cbAntal.TabIndex = 44;
            // 
            // btnSletProdukt
            // 
            this.btnSletProdukt.Location = new System.Drawing.Point(93, 433);
            this.btnSletProdukt.Name = "btnSletProdukt";
            this.btnSletProdukt.Size = new System.Drawing.Size(75, 23);
            this.btnSletProdukt.TabIndex = 43;
            this.btnSletProdukt.Text = "Slet Vare";
            this.btnSletProdukt.UseVisualStyleBackColor = true;
            // 
            // dgvIndkoebskurv
            // 
            this.dgvIndkoebskurv.AllowUserToAddRows = false;
            this.dgvIndkoebskurv.AllowUserToDeleteRows = false;
            this.dgvIndkoebskurv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndkoebskurv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VareNr,
            this.Varenavn,
            this.Rabat,
            this.Antal,
            this.Pris});
            this.dgvIndkoebskurv.Location = new System.Drawing.Point(93, 192);
            this.dgvIndkoebskurv.Name = "dgvIndkoebskurv";
            this.dgvIndkoebskurv.ReadOnly = true;
            this.dgvIndkoebskurv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIndkoebskurv.Size = new System.Drawing.Size(552, 235);
            this.dgvIndkoebskurv.TabIndex = 42;
            // 
            // VareNr
            // 
            this.VareNr.HeaderText = "Vare nr";
            this.VareNr.Name = "VareNr";
            this.VareNr.ReadOnly = true;
            // 
            // Varenavn
            // 
            this.Varenavn.HeaderText = "Varenavn";
            this.Varenavn.Name = "Varenavn";
            this.Varenavn.ReadOnly = true;
            // 
            // Rabat
            // 
            this.Rabat.HeaderText = "Rabat";
            this.Rabat.Name = "Rabat";
            this.Rabat.ReadOnly = true;
            // 
            // Antal
            // 
            this.Antal.HeaderText = "Antal";
            this.Antal.Name = "Antal";
            this.Antal.ReadOnly = true;
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            this.Pris.ReadOnly = true;
            // 
            // bntGemOrdre
            // 
            this.bntGemOrdre.Location = new System.Drawing.Point(519, 500);
            this.bntGemOrdre.Name = "bntGemOrdre";
            this.bntGemOrdre.Size = new System.Drawing.Size(126, 23);
            this.bntGemOrdre.TabIndex = 41;
            this.bntGemOrdre.Text = "Forsæt til betaling";
            this.bntGemOrdre.UseVisualStyleBackColor = true;
            this.bntGemOrdre.Click += new System.EventHandler(this.bntGemOrdre_Click);
            // 
            // btnSoegVare
            // 
            this.btnSoegVare.Location = new System.Drawing.Point(225, 71);
            this.btnSoegVare.Name = "btnSoegVare";
            this.btnSoegVare.Size = new System.Drawing.Size(75, 23);
            this.btnSoegVare.TabIndex = 40;
            this.btnSoegVare.Text = "Søg vare";
            this.btnSoegVare.UseVisualStyleBackColor = true;
            // 
            // btnsoegKunde
            // 
            this.btnsoegKunde.Location = new System.Drawing.Point(12, 74);
            this.btnsoegKunde.Name = "btnsoegKunde";
            this.btnsoegKunde.Size = new System.Drawing.Size(75, 23);
            this.btnsoegKunde.TabIndex = 39;
            this.btnsoegKunde.Text = "Søg kunde";
            this.btnsoegKunde.UseVisualStyleBackColor = true;
            // 
            // btnTilføj
            // 
            this.btnTilføj.Location = new System.Drawing.Point(570, 163);
            this.btnTilføj.Name = "btnTilføj";
            this.btnTilføj.Size = new System.Drawing.Size(75, 23);
            this.btnTilføj.TabIndex = 38;
            this.btnTilføj.Text = "Tilføj ";
            this.btnTilføj.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Antal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Rabat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "VareNr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "kundeNr";
            // 
            // textKundeNr
            // 
            this.textKundeNr.Location = new System.Drawing.Point(93, 77);
            this.textKundeNr.Name = "textKundeNr";
            this.textKundeNr.Size = new System.Drawing.Size(100, 20);
            this.textKundeNr.TabIndex = 32;
            // 
            // textVareNr
            // 
            this.textVareNr.Location = new System.Drawing.Point(321, 74);
            this.textVareNr.Name = "textVareNr";
            this.textVareNr.Size = new System.Drawing.Size(100, 20);
            this.textVareNr.TabIndex = 31;
            // 
            // textRabat
            // 
            this.textRabat.Location = new System.Drawing.Point(436, 76);
            this.textRabat.Name = "textRabat";
            this.textRabat.Size = new System.Drawing.Size(100, 20);
            this.textRabat.TabIndex = 30;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(545, 446);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 29;
            this.textTotal.Text = "0";
            // 
            // Forside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 554);
            this.Controls.Add(this.cbAntal);
            this.Controls.Add(this.btnSletProdukt);
            this.Controls.Add(this.dgvIndkoebskurv);
            this.Controls.Add(this.bntGemOrdre);
            this.Controls.Add(this.btnSoegVare);
            this.Controls.Add(this.btnsoegKunde);
            this.Controls.Add(this.btnTilføj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKundeNr);
            this.Controls.Add(this.textVareNr);
            this.Controls.Add(this.textRabat);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Forside";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Forside_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndkoebskurv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kartotekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kunderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medarbejderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leverandørToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbAntal;
        private System.Windows.Forms.Button btnSletProdukt;
        private System.Windows.Forms.DataGridView dgvIndkoebskurv;
        private System.Windows.Forms.Button bntGemOrdre;
        private System.Windows.Forms.Button btnSoegVare;
        private System.Windows.Forms.Button btnsoegKunde;
        private System.Windows.Forms.Button btnTilføj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKundeNr;
        private System.Windows.Forms.TextBox textVareNr;
        private System.Windows.Forms.TextBox textRabat;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.ToolStripMenuItem varerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varegrupperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn VareNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varenavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rabat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
    }
}

