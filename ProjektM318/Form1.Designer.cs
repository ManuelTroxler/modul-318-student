namespace ProjektM318
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtvon = new System.Windows.Forms.TextBox();
            this.txthaltestelle = new System.Windows.Forms.TextBox();
            this.txtbis = new System.Windows.Forms.TextBox();
            this.btnwechsel = new System.Windows.Forms.Button();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnfrüher = new System.Windows.Forms.Button();
            this.btnspäter = new System.Windows.Forms.Button();
            this.btnvonmap = new System.Windows.Forms.Button();
            this.btnbismap = new System.Windows.Forms.Button();
            this.btnhaltestellemap = new System.Windows.Forms.Button();
            this.dgverbindungen = new System.Windows.Forms.DataGridView();
            this.abfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtszone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunftsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunftszone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbabfahrt = new System.Windows.Forms.ListBox();
            this.lbankunft = new System.Windows.Forms.ListBox();
            this.btnhaltestellesearch = new System.Windows.Forms.Button();
            this.lbhaltestelle = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgverbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvon
            // 
            this.txtvon.Location = new System.Drawing.Point(84, 56);
            this.txtvon.Name = "txtvon";
            this.txtvon.Size = new System.Drawing.Size(100, 22);
            this.txtvon.TabIndex = 0;
            this.txtvon.Text = " ";
            this.txtvon.TextChanged += new System.EventHandler(this.txtvon_TextChanged);
            this.txtvon.Leave += new System.EventHandler(this.txtvon_Leave);
            // 
            // txthaltestelle
            // 
            this.txthaltestelle.Location = new System.Drawing.Point(84, 163);
            this.txthaltestelle.Name = "txthaltestelle";
            this.txthaltestelle.Size = new System.Drawing.Size(100, 22);
            this.txthaltestelle.TabIndex = 3;
            this.txthaltestelle.TextChanged += new System.EventHandler(this.txthaltestelle_TextChanged);
            this.txthaltestelle.Leave += new System.EventHandler(this.txthaltestelle_Leave);
            // 
            // txtbis
            // 
            this.txtbis.Location = new System.Drawing.Point(423, 56);
            this.txtbis.Name = "txtbis";
            this.txtbis.Size = new System.Drawing.Size(100, 22);
            this.txtbis.TabIndex = 1;
            this.txtbis.TextChanged += new System.EventHandler(this.txtbis_TextChanged);
            this.txtbis.Leave += new System.EventHandler(this.txtbis_Leave);
            // 
            // btnwechsel
            // 
            this.btnwechsel.Location = new System.Drawing.Point(301, 56);
            this.btnwechsel.Name = "btnwechsel";
            this.btnwechsel.Size = new System.Drawing.Size(75, 23);
            this.btnwechsel.TabIndex = 8;
            this.btnwechsel.Text = "<-->";
            this.btnwechsel.UseVisualStyleBackColor = true;
            this.btnwechsel.Click += new System.EventHandler(this.btnwechsel_Click);
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(775, 54);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(250, 22);
            this.datepicker.TabIndex = 7;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(1094, 45);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(87, 44);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnfrüher
            // 
            this.btnfrüher.Location = new System.Drawing.Point(823, 163);
            this.btnfrüher.Name = "btnfrüher";
            this.btnfrüher.Size = new System.Drawing.Size(75, 23);
            this.btnfrüher.TabIndex = 9;
            this.btnfrüher.Text = "Früher";
            this.btnfrüher.UseVisualStyleBackColor = true;
            // 
            // btnspäter
            // 
            this.btnspäter.Location = new System.Drawing.Point(950, 163);
            this.btnspäter.Name = "btnspäter";
            this.btnspäter.Size = new System.Drawing.Size(75, 23);
            this.btnspäter.TabIndex = 10;
            this.btnspäter.Text = "Später";
            this.btnspäter.UseVisualStyleBackColor = true;
            // 
            // btnvonmap
            // 
            this.btnvonmap.Image = ((System.Drawing.Image)(resources.GetObject("btnvonmap.Image")));
            this.btnvonmap.Location = new System.Drawing.Point(199, 45);
            this.btnvonmap.Name = "btnvonmap";
            this.btnvonmap.Size = new System.Drawing.Size(75, 44);
            this.btnvonmap.TabIndex = 4;
            this.btnvonmap.UseVisualStyleBackColor = true;
            this.btnvonmap.Click += new System.EventHandler(this.btnvonmap_Click);
            // 
            // btnbismap
            // 
            this.btnbismap.Image = ((System.Drawing.Image)(resources.GetObject("btnbismap.Image")));
            this.btnbismap.Location = new System.Drawing.Point(539, 45);
            this.btnbismap.Name = "btnbismap";
            this.btnbismap.Size = new System.Drawing.Size(75, 44);
            this.btnbismap.TabIndex = 5;
            this.btnbismap.UseVisualStyleBackColor = true;
            this.btnbismap.Click += new System.EventHandler(this.btnbismap_Click);
            // 
            // btnhaltestellemap
            // 
            this.btnhaltestellemap.Image = ((System.Drawing.Image)(resources.GetObject("btnhaltestellemap.Image")));
            this.btnhaltestellemap.Location = new System.Drawing.Point(199, 158);
            this.btnhaltestellemap.Name = "btnhaltestellemap";
            this.btnhaltestellemap.Size = new System.Drawing.Size(75, 44);
            this.btnhaltestellemap.TabIndex = 6;
            this.btnhaltestellemap.UseVisualStyleBackColor = true;
            this.btnhaltestellemap.Click += new System.EventHandler(this.btnhaltestellemap_Click);
            // 
            // dgverbindungen
            // 
            this.dgverbindungen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgverbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgverbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abfahrtsstation,
            this.abfahrtszeit,
            this.abfahrtszone,
            this.ankunftsstation,
            this.ankunftszeit,
            this.ankunftszone,
            this.verspätung});
            this.dgverbindungen.Location = new System.Drawing.Point(84, 211);
            this.dgverbindungen.Name = "dgverbindungen";
            this.dgverbindungen.ReadOnly = true;
            this.dgverbindungen.RowTemplate.Height = 24;
            this.dgverbindungen.Size = new System.Drawing.Size(1106, 364);
            this.dgverbindungen.TabIndex = 11;
            // 
            // abfahrtsstation
            // 
            this.abfahrtsstation.HeaderText = "Ort";
            this.abfahrtsstation.Name = "abfahrtsstation";
            this.abfahrtsstation.ReadOnly = true;
            // 
            // abfahrtszeit
            // 
            this.abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.abfahrtszeit.Name = "abfahrtszeit";
            this.abfahrtszeit.ReadOnly = true;
            // 
            // abfahrtszone
            // 
            this.abfahrtszone.HeaderText = "Zone";
            this.abfahrtszone.Name = "abfahrtszone";
            this.abfahrtszone.ReadOnly = true;
            // 
            // ankunftsstation
            // 
            this.ankunftsstation.HeaderText = "Ort";
            this.ankunftsstation.Name = "ankunftsstation";
            this.ankunftsstation.ReadOnly = true;
            // 
            // ankunftszeit
            // 
            this.ankunftszeit.HeaderText = "Ankunftszeit";
            this.ankunftszeit.Name = "ankunftszeit";
            this.ankunftszeit.ReadOnly = true;
            // 
            // ankunftszone
            // 
            this.ankunftszone.HeaderText = "Zone";
            this.ankunftszone.Name = "ankunftszone";
            this.ankunftszone.ReadOnly = true;
            // 
            // verspätung
            // 
            this.verspätung.HeaderText = "Verspätung";
            this.verspätung.Name = "verspätung";
            this.verspätung.ReadOnly = true;
            // 
            // lbabfahrt
            // 
            this.lbabfahrt.FormattingEnabled = true;
            this.lbabfahrt.ItemHeight = 16;
            this.lbabfahrt.Location = new System.Drawing.Point(84, 85);
            this.lbabfahrt.Name = "lbabfahrt";
            this.lbabfahrt.Size = new System.Drawing.Size(256, 212);
            this.lbabfahrt.TabIndex = 12;
            this.lbabfahrt.Visible = false;
            this.lbabfahrt.Enter += new System.EventHandler(this.lbabfahrt_Enter);
            this.lbabfahrt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbabfahrt_MouseDoubleClick);
            // 
            // lbankunft
            // 
            this.lbankunft.FormattingEnabled = true;
            this.lbankunft.ItemHeight = 16;
            this.lbankunft.Location = new System.Drawing.Point(423, 85);
            this.lbankunft.Name = "lbankunft";
            this.lbankunft.Size = new System.Drawing.Size(256, 212);
            this.lbankunft.TabIndex = 13;
            this.lbankunft.Visible = false;
            this.lbankunft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbankunft_MouseDoubleClick);
            // 
            // btnhaltestellesearch
            // 
            this.btnhaltestellesearch.Location = new System.Drawing.Point(342, 158);
            this.btnhaltestellesearch.Name = "btnhaltestellesearch";
            this.btnhaltestellesearch.Size = new System.Drawing.Size(75, 32);
            this.btnhaltestellesearch.TabIndex = 14;
            this.btnhaltestellesearch.Text = "Search";
            this.btnhaltestellesearch.UseVisualStyleBackColor = true;
            this.btnhaltestellesearch.Click += new System.EventHandler(this.btnhaltestellesearch_Click);
            // 
            // lbhaltestelle
            // 
            this.lbhaltestelle.FormattingEnabled = true;
            this.lbhaltestelle.ItemHeight = 16;
            this.lbhaltestelle.Location = new System.Drawing.Point(84, 191);
            this.lbhaltestelle.Name = "lbhaltestelle";
            this.lbhaltestelle.Size = new System.Drawing.Size(256, 212);
            this.lbhaltestelle.TabIndex = 15;
            this.lbhaltestelle.Visible = false;
            this.lbhaltestelle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbhaltestelle_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 632);
            this.Controls.Add(this.lbankunft);
            this.Controls.Add(this.lbhaltestelle);
            this.Controls.Add(this.lbabfahrt);
            this.Controls.Add(this.btnhaltestellesearch);
            this.Controls.Add(this.dgverbindungen);
            this.Controls.Add(this.btnhaltestellemap);
            this.Controls.Add(this.btnbismap);
            this.Controls.Add(this.btnvonmap);
            this.Controls.Add(this.btnspäter);
            this.Controls.Add(this.btnfrüher);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.btnwechsel);
            this.Controls.Add(this.txtbis);
            this.Controls.Add(this.txthaltestelle);
            this.Controls.Add(this.txtvon);
            this.Name = "Form1";
            this.Text = "Fahrplan";
            ((System.ComponentModel.ISupportInitialize)(this.dgverbindungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvon;
        private System.Windows.Forms.TextBox txthaltestelle;
        private System.Windows.Forms.TextBox txtbis;
        private System.Windows.Forms.Button btnwechsel;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnfrüher;
        private System.Windows.Forms.Button btnspäter;
        private System.Windows.Forms.Button btnvonmap;
        private System.Windows.Forms.Button btnbismap;
        private System.Windows.Forms.Button btnhaltestellemap;
        private System.Windows.Forms.DataGridView dgverbindungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtszone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunftsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunftszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunftszone;
        private System.Windows.Forms.DataGridViewTextBoxColumn verspätung;
        private System.Windows.Forms.ListBox lbabfahrt;
        private System.Windows.Forms.ListBox lbankunft;
        private System.Windows.Forms.Button btnhaltestellesearch;
        private System.Windows.Forms.ListBox lbhaltestelle;
    }
}

