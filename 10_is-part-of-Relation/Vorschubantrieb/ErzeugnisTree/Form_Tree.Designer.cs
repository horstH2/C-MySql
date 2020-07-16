using System.Windows.Forms;

namespace Erzeugnisstruktur
{
	partial class Form_Tree
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Tree));
			this.menuStrip_Tree = new System.Windows.Forms.MenuStrip();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.speichernAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_trennen = new System.Windows.Forms.ToolStripMenuItem();
			this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer_Tree = new System.Windows.Forms.SplitContainer();
			this.tabControl_Teile = new System.Windows.Forms.TabControl();
			this.tabPage_Kugelumlaufspindel = new System.Windows.Forms.TabPage();
			this.contextMenuStrip_Tree = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.erzeugnisAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baugruppeAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.teilBaugruppeEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView_Spindel = new System.Windows.Forms.DataGridView();
			this.bindingNavigator_Spindel = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem6 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem6 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem6 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem6 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem6 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator18 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem6 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator19 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem6 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem6 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator20 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_SpindelUpdate = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_AddSpindel = new System.Windows.Forms.ToolStripButton();
			this.tabPage_Vorschubmotor = new System.Windows.Forms.TabPage();
			this.dataGridView_Motor = new System.Windows.Forms.DataGridView();
			this.bindingNavigator_Motor = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem5 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem5 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem5 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem5 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem5 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator15 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem5 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator16 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem5 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem5 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator17 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_MotorUpdate = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_AddMotor = new System.Windows.Forms.ToolStripButton();
			this.tabPage_Wälzlager = new System.Windows.Forms.TabPage();
			this.dataGridView_Lager = new System.Windows.Forms.DataGridView();
			this.bindingNavigator_Lager = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem4 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem4 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_LagerUpdate = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_AddLager = new System.Windows.Forms.ToolStripButton();
			this.tabPage_Schraube = new System.Windows.Forms.TabPage();
			this.dataGridView_Schrauben = new System.Windows.Forms.DataGridView();
			this.bindingNavigator_Schrauben = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_SchraubenUpdate = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_AddSchraube = new System.Windows.Forms.ToolStripButton();
			this.tabPage_Passfeder = new System.Windows.Forms.TabPage();
			this.dataGridView_Passfedern = new System.Windows.Forms.DataGridView();
			this.bindingNavigator_Passfedern = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_PassfedernUpdate = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Passfeder = new System.Windows.Forms.ToolStripButton();
			this.tabPage_Zahnriemen = new System.Windows.Forms.TabPage();
			this.dataGridView_Zahnriemen = new System.Windows.Forms.DataGridView();
			this.bindingNavigator_Zahnriemen = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.toolStripButton_ZahnriemenUpdate = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_AddZahnriemen = new System.Windows.Forms.ToolStripButton();
			this.tabPage_Zahnriemenscheibe = new System.Windows.Forms.TabPage();
			this.dataGridView_Zahnscheiben = new System.Windows.Forms.DataGridView();
			this.bindingNavigator_Zahnscheiben = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.toolStripButton_ZahnscheibenUpdate = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_AddZahnscheibe = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.splitContainer_TreeErz = new System.Windows.Forms.SplitContainer();
			this.label_Tree = new System.Windows.Forms.Label();
			this.textBox_edit = new System.Windows.Forms.TextBox();
			this.treeView_Erz = new System.Windows.Forms.TreeView();
			this.label_Info = new System.Windows.Forms.Label();
			this.menuStrip_Tree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Tree)).BeginInit();
			this.splitContainer_Tree.Panel1.SuspendLayout();
			this.splitContainer_Tree.Panel2.SuspendLayout();
			this.splitContainer_Tree.SuspendLayout();
			this.tabControl_Teile.SuspendLayout();
			this.tabPage_Kugelumlaufspindel.SuspendLayout();
			this.contextMenuStrip_Tree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spindel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Spindel)).BeginInit();
			this.bindingNavigator_Spindel.SuspendLayout();
			this.tabPage_Vorschubmotor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Motor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Motor)).BeginInit();
			this.bindingNavigator_Motor.SuspendLayout();
			this.tabPage_Wälzlager.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Lager)).BeginInit();
			this.bindingNavigator_Lager.SuspendLayout();
			this.tabPage_Schraube.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schrauben)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Schrauben)).BeginInit();
			this.bindingNavigator_Schrauben.SuspendLayout();
			this.tabPage_Passfeder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Passfedern)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Passfedern)).BeginInit();
			this.bindingNavigator_Passfedern.SuspendLayout();
			this.tabPage_Zahnriemen.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zahnriemen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Zahnriemen)).BeginInit();
			this.bindingNavigator_Zahnriemen.SuspendLayout();
			this.tabPage_Zahnriemenscheibe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zahnscheiben)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Zahnscheiben)).BeginInit();
			this.bindingNavigator_Zahnscheiben.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_TreeErz)).BeginInit();
			this.splitContainer_TreeErz.Panel1.SuspendLayout();
			this.splitContainer_TreeErz.Panel2.SuspendLayout();
			this.splitContainer_TreeErz.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip_Tree
			// 
			this.menuStrip_Tree.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip_Tree.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip_Tree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem,
            this.speichernAlsToolStripMenuItem,
            this.ladenToolStripMenuItem,
            this.toolStripMenuItem_trennen,
            this.löschenToolStripMenuItem});
			this.menuStrip_Tree.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_Tree.Name = "menuStrip_Tree";
			this.menuStrip_Tree.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip_Tree.Size = new System.Drawing.Size(905, 30);
			this.menuStrip_Tree.TabIndex = 0;
			this.menuStrip_Tree.Text = "menuStrip_Tree";
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Image = global::TabellenVerwalten.Properties.Resources.beenden_2;
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
			this.beendenToolStripMenuItem.Text = "Beenden";
			this.beendenToolStripMenuItem.ToolTipText = "Anwendung beenden";
			this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
			// 
			// speichernAlsToolStripMenuItem
			// 
			this.speichernAlsToolStripMenuItem.Image = global::TabellenVerwalten.Properties.Resources.SICHERN_Disk;
			this.speichernAlsToolStripMenuItem.Name = "speichernAlsToolStripMenuItem";
			this.speichernAlsToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
			this.speichernAlsToolStripMenuItem.Text = "Speichern als";
			this.speichernAlsToolStripMenuItem.ToolTipText = "Erzeugnisstruktur speichern";
			this.speichernAlsToolStripMenuItem.Click += new System.EventHandler(this.speichernAlsToolStripMenuItem_Click);
			// 
			// ladenToolStripMenuItem
			// 
			this.ladenToolStripMenuItem.Image = global::TabellenVerwalten.Properties.Resources.Oeffnen;
			this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
			this.ladenToolStripMenuItem.Size = new System.Drawing.Size(85, 28);
			this.ladenToolStripMenuItem.Text = "Laden";
			this.ladenToolStripMenuItem.ToolTipText = "Erzeugnisstruktur laden";
			this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
			// 
			// toolStripMenuItem_trennen
			// 
			this.toolStripMenuItem_trennen.Name = "toolStripMenuItem_trennen";
			this.toolStripMenuItem_trennen.Size = new System.Drawing.Size(25, 28);
			this.toolStripMenuItem_trennen.Text = "|";
			// 
			// löschenToolStripMenuItem
			// 
			this.löschenToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
			this.löschenToolStripMenuItem.Image = global::TabellenVerwalten.Properties.Resources.Löschen;
			this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
			this.löschenToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
			this.löschenToolStripMenuItem.Text = "Löschen";
			this.löschenToolStripMenuItem.ToolTipText = "Erzeugnisstruktur löschen";
			this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
			// 
			// splitContainer_Tree
			// 
			this.splitContainer_Tree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Tree.Location = new System.Drawing.Point(0, 30);
			this.splitContainer_Tree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.splitContainer_Tree.Name = "splitContainer_Tree";
			this.splitContainer_Tree.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_Tree.Panel1
			// 
			this.splitContainer_Tree.Panel1.Controls.Add(this.tabControl_Teile);
			// 
			// splitContainer_Tree.Panel2
			// 
			this.splitContainer_Tree.Panel2.Controls.Add(this.splitContainer_TreeErz);
			this.splitContainer_Tree.Panel2.Controls.Add(this.label_Info);
			this.splitContainer_Tree.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitContainer_Tree.Size = new System.Drawing.Size(905, 676);
			this.splitContainer_Tree.SplitterDistance = 374;
			this.splitContainer_Tree.SplitterWidth = 3;
			this.splitContainer_Tree.TabIndex = 5;
			// 
			// tabControl_Teile
			// 
			this.tabControl_Teile.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl_Teile.Controls.Add(this.tabPage_Kugelumlaufspindel);
			this.tabControl_Teile.Controls.Add(this.tabPage_Vorschubmotor);
			this.tabControl_Teile.Controls.Add(this.tabPage_Wälzlager);
			this.tabControl_Teile.Controls.Add(this.tabPage_Schraube);
			this.tabControl_Teile.Controls.Add(this.tabPage_Passfeder);
			this.tabControl_Teile.Controls.Add(this.tabPage_Zahnriemen);
			this.tabControl_Teile.Controls.Add(this.tabPage_Zahnriemenscheibe);
			this.tabControl_Teile.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl_Teile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl_Teile.Location = new System.Drawing.Point(0, 0);
			this.tabControl_Teile.MaximumSize = new System.Drawing.Size(0, 520);
			this.tabControl_Teile.Name = "tabControl_Teile";
			this.tabControl_Teile.SelectedIndex = 0;
			this.tabControl_Teile.Size = new System.Drawing.Size(905, 520);
			this.tabControl_Teile.TabIndex = 5;
			this.tabControl_Teile.Click += new System.EventHandler(this.toolStripButton_LagerUpdate_Click);
			// 
			// tabPage_Kugelumlaufspindel
			// 
			this.tabPage_Kugelumlaufspindel.ContextMenuStrip = this.contextMenuStrip_Tree;
			this.tabPage_Kugelumlaufspindel.Controls.Add(this.dataGridView_Spindel);
			this.tabPage_Kugelumlaufspindel.Controls.Add(this.bindingNavigator_Spindel);
			this.tabPage_Kugelumlaufspindel.Location = new System.Drawing.Point(4, 28);
			this.tabPage_Kugelumlaufspindel.Name = "tabPage_Kugelumlaufspindel";
			this.tabPage_Kugelumlaufspindel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage_Kugelumlaufspindel.Size = new System.Drawing.Size(897, 488);
			this.tabPage_Kugelumlaufspindel.TabIndex = 0;
			this.tabPage_Kugelumlaufspindel.Tag = "dataGridView_Spindel";
			this.tabPage_Kugelumlaufspindel.Text = "Kugelumlaufspindel";
			this.tabPage_Kugelumlaufspindel.UseVisualStyleBackColor = true;
			// 
			// contextMenuStrip_Tree
			// 
			this.contextMenuStrip_Tree.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip_Tree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erzeugnisAnlegenToolStripMenuItem,
            this.baugruppeAnlegenToolStripMenuItem,
            this.editierenToolStripMenuItem,
            this.toolStripSeparator1,
            this.teilBaugruppeEntfernenToolStripMenuItem});
			this.contextMenuStrip_Tree.Name = "contextMenuStrip_Tree";
			this.contextMenuStrip_Tree.Size = new System.Drawing.Size(217, 130);
			// 
			// erzeugnisAnlegenToolStripMenuItem
			// 
			this.erzeugnisAnlegenToolStripMenuItem.Image = global::TabellenVerwalten.Properties.Resources.Hinzufügen;
			this.erzeugnisAnlegenToolStripMenuItem.Name = "erzeugnisAnlegenToolStripMenuItem";
			this.erzeugnisAnlegenToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
			this.erzeugnisAnlegenToolStripMenuItem.Text = "Erzeugnis anlegen";
			this.erzeugnisAnlegenToolStripMenuItem.Click += new System.EventHandler(this.erzeugnisAnlegenToolStripMenuItem_Click);
			// 
			// baugruppeAnlegenToolStripMenuItem
			// 
			this.baugruppeAnlegenToolStripMenuItem.Image = global::TabellenVerwalten.Properties.Resources.Hinzufügen;
			this.baugruppeAnlegenToolStripMenuItem.Name = "baugruppeAnlegenToolStripMenuItem";
			this.baugruppeAnlegenToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
			this.baugruppeAnlegenToolStripMenuItem.Text = "Baugruppe anlegen";
			this.baugruppeAnlegenToolStripMenuItem.Click += new System.EventHandler(this.baugruppeAnlegenToolStripMenuItem_Click);
			// 
			// editierenToolStripMenuItem
			// 
			this.editierenToolStripMenuItem.Image = global::TabellenVerwalten.Properties.Resources.Dokument;
			this.editierenToolStripMenuItem.Name = "editierenToolStripMenuItem";
			this.editierenToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
			this.editierenToolStripMenuItem.Text = "Editieren";
			this.editierenToolStripMenuItem.Click += new System.EventHandler(this.editierenToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
			// 
			// teilBaugruppeEntfernenToolStripMenuItem
			// 
			this.teilBaugruppeEntfernenToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
			this.teilBaugruppeEntfernenToolStripMenuItem.Image = global::TabellenVerwalten.Properties.Resources.Löschen;
			this.teilBaugruppeEntfernenToolStripMenuItem.Name = "teilBaugruppeEntfernenToolStripMenuItem";
			this.teilBaugruppeEntfernenToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
			this.teilBaugruppeEntfernenToolStripMenuItem.Text = "Teil/Baugruppe entfernen";
			this.teilBaugruppeEntfernenToolStripMenuItem.Click += new System.EventHandler(this.teilBaugruppeEntfernenToolStripMenuItem_Click);
			// 
			// dataGridView_Spindel
			// 
			this.dataGridView_Spindel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Spindel.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridView_Spindel.Location = new System.Drawing.Point(3, 34);
			this.dataGridView_Spindel.Name = "dataGridView_Spindel";
			this.dataGridView_Spindel.RowHeadersWidth = 62;
			this.dataGridView_Spindel.Size = new System.Drawing.Size(891, 2168);
			this.dataGridView_Spindel.TabIndex = 1;
			// 
			// bindingNavigator_Spindel
			// 
			this.bindingNavigator_Spindel.AddNewItem = this.bindingNavigatorAddNewItem6;
			this.bindingNavigator_Spindel.CountItem = this.bindingNavigatorCountItem6;
			this.bindingNavigator_Spindel.DeleteItem = this.bindingNavigatorDeleteItem6;
			this.bindingNavigator_Spindel.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_Spindel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem6,
            this.bindingNavigatorMovePreviousItem6,
            this.bindingNavigatorSeparator18,
            this.bindingNavigatorPositionItem6,
            this.bindingNavigatorCountItem6,
            this.bindingNavigatorSeparator19,
            this.bindingNavigatorMoveNextItem6,
            this.bindingNavigatorMoveLastItem6,
            this.bindingNavigatorSeparator20,
            this.bindingNavigatorAddNewItem6,
            this.bindingNavigatorDeleteItem6,
            this.toolStripButton_SpindelUpdate,
            this.toolStripButton_AddSpindel});
			this.bindingNavigator_Spindel.Location = new System.Drawing.Point(3, 3);
			this.bindingNavigator_Spindel.MoveFirstItem = this.bindingNavigatorMoveFirstItem6;
			this.bindingNavigator_Spindel.MoveLastItem = this.bindingNavigatorMoveLastItem6;
			this.bindingNavigator_Spindel.MoveNextItem = this.bindingNavigatorMoveNextItem6;
			this.bindingNavigator_Spindel.MovePreviousItem = this.bindingNavigatorMovePreviousItem6;
			this.bindingNavigator_Spindel.Name = "bindingNavigator_Spindel";
			this.bindingNavigator_Spindel.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.bindingNavigator_Spindel.PositionItem = this.bindingNavigatorPositionItem6;
			this.bindingNavigator_Spindel.Size = new System.Drawing.Size(891, 31);
			this.bindingNavigator_Spindel.TabIndex = 0;
			this.bindingNavigator_Spindel.Text = "bindingNavigator7";
			// 
			// bindingNavigatorAddNewItem6
			// 
			this.bindingNavigatorAddNewItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem6.Image")));
			this.bindingNavigatorAddNewItem6.Name = "bindingNavigatorAddNewItem6";
			this.bindingNavigatorAddNewItem6.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem6.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorAddNewItem6.Text = "Neu hinzufügen";
			// 
			// bindingNavigatorCountItem6
			// 
			this.bindingNavigatorCountItem6.Name = "bindingNavigatorCountItem6";
			this.bindingNavigatorCountItem6.Size = new System.Drawing.Size(35, 28);
			this.bindingNavigatorCountItem6.Text = "of {0}";
			this.bindingNavigatorCountItem6.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorDeleteItem6
			// 
			this.bindingNavigatorDeleteItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem6.Image")));
			this.bindingNavigatorDeleteItem6.Name = "bindingNavigatorDeleteItem6";
			this.bindingNavigatorDeleteItem6.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem6.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorDeleteItem6.Text = "Löschen";
			// 
			// bindingNavigatorMoveFirstItem6
			// 
			this.bindingNavigatorMoveFirstItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem6.Image")));
			this.bindingNavigatorMoveFirstItem6.Name = "bindingNavigatorMoveFirstItem6";
			this.bindingNavigatorMoveFirstItem6.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem6.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveFirstItem6.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem6
			// 
			this.bindingNavigatorMovePreviousItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem6.Image")));
			this.bindingNavigatorMovePreviousItem6.Name = "bindingNavigatorMovePreviousItem6";
			this.bindingNavigatorMovePreviousItem6.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem6.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMovePreviousItem6.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator18
			// 
			this.bindingNavigatorSeparator18.Name = "bindingNavigatorSeparator18";
			this.bindingNavigatorSeparator18.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorPositionItem6
			// 
			this.bindingNavigatorPositionItem6.AccessibleName = "Position";
			this.bindingNavigatorPositionItem6.AutoSize = false;
			this.bindingNavigatorPositionItem6.Name = "bindingNavigatorPositionItem6";
			this.bindingNavigatorPositionItem6.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem6.Text = "0";
			this.bindingNavigatorPositionItem6.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorSeparator19
			// 
			this.bindingNavigatorSeparator19.Name = "bindingNavigatorSeparator19";
			this.bindingNavigatorSeparator19.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorMoveNextItem6
			// 
			this.bindingNavigatorMoveNextItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem6.Image")));
			this.bindingNavigatorMoveNextItem6.Name = "bindingNavigatorMoveNextItem6";
			this.bindingNavigatorMoveNextItem6.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem6.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveNextItem6.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem6
			// 
			this.bindingNavigatorMoveLastItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem6.Image")));
			this.bindingNavigatorMoveLastItem6.Name = "bindingNavigatorMoveLastItem6";
			this.bindingNavigatorMoveLastItem6.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem6.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveLastItem6.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator20
			// 
			this.bindingNavigatorSeparator20.Name = "bindingNavigatorSeparator20";
			this.bindingNavigatorSeparator20.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripButton_SpindelUpdate
			// 
			this.toolStripButton_SpindelUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_SpindelUpdate.Image = global::TabellenVerwalten.Properties.Resources.accept;
			this.toolStripButton_SpindelUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_SpindelUpdate.Name = "toolStripButton_SpindelUpdate";
			this.toolStripButton_SpindelUpdate.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_SpindelUpdate.Text = "toolStripButton1";
			this.toolStripButton_SpindelUpdate.ToolTipText = "Aktualisieren";
			this.toolStripButton_SpindelUpdate.Click += new System.EventHandler(this.toolStripButton_SpindelUpdate_Click);
			// 
			// toolStripButton_AddSpindel
			// 
			this.toolStripButton_AddSpindel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_AddSpindel.Image = global::TabellenVerwalten.Properties.Resources.ImportStart_1;
			this.toolStripButton_AddSpindel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_AddSpindel.Name = "toolStripButton_AddSpindel";
			this.toolStripButton_AddSpindel.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_AddSpindel.Text = "Add Spindel";
			this.toolStripButton_AddSpindel.Click += new System.EventHandler(this.toolStripButton_AddSpindel_Click);
			// 
			// tabPage_Vorschubmotor
			// 
			this.tabPage_Vorschubmotor.Controls.Add(this.dataGridView_Motor);
			this.tabPage_Vorschubmotor.Controls.Add(this.bindingNavigator_Motor);
			this.tabPage_Vorschubmotor.Location = new System.Drawing.Point(4, 28);
			this.tabPage_Vorschubmotor.Name = "tabPage_Vorschubmotor";
			this.tabPage_Vorschubmotor.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage_Vorschubmotor.Size = new System.Drawing.Size(0, 488);
			this.tabPage_Vorschubmotor.TabIndex = 1;
			this.tabPage_Vorschubmotor.Text = "Vorschubmotor";
			this.tabPage_Vorschubmotor.UseVisualStyleBackColor = true;
			// 
			// dataGridView_Motor
			// 
			this.dataGridView_Motor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Motor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Motor.Location = new System.Drawing.Point(3, 34);
			this.dataGridView_Motor.Name = "dataGridView_Motor";
			this.dataGridView_Motor.RowHeadersWidth = 62;
			this.dataGridView_Motor.Size = new System.Drawing.Size(0, 451);
			this.dataGridView_Motor.TabIndex = 1;
			// 
			// bindingNavigator_Motor
			// 
			this.bindingNavigator_Motor.AddNewItem = this.bindingNavigatorAddNewItem5;
			this.bindingNavigator_Motor.CountItem = this.bindingNavigatorCountItem5;
			this.bindingNavigator_Motor.DeleteItem = this.bindingNavigatorDeleteItem5;
			this.bindingNavigator_Motor.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_Motor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem5,
            this.bindingNavigatorMovePreviousItem5,
            this.bindingNavigatorSeparator15,
            this.bindingNavigatorPositionItem5,
            this.bindingNavigatorCountItem5,
            this.bindingNavigatorSeparator16,
            this.bindingNavigatorMoveNextItem5,
            this.bindingNavigatorMoveLastItem5,
            this.bindingNavigatorSeparator17,
            this.bindingNavigatorAddNewItem5,
            this.bindingNavigatorDeleteItem5,
            this.toolStripButton_MotorUpdate,
            this.toolStripButton_AddMotor});
			this.bindingNavigator_Motor.Location = new System.Drawing.Point(3, 3);
			this.bindingNavigator_Motor.MoveFirstItem = this.bindingNavigatorMoveFirstItem5;
			this.bindingNavigator_Motor.MoveLastItem = this.bindingNavigatorMoveLastItem5;
			this.bindingNavigator_Motor.MoveNextItem = this.bindingNavigatorMoveNextItem5;
			this.bindingNavigator_Motor.MovePreviousItem = this.bindingNavigatorMovePreviousItem5;
			this.bindingNavigator_Motor.Name = "bindingNavigator_Motor";
			this.bindingNavigator_Motor.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.bindingNavigator_Motor.PositionItem = this.bindingNavigatorPositionItem5;
			this.bindingNavigator_Motor.Size = new System.Drawing.Size(0, 31);
			this.bindingNavigator_Motor.TabIndex = 0;
			this.bindingNavigator_Motor.Text = "bindingNavigator6";
			// 
			// bindingNavigatorAddNewItem5
			// 
			this.bindingNavigatorAddNewItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem5.Image")));
			this.bindingNavigatorAddNewItem5.Name = "bindingNavigatorAddNewItem5";
			this.bindingNavigatorAddNewItem5.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem5.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorAddNewItem5.Text = "Neu hinzufügen";
			// 
			// bindingNavigatorCountItem5
			// 
			this.bindingNavigatorCountItem5.Name = "bindingNavigatorCountItem5";
			this.bindingNavigatorCountItem5.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem5.Text = "of {0}";
			this.bindingNavigatorCountItem5.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorDeleteItem5
			// 
			this.bindingNavigatorDeleteItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem5.Image")));
			this.bindingNavigatorDeleteItem5.Name = "bindingNavigatorDeleteItem5";
			this.bindingNavigatorDeleteItem5.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem5.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorDeleteItem5.Text = "Löschen";
			// 
			// bindingNavigatorMoveFirstItem5
			// 
			this.bindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem5.Image")));
			this.bindingNavigatorMoveFirstItem5.Name = "bindingNavigatorMoveFirstItem5";
			this.bindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem5.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveFirstItem5.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem5
			// 
			this.bindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem5.Image")));
			this.bindingNavigatorMovePreviousItem5.Name = "bindingNavigatorMovePreviousItem5";
			this.bindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem5.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMovePreviousItem5.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator15
			// 
			this.bindingNavigatorSeparator15.Name = "bindingNavigatorSeparator15";
			this.bindingNavigatorSeparator15.Size = new System.Drawing.Size(6, 33);
			// 
			// bindingNavigatorPositionItem5
			// 
			this.bindingNavigatorPositionItem5.AccessibleName = "Position";
			this.bindingNavigatorPositionItem5.AutoSize = false;
			this.bindingNavigatorPositionItem5.Name = "bindingNavigatorPositionItem5";
			this.bindingNavigatorPositionItem5.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem5.Text = "0";
			this.bindingNavigatorPositionItem5.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorSeparator16
			// 
			this.bindingNavigatorSeparator16.Name = "bindingNavigatorSeparator16";
			this.bindingNavigatorSeparator16.Size = new System.Drawing.Size(6, 33);
			// 
			// bindingNavigatorMoveNextItem5
			// 
			this.bindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem5.Image")));
			this.bindingNavigatorMoveNextItem5.Name = "bindingNavigatorMoveNextItem5";
			this.bindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem5.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveNextItem5.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem5
			// 
			this.bindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem5.Image")));
			this.bindingNavigatorMoveLastItem5.Name = "bindingNavigatorMoveLastItem5";
			this.bindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem5.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveLastItem5.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator17
			// 
			this.bindingNavigatorSeparator17.Name = "bindingNavigatorSeparator17";
			this.bindingNavigatorSeparator17.Size = new System.Drawing.Size(6, 33);
			// 
			// toolStripButton_MotorUpdate
			// 
			this.toolStripButton_MotorUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_MotorUpdate.Image = global::TabellenVerwalten.Properties.Resources.accept;
			this.toolStripButton_MotorUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_MotorUpdate.Name = "toolStripButton_MotorUpdate";
			this.toolStripButton_MotorUpdate.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_MotorUpdate.Text = "toolStripButton1";
			this.toolStripButton_MotorUpdate.ToolTipText = "Aktualisieren";
			this.toolStripButton_MotorUpdate.Click += new System.EventHandler(this.toolStripButton_MotorUpdate_Click);
			// 
			// toolStripButton_AddMotor
			// 
			this.toolStripButton_AddMotor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_AddMotor.Image = global::TabellenVerwalten.Properties.Resources.ImportStart_1;
			this.toolStripButton_AddMotor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_AddMotor.Name = "toolStripButton_AddMotor";
			this.toolStripButton_AddMotor.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_AddMotor.Text = " Add Vorschubmotor";
			this.toolStripButton_AddMotor.Click += new System.EventHandler(this.toolStripButton_AddMotor_Click);
			// 
			// tabPage_Wälzlager
			// 
			this.tabPage_Wälzlager.Controls.Add(this.dataGridView_Lager);
			this.tabPage_Wälzlager.Controls.Add(this.bindingNavigator_Lager);
			this.tabPage_Wälzlager.Location = new System.Drawing.Point(4, 28);
			this.tabPage_Wälzlager.Name = "tabPage_Wälzlager";
			this.tabPage_Wälzlager.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage_Wälzlager.Size = new System.Drawing.Size(0, 488);
			this.tabPage_Wälzlager.TabIndex = 2;
			this.tabPage_Wälzlager.Text = "Wälzlager";
			this.tabPage_Wälzlager.UseVisualStyleBackColor = true;
			// 
			// dataGridView_Lager
			// 
			this.dataGridView_Lager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Lager.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Lager.Location = new System.Drawing.Point(3, 34);
			this.dataGridView_Lager.Name = "dataGridView_Lager";
			this.dataGridView_Lager.RowHeadersWidth = 62;
			this.dataGridView_Lager.Size = new System.Drawing.Size(0, 451);
			this.dataGridView_Lager.TabIndex = 1;
			// 
			// bindingNavigator_Lager
			// 
			this.bindingNavigator_Lager.AddNewItem = this.bindingNavigatorAddNewItem4;
			this.bindingNavigator_Lager.CountItem = this.bindingNavigatorCountItem4;
			this.bindingNavigator_Lager.DeleteItem = this.bindingNavigatorDeleteItem4;
			this.bindingNavigator_Lager.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_Lager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.bindingNavigatorAddNewItem4,
            this.bindingNavigatorDeleteItem4,
            this.toolStripButton_LagerUpdate,
            this.toolStripButton_AddLager});
			this.bindingNavigator_Lager.Location = new System.Drawing.Point(3, 3);
			this.bindingNavigator_Lager.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
			this.bindingNavigator_Lager.MoveLastItem = this.bindingNavigatorMoveLastItem4;
			this.bindingNavigator_Lager.MoveNextItem = this.bindingNavigatorMoveNextItem4;
			this.bindingNavigator_Lager.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
			this.bindingNavigator_Lager.Name = "bindingNavigator_Lager";
			this.bindingNavigator_Lager.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.bindingNavigator_Lager.PositionItem = this.bindingNavigatorPositionItem4;
			this.bindingNavigator_Lager.Size = new System.Drawing.Size(0, 31);
			this.bindingNavigator_Lager.TabIndex = 0;
			this.bindingNavigator_Lager.Text = "bindingNavigator5";
			// 
			// bindingNavigatorAddNewItem4
			// 
			this.bindingNavigatorAddNewItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem4.Image")));
			this.bindingNavigatorAddNewItem4.Name = "bindingNavigatorAddNewItem4";
			this.bindingNavigatorAddNewItem4.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem4.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorAddNewItem4.Text = "Neu hinzufügen";
			// 
			// bindingNavigatorCountItem4
			// 
			this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
			this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem4.Text = "of {0}";
			this.bindingNavigatorCountItem4.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorDeleteItem4
			// 
			this.bindingNavigatorDeleteItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem4.Image")));
			this.bindingNavigatorDeleteItem4.Name = "bindingNavigatorDeleteItem4";
			this.bindingNavigatorDeleteItem4.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem4.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorDeleteItem4.Text = "Löschen";
			// 
			// bindingNavigatorMoveFirstItem4
			// 
			this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
			this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
			this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveFirstItem4.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem4
			// 
			this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
			this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
			this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMovePreviousItem4.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator12
			// 
			this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
			this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 33);
			// 
			// bindingNavigatorPositionItem4
			// 
			this.bindingNavigatorPositionItem4.AccessibleName = "Position";
			this.bindingNavigatorPositionItem4.AutoSize = false;
			this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
			this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem4.Text = "0";
			this.bindingNavigatorPositionItem4.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorSeparator13
			// 
			this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
			this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 33);
			// 
			// bindingNavigatorMoveNextItem4
			// 
			this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
			this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
			this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveNextItem4.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem4
			// 
			this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
			this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
			this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveLastItem4.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator14
			// 
			this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
			this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 33);
			// 
			// toolStripButton_LagerUpdate
			// 
			this.toolStripButton_LagerUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_LagerUpdate.Image = global::TabellenVerwalten.Properties.Resources.accept;
			this.toolStripButton_LagerUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_LagerUpdate.Name = "toolStripButton_LagerUpdate";
			this.toolStripButton_LagerUpdate.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_LagerUpdate.Text = "toolStripButton1";
			this.toolStripButton_LagerUpdate.ToolTipText = "Aktualisieren";
			// 
			// toolStripButton_AddLager
			// 
			this.toolStripButton_AddLager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_AddLager.Image = global::TabellenVerwalten.Properties.Resources.ImportStart_1;
			this.toolStripButton_AddLager.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_AddLager.Name = "toolStripButton_AddLager";
			this.toolStripButton_AddLager.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_AddLager.Text = "Add Wälzlager";
			this.toolStripButton_AddLager.Click += new System.EventHandler(this.toolStripButton_AddLager_Click);
			// 
			// tabPage_Schraube
			// 
			this.tabPage_Schraube.Controls.Add(this.dataGridView_Schrauben);
			this.tabPage_Schraube.Controls.Add(this.bindingNavigator_Schrauben);
			this.tabPage_Schraube.Location = new System.Drawing.Point(4, 28);
			this.tabPage_Schraube.Name = "tabPage_Schraube";
			this.tabPage_Schraube.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage_Schraube.Size = new System.Drawing.Size(0, 488);
			this.tabPage_Schraube.TabIndex = 3;
			this.tabPage_Schraube.Text = "Schraube";
			this.tabPage_Schraube.UseVisualStyleBackColor = true;
			// 
			// dataGridView_Schrauben
			// 
			this.dataGridView_Schrauben.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Schrauben.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Schrauben.Location = new System.Drawing.Point(3, 34);
			this.dataGridView_Schrauben.Name = "dataGridView_Schrauben";
			this.dataGridView_Schrauben.RowHeadersWidth = 62;
			this.dataGridView_Schrauben.Size = new System.Drawing.Size(0, 451);
			this.dataGridView_Schrauben.TabIndex = 1;
			// 
			// bindingNavigator_Schrauben
			// 
			this.bindingNavigator_Schrauben.AddNewItem = this.bindingNavigatorAddNewItem3;
			this.bindingNavigator_Schrauben.CountItem = this.bindingNavigatorCountItem3;
			this.bindingNavigator_Schrauben.DeleteItem = this.bindingNavigatorDeleteItem3;
			this.bindingNavigator_Schrauben.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_Schrauben.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3,
            this.toolStripButton_SchraubenUpdate,
            this.toolStripButton_AddSchraube});
			this.bindingNavigator_Schrauben.Location = new System.Drawing.Point(3, 3);
			this.bindingNavigator_Schrauben.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
			this.bindingNavigator_Schrauben.MoveLastItem = this.bindingNavigatorMoveLastItem3;
			this.bindingNavigator_Schrauben.MoveNextItem = this.bindingNavigatorMoveNextItem3;
			this.bindingNavigator_Schrauben.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
			this.bindingNavigator_Schrauben.Name = "bindingNavigator_Schrauben";
			this.bindingNavigator_Schrauben.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.bindingNavigator_Schrauben.PositionItem = this.bindingNavigatorPositionItem3;
			this.bindingNavigator_Schrauben.Size = new System.Drawing.Size(0, 31);
			this.bindingNavigator_Schrauben.TabIndex = 0;
			this.bindingNavigator_Schrauben.Text = "bindingNavigator4";
			this.bindingNavigator_Schrauben.Click += new System.EventHandler(this.toolStripButton_SchraubenUpdate_Click);
			// 
			// bindingNavigatorAddNewItem3
			// 
			this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
			this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
			this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorAddNewItem3.Text = "Neu hinzufügen";
			// 
			// bindingNavigatorCountItem3
			// 
			this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
			this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem3.Text = "of {0}";
			this.bindingNavigatorCountItem3.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorDeleteItem3
			// 
			this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
			this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
			this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorDeleteItem3.Text = "Löschen";
			// 
			// bindingNavigatorMoveFirstItem3
			// 
			this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
			this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
			this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveFirstItem3.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem3
			// 
			this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
			this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
			this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMovePreviousItem3.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator9
			// 
			this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
			this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 33);
			// 
			// bindingNavigatorPositionItem3
			// 
			this.bindingNavigatorPositionItem3.AccessibleName = "Position";
			this.bindingNavigatorPositionItem3.AutoSize = false;
			this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
			this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem3.Text = "0";
			this.bindingNavigatorPositionItem3.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorSeparator10
			// 
			this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
			this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 33);
			// 
			// bindingNavigatorMoveNextItem3
			// 
			this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
			this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
			this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveNextItem3.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem3
			// 
			this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
			this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
			this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveLastItem3.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator11
			// 
			this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
			this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 33);
			// 
			// toolStripButton_SchraubenUpdate
			// 
			this.toolStripButton_SchraubenUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_SchraubenUpdate.Image = global::TabellenVerwalten.Properties.Resources.accept;
			this.toolStripButton_SchraubenUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_SchraubenUpdate.Name = "toolStripButton_SchraubenUpdate";
			this.toolStripButton_SchraubenUpdate.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_SchraubenUpdate.Text = "toolStripButton1";
			this.toolStripButton_SchraubenUpdate.ToolTipText = "Aktualisieren";
			// 
			// toolStripButton_AddSchraube
			// 
			this.toolStripButton_AddSchraube.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_AddSchraube.Image = global::TabellenVerwalten.Properties.Resources.ImportStart_1;
			this.toolStripButton_AddSchraube.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_AddSchraube.Name = "toolStripButton_AddSchraube";
			this.toolStripButton_AddSchraube.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_AddSchraube.Text = "Add Schraube";
			this.toolStripButton_AddSchraube.Click += new System.EventHandler(this.toolStripButton_AddSchraube_Click);
			// 
			// tabPage_Passfeder
			// 
			this.tabPage_Passfeder.Controls.Add(this.dataGridView_Passfedern);
			this.tabPage_Passfeder.Controls.Add(this.bindingNavigator_Passfedern);
			this.tabPage_Passfeder.Location = new System.Drawing.Point(4, 28);
			this.tabPage_Passfeder.Name = "tabPage_Passfeder";
			this.tabPage_Passfeder.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage_Passfeder.Size = new System.Drawing.Size(0, 488);
			this.tabPage_Passfeder.TabIndex = 4;
			this.tabPage_Passfeder.Text = "Passfeder";
			this.tabPage_Passfeder.UseVisualStyleBackColor = true;
			// 
			// dataGridView_Passfedern
			// 
			this.dataGridView_Passfedern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Passfedern.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Passfedern.Location = new System.Drawing.Point(3, 34);
			this.dataGridView_Passfedern.Name = "dataGridView_Passfedern";
			this.dataGridView_Passfedern.RowHeadersWidth = 62;
			this.dataGridView_Passfedern.Size = new System.Drawing.Size(0, 451);
			this.dataGridView_Passfedern.TabIndex = 1;
			// 
			// bindingNavigator_Passfedern
			// 
			this.bindingNavigator_Passfedern.AddNewItem = this.bindingNavigatorAddNewItem2;
			this.bindingNavigator_Passfedern.CountItem = this.bindingNavigatorCountItem2;
			this.bindingNavigator_Passfedern.DeleteItem = this.bindingNavigatorDeleteItem2;
			this.bindingNavigator_Passfedern.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_Passfedern.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2,
            this.toolStripButton_PassfedernUpdate,
            this.toolStripButton_Passfeder});
			this.bindingNavigator_Passfedern.Location = new System.Drawing.Point(3, 3);
			this.bindingNavigator_Passfedern.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
			this.bindingNavigator_Passfedern.MoveLastItem = this.bindingNavigatorMoveLastItem2;
			this.bindingNavigator_Passfedern.MoveNextItem = this.bindingNavigatorMoveNextItem2;
			this.bindingNavigator_Passfedern.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
			this.bindingNavigator_Passfedern.Name = "bindingNavigator_Passfedern";
			this.bindingNavigator_Passfedern.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.bindingNavigator_Passfedern.PositionItem = this.bindingNavigatorPositionItem2;
			this.bindingNavigator_Passfedern.Size = new System.Drawing.Size(0, 31);
			this.bindingNavigator_Passfedern.TabIndex = 0;
			this.bindingNavigator_Passfedern.Text = "bindingNavigator3";
			this.bindingNavigator_Passfedern.Click += new System.EventHandler(this.toolStripButton_PassfedernUpdate_Click);
			// 
			// bindingNavigatorAddNewItem2
			// 
			this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
			this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
			this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorAddNewItem2.Text = "Neu hinzufügen";
			// 
			// bindingNavigatorCountItem2
			// 
			this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
			this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem2.Text = "of {0}";
			this.bindingNavigatorCountItem2.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorDeleteItem2
			// 
			this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
			this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
			this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorDeleteItem2.Text = "Löschen";
			// 
			// bindingNavigatorMoveFirstItem2
			// 
			this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
			this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
			this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveFirstItem2.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem2
			// 
			this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
			this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
			this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMovePreviousItem2.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator6
			// 
			this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
			this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 33);
			// 
			// bindingNavigatorPositionItem2
			// 
			this.bindingNavigatorPositionItem2.AccessibleName = "Position";
			this.bindingNavigatorPositionItem2.AutoSize = false;
			this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
			this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem2.Text = "0";
			this.bindingNavigatorPositionItem2.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorSeparator7
			// 
			this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
			this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 33);
			// 
			// bindingNavigatorMoveNextItem2
			// 
			this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
			this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
			this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveNextItem2.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem2
			// 
			this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
			this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
			this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveLastItem2.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator8
			// 
			this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
			this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 33);
			// 
			// toolStripButton_PassfedernUpdate
			// 
			this.toolStripButton_PassfedernUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_PassfedernUpdate.Image = global::TabellenVerwalten.Properties.Resources.accept;
			this.toolStripButton_PassfedernUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_PassfedernUpdate.Name = "toolStripButton_PassfedernUpdate";
			this.toolStripButton_PassfedernUpdate.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_PassfedernUpdate.Text = "toolStripButton1";
			this.toolStripButton_PassfedernUpdate.ToolTipText = "Aktualisieren";
			// 
			// toolStripButton_Passfeder
			// 
			this.toolStripButton_Passfeder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_Passfeder.Image = global::TabellenVerwalten.Properties.Resources.ImportStart_1;
			this.toolStripButton_Passfeder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Passfeder.Name = "toolStripButton_Passfeder";
			this.toolStripButton_Passfeder.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_Passfeder.Text = "Add Passfeder";
			this.toolStripButton_Passfeder.Click += new System.EventHandler(this.toolStripButton_Passfeder_Click);
			// 
			// tabPage_Zahnriemen
			// 
			this.tabPage_Zahnriemen.Controls.Add(this.dataGridView_Zahnriemen);
			this.tabPage_Zahnriemen.Controls.Add(this.bindingNavigator_Zahnriemen);
			this.tabPage_Zahnriemen.Location = new System.Drawing.Point(4, 28);
			this.tabPage_Zahnriemen.Name = "tabPage_Zahnriemen";
			this.tabPage_Zahnriemen.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage_Zahnriemen.Size = new System.Drawing.Size(0, 488);
			this.tabPage_Zahnriemen.TabIndex = 5;
			this.tabPage_Zahnriemen.Text = "Zahnriemen";
			this.tabPage_Zahnriemen.UseVisualStyleBackColor = true;
			// 
			// dataGridView_Zahnriemen
			// 
			this.dataGridView_Zahnriemen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Zahnriemen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Zahnriemen.Location = new System.Drawing.Point(3, 34);
			this.dataGridView_Zahnriemen.Name = "dataGridView_Zahnriemen";
			this.dataGridView_Zahnriemen.RowHeadersWidth = 62;
			this.dataGridView_Zahnriemen.Size = new System.Drawing.Size(0, 451);
			this.dataGridView_Zahnriemen.TabIndex = 1;
			// 
			// bindingNavigator_Zahnriemen
			// 
			this.bindingNavigator_Zahnriemen.AddNewItem = this.bindingNavigatorAddNewItem1;
			this.bindingNavigator_Zahnriemen.CountItem = this.bindingNavigatorCountItem1;
			this.bindingNavigator_Zahnriemen.DeleteItem = this.bindingNavigatorDeleteItem1;
			this.bindingNavigator_Zahnriemen.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_Zahnriemen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton_ZahnriemenUpdate,
            this.toolStripButton_AddZahnriemen});
			this.bindingNavigator_Zahnriemen.Location = new System.Drawing.Point(3, 3);
			this.bindingNavigator_Zahnriemen.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
			this.bindingNavigator_Zahnriemen.MoveLastItem = this.bindingNavigatorMoveLastItem1;
			this.bindingNavigator_Zahnriemen.MoveNextItem = this.bindingNavigatorMoveNextItem1;
			this.bindingNavigator_Zahnriemen.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
			this.bindingNavigator_Zahnriemen.Name = "bindingNavigator_Zahnriemen";
			this.bindingNavigator_Zahnriemen.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.bindingNavigator_Zahnriemen.PositionItem = this.bindingNavigatorPositionItem1;
			this.bindingNavigator_Zahnriemen.Size = new System.Drawing.Size(0, 31);
			this.bindingNavigator_Zahnriemen.TabIndex = 0;
			this.bindingNavigator_Zahnriemen.Text = "bindingNavigator2";
			this.bindingNavigator_Zahnriemen.Click += new System.EventHandler(this.toolStripButton_ZahnriemenUpdate_Click);
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
			this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem1.Text = "of {0}";
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
			this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 33);
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
			this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 33);
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
			this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 33);
			// 
			// toolStripButton_ZahnriemenUpdate
			// 
			this.toolStripButton_ZahnriemenUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_ZahnriemenUpdate.Image = global::TabellenVerwalten.Properties.Resources.accept;
			this.toolStripButton_ZahnriemenUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_ZahnriemenUpdate.Name = "toolStripButton_ZahnriemenUpdate";
			this.toolStripButton_ZahnriemenUpdate.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_ZahnriemenUpdate.Text = "toolStripButton1";
			this.toolStripButton_ZahnriemenUpdate.ToolTipText = "Aktualisieren";
			this.toolStripButton_ZahnriemenUpdate.Click += new System.EventHandler(this.toolStripButton_ZahnriemenUpdate_Click);
			// 
			// toolStripButton_AddZahnriemen
			// 
			this.toolStripButton_AddZahnriemen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_AddZahnriemen.Image = global::TabellenVerwalten.Properties.Resources.ImportStart_1;
			this.toolStripButton_AddZahnriemen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_AddZahnriemen.Name = "toolStripButton_AddZahnriemen";
			this.toolStripButton_AddZahnriemen.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_AddZahnriemen.Text = "Add Zahnriemen";
			this.toolStripButton_AddZahnriemen.Click += new System.EventHandler(this.toolStripButton_AddZahnriemen_Click);
			// 
			// tabPage_Zahnriemenscheibe
			// 
			this.tabPage_Zahnriemenscheibe.Controls.Add(this.dataGridView_Zahnscheiben);
			this.tabPage_Zahnriemenscheibe.Controls.Add(this.bindingNavigator_Zahnscheiben);
			this.tabPage_Zahnriemenscheibe.Location = new System.Drawing.Point(4, 28);
			this.tabPage_Zahnriemenscheibe.Name = "tabPage_Zahnriemenscheibe";
			this.tabPage_Zahnriemenscheibe.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage_Zahnriemenscheibe.Size = new System.Drawing.Size(0, 488);
			this.tabPage_Zahnriemenscheibe.TabIndex = 6;
			this.tabPage_Zahnriemenscheibe.Text = "Zahnriemenscheibe";
			this.tabPage_Zahnriemenscheibe.UseVisualStyleBackColor = true;
			// 
			// dataGridView_Zahnscheiben
			// 
			this.dataGridView_Zahnscheiben.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Zahnscheiben.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Zahnscheiben.Location = new System.Drawing.Point(3, 34);
			this.dataGridView_Zahnscheiben.Name = "dataGridView_Zahnscheiben";
			this.dataGridView_Zahnscheiben.RowHeadersWidth = 62;
			this.dataGridView_Zahnscheiben.Size = new System.Drawing.Size(0, 451);
			this.dataGridView_Zahnscheiben.TabIndex = 1;
			// 
			// bindingNavigator_Zahnscheiben
			// 
			this.bindingNavigator_Zahnscheiben.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator_Zahnscheiben.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator_Zahnscheiben.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator_Zahnscheiben.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_Zahnscheiben.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton_ZahnscheibenUpdate,
            this.toolStripButton_AddZahnscheibe,
            this.toolStripButton1});
			this.bindingNavigator_Zahnscheiben.Location = new System.Drawing.Point(3, 3);
			this.bindingNavigator_Zahnscheiben.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator_Zahnscheiben.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator_Zahnscheiben.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator_Zahnscheiben.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator_Zahnscheiben.Name = "bindingNavigator_Zahnscheiben";
			this.bindingNavigator_Zahnscheiben.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.bindingNavigator_Zahnscheiben.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator_Zahnscheiben.Size = new System.Drawing.Size(0, 31);
			this.bindingNavigator_Zahnscheiben.TabIndex = 0;
			this.bindingNavigator_Zahnscheiben.Text = "bindingNavigator1";
			this.bindingNavigator_Zahnscheiben.Click += new System.EventHandler(this.toolStripButton_ZahnscheibenUpdate_Click);
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
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem.Text = "of {0}";
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
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
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
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
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
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
			// 
			// toolStripButton_ZahnscheibenUpdate
			// 
			this.toolStripButton_ZahnscheibenUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_ZahnscheibenUpdate.Image = global::TabellenVerwalten.Properties.Resources.accept;
			this.toolStripButton_ZahnscheibenUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_ZahnscheibenUpdate.Name = "toolStripButton_ZahnscheibenUpdate";
			this.toolStripButton_ZahnscheibenUpdate.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_ZahnscheibenUpdate.Text = "toolStripButton1";
			this.toolStripButton_ZahnscheibenUpdate.ToolTipText = "Aktualisieren";
			this.toolStripButton_ZahnscheibenUpdate.Click += new System.EventHandler(this.toolStripButton_ZahnscheibenUpdate_Click);
			// 
			// toolStripButton_AddZahnscheibe
			// 
			this.toolStripButton_AddZahnscheibe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_AddZahnscheibe.Image = global::TabellenVerwalten.Properties.Resources.ImportStart_1;
			this.toolStripButton_AddZahnscheibe.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_AddZahnscheibe.Name = "toolStripButton_AddZahnscheibe";
			this.toolStripButton_AddZahnscheibe.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_AddZahnscheibe.Text = "Add Zahnriemenscheibe";
			this.toolStripButton_AddZahnscheibe.Click += new System.EventHandler(this.toolStripButton_AddZahnscheibe_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// splitContainer_TreeErz
			// 
			this.splitContainer_TreeErz.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_TreeErz.Location = new System.Drawing.Point(0, 0);
			this.splitContainer_TreeErz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.splitContainer_TreeErz.Name = "splitContainer_TreeErz";
			this.splitContainer_TreeErz.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_TreeErz.Panel1
			// 
			this.splitContainer_TreeErz.Panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.splitContainer_TreeErz.Panel1.Controls.Add(this.label_Tree);
			// 
			// splitContainer_TreeErz.Panel2
			// 
			this.splitContainer_TreeErz.Panel2.Controls.Add(this.textBox_edit);
			this.splitContainer_TreeErz.Panel2.Controls.Add(this.treeView_Erz);
			this.splitContainer_TreeErz.Size = new System.Drawing.Size(905, 283);
			this.splitContainer_TreeErz.SplitterDistance = 25;
			this.splitContainer_TreeErz.SplitterWidth = 3;
			this.splitContainer_TreeErz.TabIndex = 6;
			// 
			// label_Tree
			// 
			this.label_Tree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Tree.ForeColor = System.Drawing.Color.White;
			this.label_Tree.Location = new System.Drawing.Point(0, 0);
			this.label_Tree.Name = "label_Tree";
			this.label_Tree.Size = new System.Drawing.Size(905, 25);
			this.label_Tree.TabIndex = 0;
			this.label_Tree.Text = "Erzeugnisstruktur";
			this.label_Tree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox_edit
			// 
			this.textBox_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_edit.Location = new System.Drawing.Point(564, 14);
			this.textBox_edit.MinimumSize = new System.Drawing.Size(120, 18);
			this.textBox_edit.Name = "textBox_edit";
			this.textBox_edit.Size = new System.Drawing.Size(329, 22);
			this.textBox_edit.TabIndex = 2;
			this.textBox_edit.Visible = false;
			this.textBox_edit.Leave += new System.EventHandler(this.textBox_Leave);
			// 
			// treeView_Erz
			// 
			this.treeView_Erz.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.treeView_Erz.ContextMenuStrip = this.contextMenuStrip_Tree;
			this.treeView_Erz.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView_Erz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeView_Erz.Location = new System.Drawing.Point(0, 0);
			this.treeView_Erz.Name = "treeView_Erz";
			this.treeView_Erz.Size = new System.Drawing.Size(905, 255);
			this.treeView_Erz.TabIndex = 1;
			this.treeView_Erz.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Erz_AfterSelect);
			// 
			// label_Info
			// 
			this.label_Info.AutoSize = true;
			this.label_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label_Info.Location = new System.Drawing.Point(0, 283);
			this.label_Info.Name = "label_Info";
			this.label_Info.Size = new System.Drawing.Size(29, 16);
			this.label_Info.TabIndex = 1;
			this.label_Info.Text = "Info";
			// 
			// Form_Tree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(905, 706);
			this.Controls.Add(this.splitContainer_Tree);
			this.Controls.Add(this.menuStrip_Tree);
			this.MainMenuStrip = this.menuStrip_Tree;
			this.Name = "Form_Tree";
			this.Text = "Erzeugnisstruktur";
			this.Load += new System.EventHandler(this.Form_TabOrg_Load);
			this.menuStrip_Tree.ResumeLayout(false);
			this.menuStrip_Tree.PerformLayout();
			this.splitContainer_Tree.Panel1.ResumeLayout(false);
			this.splitContainer_Tree.Panel2.ResumeLayout(false);
			this.splitContainer_Tree.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Tree)).EndInit();
			this.splitContainer_Tree.ResumeLayout(false);
			this.tabControl_Teile.ResumeLayout(false);
			this.tabPage_Kugelumlaufspindel.ResumeLayout(false);
			this.tabPage_Kugelumlaufspindel.PerformLayout();
			this.contextMenuStrip_Tree.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spindel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Spindel)).EndInit();
			this.bindingNavigator_Spindel.ResumeLayout(false);
			this.bindingNavigator_Spindel.PerformLayout();
			this.tabPage_Vorschubmotor.ResumeLayout(false);
			this.tabPage_Vorschubmotor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Motor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Motor)).EndInit();
			this.bindingNavigator_Motor.ResumeLayout(false);
			this.bindingNavigator_Motor.PerformLayout();
			this.tabPage_Wälzlager.ResumeLayout(false);
			this.tabPage_Wälzlager.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Lager)).EndInit();
			this.bindingNavigator_Lager.ResumeLayout(false);
			this.bindingNavigator_Lager.PerformLayout();
			this.tabPage_Schraube.ResumeLayout(false);
			this.tabPage_Schraube.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schrauben)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Schrauben)).EndInit();
			this.bindingNavigator_Schrauben.ResumeLayout(false);
			this.bindingNavigator_Schrauben.PerformLayout();
			this.tabPage_Passfeder.ResumeLayout(false);
			this.tabPage_Passfeder.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Passfedern)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Passfedern)).EndInit();
			this.bindingNavigator_Passfedern.ResumeLayout(false);
			this.bindingNavigator_Passfedern.PerformLayout();
			this.tabPage_Zahnriemen.ResumeLayout(false);
			this.tabPage_Zahnriemen.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zahnriemen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Zahnriemen)).EndInit();
			this.bindingNavigator_Zahnriemen.ResumeLayout(false);
			this.bindingNavigator_Zahnriemen.PerformLayout();
			this.tabPage_Zahnriemenscheibe.ResumeLayout(false);
			this.tabPage_Zahnriemenscheibe.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zahnscheiben)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Zahnscheiben)).EndInit();
			this.bindingNavigator_Zahnscheiben.ResumeLayout(false);
			this.bindingNavigator_Zahnscheiben.PerformLayout();
			this.splitContainer_TreeErz.Panel1.ResumeLayout(false);
			this.splitContainer_TreeErz.Panel2.ResumeLayout(false);
			this.splitContainer_TreeErz.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_TreeErz)).EndInit();
			this.splitContainer_TreeErz.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip_Tree;
		private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer_Tree;
		private System.Windows.Forms.TabControl tabControl_Teile;
		private System.Windows.Forms.TabPage tabPage_Kugelumlaufspindel;
		private System.Windows.Forms.DataGridView dataGridView_Spindel;
		private System.Windows.Forms.BindingNavigator bindingNavigator_Spindel;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem6;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem6;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem6;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem6;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem6;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator18;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem6;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator19;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem6;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem6;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator20;
		private System.Windows.Forms.ToolStripButton toolStripButton_SpindelUpdate;
		private System.Windows.Forms.ToolStripButton toolStripButton_AddSpindel;
		private System.Windows.Forms.TabPage tabPage_Vorschubmotor;
		private System.Windows.Forms.DataGridView dataGridView_Motor;
		private System.Windows.Forms.BindingNavigator bindingNavigator_Motor;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem5;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem5;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem5;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem5;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem5;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator15;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem5;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator16;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem5;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem5;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator17;
		private System.Windows.Forms.ToolStripButton toolStripButton_MotorUpdate;
		private System.Windows.Forms.TabPage tabPage_Wälzlager;
		private System.Windows.Forms.DataGridView dataGridView_Lager;
		private System.Windows.Forms.BindingNavigator bindingNavigator_Lager;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem4;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem4;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
		private System.Windows.Forms.ToolStripButton toolStripButton_LagerUpdate;
		private System.Windows.Forms.TabPage tabPage_Schraube;
		private System.Windows.Forms.DataGridView dataGridView_Schrauben;
		private System.Windows.Forms.BindingNavigator bindingNavigator_Schrauben;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
		private System.Windows.Forms.ToolStripButton toolStripButton_SchraubenUpdate;
		private System.Windows.Forms.TabPage tabPage_Passfeder;
		private System.Windows.Forms.DataGridView dataGridView_Passfedern;
		private System.Windows.Forms.BindingNavigator bindingNavigator_Passfedern;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
		private System.Windows.Forms.ToolStripButton toolStripButton_PassfedernUpdate;
		private System.Windows.Forms.TabPage tabPage_Zahnriemen;
		private System.Windows.Forms.DataGridView dataGridView_Zahnriemen;
		private System.Windows.Forms.BindingNavigator bindingNavigator_Zahnriemen;
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
		private System.Windows.Forms.ToolStripButton toolStripButton_ZahnriemenUpdate;
		private System.Windows.Forms.TabPage tabPage_Zahnriemenscheibe;
		private System.Windows.Forms.DataGridView dataGridView_Zahnscheiben;
		private System.Windows.Forms.BindingNavigator bindingNavigator_Zahnscheiben;
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
		private System.Windows.Forms.ToolStripButton toolStripButton_ZahnscheibenUpdate;
		private Label label_Info;
		private ContextMenuStrip contextMenuStrip_Tree;
		private ToolStripMenuItem erzeugnisAnlegenToolStripMenuItem;
		private ToolStripMenuItem baugruppeAnlegenToolStripMenuItem;
		private ToolStripMenuItem teilBaugruppeEntfernenToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem speichernAlsToolStripMenuItem;
		private ToolStripMenuItem ladenToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem_trennen;
		private ToolStripMenuItem löschenToolStripMenuItem;
		private ToolStripMenuItem editierenToolStripMenuItem;
		private SplitContainer splitContainer_TreeErz;
		private TreeView treeView_Erz;
		public TextBox textBox_edit;
		private Label label_Tree;
		private ToolStripButton toolStripButton_AddMotor;
		private ToolStripButton toolStripButton_AddLager;
		private ToolStripButton toolStripButton_AddSchraube;
		private ToolStripButton toolStripButton_Passfeder;
		private ToolStripButton toolStripButton_AddZahnriemen;
		private ToolStripButton toolStripButton_AddZahnscheibe;
		private ToolStripButton toolStripButton1;
	}
}

