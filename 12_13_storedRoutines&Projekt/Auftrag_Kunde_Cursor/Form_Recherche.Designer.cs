namespace Auftrag_Kunde
{
  partial class Form_Recherche
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Recherche));
			this.tabControl_Recherche = new System.Windows.Forms.TabControl();
			this.tabPage_Durchlaufzeit = new System.Windows.Forms.TabPage();
			this.splitContainer_RechercheDurchlaufzeit = new System.Windows.Forms.SplitContainer();
			this.bindingNavigator_DLZ = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.toolStripButton_RechercheAuftragsdurchlauf = new System.Windows.Forms.ToolStripButton();
			this.label_RechercheDurchlaufzeitHinweis = new System.Windows.Forms.Label();
			this.label_EndTermin = new System.Windows.Forms.Label();
			this.label_StartTermin = new System.Windows.Forms.Label();
			this.textBox_EndTermin = new System.Windows.Forms.TextBox();
			this.textBox_StartTermin = new System.Windows.Forms.TextBox();
			this.dataGridView_DLZ = new System.Windows.Forms.DataGridView();
			this.menuStrip_Recherche = new System.Windows.Forms.MenuStrip();
			this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl_Recherche.SuspendLayout();
			this.tabPage_Durchlaufzeit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_RechercheDurchlaufzeit)).BeginInit();
			this.splitContainer_RechercheDurchlaufzeit.Panel1.SuspendLayout();
			this.splitContainer_RechercheDurchlaufzeit.Panel2.SuspendLayout();
			this.splitContainer_RechercheDurchlaufzeit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_DLZ)).BeginInit();
			this.bindingNavigator_DLZ.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DLZ)).BeginInit();
			this.menuStrip_Recherche.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl_Recherche
			// 
			this.tabControl_Recherche.Controls.Add(this.tabPage_Durchlaufzeit);
			this.tabControl_Recherche.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_Recherche.Location = new System.Drawing.Point(0, 32);
			this.tabControl_Recherche.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl_Recherche.Name = "tabControl_Recherche";
			this.tabControl_Recherche.SelectedIndex = 0;
			this.tabControl_Recherche.Size = new System.Drawing.Size(643, 514);
			this.tabControl_Recherche.TabIndex = 0;
			// 
			// tabPage_Durchlaufzeit
			// 
			this.tabPage_Durchlaufzeit.Controls.Add(this.splitContainer_RechercheDurchlaufzeit);
			this.tabPage_Durchlaufzeit.Location = new System.Drawing.Point(4, 27);
			this.tabPage_Durchlaufzeit.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage_Durchlaufzeit.Name = "tabPage_Durchlaufzeit";
			this.tabPage_Durchlaufzeit.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage_Durchlaufzeit.Size = new System.Drawing.Size(635, 483);
			this.tabPage_Durchlaufzeit.TabIndex = 0;
			this.tabPage_Durchlaufzeit.Tag = "order lead time";
			this.tabPage_Durchlaufzeit.Text = "Durchlaufzeit";
			this.tabPage_Durchlaufzeit.UseVisualStyleBackColor = true;
			// 
			// splitContainer_RechercheDurchlaufzeit
			// 
			this.splitContainer_RechercheDurchlaufzeit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_RechercheDurchlaufzeit.Location = new System.Drawing.Point(4, 4);
			this.splitContainer_RechercheDurchlaufzeit.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer_RechercheDurchlaufzeit.Name = "splitContainer_RechercheDurchlaufzeit";
			this.splitContainer_RechercheDurchlaufzeit.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_RechercheDurchlaufzeit.Panel1
			// 
			this.splitContainer_RechercheDurchlaufzeit.Panel1.Controls.Add(this.bindingNavigator_DLZ);
			this.splitContainer_RechercheDurchlaufzeit.Panel1.Controls.Add(this.label_RechercheDurchlaufzeitHinweis);
			this.splitContainer_RechercheDurchlaufzeit.Panel1.Controls.Add(this.label_EndTermin);
			this.splitContainer_RechercheDurchlaufzeit.Panel1.Controls.Add(this.label_StartTermin);
			this.splitContainer_RechercheDurchlaufzeit.Panel1.Controls.Add(this.textBox_EndTermin);
			this.splitContainer_RechercheDurchlaufzeit.Panel1.Controls.Add(this.textBox_StartTermin);
			this.splitContainer_RechercheDurchlaufzeit.Panel1MinSize = 95;
			// 
			// splitContainer_RechercheDurchlaufzeit.Panel2
			// 
			this.splitContainer_RechercheDurchlaufzeit.Panel2.Controls.Add(this.dataGridView_DLZ);
			this.splitContainer_RechercheDurchlaufzeit.Size = new System.Drawing.Size(627, 475);
			this.splitContainer_RechercheDurchlaufzeit.SplitterDistance = 99;
			this.splitContainer_RechercheDurchlaufzeit.SplitterWidth = 6;
			this.splitContainer_RechercheDurchlaufzeit.TabIndex = 2;
			// 
			// bindingNavigator_DLZ
			// 
			this.bindingNavigator_DLZ.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator_DLZ.BackColor = System.Drawing.Color.Wheat;
			this.bindingNavigator_DLZ.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator_DLZ.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator_DLZ.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bindingNavigator_DLZ.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingNavigator_DLZ.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_DLZ.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton_RechercheAuftragsdurchlauf});
			this.bindingNavigator_DLZ.Location = new System.Drawing.Point(0, 68);
			this.bindingNavigator_DLZ.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator_DLZ.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator_DLZ.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator_DLZ.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator_DLZ.Name = "bindingNavigator_DLZ";
			this.bindingNavigator_DLZ.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator_DLZ.Size = new System.Drawing.Size(627, 31);
			this.bindingNavigator_DLZ.TabIndex = 6;
			this.bindingNavigator_DLZ.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
			this.bindingNavigatorAddNewItem.Visible = false;
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
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
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
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
			// toolStripButton_RechercheAuftragsdurchlauf
			// 
			this.toolStripButton_RechercheAuftragsdurchlauf.BackColor = System.Drawing.Color.White;
			this.toolStripButton_RechercheAuftragsdurchlauf.Image = global::Auftrag_Kunde.Properties.Resources.ImportStart_1;
			this.toolStripButton_RechercheAuftragsdurchlauf.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_RechercheAuftragsdurchlauf.Name = "toolStripButton_RechercheAuftragsdurchlauf";
			this.toolStripButton_RechercheAuftragsdurchlauf.Size = new System.Drawing.Size(101, 28);
			this.toolStripButton_RechercheAuftragsdurchlauf.Text = "Durchlauf";
			this.toolStripButton_RechercheAuftragsdurchlauf.Click += new System.EventHandler(this.toolStripButton_RechercheAuftragsdurchlauf_Click);
			// 
			// label_RechercheDurchlaufzeitHinweis
			// 
			this.label_RechercheDurchlaufzeitHinweis.AutoSize = true;
			this.label_RechercheDurchlaufzeitHinweis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_RechercheDurchlaufzeitHinweis.Location = new System.Drawing.Point(58, 4);
			this.label_RechercheDurchlaufzeitHinweis.Name = "label_RechercheDurchlaufzeitHinweis";
			this.label_RechercheDurchlaufzeitHinweis.Size = new System.Drawing.Size(452, 20);
			this.label_RechercheDurchlaufzeitHinweis.TabIndex = 4;
			this.label_RechercheDurchlaufzeitHinweis.Text = "Listet alle Aufträge mit  Liefertermin im angegeben Zeitintervall.";
			// 
			// label_EndTermin
			// 
			this.label_EndTermin.AutoSize = true;
			this.label_EndTermin.Location = new System.Drawing.Point(280, 30);
			this.label_EndTermin.Name = "label_EndTermin";
			this.label_EndTermin.Size = new System.Drawing.Size(75, 18);
			this.label_EndTermin.TabIndex = 3;
			this.label_EndTermin.Text = "Endtermin";
			// 
			// label_StartTermin
			// 
			this.label_StartTermin.AutoSize = true;
			this.label_StartTermin.Location = new System.Drawing.Point(27, 36);
			this.label_StartTermin.Name = "label_StartTermin";
			this.label_StartTermin.Size = new System.Drawing.Size(80, 18);
			this.label_StartTermin.TabIndex = 2;
			this.label_StartTermin.Text = "Starttermin";
			// 
			// textBox_EndTermin
			// 
			this.textBox_EndTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_EndTermin.Location = new System.Drawing.Point(362, 28);
			this.textBox_EndTermin.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_EndTermin.Name = "textBox_EndTermin";
			this.textBox_EndTermin.Size = new System.Drawing.Size(148, 24);
			this.textBox_EndTermin.TabIndex = 1;
			this.textBox_EndTermin.Text = "2999-01-01";
			// 
			// textBox_StartTermin
			// 
			this.textBox_StartTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_StartTermin.Location = new System.Drawing.Point(114, 30);
			this.textBox_StartTermin.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_StartTermin.Name = "textBox_StartTermin";
			this.textBox_StartTermin.Size = new System.Drawing.Size(148, 24);
			this.textBox_StartTermin.TabIndex = 0;
			this.textBox_StartTermin.Text = "2015-01-01";
			// 
			// dataGridView_DLZ
			// 
			this.dataGridView_DLZ.BackgroundColor = System.Drawing.Color.Silver;
			this.dataGridView_DLZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_DLZ.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_DLZ.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_DLZ.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_DLZ.Name = "dataGridView_DLZ";
			this.dataGridView_DLZ.RowHeadersWidth = 62;
			this.dataGridView_DLZ.Size = new System.Drawing.Size(627, 370);
			this.dataGridView_DLZ.TabIndex = 2;
			this.dataGridView_DLZ.Tag = "minimum order throughput time";
			// 
			// menuStrip_Recherche
			// 
			this.menuStrip_Recherche.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip_Recherche.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip_Recherche.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
			this.menuStrip_Recherche.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_Recherche.Name = "menuStrip_Recherche";
			this.menuStrip_Recherche.Size = new System.Drawing.Size(643, 32);
			this.menuStrip_Recherche.TabIndex = 1;
			this.menuStrip_Recherche.Text = "menuStrip1";
			// 
			// schließenToolStripMenuItem
			// 
			this.schließenToolStripMenuItem.Image = global::Auftrag_Kunde.Properties.Resources.SCHLIESSEN_gruen_weiß_blau;
			this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
			this.schließenToolStripMenuItem.Size = new System.Drawing.Size(108, 28);
			this.schließenToolStripMenuItem.Text = "Schließen";
			this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
			// 
			// Form_Recherche
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 546);
			this.Controls.Add(this.tabControl_Recherche);
			this.Controls.Add(this.menuStrip_Recherche);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip_Recherche;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form_Recherche";
			this.Tag = "inquire";
			this.Text = "Recherche";
			this.Load += new System.EventHandler(this.Form_Recherche_Load);
			this.tabControl_Recherche.ResumeLayout(false);
			this.tabPage_Durchlaufzeit.ResumeLayout(false);
			this.splitContainer_RechercheDurchlaufzeit.Panel1.ResumeLayout(false);
			this.splitContainer_RechercheDurchlaufzeit.Panel1.PerformLayout();
			this.splitContainer_RechercheDurchlaufzeit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_RechercheDurchlaufzeit)).EndInit();
			this.splitContainer_RechercheDurchlaufzeit.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_DLZ)).EndInit();
			this.bindingNavigator_DLZ.ResumeLayout(false);
			this.bindingNavigator_DLZ.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DLZ)).EndInit();
			this.menuStrip_Recherche.ResumeLayout(false);
			this.menuStrip_Recherche.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl_Recherche;
    private System.Windows.Forms.TabPage tabPage_Durchlaufzeit;
    private System.Windows.Forms.MenuStrip menuStrip_Recherche;
    private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer_RechercheDurchlaufzeit;
    private System.Windows.Forms.DataGridView dataGridView_DLZ;
    private System.Windows.Forms.Label label_RechercheDurchlaufzeitHinweis;
    private System.Windows.Forms.Label label_EndTermin;
    private System.Windows.Forms.Label label_StartTermin;
    private System.Windows.Forms.TextBox textBox_EndTermin;
    private System.Windows.Forms.TextBox textBox_StartTermin;
    private System.Windows.Forms.BindingNavigator bindingNavigator_DLZ;
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
    private System.Windows.Forms.ToolStripButton toolStripButton_RechercheAuftragsdurchlauf;
    private System.Windows.Forms.DataGridViewTextBoxColumn idAuftraegeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn auftragDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn stueckzahlDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lieferterminDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idWerkstueckeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn anzahlArbeitsvorgaengeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn durchlaufzeitDataGridViewTextBoxColumn;
  }
}