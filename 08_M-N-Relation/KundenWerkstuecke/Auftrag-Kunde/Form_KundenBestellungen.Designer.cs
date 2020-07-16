namespace KundenWerkstuecke
{
    partial class Form_KundenBestellenWerkstuecke
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KundenBestellenWerkstuecke));
			this.splitContainer_Kundenauftraege = new System.Windows.Forms.SplitContainer();
			this.menuStrip_Auftragsverwaltung = new System.Windows.Forms.MenuStrip();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl_AuftraegeUndKunden = new System.Windows.Forms.TabControl();
			this.tabPage_Auftraege = new System.Windows.Forms.TabPage();
			this.splitContainer_Auftraege = new System.Windows.Forms.SplitContainer();
			this.splitContainer_Kunde = new System.Windows.Forms.SplitContainer();
			this.comboBox_AT_idWSt = new System.Windows.Forms.ComboBox();
			this.label_comboWerkstueck = new System.Windows.Forms.Label();
			this.label_comboKunden = new System.Windows.Forms.Label();
			this.label_Liefertermin = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_idAT = new System.Windows.Forms.Label();
			this.textBox_Liefertermin = new System.Windows.Forms.TextBox();
			this.textBox_Auftrag = new System.Windows.Forms.TextBox();
			this.textBox_idAT = new System.Windows.Forms.TextBox();
			this.comboBox_AT_idKD = new System.Windows.Forms.ComboBox();
			this.dataGridView_AT = new System.Windows.Forms.DataGridView();
			this.bindingNavigator_AT = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_AuftragAktualisieren = new System.Windows.Forms.ToolStripButton();
			this.textBox_infoKDnr = new System.Windows.Forms.TextBox();
			this.textBox_infoWStBearbeiter = new System.Windows.Forms.TextBox();
			this.textBox_infoWerkstueck = new System.Windows.Forms.TextBox();
			this.textBox_infoIdWst = new System.Windows.Forms.TextBox();
			this.label_Werkstueckinformationen = new System.Windows.Forms.Label();
			this.textBox_infoKDplz = new System.Windows.Forms.TextBox();
			this.textBox_infoKDemail = new System.Windows.Forms.TextBox();
			this.textBox_infoKDtelefon = new System.Windows.Forms.TextBox();
			this.textBox_infoKDort = new System.Windows.Forms.TextBox();
			this.textBox_infoKDstrasse = new System.Windows.Forms.TextBox();
			this.textBox_infoKunde = new System.Windows.Forms.TextBox();
			this.textBox_infoIdKD = new System.Windows.Forms.TextBox();
			this.label_Kundeninformationen = new System.Windows.Forms.Label();
			this.tabPage_Kunden = new System.Windows.Forms.TabPage();
			this.splitContainer_Kunden = new System.Windows.Forms.SplitContainer();
			this.splitContainer_Kunenmaske = new System.Windows.Forms.SplitContainer();
			this.label_Nr = new System.Windows.Forms.Label();
			this.textBox_Nr = new System.Windows.Forms.TextBox();
			this.label_Strasse = new System.Windows.Forms.Label();
			this.label_Kunde = new System.Windows.Forms.Label();
			this.label_idKD = new System.Windows.Forms.Label();
			this.textBox_Strasse = new System.Windows.Forms.TextBox();
			this.textBox_Kunde = new System.Windows.Forms.TextBox();
			this.textBox_idKD = new System.Windows.Forms.TextBox();
			this.bindingNavigator_KD = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_KundeAktualisieren = new System.Windows.Forms.ToolStripButton();
			this.label_Email = new System.Windows.Forms.Label();
			this.label_Telefon = new System.Windows.Forms.Label();
			this.label_Ort = new System.Windows.Forms.Label();
			this.label_PLZ = new System.Windows.Forms.Label();
			this.textBox_Email = new System.Windows.Forms.TextBox();
			this.textBox_Telefon = new System.Windows.Forms.TextBox();
			this.textBox_Ort = new System.Windows.Forms.TextBox();
			this.textBox_PLZ = new System.Windows.Forms.TextBox();
			this.dataGridView_KD = new System.Windows.Forms.DataGridView();
			this.tabPage_Werkstuecke = new System.Windows.Forms.TabPage();
			this.splitContainer_Werkstuecke = new System.Windows.Forms.SplitContainer();
			this.splitContainer_Werkstueck = new System.Windows.Forms.SplitContainer();
			this.bindingNavigator_WSt = new System.Windows.Forms.BindingNavigator(this.components);
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_WerkstueckAktualisieren = new System.Windows.Forms.ToolStripButton();
			this.label_Bearbeiter = new System.Windows.Forms.Label();
			this.label_Werkstueck = new System.Windows.Forms.Label();
			this.label_idWSt = new System.Windows.Forms.Label();
			this.textBox_Bearbeiter = new System.Windows.Forms.TextBox();
			this.textBox_Werkstueck = new System.Windows.Forms.TextBox();
			this.textBox_idWSt = new System.Windows.Forms.TextBox();
			this.pictureBox_Werkstueck = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip_Bild = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_Einfuegen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Kopieren = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Loeschen = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView_WSt = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Kundenauftraege)).BeginInit();
			this.splitContainer_Kundenauftraege.Panel1.SuspendLayout();
			this.splitContainer_Kundenauftraege.Panel2.SuspendLayout();
			this.splitContainer_Kundenauftraege.SuspendLayout();
			this.menuStrip_Auftragsverwaltung.SuspendLayout();
			this.tabControl_AuftraegeUndKunden.SuspendLayout();
			this.tabPage_Auftraege.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Auftraege)).BeginInit();
			this.splitContainer_Auftraege.Panel1.SuspendLayout();
			this.splitContainer_Auftraege.Panel2.SuspendLayout();
			this.splitContainer_Auftraege.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Kunde)).BeginInit();
			this.splitContainer_Kunde.Panel1.SuspendLayout();
			this.splitContainer_Kunde.Panel2.SuspendLayout();
			this.splitContainer_Kunde.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_AT)).BeginInit();
			this.bindingNavigator_AT.SuspendLayout();
			this.tabPage_Kunden.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Kunden)).BeginInit();
			this.splitContainer_Kunden.Panel1.SuspendLayout();
			this.splitContainer_Kunden.Panel2.SuspendLayout();
			this.splitContainer_Kunden.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Kunenmaske)).BeginInit();
			this.splitContainer_Kunenmaske.Panel1.SuspendLayout();
			this.splitContainer_Kunenmaske.Panel2.SuspendLayout();
			this.splitContainer_Kunenmaske.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_KD)).BeginInit();
			this.bindingNavigator_KD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_KD)).BeginInit();
			this.tabPage_Werkstuecke.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Werkstuecke)).BeginInit();
			this.splitContainer_Werkstuecke.Panel1.SuspendLayout();
			this.splitContainer_Werkstuecke.Panel2.SuspendLayout();
			this.splitContainer_Werkstuecke.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Werkstueck)).BeginInit();
			this.splitContainer_Werkstueck.Panel1.SuspendLayout();
			this.splitContainer_Werkstueck.Panel2.SuspendLayout();
			this.splitContainer_Werkstueck.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_WSt)).BeginInit();
			this.bindingNavigator_WSt.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Werkstueck)).BeginInit();
			this.contextMenuStrip_Bild.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_WSt)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer_Kundenauftraege
			// 
			this.splitContainer_Kundenauftraege.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Kundenauftraege.Location = new System.Drawing.Point(0, 0);
			this.splitContainer_Kundenauftraege.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer_Kundenauftraege.Name = "splitContainer_Kundenauftraege";
			this.splitContainer_Kundenauftraege.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_Kundenauftraege.Panel1
			// 
			this.splitContainer_Kundenauftraege.Panel1.Controls.Add(this.menuStrip_Auftragsverwaltung);
			// 
			// splitContainer_Kundenauftraege.Panel2
			// 
			this.splitContainer_Kundenauftraege.Panel2.Controls.Add(this.tabControl_AuftraegeUndKunden);
			this.splitContainer_Kundenauftraege.Size = new System.Drawing.Size(634, 571);
			this.splitContainer_Kundenauftraege.SplitterDistance = 31;
			this.splitContainer_Kundenauftraege.SplitterWidth = 6;
			this.splitContainer_Kundenauftraege.TabIndex = 0;
			// 
			// menuStrip_Auftragsverwaltung
			// 
			this.menuStrip_Auftragsverwaltung.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip_Auftragsverwaltung.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip_Auftragsverwaltung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
			this.menuStrip_Auftragsverwaltung.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_Auftragsverwaltung.Name = "menuStrip_Auftragsverwaltung";
			this.menuStrip_Auftragsverwaltung.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
			this.menuStrip_Auftragsverwaltung.Size = new System.Drawing.Size(634, 34);
			this.menuStrip_Auftragsverwaltung.TabIndex = 0;
			this.menuStrip_Auftragsverwaltung.Text = "menuStrip1";
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Image = global::Auftrag_Kunde.Properties.Resources.beenden_2;
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
			this.beendenToolStripMenuItem.Text = "Beenden";
			this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
			// 
			// tabControl_AuftraegeUndKunden
			// 
			this.tabControl_AuftraegeUndKunden.Controls.Add(this.tabPage_Auftraege);
			this.tabControl_AuftraegeUndKunden.Controls.Add(this.tabPage_Kunden);
			this.tabControl_AuftraegeUndKunden.Controls.Add(this.tabPage_Werkstuecke);
			this.tabControl_AuftraegeUndKunden.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_AuftraegeUndKunden.Location = new System.Drawing.Point(0, 0);
			this.tabControl_AuftraegeUndKunden.Name = "tabControl_AuftraegeUndKunden";
			this.tabControl_AuftraegeUndKunden.SelectedIndex = 0;
			this.tabControl_AuftraegeUndKunden.Size = new System.Drawing.Size(634, 534);
			this.tabControl_AuftraegeUndKunden.TabIndex = 0;
			// 
			// tabPage_Auftraege
			// 
			this.tabPage_Auftraege.Controls.Add(this.splitContainer_Auftraege);
			this.tabPage_Auftraege.Location = new System.Drawing.Point(4, 27);
			this.tabPage_Auftraege.Name = "tabPage_Auftraege";
			this.tabPage_Auftraege.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Auftraege.Size = new System.Drawing.Size(626, 503);
			this.tabPage_Auftraege.TabIndex = 0;
			this.tabPage_Auftraege.Text = "Aufträge";
			this.tabPage_Auftraege.UseVisualStyleBackColor = true;
			// 
			// splitContainer_Auftraege
			// 
			this.splitContainer_Auftraege.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Auftraege.Location = new System.Drawing.Point(3, 3);
			this.splitContainer_Auftraege.Name = "splitContainer_Auftraege";
			// 
			// splitContainer_Auftraege.Panel1
			// 
			this.splitContainer_Auftraege.Panel1.Controls.Add(this.splitContainer_Kunde);
			this.splitContainer_Auftraege.Panel1.Controls.Add(this.bindingNavigator_AT);
			// 
			// splitContainer_Auftraege.Panel2
			// 
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoKDnr);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoWStBearbeiter);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoWerkstueck);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoIdWst);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.label_Werkstueckinformationen);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoKDplz);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoKDemail);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoKDtelefon);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoKDort);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoKDstrasse);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoKunde);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.textBox_infoIdKD);
			this.splitContainer_Auftraege.Panel2.Controls.Add(this.label_Kundeninformationen);
			this.splitContainer_Auftraege.Size = new System.Drawing.Size(620, 497);
			this.splitContainer_Auftraege.SplitterDistance = 408;
			this.splitContainer_Auftraege.TabIndex = 0;
			// 
			// splitContainer_Kunde
			// 
			this.splitContainer_Kunde.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Kunde.Location = new System.Drawing.Point(0, 31);
			this.splitContainer_Kunde.Name = "splitContainer_Kunde";
			this.splitContainer_Kunde.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_Kunde.Panel1
			// 
			this.splitContainer_Kunde.Panel1.Controls.Add(this.comboBox_AT_idWSt);
			this.splitContainer_Kunde.Panel1.Controls.Add(this.label_comboWerkstueck);
			this.splitContainer_Kunde.Panel1.Controls.Add(this.label_comboKunden);
			this.splitContainer_Kunde.Panel1.Controls.Add(this.label_Liefertermin);
			this.splitContainer_Kunde.Panel1.Controls.Add(this.label2);
			this.splitContainer_Kunde.Panel1.Controls.Add(this.label_idAT);
			this.splitContainer_Kunde.Panel1.Controls.Add(this.textBox_Liefertermin);
			this.splitContainer_Kunde.Panel1.Controls.Add(this.textBox_Auftrag);
			this.splitContainer_Kunde.Panel1.Controls.Add(this.textBox_idAT);
			this.splitContainer_Kunde.Panel1.Controls.Add(this.comboBox_AT_idKD);
			// 
			// splitContainer_Kunde.Panel2
			// 
			this.splitContainer_Kunde.Panel2.Controls.Add(this.dataGridView_AT);
			this.splitContainer_Kunde.Size = new System.Drawing.Size(408, 466);
			this.splitContainer_Kunde.SplitterDistance = 218;
			this.splitContainer_Kunde.TabIndex = 1;
			// 
			// comboBox_AT_idWSt
			// 
			this.comboBox_AT_idWSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.comboBox_AT_idWSt.FormattingEnabled = true;
			this.comboBox_AT_idWSt.Location = new System.Drawing.Point(146, 166);
			this.comboBox_AT_idWSt.Name = "comboBox_AT_idWSt";
			this.comboBox_AT_idWSt.Size = new System.Drawing.Size(236, 26);
			this.comboBox_AT_idWSt.TabIndex = 9;
			this.comboBox_AT_idWSt.SelectionChangeCommitted += new System.EventHandler(this.comboBox_AT_idWSt_SelectionChangeCommitted);
			// 
			// label_comboWerkstueck
			// 
			this.label_comboWerkstueck.AutoSize = true;
			this.label_comboWerkstueck.Location = new System.Drawing.Point(17, 166);
			this.label_comboWerkstueck.Name = "label_comboWerkstueck";
			this.label_comboWerkstueck.Size = new System.Drawing.Size(80, 18);
			this.label_comboWerkstueck.TabIndex = 8;
			this.label_comboWerkstueck.Text = "Werkstück";
			// 
			// label_comboKunden
			// 
			this.label_comboKunden.AutoSize = true;
			this.label_comboKunden.Location = new System.Drawing.Point(17, 134);
			this.label_comboKunden.Name = "label_comboKunden";
			this.label_comboKunden.Size = new System.Drawing.Size(50, 18);
			this.label_comboKunden.TabIndex = 7;
			this.label_comboKunden.Text = "Kunde";
			// 
			// label_Liefertermin
			// 
			this.label_Liefertermin.AutoSize = true;
			this.label_Liefertermin.Location = new System.Drawing.Point(17, 98);
			this.label_Liefertermin.Name = "label_Liefertermin";
			this.label_Liefertermin.Size = new System.Drawing.Size(85, 18);
			this.label_Liefertermin.TabIndex = 6;
			this.label_Liefertermin.Text = "Liefertermin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "Auftrag";
			// 
			// label_idAT
			// 
			this.label_idAT.AutoSize = true;
			this.label_idAT.Location = new System.Drawing.Point(17, 22);
			this.label_idAT.Name = "label_idAT";
			this.label_idAT.Size = new System.Drawing.Size(72, 18);
			this.label_idAT.TabIndex = 4;
			this.label_idAT.Text = "ID Auftrag";
			// 
			// textBox_Liefertermin
			// 
			this.textBox_Liefertermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Liefertermin.Location = new System.Drawing.Point(146, 92);
			this.textBox_Liefertermin.Name = "textBox_Liefertermin";
			this.textBox_Liefertermin.Size = new System.Drawing.Size(236, 24);
			this.textBox_Liefertermin.TabIndex = 3;
			// 
			// textBox_Auftrag
			// 
			this.textBox_Auftrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Auftrag.Location = new System.Drawing.Point(146, 52);
			this.textBox_Auftrag.Name = "textBox_Auftrag";
			this.textBox_Auftrag.Size = new System.Drawing.Size(236, 24);
			this.textBox_Auftrag.TabIndex = 2;
			// 
			// textBox_idAT
			// 
			this.textBox_idAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_idAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_idAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.textBox_idAT.Location = new System.Drawing.Point(146, 12);
			this.textBox_idAT.Name = "textBox_idAT";
			this.textBox_idAT.Size = new System.Drawing.Size(236, 24);
			this.textBox_idAT.TabIndex = 1;
			// 
			// comboBox_AT_idKD
			// 
			this.comboBox_AT_idKD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.comboBox_AT_idKD.FormattingEnabled = true;
			this.comboBox_AT_idKD.Location = new System.Drawing.Point(146, 134);
			this.comboBox_AT_idKD.Name = "comboBox_AT_idKD";
			this.comboBox_AT_idKD.Size = new System.Drawing.Size(236, 26);
			this.comboBox_AT_idKD.TabIndex = 0;
			this.comboBox_AT_idKD.Tag = "comboBox_AT_idKD";
			this.comboBox_AT_idKD.SelectionChangeCommitted += new System.EventHandler(this.comboBox_AT_idKD_SelectionChangeCommitted);
			// 
			// dataGridView_AT
			// 
			this.dataGridView_AT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_AT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_AT.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_AT.Name = "dataGridView_AT";
			this.dataGridView_AT.Size = new System.Drawing.Size(408, 244);
			this.dataGridView_AT.TabIndex = 0;
			this.dataGridView_AT.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AT_CellEnter);
			// 
			// bindingNavigator_AT
			// 
			this.bindingNavigator_AT.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator_AT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
			this.bindingNavigator_AT.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator_AT.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator_AT.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_AT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton_AuftragAktualisieren});
			this.bindingNavigator_AT.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator_AT.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator_AT.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator_AT.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator_AT.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator_AT.Name = "bindingNavigator_AT";
			this.bindingNavigator_AT.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator_AT.Size = new System.Drawing.Size(408, 31);
			this.bindingNavigator_AT.TabIndex = 0;
			this.bindingNavigator_AT.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 28);
			this.bindingNavigatorCountItem.Text = "von {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorDeleteItem.Text = "Löschen";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripButton_AuftragAktualisieren
			// 
			this.toolStripButton_AuftragAktualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_AuftragAktualisieren.Image = global::Auftrag_Kunde.Properties.Resources.accept;
			this.toolStripButton_AuftragAktualisieren.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_AuftragAktualisieren.Name = "toolStripButton_AuftragAktualisieren";
			this.toolStripButton_AuftragAktualisieren.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_AuftragAktualisieren.Text = "toolStripButton7";
			this.toolStripButton_AuftragAktualisieren.Click += new System.EventHandler(this.toolStripButton_AuftragAktualisieren_Click);
			// 
			// textBox_infoKDnr
			// 
			this.textBox_infoKDnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoKDnr.Location = new System.Drawing.Point(15, 247);
			this.textBox_infoKDnr.Name = "textBox_infoKDnr";
			this.textBox_infoKDnr.Size = new System.Drawing.Size(74, 24);
			this.textBox_infoKDnr.TabIndex = 17;
			// 
			// textBox_infoWStBearbeiter
			// 
			this.textBox_infoWStBearbeiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoWStBearbeiter.Location = new System.Drawing.Point(13, 88);
			this.textBox_infoWStBearbeiter.Name = "textBox_infoWStBearbeiter";
			this.textBox_infoWStBearbeiter.Size = new System.Drawing.Size(182, 24);
			this.textBox_infoWStBearbeiter.TabIndex = 16;
			// 
			// textBox_infoWerkstueck
			// 
			this.textBox_infoWerkstueck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoWerkstueck.Location = new System.Drawing.Point(15, 58);
			this.textBox_infoWerkstueck.Name = "textBox_infoWerkstueck";
			this.textBox_infoWerkstueck.Size = new System.Drawing.Size(180, 24);
			this.textBox_infoWerkstueck.TabIndex = 15;
			// 
			// textBox_infoIdWst
			// 
			this.textBox_infoIdWst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoIdWst.Location = new System.Drawing.Point(15, 28);
			this.textBox_infoIdWst.Name = "textBox_infoIdWst";
			this.textBox_infoIdWst.Size = new System.Drawing.Size(180, 24);
			this.textBox_infoIdWst.TabIndex = 14;
			// 
			// label_Werkstueckinformationen
			// 
			this.label_Werkstueckinformationen.AutoSize = true;
			this.label_Werkstueckinformationen.Location = new System.Drawing.Point(12, 7);
			this.label_Werkstueckinformationen.Name = "label_Werkstueckinformationen";
			this.label_Werkstueckinformationen.Size = new System.Drawing.Size(170, 18);
			this.label_Werkstueckinformationen.TabIndex = 13;
			this.label_Werkstueckinformationen.Text = "Werkstückinformationen";
			// 
			// textBox_infoKDplz
			// 
			this.textBox_infoKDplz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoKDplz.Location = new System.Drawing.Point(15, 284);
			this.textBox_infoKDplz.Name = "textBox_infoKDplz";
			this.textBox_infoKDplz.Size = new System.Drawing.Size(74, 24);
			this.textBox_infoKDplz.TabIndex = 8;
			// 
			// textBox_infoKDemail
			// 
			this.textBox_infoKDemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoKDemail.Location = new System.Drawing.Point(15, 374);
			this.textBox_infoKDemail.Name = "textBox_infoKDemail";
			this.textBox_infoKDemail.Size = new System.Drawing.Size(182, 24);
			this.textBox_infoKDemail.TabIndex = 7;
			// 
			// textBox_infoKDtelefon
			// 
			this.textBox_infoKDtelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoKDtelefon.Location = new System.Drawing.Point(15, 344);
			this.textBox_infoKDtelefon.Name = "textBox_infoKDtelefon";
			this.textBox_infoKDtelefon.Size = new System.Drawing.Size(182, 24);
			this.textBox_infoKDtelefon.TabIndex = 6;
			// 
			// textBox_infoKDort
			// 
			this.textBox_infoKDort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoKDort.Location = new System.Drawing.Point(15, 314);
			this.textBox_infoKDort.Name = "textBox_infoKDort";
			this.textBox_infoKDort.Size = new System.Drawing.Size(182, 24);
			this.textBox_infoKDort.TabIndex = 5;
			// 
			// textBox_infoKDstrasse
			// 
			this.textBox_infoKDstrasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoKDstrasse.Location = new System.Drawing.Point(13, 217);
			this.textBox_infoKDstrasse.Name = "textBox_infoKDstrasse";
			this.textBox_infoKDstrasse.Size = new System.Drawing.Size(182, 24);
			this.textBox_infoKDstrasse.TabIndex = 3;
			// 
			// textBox_infoKunde
			// 
			this.textBox_infoKunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoKunde.Location = new System.Drawing.Point(15, 183);
			this.textBox_infoKunde.Name = "textBox_infoKunde";
			this.textBox_infoKunde.Size = new System.Drawing.Size(180, 24);
			this.textBox_infoKunde.TabIndex = 2;
			// 
			// textBox_infoIdKD
			// 
			this.textBox_infoIdKD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox_infoIdKD.Location = new System.Drawing.Point(15, 153);
			this.textBox_infoIdKD.Name = "textBox_infoIdKD";
			this.textBox_infoIdKD.Size = new System.Drawing.Size(180, 24);
			this.textBox_infoIdKD.TabIndex = 1;
			// 
			// label_Kundeninformationen
			// 
			this.label_Kundeninformationen.AutoSize = true;
			this.label_Kundeninformationen.Location = new System.Drawing.Point(12, 123);
			this.label_Kundeninformationen.Name = "label_Kundeninformationen";
			this.label_Kundeninformationen.Size = new System.Drawing.Size(148, 18);
			this.label_Kundeninformationen.TabIndex = 0;
			this.label_Kundeninformationen.Text = "Kundeninformationen";
			// 
			// tabPage_Kunden
			// 
			this.tabPage_Kunden.Controls.Add(this.splitContainer_Kunden);
			this.tabPage_Kunden.Location = new System.Drawing.Point(4, 27);
			this.tabPage_Kunden.Name = "tabPage_Kunden";
			this.tabPage_Kunden.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Kunden.Size = new System.Drawing.Size(626, 503);
			this.tabPage_Kunden.TabIndex = 1;
			this.tabPage_Kunden.Text = "Kunden";
			this.tabPage_Kunden.UseVisualStyleBackColor = true;
			// 
			// splitContainer_Kunden
			// 
			this.splitContainer_Kunden.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Kunden.Location = new System.Drawing.Point(3, 3);
			this.splitContainer_Kunden.Name = "splitContainer_Kunden";
			this.splitContainer_Kunden.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_Kunden.Panel1
			// 
			this.splitContainer_Kunden.Panel1.Controls.Add(this.splitContainer_Kunenmaske);
			// 
			// splitContainer_Kunden.Panel2
			// 
			this.splitContainer_Kunden.Panel2.Controls.Add(this.dataGridView_KD);
			this.splitContainer_Kunden.Size = new System.Drawing.Size(620, 497);
			this.splitContainer_Kunden.SplitterDistance = 169;
			this.splitContainer_Kunden.TabIndex = 0;
			// 
			// splitContainer_Kunenmaske
			// 
			this.splitContainer_Kunenmaske.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Kunenmaske.Location = new System.Drawing.Point(0, 0);
			this.splitContainer_Kunenmaske.Name = "splitContainer_Kunenmaske";
			// 
			// splitContainer_Kunenmaske.Panel1
			// 
			this.splitContainer_Kunenmaske.Panel1.Controls.Add(this.label_Nr);
			this.splitContainer_Kunenmaske.Panel1.Controls.Add(this.textBox_Nr);
			this.splitContainer_Kunenmaske.Panel1.Controls.Add(this.label_Strasse);
			this.splitContainer_Kunenmaske.Panel1.Controls.Add(this.label_Kunde);
			this.splitContainer_Kunenmaske.Panel1.Controls.Add(this.label_idKD);
			this.splitContainer_Kunenmaske.Panel1.Controls.Add(this.textBox_Strasse);
			this.splitContainer_Kunenmaske.Panel1.Controls.Add(this.textBox_Kunde);
			this.splitContainer_Kunenmaske.Panel1.Controls.Add(this.textBox_idKD);
			this.splitContainer_Kunenmaske.Panel1.Controls.Add(this.bindingNavigator_KD);
			// 
			// splitContainer_Kunenmaske.Panel2
			// 
			this.splitContainer_Kunenmaske.Panel2.Controls.Add(this.label_Email);
			this.splitContainer_Kunenmaske.Panel2.Controls.Add(this.label_Telefon);
			this.splitContainer_Kunenmaske.Panel2.Controls.Add(this.label_Ort);
			this.splitContainer_Kunenmaske.Panel2.Controls.Add(this.label_PLZ);
			this.splitContainer_Kunenmaske.Panel2.Controls.Add(this.textBox_Email);
			this.splitContainer_Kunenmaske.Panel2.Controls.Add(this.textBox_Telefon);
			this.splitContainer_Kunenmaske.Panel2.Controls.Add(this.textBox_Ort);
			this.splitContainer_Kunenmaske.Panel2.Controls.Add(this.textBox_PLZ);
			this.splitContainer_Kunenmaske.Size = new System.Drawing.Size(620, 169);
			this.splitContainer_Kunenmaske.SplitterDistance = 328;
			this.splitContainer_Kunenmaske.TabIndex = 0;
			// 
			// label_Nr
			// 
			this.label_Nr.AutoSize = true;
			this.label_Nr.Location = new System.Drawing.Point(20, 117);
			this.label_Nr.Name = "label_Nr";
			this.label_Nr.Size = new System.Drawing.Size(24, 18);
			this.label_Nr.TabIndex = 8;
			this.label_Nr.Text = "Nr";
			// 
			// textBox_Nr
			// 
			this.textBox_Nr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Nr.Location = new System.Drawing.Point(120, 111);
			this.textBox_Nr.Name = "textBox_Nr";
			this.textBox_Nr.Size = new System.Drawing.Size(59, 24);
			this.textBox_Nr.TabIndex = 7;
			// 
			// label_Strasse
			// 
			this.label_Strasse.AutoSize = true;
			this.label_Strasse.Location = new System.Drawing.Point(20, 91);
			this.label_Strasse.Name = "label_Strasse";
			this.label_Strasse.Size = new System.Drawing.Size(52, 18);
			this.label_Strasse.TabIndex = 6;
			this.label_Strasse.Text = "Straße";
			// 
			// label_Kunde
			// 
			this.label_Kunde.AutoSize = true;
			this.label_Kunde.Location = new System.Drawing.Point(20, 64);
			this.label_Kunde.Name = "label_Kunde";
			this.label_Kunde.Size = new System.Drawing.Size(50, 18);
			this.label_Kunde.TabIndex = 5;
			this.label_Kunde.Text = "Kunde";
			// 
			// label_idKD
			// 
			this.label_idKD.AutoSize = true;
			this.label_idKD.Location = new System.Drawing.Point(20, 31);
			this.label_idKD.Name = "label_idKD";
			this.label_idKD.Size = new System.Drawing.Size(76, 18);
			this.label_idKD.TabIndex = 4;
			this.label_idKD.Text = "ID Kunden";
			// 
			// textBox_Strasse
			// 
			this.textBox_Strasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Strasse.Location = new System.Drawing.Point(120, 85);
			this.textBox_Strasse.Name = "textBox_Strasse";
			this.textBox_Strasse.Size = new System.Drawing.Size(168, 24);
			this.textBox_Strasse.TabIndex = 3;
			// 
			// textBox_Kunde
			// 
			this.textBox_Kunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Kunde.Location = new System.Drawing.Point(120, 55);
			this.textBox_Kunde.Name = "textBox_Kunde";
			this.textBox_Kunde.Size = new System.Drawing.Size(168, 24);
			this.textBox_Kunde.TabIndex = 2;
			// 
			// textBox_idKD
			// 
			this.textBox_idKD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_idKD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_idKD.ForeColor = System.Drawing.Color.DarkRed;
			this.textBox_idKD.Location = new System.Drawing.Point(120, 25);
			this.textBox_idKD.Name = "textBox_idKD";
			this.textBox_idKD.Size = new System.Drawing.Size(168, 24);
			this.textBox_idKD.TabIndex = 1;
			// 
			// bindingNavigator_KD
			// 
			this.bindingNavigator_KD.AddNewItem = this.bindingNavigatorAddNewItem1;
			this.bindingNavigator_KD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
			this.bindingNavigator_KD.CountItem = this.bindingNavigatorCountItem1;
			this.bindingNavigator_KD.DeleteItem = this.bindingNavigatorDeleteItem1;
			this.bindingNavigator_KD.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_KD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripButton_KundeAktualisieren});
			this.bindingNavigator_KD.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator_KD.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
			this.bindingNavigator_KD.MoveLastItem = this.bindingNavigatorMoveLastItem1;
			this.bindingNavigator_KD.MoveNextItem = this.bindingNavigatorMoveNextItem1;
			this.bindingNavigator_KD.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
			this.bindingNavigator_KD.Name = "bindingNavigator_KD";
			this.bindingNavigator_KD.PositionItem = this.bindingNavigatorPositionItem1;
			this.bindingNavigator_KD.Size = new System.Drawing.Size(328, 31);
			this.bindingNavigator_KD.TabIndex = 0;
			this.bindingNavigator_KD.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem1
			// 
			this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
			this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
			this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorAddNewItem1.Text = "Neu hinzufügen";
			// 
			// bindingNavigatorCountItem1
			// 
			this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
			this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(44, 28);
			this.bindingNavigatorCountItem1.Text = "von {0}";
			this.bindingNavigatorCountItem1.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorDeleteItem1
			// 
			this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
			this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
			this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorDeleteItem1.Text = "Löschen";
			// 
			// bindingNavigatorMoveFirstItem1
			// 
			this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
			this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
			this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveFirstItem1.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem1
			// 
			this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
			this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
			this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMovePreviousItem1.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator3
			// 
			this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
			this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorPositionItem1
			// 
			this.bindingNavigatorPositionItem1.AccessibleName = "Position";
			this.bindingNavigatorPositionItem1.AutoSize = false;
			this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
			this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem1.Text = "0";
			this.bindingNavigatorPositionItem1.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorSeparator4
			// 
			this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
			this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorMoveNextItem1
			// 
			this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
			this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
			this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveNextItem1.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem1
			// 
			this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
			this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
			this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveLastItem1.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator5
			// 
			this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
			this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripButton_KundeAktualisieren
			// 
			this.toolStripButton_KundeAktualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_KundeAktualisieren.Image = global::Auftrag_Kunde.Properties.Resources.accept;
			this.toolStripButton_KundeAktualisieren.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_KundeAktualisieren.Name = "toolStripButton_KundeAktualisieren";
			this.toolStripButton_KundeAktualisieren.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_KundeAktualisieren.Text = "toolStripButton7";
			this.toolStripButton_KundeAktualisieren.Click += new System.EventHandler(this.toolStripButton_KundeAktualisieren_Click);
			// 
			// label_Email
			// 
			this.label_Email.AutoSize = true;
			this.label_Email.Location = new System.Drawing.Point(12, 116);
			this.label_Email.Name = "label_Email";
			this.label_Email.Size = new System.Drawing.Size(45, 18);
			this.label_Email.TabIndex = 11;
			this.label_Email.Text = "Email";
			// 
			// label_Telefon
			// 
			this.label_Telefon.AutoSize = true;
			this.label_Telefon.Location = new System.Drawing.Point(12, 85);
			this.label_Telefon.Name = "label_Telefon";
			this.label_Telefon.Size = new System.Drawing.Size(57, 18);
			this.label_Telefon.TabIndex = 10;
			this.label_Telefon.Text = "Telefon";
			// 
			// label_Ort
			// 
			this.label_Ort.AutoSize = true;
			this.label_Ort.Location = new System.Drawing.Point(12, 55);
			this.label_Ort.Name = "label_Ort";
			this.label_Ort.Size = new System.Drawing.Size(29, 18);
			this.label_Ort.TabIndex = 9;
			this.label_Ort.Text = "Ort";
			// 
			// label_PLZ
			// 
			this.label_PLZ.AutoSize = true;
			this.label_PLZ.Location = new System.Drawing.Point(12, 25);
			this.label_PLZ.Name = "label_PLZ";
			this.label_PLZ.Size = new System.Drawing.Size(35, 18);
			this.label_PLZ.TabIndex = 8;
			this.label_PLZ.Text = "PLZ";
			// 
			// textBox_Email
			// 
			this.textBox_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Email.Location = new System.Drawing.Point(78, 113);
			this.textBox_Email.Name = "textBox_Email";
			this.textBox_Email.Size = new System.Drawing.Size(166, 24);
			this.textBox_Email.TabIndex = 7;
			// 
			// textBox_Telefon
			// 
			this.textBox_Telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Telefon.Location = new System.Drawing.Point(78, 82);
			this.textBox_Telefon.Name = "textBox_Telefon";
			this.textBox_Telefon.Size = new System.Drawing.Size(166, 24);
			this.textBox_Telefon.TabIndex = 6;
			// 
			// textBox_Ort
			// 
			this.textBox_Ort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Ort.Location = new System.Drawing.Point(78, 52);
			this.textBox_Ort.Name = "textBox_Ort";
			this.textBox_Ort.Size = new System.Drawing.Size(166, 24);
			this.textBox_Ort.TabIndex = 5;
			// 
			// textBox_PLZ
			// 
			this.textBox_PLZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_PLZ.Location = new System.Drawing.Point(78, 22);
			this.textBox_PLZ.Name = "textBox_PLZ";
			this.textBox_PLZ.Size = new System.Drawing.Size(166, 24);
			this.textBox_PLZ.TabIndex = 4;
			// 
			// dataGridView_KD
			// 
			this.dataGridView_KD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_KD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_KD.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_KD.Name = "dataGridView_KD";
			this.dataGridView_KD.Size = new System.Drawing.Size(620, 324);
			this.dataGridView_KD.TabIndex = 0;
			// 
			// tabPage_Werkstuecke
			// 
			this.tabPage_Werkstuecke.Controls.Add(this.splitContainer_Werkstuecke);
			this.tabPage_Werkstuecke.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Werkstuecke.Name = "tabPage_Werkstuecke";
			this.tabPage_Werkstuecke.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Werkstuecke.Size = new System.Drawing.Size(626, 508);
			this.tabPage_Werkstuecke.TabIndex = 2;
			this.tabPage_Werkstuecke.Text = "Werkstücke";
			this.tabPage_Werkstuecke.UseVisualStyleBackColor = true;
			// 
			// splitContainer_Werkstuecke
			// 
			this.splitContainer_Werkstuecke.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Werkstuecke.Location = new System.Drawing.Point(3, 3);
			this.splitContainer_Werkstuecke.Name = "splitContainer_Werkstuecke";
			this.splitContainer_Werkstuecke.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_Werkstuecke.Panel1
			// 
			this.splitContainer_Werkstuecke.Panel1.Controls.Add(this.splitContainer_Werkstueck);
			// 
			// splitContainer_Werkstuecke.Panel2
			// 
			this.splitContainer_Werkstuecke.Panel2.Controls.Add(this.dataGridView_WSt);
			this.splitContainer_Werkstuecke.Size = new System.Drawing.Size(620, 502);
			this.splitContainer_Werkstuecke.SplitterDistance = 226;
			this.splitContainer_Werkstuecke.TabIndex = 0;
			// 
			// splitContainer_Werkstueck
			// 
			this.splitContainer_Werkstueck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Werkstueck.Location = new System.Drawing.Point(0, 0);
			this.splitContainer_Werkstueck.Name = "splitContainer_Werkstueck";
			// 
			// splitContainer_Werkstueck.Panel1
			// 
			this.splitContainer_Werkstueck.Panel1.Controls.Add(this.bindingNavigator_WSt);
			this.splitContainer_Werkstueck.Panel1.Controls.Add(this.label_Bearbeiter);
			this.splitContainer_Werkstueck.Panel1.Controls.Add(this.label_Werkstueck);
			this.splitContainer_Werkstueck.Panel1.Controls.Add(this.label_idWSt);
			this.splitContainer_Werkstueck.Panel1.Controls.Add(this.textBox_Bearbeiter);
			this.splitContainer_Werkstueck.Panel1.Controls.Add(this.textBox_Werkstueck);
			this.splitContainer_Werkstueck.Panel1.Controls.Add(this.textBox_idWSt);
			// 
			// splitContainer_Werkstueck.Panel2
			// 
			this.splitContainer_Werkstueck.Panel2.Controls.Add(this.pictureBox_Werkstueck);
			this.splitContainer_Werkstueck.Size = new System.Drawing.Size(620, 226);
			this.splitContainer_Werkstueck.SplitterDistance = 334;
			this.splitContainer_Werkstueck.TabIndex = 0;
			// 
			// bindingNavigator_WSt
			// 
			this.bindingNavigator_WSt.AddNewItem = this.toolStripButton1;
			this.bindingNavigator_WSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
			this.bindingNavigator_WSt.CountItem = this.toolStripLabel1;
			this.bindingNavigator_WSt.DeleteItem = this.toolStripButton2;
			this.bindingNavigator_WSt.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_WSt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton_WerkstueckAktualisieren});
			this.bindingNavigator_WSt.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator_WSt.MoveFirstItem = this.toolStripButton3;
			this.bindingNavigator_WSt.MoveLastItem = this.toolStripButton6;
			this.bindingNavigator_WSt.MoveNextItem = this.toolStripButton5;
			this.bindingNavigator_WSt.MovePreviousItem = this.toolStripButton4;
			this.bindingNavigator_WSt.Name = "bindingNavigator_WSt";
			this.bindingNavigator_WSt.PositionItem = this.toolStripTextBox1;
			this.bindingNavigator_WSt.Size = new System.Drawing.Size(334, 31);
			this.bindingNavigator_WSt.TabIndex = 13;
			this.bindingNavigator_WSt.Text = "bindingNavigator1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.RightToLeftAutoMirrorImage = true;
			this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton1.Text = "Neu hinzufügen";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(44, 28);
			this.toolStripLabel1.Text = "von {0}";
			this.toolStripLabel1.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.RightToLeftAutoMirrorImage = true;
			this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton2.Text = "Löschen";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.RightToLeftAutoMirrorImage = true;
			this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton3.Text = "Erste verschieben";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.RightToLeftAutoMirrorImage = true;
			this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton4.Text = "Vorherige verschieben";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.AccessibleName = "Position";
			this.toolStripTextBox1.AutoSize = false;
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
			this.toolStripTextBox1.Text = "0";
			this.toolStripTextBox1.ToolTipText = "Aktuelle Position";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.RightToLeftAutoMirrorImage = true;
			this.toolStripButton5.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton5.Text = "Nächste verschieben";
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.RightToLeftAutoMirrorImage = true;
			this.toolStripButton6.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton6.Text = "Letzte verschieben";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripButton_WerkstueckAktualisieren
			// 
			this.toolStripButton_WerkstueckAktualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_WerkstueckAktualisieren.Image = global::Auftrag_Kunde.Properties.Resources.accept;
			this.toolStripButton_WerkstueckAktualisieren.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_WerkstueckAktualisieren.Name = "toolStripButton_WerkstueckAktualisieren";
			this.toolStripButton_WerkstueckAktualisieren.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_WerkstueckAktualisieren.Text = "toolStripButton7";
			this.toolStripButton_WerkstueckAktualisieren.Click += new System.EventHandler(this.toolStripButton_WerkstueckAktualisieren_Click);
			// 
			// label_Bearbeiter
			// 
			this.label_Bearbeiter.AutoSize = true;
			this.label_Bearbeiter.Location = new System.Drawing.Point(10, 133);
			this.label_Bearbeiter.Name = "label_Bearbeiter";
			this.label_Bearbeiter.Size = new System.Drawing.Size(75, 18);
			this.label_Bearbeiter.TabIndex = 12;
			this.label_Bearbeiter.Text = "Bearbeiter";
			// 
			// label_Werkstueck
			// 
			this.label_Werkstueck.AutoSize = true;
			this.label_Werkstueck.Location = new System.Drawing.Point(10, 91);
			this.label_Werkstueck.Name = "label_Werkstueck";
			this.label_Werkstueck.Size = new System.Drawing.Size(88, 18);
			this.label_Werkstueck.TabIndex = 11;
			this.label_Werkstueck.Text = "Werkstueck";
			// 
			// label_idWSt
			// 
			this.label_idWSt.AutoSize = true;
			this.label_idWSt.Location = new System.Drawing.Point(10, 56);
			this.label_idWSt.Name = "label_idWSt";
			this.label_idWSt.Size = new System.Drawing.Size(98, 18);
			this.label_idWSt.TabIndex = 10;
			this.label_idWSt.Text = "ID Werkstück";
			// 
			// textBox_Bearbeiter
			// 
			this.textBox_Bearbeiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Bearbeiter.Location = new System.Drawing.Point(110, 127);
			this.textBox_Bearbeiter.Name = "textBox_Bearbeiter";
			this.textBox_Bearbeiter.Size = new System.Drawing.Size(181, 24);
			this.textBox_Bearbeiter.TabIndex = 9;
			// 
			// textBox_Werkstueck
			// 
			this.textBox_Werkstueck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_Werkstueck.Location = new System.Drawing.Point(110, 88);
			this.textBox_Werkstueck.Name = "textBox_Werkstueck";
			this.textBox_Werkstueck.Size = new System.Drawing.Size(181, 24);
			this.textBox_Werkstueck.TabIndex = 8;
			// 
			// textBox_idWSt
			// 
			this.textBox_idWSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_idWSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_idWSt.ForeColor = System.Drawing.Color.DarkRed;
			this.textBox_idWSt.Location = new System.Drawing.Point(110, 50);
			this.textBox_idWSt.Name = "textBox_idWSt";
			this.textBox_idWSt.Size = new System.Drawing.Size(181, 24);
			this.textBox_idWSt.TabIndex = 7;
			this.textBox_idWSt.Tag = "Auto-Inkrement";
			// 
			// pictureBox_Werkstueck
			// 
			this.pictureBox_Werkstueck.BackColor = System.Drawing.Color.Gainsboro;
			this.pictureBox_Werkstueck.ContextMenuStrip = this.contextMenuStrip_Bild;
			this.pictureBox_Werkstueck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox_Werkstueck.Location = new System.Drawing.Point(0, 0);
			this.pictureBox_Werkstueck.Name = "pictureBox_Werkstueck";
			this.pictureBox_Werkstueck.Size = new System.Drawing.Size(282, 226);
			this.pictureBox_Werkstueck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_Werkstueck.TabIndex = 0;
			this.pictureBox_Werkstueck.TabStop = false;
			// 
			// contextMenuStrip_Bild
			// 
			this.contextMenuStrip_Bild.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip_Bild.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Einfuegen,
            this.toolStripMenuItem_Kopieren,
            this.toolStripMenuItem_Loeschen});
			this.contextMenuStrip_Bild.Name = "contextMenuStrip_Bild";
			this.contextMenuStrip_Bild.Size = new System.Drawing.Size(122, 70);
			// 
			// toolStripMenuItem_Einfuegen
			// 
			this.toolStripMenuItem_Einfuegen.Name = "toolStripMenuItem_Einfuegen";
			this.toolStripMenuItem_Einfuegen.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItem_Einfuegen.Text = "Einfügen";
			this.toolStripMenuItem_Einfuegen.Click += new System.EventHandler(this.toolStripMenuItem_Einfuegen_Click);
			// 
			// toolStripMenuItem_Kopieren
			// 
			this.toolStripMenuItem_Kopieren.Name = "toolStripMenuItem_Kopieren";
			this.toolStripMenuItem_Kopieren.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItem_Kopieren.Text = "Kopieren";
			this.toolStripMenuItem_Kopieren.Click += new System.EventHandler(this.toolStripMenuItem_Kopieren_Click);
			// 
			// toolStripMenuItem_Loeschen
			// 
			this.toolStripMenuItem_Loeschen.Name = "toolStripMenuItem_Loeschen";
			this.toolStripMenuItem_Loeschen.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItem_Loeschen.Text = "Löschen";
			this.toolStripMenuItem_Loeschen.Click += new System.EventHandler(this.toolStripMenuItem_Loeschen_Click);
			// 
			// dataGridView_WSt
			// 
			this.dataGridView_WSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_WSt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_WSt.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_WSt.Name = "dataGridView_WSt";
			this.dataGridView_WSt.Size = new System.Drawing.Size(620, 272);
			this.dataGridView_WSt.TabIndex = 1;
			// 
			// Form_KundenBestellenWerkstuecke
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 571);
			this.Controls.Add(this.splitContainer_Kundenauftraege);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip_Auftragsverwaltung;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form_KundenBestellenWerkstuecke";
			this.Text = "Kunden bestellen Werkstücke";
			this.Load += new System.EventHandler(this.Form_KundenBestellungen_Load);
			this.Shown += new System.EventHandler(this.Form_KundenBestellungen_Shown);
			this.splitContainer_Kundenauftraege.Panel1.ResumeLayout(false);
			this.splitContainer_Kundenauftraege.Panel1.PerformLayout();
			this.splitContainer_Kundenauftraege.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Kundenauftraege)).EndInit();
			this.splitContainer_Kundenauftraege.ResumeLayout(false);
			this.menuStrip_Auftragsverwaltung.ResumeLayout(false);
			this.menuStrip_Auftragsverwaltung.PerformLayout();
			this.tabControl_AuftraegeUndKunden.ResumeLayout(false);
			this.tabPage_Auftraege.ResumeLayout(false);
			this.splitContainer_Auftraege.Panel1.ResumeLayout(false);
			this.splitContainer_Auftraege.Panel1.PerformLayout();
			this.splitContainer_Auftraege.Panel2.ResumeLayout(false);
			this.splitContainer_Auftraege.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Auftraege)).EndInit();
			this.splitContainer_Auftraege.ResumeLayout(false);
			this.splitContainer_Kunde.Panel1.ResumeLayout(false);
			this.splitContainer_Kunde.Panel1.PerformLayout();
			this.splitContainer_Kunde.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Kunde)).EndInit();
			this.splitContainer_Kunde.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_AT)).EndInit();
			this.bindingNavigator_AT.ResumeLayout(false);
			this.bindingNavigator_AT.PerformLayout();
			this.tabPage_Kunden.ResumeLayout(false);
			this.splitContainer_Kunden.Panel1.ResumeLayout(false);
			this.splitContainer_Kunden.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Kunden)).EndInit();
			this.splitContainer_Kunden.ResumeLayout(false);
			this.splitContainer_Kunenmaske.Panel1.ResumeLayout(false);
			this.splitContainer_Kunenmaske.Panel1.PerformLayout();
			this.splitContainer_Kunenmaske.Panel2.ResumeLayout(false);
			this.splitContainer_Kunenmaske.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Kunenmaske)).EndInit();
			this.splitContainer_Kunenmaske.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_KD)).EndInit();
			this.bindingNavigator_KD.ResumeLayout(false);
			this.bindingNavigator_KD.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_KD)).EndInit();
			this.tabPage_Werkstuecke.ResumeLayout(false);
			this.splitContainer_Werkstuecke.Panel1.ResumeLayout(false);
			this.splitContainer_Werkstuecke.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Werkstuecke)).EndInit();
			this.splitContainer_Werkstuecke.ResumeLayout(false);
			this.splitContainer_Werkstueck.Panel1.ResumeLayout(false);
			this.splitContainer_Werkstueck.Panel1.PerformLayout();
			this.splitContainer_Werkstueck.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Werkstueck)).EndInit();
			this.splitContainer_Werkstueck.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_WSt)).EndInit();
			this.bindingNavigator_WSt.ResumeLayout(false);
			this.bindingNavigator_WSt.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Werkstueck)).EndInit();
			this.contextMenuStrip_Bild.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_WSt)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Kundenauftraege;
        private System.Windows.Forms.MenuStrip menuStrip_Auftragsverwaltung;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_AuftraegeUndKunden;
        private System.Windows.Forms.TabPage tabPage_Auftraege;
        private System.Windows.Forms.SplitContainer splitContainer_Auftraege;
        private System.Windows.Forms.SplitContainer splitContainer_Kunde;
        private System.Windows.Forms.BindingNavigator bindingNavigator_AT;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabPage tabPage_Kunden;
        private System.Windows.Forms.DataGridView dataGridView_AT;
        private System.Windows.Forms.Label label_comboKunden;
        private System.Windows.Forms.Label label_Liefertermin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_idAT;
        private System.Windows.Forms.TextBox textBox_Liefertermin;
        private System.Windows.Forms.TextBox textBox_Auftrag;
        private System.Windows.Forms.TextBox textBox_idAT;
        private System.Windows.Forms.ComboBox comboBox_AT_idKD;
        private System.Windows.Forms.SplitContainer splitContainer_Kunden;
        private System.Windows.Forms.SplitContainer splitContainer_Kunenmaske;
        private System.Windows.Forms.DataGridView dataGridView_KD;
        private System.Windows.Forms.TextBox textBox_Strasse;
        private System.Windows.Forms.TextBox textBox_Kunde;
        private System.Windows.Forms.TextBox textBox_idKD;
        private System.Windows.Forms.BindingNavigator bindingNavigator_KD;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.TextBox textBox_Ort;
        private System.Windows.Forms.TextBox textBox_PLZ;
        private System.Windows.Forms.Label label_Strasse;
        private System.Windows.Forms.Label label_Kunde;
        private System.Windows.Forms.Label label_idKD;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Telefon;
        private System.Windows.Forms.Label label_Ort;
        private System.Windows.Forms.Label label_PLZ;
        private System.Windows.Forms.TextBox textBox_infoIdKD;
        private System.Windows.Forms.Label label_Kundeninformationen;
        private System.Windows.Forms.TextBox textBox_infoKDort;
        private System.Windows.Forms.TextBox textBox_infoKDstrasse;
        private System.Windows.Forms.TextBox textBox_infoKunde;
        private System.Windows.Forms.TextBox textBox_infoKDemail;
        private System.Windows.Forms.TextBox textBox_infoKDtelefon;
        private System.Windows.Forms.TextBox textBox_Nr;
        private System.Windows.Forms.Label label_Nr;
        private System.Windows.Forms.TextBox textBox_infoKDplz;
        private System.Windows.Forms.TabPage tabPage_Werkstuecke;
        private System.Windows.Forms.SplitContainer splitContainer_Werkstuecke;
        private System.Windows.Forms.SplitContainer splitContainer_Werkstueck;
        private System.Windows.Forms.DataGridView dataGridView_WSt;
        private System.Windows.Forms.BindingNavigator bindingNavigator_WSt;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label_Bearbeiter;
        private System.Windows.Forms.Label label_Werkstueck;
        private System.Windows.Forms.Label label_idWSt;
        private System.Windows.Forms.TextBox textBox_Bearbeiter;
        private System.Windows.Forms.TextBox textBox_Werkstueck;
        private System.Windows.Forms.TextBox textBox_idWSt;
        private System.Windows.Forms.PictureBox pictureBox_Werkstueck;
        private System.Windows.Forms.ComboBox comboBox_AT_idWSt;
        private System.Windows.Forms.Label label_comboWerkstueck;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKundenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Bild;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Einfuegen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Kopieren;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Loeschen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAuftraegeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auftragDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieferterminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWerkstueckeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn werkstueckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bearbeiterDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton_WerkstueckAktualisieren;
        private System.Windows.Forms.ToolStripButton toolStripButton_KundeAktualisieren;
        private System.Windows.Forms.ToolStripButton toolStripButton_AuftragAktualisieren;
        private System.Windows.Forms.TextBox textBox_infoWStBearbeiter;
        private System.Windows.Forms.TextBox textBox_infoWerkstueck;
        private System.Windows.Forms.TextBox textBox_infoIdWst;
        private System.Windows.Forms.Label label_Werkstueckinformationen;
		private System.Windows.Forms.TextBox textBox_infoKDnr;
	}
}

