
namespace Nya_projektet_Grupp_18_C_Projekt
{
    partial class Form1
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


        private void InitializeComponent()
        {
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.scrollBarKategori = new System.Windows.Forms.VScrollBar();
            this.listViewKategorier = new System.Windows.Forms.ListView();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.listViewPodcast = new System.Windows.Forms.ListView();
            this.scrollBarPodcast = new System.Windows.Forms.VScrollBar();
            this.btnNyPodcast = new System.Windows.Forms.Button();
            this.btnSparaPodcast = new System.Windows.Forms.Button();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblUppF = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbUppF = new System.Windows.Forms.ComboBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.listViewSamling = new System.Windows.Forms.ListView();
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPodcast2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(756, 12);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(89, 17);
            this.lblKategorier.TabIndex = 0;
            this.lblKategorier.Text = "Kategorier:";
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcast.Location = new System.Drawing.Point(43, 297);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(71, 17);
            this.lblPodcast.TabIndex = 1;
            this.lblPodcast.Text = "Podcast:";
            // 
            // scrollBarKategori
            // 
            this.scrollBarKategori.Location = new System.Drawing.Point(1179, 32);
            this.scrollBarKategori.Name = "scrollBarKategori";
            this.scrollBarKategori.Size = new System.Drawing.Size(21, 162);
            this.scrollBarKategori.TabIndex = 2;
            // 
            // listViewKategorier
            // 
            this.listViewKategorier.HideSelection = false;
            this.listViewKategorier.Location = new System.Drawing.Point(759, 32);
            this.listViewKategorier.Name = "listViewKategorier";
            this.listViewKategorier.Size = new System.Drawing.Size(441, 162);
            this.listViewKategorier.TabIndex = 4;
            this.listViewKategorier.UseCompatibleStateImageBehavior = false;
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(759, 210);
            this.tbKategori.Multiline = true;
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(240, 28);
            this.tbKategori.TabIndex = 5;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(759, 264);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(95, 30);
            this.btnNyKategori.TabIndex = 6;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(878, 264);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(107, 30);
            this.btnSparaKategori.TabIndex = 7;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(1013, 264);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(97, 30);
            this.btnTaBortKategori.TabIndex = 8;
            this.btnTaBortKategori.Text = "Ta bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // listViewPodcast
            // 
            this.listViewPodcast.HideSelection = false;
            this.listViewPodcast.Location = new System.Drawing.Point(46, 322);
            this.listViewPodcast.Name = "listViewPodcast";
            this.listViewPodcast.Size = new System.Drawing.Size(679, 206);
            this.listViewPodcast.TabIndex = 9;
            this.listViewPodcast.UseCompatibleStateImageBehavior = false;
            // 
            // scrollBarPodcast
            // 
            this.scrollBarPodcast.Location = new System.Drawing.Point(704, 322);
            this.scrollBarPodcast.Name = "scrollBarPodcast";
            this.scrollBarPodcast.Size = new System.Drawing.Size(21, 206);
            this.scrollBarPodcast.TabIndex = 10;
            // 
            // btnNyPodcast
            // 
            this.btnNyPodcast.Location = new System.Drawing.Point(366, 274);
            this.btnNyPodcast.Name = "btnNyPodcast";
            this.btnNyPodcast.Size = new System.Drawing.Size(107, 30);
            this.btnNyPodcast.TabIndex = 11;
            this.btnNyPodcast.Text = "Ny...";
            this.btnNyPodcast.UseVisualStyleBackColor = true;
            this.btnNyPodcast.Click += new System.EventHandler(this.btnNyPodcast_Click);
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(493, 274);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(97, 30);
            this.btnSparaPodcast.TabIndex = 12;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(608, 274);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(117, 30);
            this.btnTaBortPodcast.TabIndex = 13;
            this.btnTaBortPodcast.Text = "Ta bort...";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(43, 210);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(44, 17);
            this.lblUrl.TabIndex = 14;
            this.lblUrl.Text = "URL:";
            // 
            // lblUppF
            // 
            this.lblUppF.AutoSize = true;
            this.lblUppF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppF.Location = new System.Drawing.Point(319, 210);
            this.lblUppF.Name = "lblUppF";
            this.lblUppF.Size = new System.Drawing.Size(190, 17);
            this.lblUppF.TabIndex = 15;
            this.lblUppF.Text = "Uppdateringsfrekvensen:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(591, 210);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(74, 17);
            this.lblKategori.TabIndex = 16;
            this.lblKategori.Text = "Kategori:";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Humor",
            "Historia",
            "Skräck",
            "Informativ",
            "Träning och hälsa"});
            this.cbKategori.Location = new System.Drawing.Point(594, 234);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(131, 24);
            this.cbKategori.TabIndex = 17;
            // 
            // cbUppF
            // 
            this.cbUppF.FormattingEnabled = true;
            this.cbUppF.Items.AddRange(new object[] {
            "10 sek",
            "30 sek",
            "1 min"});
            this.cbUppF.Location = new System.Drawing.Point(322, 234);
            this.cbUppF.Name = "cbUppF";
            this.cbUppF.Size = new System.Drawing.Size(214, 24);
            this.cbUppF.TabIndex = 18;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(46, 234);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(217, 34);
            this.tbUrl.TabIndex = 19;
            // 
            // listViewSamling
            // 
            this.listViewSamling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Avsnitt,
            this.Namn,
            this.Frekvens,
            this.Kategori});
            this.listViewSamling.HideSelection = false;
            this.listViewSamling.Location = new System.Drawing.Point(46, 12);
            this.listViewSamling.Name = "listViewSamling";
            this.listViewSamling.Size = new System.Drawing.Size(670, 195);
            this.listViewSamling.TabIndex = 20;
            this.listViewSamling.UseCompatibleStateImageBehavior = false;
            this.listViewSamling.View = System.Windows.Forms.View.Details;
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            this.Avsnitt.Width = 120;
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 240;
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            this.Frekvens.Width = 150;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            this.Kategori.Width = 150;
            // 
            // lblPodcast2
            // 
            this.lblPodcast2.AutoSize = true;
            this.lblPodcast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcast2.Location = new System.Drawing.Point(798, 322);
            this.lblPodcast2.Name = "lblPodcast2";
            this.lblPodcast2.Size = new System.Drawing.Size(71, 17);
            this.lblPodcast2.TabIndex = 21;
            this.lblPodcast2.Text = "Podcast:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1226, 540);
            this.Controls.Add(this.lblPodcast2);
            this.Controls.Add(this.listViewSamling);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.cbUppF);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUppF);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.btnTaBortPodcast);
            this.Controls.Add(this.btnSparaPodcast);
            this.Controls.Add(this.btnNyPodcast);
            this.Controls.Add(this.scrollBarPodcast);
            this.Controls.Add(this.listViewPodcast);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.scrollBarKategori);
            this.Controls.Add(this.listViewKategorier);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.lblKategorier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Podcast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.Label lblPodcast;
        private System.Windows.Forms.VScrollBar scrollBarKategori;
        private System.Windows.Forms.ListView listViewKategorier;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.ListView listViewPodcast;
        private System.Windows.Forms.VScrollBar scrollBarPodcast;
        private System.Windows.Forms.Button btnNyPodcast;
        private System.Windows.Forms.Button btnSparaPodcast;
        private System.Windows.Forms.Button btnTaBortPodcast;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblUppF;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbUppF;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListView listViewSamling;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.Label lblPodcast2;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
    }
}

#endregion