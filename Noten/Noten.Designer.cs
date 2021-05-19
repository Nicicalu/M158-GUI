namespace Noten
{
    partial class Noten
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Noten));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubMenu2 = new System.Windows.Forms.Panel();
            this.Schulperioden = new System.Windows.Forms.Button();
            this.Orte = new System.Windows.Forms.Button();
            this.Klassen = new System.Windows.Forms.Button();
            this.Fächer = new System.Windows.Forms.Button();
            this.Berufe = new System.Windows.Forms.Button();
            this.Anreden = new System.Windows.Forms.Button();
            this.Stammdaten = new System.Windows.Forms.Button();
            this.Notenlisten = new System.Windows.Forms.Button();
            this.panelSubMenu1 = new System.Windows.Forms.Panel();
            this.Schnellerfassung = new System.Windows.Forms.Button();
            this.Firmendaten = new System.Windows.Forms.Button();
            this.Studenten = new System.Windows.Forms.Button();
            this.Adressen = new System.Windows.Forms.Button();
            this.panelSubMenu0 = new System.Windows.Forms.Panel();
            this.Notenperiode = new System.Windows.Forms.Button();
            this.Fächerzuteilung = new System.Windows.Forms.Button();
            this.Semesterdaten = new System.Windows.Forms.Button();
            this.Notendaten = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainScreen = new System.Windows.Forms.Panel();
            this.stammdaten_anreden = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.logo_mainScreen = new System.Windows.Forms.PictureBox();
            this.logo_topleft = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenu2.SuspendLayout();
            this.panelSubMenu1.SuspendLayout();
            this.panelSubMenu0.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.mainScreen.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_mainScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_topleft)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.InfoText;
            this.panelSideMenu.Controls.Add(this.panelSubMenu2);
            this.panelSideMenu.Controls.Add(this.Stammdaten);
            this.panelSideMenu.Controls.Add(this.Notenlisten);
            this.panelSideMenu.Controls.Add(this.panelSubMenu1);
            this.panelSideMenu.Controls.Add(this.Adressen);
            this.panelSideMenu.Controls.Add(this.panelSubMenu0);
            this.panelSideMenu.Controls.Add(this.Semesterdaten);
            this.panelSideMenu.Controls.Add(this.Notendaten);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 835);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelSubMenu2
            // 
            this.panelSubMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenu2.Controls.Add(this.Schulperioden);
            this.panelSubMenu2.Controls.Add(this.Orte);
            this.panelSubMenu2.Controls.Add(this.Klassen);
            this.panelSubMenu2.Controls.Add(this.Fächer);
            this.panelSubMenu2.Controls.Add(this.Berufe);
            this.panelSubMenu2.Controls.Add(this.Anreden);
            this.panelSubMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu2.Location = new System.Drawing.Point(0, 554);
            this.panelSubMenu2.Name = "panelSubMenu2";
            this.panelSubMenu2.Size = new System.Drawing.Size(250, 243);
            this.panelSubMenu2.TabIndex = 7;
            // 
            // Schulperioden
            // 
            this.Schulperioden.Dock = System.Windows.Forms.DockStyle.Top;
            this.Schulperioden.FlatAppearance.BorderSize = 0;
            this.Schulperioden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Schulperioden.ForeColor = System.Drawing.Color.Gainsboro;
            this.Schulperioden.Location = new System.Drawing.Point(0, 200);
            this.Schulperioden.Name = "Schulperioden";
            this.Schulperioden.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Schulperioden.Size = new System.Drawing.Size(250, 40);
            this.Schulperioden.TabIndex = 5;
            this.Schulperioden.Text = "Schulperioden/Lehrzeiten";
            this.Schulperioden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Schulperioden.UseVisualStyleBackColor = true;
            this.Schulperioden.Click += new System.EventHandler(this.Schulperioden_Click);
            // 
            // Orte
            // 
            this.Orte.Dock = System.Windows.Forms.DockStyle.Top;
            this.Orte.FlatAppearance.BorderSize = 0;
            this.Orte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orte.ForeColor = System.Drawing.Color.Gainsboro;
            this.Orte.Location = new System.Drawing.Point(0, 160);
            this.Orte.Name = "Orte";
            this.Orte.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Orte.Size = new System.Drawing.Size(250, 40);
            this.Orte.TabIndex = 4;
            this.Orte.Text = "Orte";
            this.Orte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orte.UseVisualStyleBackColor = true;
            this.Orte.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Klassen
            // 
            this.Klassen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Klassen.FlatAppearance.BorderSize = 0;
            this.Klassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Klassen.ForeColor = System.Drawing.Color.Gainsboro;
            this.Klassen.Location = new System.Drawing.Point(0, 120);
            this.Klassen.Name = "Klassen";
            this.Klassen.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Klassen.Size = new System.Drawing.Size(250, 40);
            this.Klassen.TabIndex = 3;
            this.Klassen.Text = "Klassen";
            this.Klassen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Klassen.UseVisualStyleBackColor = true;
            this.Klassen.Click += new System.EventHandler(this.Klassen_Click);
            // 
            // Fächer
            // 
            this.Fächer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Fächer.FlatAppearance.BorderSize = 0;
            this.Fächer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fächer.ForeColor = System.Drawing.Color.Gainsboro;
            this.Fächer.Location = new System.Drawing.Point(0, 80);
            this.Fächer.Name = "Fächer";
            this.Fächer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Fächer.Size = new System.Drawing.Size(250, 40);
            this.Fächer.TabIndex = 2;
            this.Fächer.Text = "Fächer";
            this.Fächer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fächer.UseVisualStyleBackColor = true;
            this.Fächer.Click += new System.EventHandler(this.Fächer_Click);
            // 
            // Berufe
            // 
            this.Berufe.Dock = System.Windows.Forms.DockStyle.Top;
            this.Berufe.FlatAppearance.BorderSize = 0;
            this.Berufe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Berufe.ForeColor = System.Drawing.Color.Gainsboro;
            this.Berufe.Location = new System.Drawing.Point(0, 40);
            this.Berufe.Name = "Berufe";
            this.Berufe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Berufe.Size = new System.Drawing.Size(250, 40);
            this.Berufe.TabIndex = 1;
            this.Berufe.Text = "Berufe";
            this.Berufe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Berufe.UseVisualStyleBackColor = true;
            this.Berufe.Click += new System.EventHandler(this.Berufe_Click);
            // 
            // Anreden
            // 
            this.Anreden.Cursor = System.Windows.Forms.Cursors.Default;
            this.Anreden.Dock = System.Windows.Forms.DockStyle.Top;
            this.Anreden.FlatAppearance.BorderSize = 0;
            this.Anreden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anreden.ForeColor = System.Drawing.Color.Gainsboro;
            this.Anreden.Location = new System.Drawing.Point(0, 0);
            this.Anreden.Name = "Anreden";
            this.Anreden.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Anreden.Size = new System.Drawing.Size(250, 40);
            this.Anreden.TabIndex = 0;
            this.Anreden.Text = "Anreden";
            this.Anreden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Anreden.UseVisualStyleBackColor = true;
            this.Anreden.Click += new System.EventHandler(this.Anreden_Click);
            // 
            // Stammdaten
            // 
            this.Stammdaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stammdaten.FlatAppearance.BorderSize = 0;
            this.Stammdaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stammdaten.ForeColor = System.Drawing.Color.Gainsboro;
            this.Stammdaten.Location = new System.Drawing.Point(0, 509);
            this.Stammdaten.Name = "Stammdaten";
            this.Stammdaten.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Stammdaten.Size = new System.Drawing.Size(250, 45);
            this.Stammdaten.TabIndex = 6;
            this.Stammdaten.Text = "Stammdaten";
            this.Stammdaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stammdaten.UseVisualStyleBackColor = true;
            this.Stammdaten.Click += new System.EventHandler(this.Stammdaten_Click);
            // 
            // Notenlisten
            // 
            this.Notenlisten.Dock = System.Windows.Forms.DockStyle.Top;
            this.Notenlisten.FlatAppearance.BorderSize = 0;
            this.Notenlisten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notenlisten.ForeColor = System.Drawing.Color.Gainsboro;
            this.Notenlisten.Location = new System.Drawing.Point(0, 464);
            this.Notenlisten.Name = "Notenlisten";
            this.Notenlisten.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Notenlisten.Size = new System.Drawing.Size(250, 45);
            this.Notenlisten.TabIndex = 5;
            this.Notenlisten.Text = "Notenlisten";
            this.Notenlisten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notenlisten.UseVisualStyleBackColor = true;
            // 
            // panelSubMenu1
            // 
            this.panelSubMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenu1.Controls.Add(this.Schnellerfassung);
            this.panelSubMenu1.Controls.Add(this.Firmendaten);
            this.panelSubMenu1.Controls.Add(this.Studenten);
            this.panelSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu1.Location = new System.Drawing.Point(0, 339);
            this.panelSubMenu1.Name = "panelSubMenu1";
            this.panelSubMenu1.Size = new System.Drawing.Size(250, 125);
            this.panelSubMenu1.TabIndex = 4;
            // 
            // Schnellerfassung
            // 
            this.Schnellerfassung.Dock = System.Windows.Forms.DockStyle.Top;
            this.Schnellerfassung.FlatAppearance.BorderSize = 0;
            this.Schnellerfassung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Schnellerfassung.ForeColor = System.Drawing.Color.Gainsboro;
            this.Schnellerfassung.Location = new System.Drawing.Point(0, 80);
            this.Schnellerfassung.Name = "Schnellerfassung";
            this.Schnellerfassung.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Schnellerfassung.Size = new System.Drawing.Size(250, 40);
            this.Schnellerfassung.TabIndex = 2;
            this.Schnellerfassung.Text = "Schnellerfassung";
            this.Schnellerfassung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Schnellerfassung.UseVisualStyleBackColor = true;
            this.Schnellerfassung.Click += new System.EventHandler(this.Schnellerfassung_Click);
            // 
            // Firmendaten
            // 
            this.Firmendaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.Firmendaten.FlatAppearance.BorderSize = 0;
            this.Firmendaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Firmendaten.ForeColor = System.Drawing.Color.Gainsboro;
            this.Firmendaten.Location = new System.Drawing.Point(0, 40);
            this.Firmendaten.Name = "Firmendaten";
            this.Firmendaten.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Firmendaten.Size = new System.Drawing.Size(250, 40);
            this.Firmendaten.TabIndex = 1;
            this.Firmendaten.Text = "Firmendaten";
            this.Firmendaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Firmendaten.UseVisualStyleBackColor = true;
            this.Firmendaten.Click += new System.EventHandler(this.Firmendaten_Click);
            // 
            // Studenten
            // 
            this.Studenten.Cursor = System.Windows.Forms.Cursors.Default;
            this.Studenten.Dock = System.Windows.Forms.DockStyle.Top;
            this.Studenten.FlatAppearance.BorderSize = 0;
            this.Studenten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Studenten.ForeColor = System.Drawing.Color.Gainsboro;
            this.Studenten.Location = new System.Drawing.Point(0, 0);
            this.Studenten.Name = "Studenten";
            this.Studenten.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Studenten.Size = new System.Drawing.Size(250, 40);
            this.Studenten.TabIndex = 0;
            this.Studenten.Text = "Studenten/Schüler/Lehrlinge";
            this.Studenten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Studenten.UseVisualStyleBackColor = true;
            this.Studenten.Click += new System.EventHandler(this.Studenten_Click);
            // 
            // Adressen
            // 
            this.Adressen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Adressen.FlatAppearance.BorderSize = 0;
            this.Adressen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adressen.ForeColor = System.Drawing.Color.Gainsboro;
            this.Adressen.Location = new System.Drawing.Point(0, 294);
            this.Adressen.Name = "Adressen";
            this.Adressen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Adressen.Size = new System.Drawing.Size(250, 45);
            this.Adressen.TabIndex = 3;
            this.Adressen.Text = "Adressen";
            this.Adressen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adressen.UseVisualStyleBackColor = true;
            this.Adressen.Click += new System.EventHandler(this.Adressen_Click);
            // 
            // panelSubMenu0
            // 
            this.panelSubMenu0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenu0.Controls.Add(this.Notenperiode);
            this.panelSubMenu0.Controls.Add(this.Fächerzuteilung);
            this.panelSubMenu0.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu0.Location = new System.Drawing.Point(0, 210);
            this.panelSubMenu0.Name = "panelSubMenu0";
            this.panelSubMenu0.Size = new System.Drawing.Size(250, 84);
            this.panelSubMenu0.TabIndex = 2;
            // 
            // Notenperiode
            // 
            this.Notenperiode.Dock = System.Windows.Forms.DockStyle.Top;
            this.Notenperiode.FlatAppearance.BorderSize = 0;
            this.Notenperiode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notenperiode.ForeColor = System.Drawing.Color.Gainsboro;
            this.Notenperiode.Location = new System.Drawing.Point(0, 40);
            this.Notenperiode.Name = "Notenperiode";
            this.Notenperiode.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Notenperiode.Size = new System.Drawing.Size(250, 40);
            this.Notenperiode.TabIndex = 1;
            this.Notenperiode.Text = "Notenperiode";
            this.Notenperiode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notenperiode.UseVisualStyleBackColor = true;
            this.Notenperiode.Click += new System.EventHandler(this.Notenperiode_Click);
            // 
            // Fächerzuteilung
            // 
            this.Fächerzuteilung.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fächerzuteilung.Dock = System.Windows.Forms.DockStyle.Top;
            this.Fächerzuteilung.FlatAppearance.BorderSize = 0;
            this.Fächerzuteilung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fächerzuteilung.ForeColor = System.Drawing.Color.Gainsboro;
            this.Fächerzuteilung.Location = new System.Drawing.Point(0, 0);
            this.Fächerzuteilung.Name = "Fächerzuteilung";
            this.Fächerzuteilung.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Fächerzuteilung.Size = new System.Drawing.Size(250, 40);
            this.Fächerzuteilung.TabIndex = 0;
            this.Fächerzuteilung.Text = "Fächerzuteilung";
            this.Fächerzuteilung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fächerzuteilung.UseVisualStyleBackColor = true;
            this.Fächerzuteilung.Click += new System.EventHandler(this.button1_Click);
            // 
            // Semesterdaten
            // 
            this.Semesterdaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.Semesterdaten.FlatAppearance.BorderSize = 0;
            this.Semesterdaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Semesterdaten.ForeColor = System.Drawing.Color.Gainsboro;
            this.Semesterdaten.Location = new System.Drawing.Point(0, 165);
            this.Semesterdaten.Name = "Semesterdaten";
            this.Semesterdaten.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Semesterdaten.Size = new System.Drawing.Size(250, 45);
            this.Semesterdaten.TabIndex = 1;
            this.Semesterdaten.Text = "Semesterdaten";
            this.Semesterdaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Semesterdaten.UseVisualStyleBackColor = true;
            this.Semesterdaten.Click += new System.EventHandler(this.Semesterdaten_Click);
            // 
            // Notendaten
            // 
            this.Notendaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.Notendaten.FlatAppearance.BorderSize = 0;
            this.Notendaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notendaten.ForeColor = System.Drawing.Color.Gainsboro;
            this.Notendaten.Location = new System.Drawing.Point(0, 120);
            this.Notendaten.Name = "Notendaten";
            this.Notendaten.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Notendaten.Size = new System.Drawing.Size(250, 45);
            this.Notendaten.TabIndex = 0;
            this.Notendaten.Text = "Notendaten";
            this.Notendaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notendaten.UseVisualStyleBackColor = true;
            this.Notendaten.Click += new System.EventHandler(this.Notendaten_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.logo_topleft);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainScreen
            // 
            this.mainScreen.Controls.Add(this.logo_mainScreen);
            this.mainScreen.Controls.Add(this.stammdaten_anreden);
            this.mainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScreen.Location = new System.Drawing.Point(0, 0);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.Size = new System.Drawing.Size(1008, 835);
            this.mainScreen.TabIndex = 0;
            // 
            // stammdaten_anreden
            // 
            this.stammdaten_anreden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stammdaten_anreden.Location = new System.Drawing.Point(0, 0);
            this.stammdaten_anreden.Name = "stammdaten_anreden";
            this.stammdaten_anreden.Size = new System.Drawing.Size(1008, 835);
            this.stammdaten_anreden.TabIndex = 1;
            this.stammdaten_anreden.Paint += new System.Windows.Forms.PaintEventHandler(this.stammdaten_anreden_Paint);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoSize = true;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Controls.Add(this.mainScreen);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1008, 835);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // logo_mainScreen
            // 
            this.logo_mainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo_mainScreen.Image = global::Noten.Properties.Resources.text1;
            this.logo_mainScreen.ImageLocation = "F:\\code\\img\\text.png";
            this.logo_mainScreen.Location = new System.Drawing.Point(0, 0);
            this.logo_mainScreen.Name = "logo_mainScreen";
            this.logo_mainScreen.Size = new System.Drawing.Size(1008, 835);
            this.logo_mainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_mainScreen.TabIndex = 0;
            this.logo_mainScreen.TabStop = false;
            this.logo_mainScreen.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // logo_topleft
            // 
            this.logo_topleft.BackColor = System.Drawing.Color.Black;
            this.logo_topleft.Image = global::Noten.Properties.Resources.pic;
            this.logo_topleft.ImageLocation = "F:\\code\\img\\pic.png";
            this.logo_topleft.InitialImage = null;
            this.logo_topleft.Location = new System.Drawing.Point(39, 2);
            this.logo_topleft.Name = "logo_topleft";
            this.logo_topleft.Size = new System.Drawing.Size(148, 112);
            this.logo_topleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_topleft.TabIndex = 0;
            this.logo_topleft.TabStop = false;
            this.logo_topleft.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Noten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 835);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Noten";
            this.Text = "Noten";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenu2.ResumeLayout(false);
            this.panelSubMenu1.ResumeLayout(false);
            this.panelSubMenu0.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.mainScreen.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_mainScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_topleft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenu0;
        private System.Windows.Forms.Button Notenperiode;
        private System.Windows.Forms.Button Fächerzuteilung;
        private System.Windows.Forms.Button Semesterdaten;
        private System.Windows.Forms.Button Notendaten;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenu2;
        private System.Windows.Forms.Button Orte;
        private System.Windows.Forms.Button Klassen;
        private System.Windows.Forms.Button Fächer;
        private System.Windows.Forms.Button Berufe;
        private System.Windows.Forms.Button Anreden;
        private System.Windows.Forms.Button Stammdaten;
        private System.Windows.Forms.Button Notenlisten;
        private System.Windows.Forms.Panel panelSubMenu1;
        private System.Windows.Forms.Button Schnellerfassung;
        private System.Windows.Forms.Button Firmendaten;
        private System.Windows.Forms.Button Studenten;
        private System.Windows.Forms.Button Adressen;
        private System.Windows.Forms.Button Schulperioden;
        private System.Windows.Forms.PictureBox logo_topleft;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel mainScreen;
        private System.Windows.Forms.PictureBox logo_mainScreen;
        private System.Windows.Forms.Panel stammdaten_anreden;
        private System.Windows.Forms.Panel panelContainer;
    }
}

