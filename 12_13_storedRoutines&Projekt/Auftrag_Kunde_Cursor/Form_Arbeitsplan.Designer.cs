namespace Auftrag_Kunde
{
  partial class Form_Arbeitsplan
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Arbeitsplan));
      this.menuStrip_Arbeitsplan = new System.Windows.Forms.MenuStrip();
      this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer_Arbeitsplan = new System.Windows.Forms.SplitContainer();
      this.label_ZeitJeEinheit = new System.Windows.Forms.Label();
      this.label_idWerkstueck = new System.Windows.Forms.Label();
      this.textBox_idWerkstueck = new System.Windows.Forms.TextBox();
      this.bindingSource_Arbeitsplan = new System.Windows.Forms.BindingSource(this.components);
      this.bindingSource_Werkstueck = new System.Windows.Forms.BindingSource(this.components);
      this.kundenwerkstueckarbeitsplaeneDataSet3 = new Auftrag_Kunde.kundenwerkstueckarbeitsplaeneDataSet3();
      this.label_Rüstzeit = new System.Windows.Forms.Label();
      this.label_Arbeitsplatz = new System.Windows.Forms.Label();
      this.textBox_ZeitJeEinheit = new System.Windows.Forms.TextBox();
      this.textBox_Rüstzeit = new System.Windows.Forms.TextBox();
      this.textBox_Arbeitsplatz = new System.Windows.Forms.TextBox();
      this.label_Arbeitsvorgang = new System.Windows.Forms.Label();
      this.textBox_Arbeitsvorgang = new System.Windows.Forms.TextBox();
      this.label_idAV = new System.Windows.Forms.Label();
      this.textBox_idArbeitsvorgang = new System.Windows.Forms.TextBox();
      this.dataGridView_Arbeitsplan = new System.Windows.Forms.DataGridView();
      this.werkstueckeTableAdapter = new Auftrag_Kunde.kundenwerkstueckarbeitsplaeneDataSet3TableAdapters.werkstueckeTableAdapter();
      this.arbeitsplanTableAdapter = new Auftrag_Kunde.kundenwerkstueckarbeitsplaeneDataSet3TableAdapters.arbeitsplanTableAdapter();
      this.panel_WerkstueckArbeitsplkanNavigatoren = new System.Windows.Forms.Panel();
      this.bindingNavigator_Arbeitsplan = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.toolStripButton_ArbeitsplanAktualisieren = new System.Windows.Forms.ToolStripButton();
      this.fkArbeitsplanWerkstuecke1BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.idWerkstueckeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fkArbeitsplanWerkstuecke1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.fkArbeitsplanWerkstuecke1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.fkArbeitsplanWerkstuecke1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
      this.menuStrip_Arbeitsplan.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Arbeitsplan)).BeginInit();
      this.splitContainer_Arbeitsplan.Panel1.SuspendLayout();
      this.splitContainer_Arbeitsplan.Panel2.SuspendLayout();
      this.splitContainer_Arbeitsplan.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Arbeitsplan)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Werkstueck)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.kundenwerkstueckarbeitsplaeneDataSet3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Arbeitsplan)).BeginInit();
      this.panel_WerkstueckArbeitsplkanNavigatoren.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Arbeitsplan)).BeginInit();
      this.bindingNavigator_Arbeitsplan.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fkArbeitsplanWerkstuecke1BindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fkArbeitsplanWerkstuecke1BindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fkArbeitsplanWerkstuecke1BindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fkArbeitsplanWerkstuecke1BindingSource3)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip_Arbeitsplan
      // 
      this.menuStrip_Arbeitsplan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
      this.menuStrip_Arbeitsplan.Location = new System.Drawing.Point(0, 0);
      this.menuStrip_Arbeitsplan.Name = "menuStrip_Arbeitsplan";
      this.menuStrip_Arbeitsplan.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.menuStrip_Arbeitsplan.Size = new System.Drawing.Size(515, 26);
      this.menuStrip_Arbeitsplan.TabIndex = 0;
      this.menuStrip_Arbeitsplan.Text = "menuStrip1";
      // 
      // schließenToolStripMenuItem
      // 
      this.schließenToolStripMenuItem.Image = global::Auftrag_Kunde.Properties.Resources.SCHLIESSEN_gruen_weiß_blau;
      this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
      this.schließenToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
      this.schließenToolStripMenuItem.Text = "Schließen";
      this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
      // 
      // splitContainer_Arbeitsplan
      // 
      this.splitContainer_Arbeitsplan.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer_Arbeitsplan.Location = new System.Drawing.Point(0, 26);
      this.splitContainer_Arbeitsplan.Margin = new System.Windows.Forms.Padding(4);
      this.splitContainer_Arbeitsplan.Name = "splitContainer_Arbeitsplan";
      this.splitContainer_Arbeitsplan.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer_Arbeitsplan.Panel1
      // 
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.panel_WerkstueckArbeitsplkanNavigatoren);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.label_ZeitJeEinheit);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.label_idWerkstueck);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.textBox_idWerkstueck);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.label_Rüstzeit);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.label_Arbeitsplatz);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.textBox_ZeitJeEinheit);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.textBox_Rüstzeit);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.textBox_Arbeitsplatz);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.label_Arbeitsvorgang);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.textBox_Arbeitsvorgang);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.label_idAV);
      this.splitContainer_Arbeitsplan.Panel1.Controls.Add(this.textBox_idArbeitsvorgang);
      // 
      // splitContainer_Arbeitsplan.Panel2
      // 
      this.splitContainer_Arbeitsplan.Panel2.Controls.Add(this.dataGridView_Arbeitsplan);
      this.splitContainer_Arbeitsplan.Size = new System.Drawing.Size(515, 607);
      this.splitContainer_Arbeitsplan.SplitterDistance = 197;
      this.splitContainer_Arbeitsplan.SplitterWidth = 6;
      this.splitContainer_Arbeitsplan.TabIndex = 1;
      // 
      // label_ZeitJeEinheit
      // 
      this.label_ZeitJeEinheit.AutoSize = true;
      this.label_ZeitJeEinheit.Location = new System.Drawing.Point(222, 169);
      this.label_ZeitJeEinheit.Name = "label_ZeitJeEinheit";
      this.label_ZeitJeEinheit.Size = new System.Drawing.Size(138, 18);
      this.label_ZeitJeEinheit.TabIndex = 19;
      this.label_ZeitJeEinheit.Text = "Zeit je Einheit in Min";
      // 
      // label_idWerkstueck
      // 
      this.label_idWerkstueck.AutoSize = true;
      this.label_idWerkstueck.Location = new System.Drawing.Point(243, 46);
      this.label_idWerkstueck.Name = "label_idWerkstueck";
      this.label_idWerkstueck.Size = new System.Drawing.Size(98, 18);
      this.label_idWerkstueck.TabIndex = 18;
      this.label_idWerkstueck.Text = "Werkstück ID";
      // 
      // textBox_idWerkstueck
      // 
      this.textBox_idWerkstueck.BackColor = System.Drawing.Color.Silver;
      this.textBox_idWerkstueck.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_Arbeitsplan, "idWerkstuecke", true));
      this.textBox_idWerkstueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_idWerkstueck.ForeColor = System.Drawing.Color.DarkRed;
      this.textBox_idWerkstueck.Location = new System.Drawing.Point(356, 43);
      this.textBox_idWerkstueck.Name = "textBox_idWerkstueck";
      this.textBox_idWerkstueck.Size = new System.Drawing.Size(121, 24);
      this.textBox_idWerkstueck.TabIndex = 17;
      this.textBox_idWerkstueck.Tag = "Auto-Inkrement";
      // 
      // bindingSource_Arbeitsplan
      // 
      this.bindingSource_Arbeitsplan.DataMember = "fk_Arbeitsplan_Werkstuecke1";
      this.bindingSource_Arbeitsplan.DataSource = this.bindingSource_Werkstueck;
      // 
      // bindingSource_Werkstueck
      // 
      this.bindingSource_Werkstueck.DataMember = "werkstuecke";
      this.bindingSource_Werkstueck.DataSource = this.kundenwerkstueckarbeitsplaeneDataSet3;
      // 
      // kundenwerkstueckarbeitsplaeneDataSet3
      // 
      this.kundenwerkstueckarbeitsplaeneDataSet3.DataSetName = "kundenwerkstueckarbeitsplaeneDataSet3";
      this.kundenwerkstueckarbeitsplaeneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // label_Rüstzeit
      // 
      this.label_Rüstzeit.AutoSize = true;
      this.label_Rüstzeit.Location = new System.Drawing.Point(255, 139);
      this.label_Rüstzeit.Name = "label_Rüstzeit";
      this.label_Rüstzeit.Size = new System.Drawing.Size(105, 18);
      this.label_Rüstzeit.TabIndex = 16;
      this.label_Rüstzeit.Text = "Rüstzeit in Min";
      // 
      // label_Arbeitsplatz
      // 
      this.label_Arbeitsplatz.AutoSize = true;
      this.label_Arbeitsplatz.Location = new System.Drawing.Point(73, 109);
      this.label_Arbeitsplatz.Name = "label_Arbeitsplatz";
      this.label_Arbeitsplatz.Size = new System.Drawing.Size(84, 18);
      this.label_Arbeitsplatz.TabIndex = 16;
      this.label_Arbeitsplatz.Text = "Arbeitsplatz";
      // 
      // textBox_ZeitJeEinheit
      // 
      this.textBox_ZeitJeEinheit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_ZeitJeEinheit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_Arbeitsplan, "ZeitJeEinheit", true));
      this.textBox_ZeitJeEinheit.Location = new System.Drawing.Point(366, 163);
      this.textBox_ZeitJeEinheit.Name = "textBox_ZeitJeEinheit";
      this.textBox_ZeitJeEinheit.Size = new System.Drawing.Size(111, 24);
      this.textBox_ZeitJeEinheit.TabIndex = 15;
      // 
      // textBox_Rüstzeit
      // 
      this.textBox_Rüstzeit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_Rüstzeit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_Arbeitsplan, "Rüstzeit", true));
      this.textBox_Rüstzeit.Location = new System.Drawing.Point(366, 133);
      this.textBox_Rüstzeit.Name = "textBox_Rüstzeit";
      this.textBox_Rüstzeit.Size = new System.Drawing.Size(111, 24);
      this.textBox_Rüstzeit.TabIndex = 15;
      // 
      // textBox_Arbeitsplatz
      // 
      this.textBox_Arbeitsplatz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_Arbeitsplatz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_Arbeitsplan, "Arbeitsplatz", true));
      this.textBox_Arbeitsplatz.Location = new System.Drawing.Point(163, 106);
      this.textBox_Arbeitsplatz.Name = "textBox_Arbeitsplatz";
      this.textBox_Arbeitsplatz.Size = new System.Drawing.Size(314, 24);
      this.textBox_Arbeitsplatz.TabIndex = 15;
      // 
      // label_Arbeitsvorgang
      // 
      this.label_Arbeitsvorgang.AutoSize = true;
      this.label_Arbeitsvorgang.Location = new System.Drawing.Point(56, 82);
      this.label_Arbeitsvorgang.Name = "label_Arbeitsvorgang";
      this.label_Arbeitsvorgang.Size = new System.Drawing.Size(106, 18);
      this.label_Arbeitsvorgang.TabIndex = 14;
      this.label_Arbeitsvorgang.Text = "Arbeitsvorgang";
      // 
      // textBox_Arbeitsvorgang
      // 
      this.textBox_Arbeitsvorgang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_Arbeitsvorgang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_Arbeitsplan, "Arbeitsvorgang", true));
      this.textBox_Arbeitsvorgang.Location = new System.Drawing.Point(163, 76);
      this.textBox_Arbeitsvorgang.Name = "textBox_Arbeitsvorgang";
      this.textBox_Arbeitsvorgang.Size = new System.Drawing.Size(314, 24);
      this.textBox_Arbeitsvorgang.TabIndex = 13;
      // 
      // label_idAV
      // 
      this.label_idAV.AutoSize = true;
      this.label_idAV.Location = new System.Drawing.Point(104, 46);
      this.label_idAV.Name = "label_idAV";
      this.label_idAV.Size = new System.Drawing.Size(42, 18);
      this.label_idAV.TabIndex = 12;
      this.label_idAV.Text = "AV-Id";
      // 
      // textBox_idArbeitsvorgang
      // 
      this.textBox_idArbeitsvorgang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_idArbeitsvorgang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_Arbeitsplan, "idArbeitsvorgang", true));
      this.textBox_idArbeitsvorgang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_idArbeitsvorgang.ForeColor = System.Drawing.Color.DarkRed;
      this.textBox_idArbeitsvorgang.Location = new System.Drawing.Point(163, 46);
      this.textBox_idArbeitsvorgang.Name = "textBox_idArbeitsvorgang";
      this.textBox_idArbeitsvorgang.Size = new System.Drawing.Size(74, 24);
      this.textBox_idArbeitsvorgang.TabIndex = 11;
      this.textBox_idArbeitsvorgang.Tag = "Auto-Inkrement";
      // 
      // dataGridView_Arbeitsplan
      // 
      this.dataGridView_Arbeitsplan.AutoGenerateColumns = false;
      this.dataGridView_Arbeitsplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Arbeitsplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWerkstueckeDataGridViewTextBoxColumn});
      this.dataGridView_Arbeitsplan.DataSource = this.fkArbeitsplanWerkstuecke1BindingSource3;
      this.dataGridView_Arbeitsplan.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView_Arbeitsplan.Location = new System.Drawing.Point(0, 0);
      this.dataGridView_Arbeitsplan.Margin = new System.Windows.Forms.Padding(4);
      this.dataGridView_Arbeitsplan.Name = "dataGridView_Arbeitsplan";
      this.dataGridView_Arbeitsplan.Size = new System.Drawing.Size(515, 404);
      this.dataGridView_Arbeitsplan.TabIndex = 0;
      // 
      // werkstueckeTableAdapter
      // 
      this.werkstueckeTableAdapter.ClearBeforeFill = true;
      // 
      // arbeitsplanTableAdapter
      // 
      this.arbeitsplanTableAdapter.ClearBeforeFill = true;
      // 
      // panel_WerkstueckArbeitsplkanNavigatoren
      // 
      this.panel_WerkstueckArbeitsplkanNavigatoren.Controls.Add(this.bindingNavigator_Arbeitsplan);
      this.panel_WerkstueckArbeitsplkanNavigatoren.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel_WerkstueckArbeitsplkanNavigatoren.Location = new System.Drawing.Point(0, 0);
      this.panel_WerkstueckArbeitsplkanNavigatoren.Name = "panel_WerkstueckArbeitsplkanNavigatoren";
      this.panel_WerkstueckArbeitsplkanNavigatoren.Size = new System.Drawing.Size(515, 33);
      this.panel_WerkstueckArbeitsplkanNavigatoren.TabIndex = 21;
      // 
      // bindingNavigator_Arbeitsplan
      // 
      this.bindingNavigator_Arbeitsplan.AddNewItem = this.bindingNavigatorAddNewItem;
      this.bindingNavigator_Arbeitsplan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.bindingNavigator_Arbeitsplan.BindingSource = this.bindingSource_Arbeitsplan;
      this.bindingNavigator_Arbeitsplan.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigator_Arbeitsplan.DeleteItem = this.bindingNavigatorDeleteItem;
      this.bindingNavigator_Arbeitsplan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton_ArbeitsplanAktualisieren});
      this.bindingNavigator_Arbeitsplan.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigator_Arbeitsplan.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigator_Arbeitsplan.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigator_Arbeitsplan.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigator_Arbeitsplan.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigator_Arbeitsplan.Name = "bindingNavigator_Arbeitsplan";
      this.bindingNavigator_Arbeitsplan.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
      this.bindingNavigator_Arbeitsplan.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigator_Arbeitsplan.Size = new System.Drawing.Size(515, 25);
      this.bindingNavigator_Arbeitsplan.TabIndex = 1;
      this.bindingNavigator_Arbeitsplan.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
      this.bindingNavigatorCountItem.Text = "von {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Löschen";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButton_ArbeitsplanAktualisieren
      // 
      this.toolStripButton_ArbeitsplanAktualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton_ArbeitsplanAktualisieren.Image = global::Auftrag_Kunde.Properties.Resources.accept;
      this.toolStripButton_ArbeitsplanAktualisieren.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton_ArbeitsplanAktualisieren.Name = "toolStripButton_ArbeitsplanAktualisieren";
      this.toolStripButton_ArbeitsplanAktualisieren.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton_ArbeitsplanAktualisieren.Text = "Aktualisieren";
      // 
      // fkArbeitsplanWerkstuecke1BindingSource
      // 
      this.fkArbeitsplanWerkstuecke1BindingSource.DataMember = "fk_Arbeitsplan_Werkstuecke1";
      this.fkArbeitsplanWerkstuecke1BindingSource.DataSource = this.bindingSource_Werkstueck;
      // 
      // idWerkstueckeDataGridViewTextBoxColumn
      // 
      this.idWerkstueckeDataGridViewTextBoxColumn.DataPropertyName = "idWerkstuecke";
      this.idWerkstueckeDataGridViewTextBoxColumn.HeaderText = "idWerkstuecke";
      this.idWerkstueckeDataGridViewTextBoxColumn.Name = "idWerkstueckeDataGridViewTextBoxColumn";
      // 
      // fkArbeitsplanWerkstuecke1BindingSource1
      // 
      this.fkArbeitsplanWerkstuecke1BindingSource1.DataMember = "fk_Arbeitsplan_Werkstuecke1";
      this.fkArbeitsplanWerkstuecke1BindingSource1.DataSource = this.bindingSource_Werkstueck;
      // 
      // fkArbeitsplanWerkstuecke1BindingSource2
      // 
      this.fkArbeitsplanWerkstuecke1BindingSource2.DataMember = "fk_Arbeitsplan_Werkstuecke1";
      this.fkArbeitsplanWerkstuecke1BindingSource2.DataSource = this.bindingSource_Werkstueck;
      // 
      // fkArbeitsplanWerkstuecke1BindingSource3
      // 
      this.fkArbeitsplanWerkstuecke1BindingSource3.DataMember = "fk_Arbeitsplan_Werkstuecke1";
      this.fkArbeitsplanWerkstuecke1BindingSource3.DataSource = this.bindingSource_Werkstueck;
      // 
      // Form_Arbeitsplan
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(515, 633);
      this.Controls.Add(this.splitContainer_Arbeitsplan);
      this.Controls.Add(this.menuStrip_Arbeitsplan);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip_Arbeitsplan;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form_Arbeitsplan";
      this.Text = "Arbeitsplan";
      this.Load += new System.EventHandler(this.Form_Arbeitsplan_Load);
      this.menuStrip_Arbeitsplan.ResumeLayout(false);
      this.menuStrip_Arbeitsplan.PerformLayout();
      this.splitContainer_Arbeitsplan.Panel1.ResumeLayout(false);
      this.splitContainer_Arbeitsplan.Panel1.PerformLayout();
      this.splitContainer_Arbeitsplan.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Arbeitsplan)).EndInit();
      this.splitContainer_Arbeitsplan.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Arbeitsplan)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Werkstueck)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.kundenwerkstueckarbeitsplaeneDataSet3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Arbeitsplan)).EndInit();
      this.panel_WerkstueckArbeitsplkanNavigatoren.ResumeLayout(false);
      this.panel_WerkstueckArbeitsplkanNavigatoren.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Arbeitsplan)).EndInit();
      this.bindingNavigator_Arbeitsplan.ResumeLayout(false);
      this.bindingNavigator_Arbeitsplan.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fkArbeitsplanWerkstuecke1BindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fkArbeitsplanWerkstuecke1BindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fkArbeitsplanWerkstuecke1BindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fkArbeitsplanWerkstuecke1BindingSource3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip_Arbeitsplan;
    private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer_Arbeitsplan;
    private System.Windows.Forms.DataGridView dataGridView_Arbeitsplan;
    private System.Windows.Forms.BindingSource bindingSource_Arbeitsplan;
    private kundenwerkstueckarbeitsplaeneDataSet3 kundenwerkstueckarbeitsplaeneDataSet3;
    private System.Windows.Forms.BindingSource bindingSource_Werkstueck;
    private kundenwerkstueckarbeitsplaeneDataSet3TableAdapters.werkstueckeTableAdapter werkstueckeTableAdapter;
    private kundenwerkstueckarbeitsplaeneDataSet3TableAdapters.arbeitsplanTableAdapter arbeitsplanTableAdapter;
    private System.Windows.Forms.Label label_idAV;
    private System.Windows.Forms.TextBox textBox_idArbeitsvorgang;
    private System.Windows.Forms.Label label_Arbeitsplatz;
    private System.Windows.Forms.TextBox textBox_Arbeitsplatz;
    private System.Windows.Forms.Label label_Arbeitsvorgang;
    private System.Windows.Forms.TextBox textBox_Arbeitsvorgang;
    private System.Windows.Forms.Label label_idWerkstueck;
    private System.Windows.Forms.TextBox textBox_idWerkstueck;
    private System.Windows.Forms.Label label_ZeitJeEinheit;
    private System.Windows.Forms.Label label_Rüstzeit;
    private System.Windows.Forms.TextBox textBox_ZeitJeEinheit;
    private System.Windows.Forms.TextBox textBox_Rüstzeit;
    private System.Windows.Forms.Panel panel_WerkstueckArbeitsplkanNavigatoren;
    private System.Windows.Forms.BindingNavigator bindingNavigator_Arbeitsplan;
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
    private System.Windows.Forms.ToolStripButton toolStripButton_ArbeitsplanAktualisieren;
    private System.Windows.Forms.DataGridViewTextBoxColumn idWerkstueckeDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource fkArbeitsplanWerkstuecke1BindingSource1;
    private System.Windows.Forms.BindingSource fkArbeitsplanWerkstuecke1BindingSource;
    private System.Windows.Forms.BindingSource fkArbeitsplanWerkstuecke1BindingSource3;
    private System.Windows.Forms.BindingSource fkArbeitsplanWerkstuecke1BindingSource2;
  }
}