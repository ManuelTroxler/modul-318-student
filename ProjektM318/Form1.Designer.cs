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
            this.btnsearch = new System.Windows.Forms.Button();
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
            this.lblvon = new System.Windows.Forms.Label();
            this.lblbis = new System.Windows.Forms.Label();
            this.lblhaltestelle = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgverbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvon
            // 
            this.txtvon.Location = new System.Drawing.Point(84, 57);
            this.txtvon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvon.Name = "txtvon";
            this.txtvon.Size = new System.Drawing.Size(155, 22);
            this.txtvon.TabIndex = 0;
            this.txtvon.Text = " ";
            this.txtvon.TextChanged += new System.EventHandler(this.txtvon_TextChanged);
            this.txtvon.Leave += new System.EventHandler(this.txtvon_Leave);
            // 
            // txthaltestelle
            // 
            this.txthaltestelle.Location = new System.Drawing.Point(84, 162);
            this.txthaltestelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthaltestelle.Name = "txthaltestelle";
            this.txthaltestelle.Size = new System.Drawing.Size(155, 22);
            this.txthaltestelle.TabIndex = 3;
            this.txthaltestelle.TextChanged += new System.EventHandler(this.txthaltestelle_TextChanged);
            this.txthaltestelle.Leave += new System.EventHandler(this.txthaltestelle_Leave);
            // 
            // txtbis
            // 
            this.txtbis.Location = new System.Drawing.Point(423, 57);
            this.txtbis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbis.Name = "txtbis";
            this.txtbis.Size = new System.Drawing.Size(155, 22);
            this.txtbis.TabIndex = 1;
            this.txtbis.TextChanged += new System.EventHandler(this.txtbis_TextChanged);
            this.txtbis.Leave += new System.EventHandler(this.txtbis_Leave);
            // 
            // btnwechsel
            // 
            this.btnwechsel.Image = ((System.Drawing.Image)(resources.GetObject("btnwechsel.Image")));
            this.btnwechsel.Location = new System.Drawing.Point(318, 48);
            this.btnwechsel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnwechsel.Name = "btnwechsel";
            this.btnwechsel.Size = new System.Drawing.Size(75, 46);
            this.btnwechsel.TabIndex = 8;
            this.btnwechsel.UseVisualStyleBackColor = true;
            this.btnwechsel.Click += new System.EventHandler(this.btnwechsel_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(711, 44);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(169, 50);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Verbindungen Suchen";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnvonmap
            // 
            this.btnvonmap.Image = ((System.Drawing.Image)(resources.GetObject("btnvonmap.Image")));
            this.btnvonmap.Location = new System.Drawing.Point(245, 47);
            this.btnvonmap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvonmap.Name = "btnvonmap";
            this.btnvonmap.Size = new System.Drawing.Size(51, 47);
            this.btnvonmap.TabIndex = 5;
            this.btnvonmap.UseVisualStyleBackColor = true;
            this.btnvonmap.Click += new System.EventHandler(this.btnvonmap_Click);
            // 
            // btnbismap
            // 
            this.btnbismap.Image = ((System.Drawing.Image)(resources.GetObject("btnbismap.Image")));
            this.btnbismap.Location = new System.Drawing.Point(584, 44);
            this.btnbismap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbismap.Name = "btnbismap";
            this.btnbismap.Size = new System.Drawing.Size(51, 47);
            this.btnbismap.TabIndex = 6;
            this.btnbismap.UseVisualStyleBackColor = true;
            this.btnbismap.Click += new System.EventHandler(this.btnbismap_Click);
            // 
            // btnhaltestellemap
            // 
            this.btnhaltestellemap.Image = ((System.Drawing.Image)(resources.GetObject("btnhaltestellemap.Image")));
            this.btnhaltestellemap.Location = new System.Drawing.Point(245, 150);
            this.btnhaltestellemap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhaltestellemap.Name = "btnhaltestellemap";
            this.btnhaltestellemap.Size = new System.Drawing.Size(51, 47);
            this.btnhaltestellemap.TabIndex = 7;
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
            this.dgverbindungen.Location = new System.Drawing.Point(84, 210);
            this.dgverbindungen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgverbindungen.Name = "dgverbindungen";
            this.dgverbindungen.ReadOnly = true;
            this.dgverbindungen.RowHeadersVisible = false;
            this.dgverbindungen.RowTemplate.Height = 24;
            this.dgverbindungen.Size = new System.Drawing.Size(1107, 364);
            this.dgverbindungen.TabIndex = 12;
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
            this.lbabfahrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbabfahrt.Name = "lbabfahrt";
            this.lbabfahrt.Size = new System.Drawing.Size(256, 212);
            this.lbabfahrt.TabIndex = 9;
            this.lbabfahrt.Visible = false;
            this.lbabfahrt.Enter += new System.EventHandler(this.lbabfahrt_Enter);
            this.lbabfahrt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbabfahrt_MouseDoubleClick);
            // 
            // lbankunft
            // 
            this.lbankunft.FormattingEnabled = true;
            this.lbankunft.ItemHeight = 16;
            this.lbankunft.Location = new System.Drawing.Point(423, 85);
            this.lbankunft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbankunft.Name = "lbankunft";
            this.lbankunft.Size = new System.Drawing.Size(256, 212);
            this.lbankunft.TabIndex = 10;
            this.lbankunft.Visible = false;
            this.lbankunft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbankunft_MouseDoubleClick);
            // 
            // btnhaltestellesearch
            // 
            this.btnhaltestellesearch.Location = new System.Drawing.Point(339, 150);
            this.btnhaltestellesearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhaltestellesearch.Name = "btnhaltestellesearch";
            this.btnhaltestellesearch.Size = new System.Drawing.Size(239, 47);
            this.btnhaltestellesearch.TabIndex = 4;
            this.btnhaltestellesearch.Text = "Haltestellen Fahrplan Suchen";
            this.btnhaltestellesearch.UseVisualStyleBackColor = true;
            this.btnhaltestellesearch.Click += new System.EventHandler(this.btnhaltestellesearch_Click);
            // 
            // lbhaltestelle
            // 
            this.lbhaltestelle.FormattingEnabled = true;
            this.lbhaltestelle.ItemHeight = 16;
            this.lbhaltestelle.Location = new System.Drawing.Point(84, 191);
            this.lbhaltestelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbhaltestelle.Name = "lbhaltestelle";
            this.lbhaltestelle.Size = new System.Drawing.Size(256, 212);
            this.lbhaltestelle.TabIndex = 11;
            this.lbhaltestelle.Visible = false;
            this.lbhaltestelle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbhaltestelle_MouseDoubleClick);
            // 
            // lblvon
            // 
            this.lblvon.AutoSize = true;
            this.lblvon.Location = new System.Drawing.Point(80, 38);
            this.lblvon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvon.Name = "lblvon";
            this.lblvon.Size = new System.Drawing.Size(37, 17);
            this.lblvon.TabIndex = 13;
            this.lblvon.Text = "Von:";
            // 
            // lblbis
            // 
            this.lblbis.AutoSize = true;
            this.lblbis.Location = new System.Drawing.Point(419, 38);
            this.lblbis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbis.Name = "lblbis";
            this.lblbis.Size = new System.Drawing.Size(31, 17);
            this.lblbis.TabIndex = 14;
            this.lblbis.Text = "Bis:";
            // 
            // lblhaltestelle
            // 
            this.lblhaltestelle.AutoSize = true;
            this.lblhaltestelle.Location = new System.Drawing.Point(80, 144);
            this.lblhaltestelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhaltestelle.Name = "lblhaltestelle";
            this.lblhaltestelle.Size = new System.Drawing.Size(78, 17);
            this.lblhaltestelle.TabIndex = 15;
            this.lblhaltestelle.Text = "Haltestelle:";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1114, 593);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(141, 28);
            this.btnclose.TabIndex = 16;
            this.btnclose.Text = "Exit";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 633);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lbabfahrt);
            this.Controls.Add(this.lblhaltestelle);
            this.Controls.Add(this.lblbis);
            this.Controls.Add(this.lblvon);
            this.Controls.Add(this.lbhaltestelle);
            this.Controls.Add(this.lbankunft);
            this.Controls.Add(this.btnhaltestellesearch);
            this.Controls.Add(this.dgverbindungen);
            this.Controls.Add(this.btnhaltestellemap);
            this.Controls.Add(this.btnbismap);
            this.Controls.Add(this.btnvonmap);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnwechsel);
            this.Controls.Add(this.txtbis);
            this.Controls.Add(this.txthaltestelle);
            this.Controls.Add(this.txtvon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnsearch;
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
        private System.Windows.Forms.Label lblvon;
        private System.Windows.Forms.Label lblbis;
        private System.Windows.Forms.Label lblhaltestelle;
        private System.Windows.Forms.Button btnclose;
    }
}

