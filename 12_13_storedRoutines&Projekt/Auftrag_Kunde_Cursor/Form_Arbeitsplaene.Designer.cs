namespace Auftrag_Kunde
{
  partial class Form_Arbeitsplaene
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Arbeitsplaene));
      this.menuStrip_Arbeitsplaene = new System.Windows.Forms.MenuStrip();
      this.splitContainer_Arbeitsplaene = new System.Windows.Forms.SplitContainer();
      this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bindingSource_Arbeitsplan = new System.Windows.Forms.BindingSource(this.components);
      this.kundenwerkstueckarbeitsplaeneDataSet1 = new Auftrag_Kunde.kundenwerkstueckarbeitsplaeneDataSet1();
      this.arbeitsplanTableAdapter = new Auftrag_Kunde.kundenwerkstueckarbeitsplaeneDataSet1TableAdapters.arbeitsplanTableAdapter();
      this.bindingNavigator_Arbeitsplan = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.dataGridView_Arbeitsplan = new System.Windows.Forms.DataGridView();
      this.idWerkstueckeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idArbeitsvorgangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.arbeitsvorgangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.arbeitsplatzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rüstzeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.zeitJeEinheitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuStrip_Arbeitsplaene.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Arbeitsplaene)).BeginInit();
      this.splitContainer_Arbeitsplaene.Panel1.SuspendLayout();
      this.splitContainer_Arbeitsplaene.Panel2.SuspendLayout();
      this.splitContainer_Arbeitsplaene.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Arbeitsplan)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.kundenwerkstueckarbeitsplaeneDataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Arbeitsplan)).BeginInit();
      this.bindingNavigator_Arbeitsplan.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Arbeitsplan)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip_Arbeitsplaene
      // 
      this.menuStrip_Arbeitsplaene.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuStrip_Arbeitsplaene.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
      this.menuStrip_Arbeitsplaene.Location = new System.Drawing.Point(0, 0);
      this.menuStrip_Arbeitsplaene.Name = "menuStrip_Arbeitsplaene";
      this.menuStrip_Arbeitsplaene.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.menuStrip_Arbeitsplaene.Size = new System.Drawing.Size(572, 30);
      this.menuStrip_Arbeitsplaene.TabIndex = 0;
      this.menuStrip_Arbeitsplaene.Text = "menuStrip1";
      // 
      // splitContainer_Arbeitsplaene
      // 
      this.splitContainer_Arbeitsplaene.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer_Arbeitsplaene.Location = new System.Drawing.Point(0, 30);
      this.splitContainer_Arbeitsplaene.Name = "splitContainer_Arbeitsplaene";
      this.splitContainer_Arbeitsplaene.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer_Arbeitsplaene.Panel1
      // 
      this.splitContainer_Arbeitsplaene.Panel1.Controls.Add(this.bindingNavigator_Arbeitsplan);
      // 
      // splitContainer_Arbeitsplaene.Panel2
      // 
      this.splitContainer_Arbeitsplaene.Panel2.Controls.Add(this.dataGridView_Arbeitsplan);
      this.splitContainer_Arbeitsplaene.Size = new System.Drawing.Size(572, 385);
      this.splitContainer_Arbeitsplaene.SplitterDistance = 164;
      this.splitContainer_Arbeitsplaene.TabIndex = 2;
      // 
      // schließenToolStripMenuItem
      // 
      this.schließenToolStripMenuItem.Image = global::Auftrag_Kunde.Properties.Resources.SCHLIESSEN_gruen_weiß_blau;
      this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
      this.schließenToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
      this.schließenToolStripMenuItem.Text = "Schließen";
      // 
      // bindingSource_Arbeitsplan
      // 
      this.bindingSource_Arbeitsplan.DataMember = "arbeitsplan";
      this.bindingSource_Arbeitsplan.DataSource = this.kundenwerkstueckarbeitsplaeneDataSet1;
      // 
      // kundenwerkstueckarbeitsplaeneDataSet1
      // 
      this.kundenwerkstueckarbeitsplaeneDataSet1.DataSetName = "kundenwerkstueckarbeitsplaeneDataSet1";
      this.kundenwerkstueckarbeitsplaeneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // arbeitsplanTableAdapter
      // 
      this.arbeitsplanTableAdapter.ClearBeforeFill = true;
      // 
      // bindingNavigator_Arbeitsplan
      // 
      this.bindingNavigator_Arbeitsplan.AddNewItem = this.bindingNavigatorAddNewItem;
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
            this.bindingNavigatorDeleteItem});
      this.bindingNavigator_Arbeitsplan.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigator_Arbeitsplan.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigator_Arbeitsplan.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigator_Arbeitsplan.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigator_Arbeitsplan.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigator_Arbeitsplan.Name = "bindingNavigator_Arbeitsplan";
      this.bindingNavigator_Arbeitsplan.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigator_Arbeitsplan.Size = new System.Drawing.Size(572, 25);
      this.bindingNavigator_Arbeitsplan.TabIndex = 0;
      this.bindingNavigator_Arbeitsplan.Text = "bindingNavigator1";
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
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
      this.bindingNavigatorCountItem.Text = "von {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Löschen";
      // 
      // dataGridView_Arbeitsplan
      // 
      this.dataGridView_Arbeitsplan.AutoGenerateColumns = false;
      this.dataGridView_Arbeitsplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Arbeitsplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWerkstueckeDataGridViewTextBoxColumn,
            this.idArbeitsvorgangDataGridViewTextBoxColumn,
            this.arbeitsvorgangDataGridViewTextBoxColumn,
            this.arbeitsplatzDataGridViewTextBoxColumn,
            this.rüstzeitDataGridViewTextBoxColumn,
            this.zeitJeEinheitDataGridViewTextBoxColumn});
      this.dataGridView_Arbeitsplan.DataSource = this.bindingSource_Arbeitsplan;
      this.dataGridView_Arbeitsplan.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView_Arbeitsplan.Location = new System.Drawing.Point(0, 0);
      this.dataGridView_Arbeitsplan.Name = "dataGridView_Arbeitsplan";
      this.dataGridView_Arbeitsplan.Size = new System.Drawing.Size(572, 217);
      this.dataGridView_Arbeitsplan.TabIndex = 0;
      // 
      // idWerkstueckeDataGridViewTextBoxColumn
      // 
      this.idWerkstueckeDataGridViewTextBoxColumn.DataPropertyName = "idWerkstuecke";
      this.idWerkstueckeDataGridViewTextBoxColumn.HeaderText = "idWerkstuecke";
      this.idWerkstueckeDataGridViewTextBoxColumn.Name = "idWerkstueckeDataGridViewTextBoxColumn";
      // 
      // idArbeitsvorgangDataGridViewTextBoxColumn
      // 
      this.idArbeitsvorgangDataGridViewTextBoxColumn.DataPropertyName = "idArbeitsvorgang";
      this.idArbeitsvorgangDataGridViewTextBoxColumn.HeaderText = "idArbeitsvorgang";
      this.idArbeitsvorgangDataGridViewTextBoxColumn.Name = "idArbeitsvorgangDataGridViewTextBoxColumn";
      // 
      // arbeitsvorgangDataGridViewTextBoxColumn
      // 
      this.arbeitsvorgangDataGridViewTextBoxColumn.DataPropertyName = "Arbeitsvorgang";
      this.arbeitsvorgangDataGridViewTextBoxColumn.HeaderText = "Arbeitsvorgang";
      this.arbeitsvorgangDataGridViewTextBoxColumn.Name = "arbeitsvorgangDataGridViewTextBoxColumn";
      // 
      // arbeitsplatzDataGridViewTextBoxColumn
      // 
      this.arbeitsplatzDataGridViewTextBoxColumn.DataPropertyName = "Arbeitsplatz";
      this.arbeitsplatzDataGridViewTextBoxColumn.HeaderText = "Arbeitsplatz";
      this.arbeitsplatzDataGridViewTextBoxColumn.Name = "arbeitsplatzDataGridViewTextBoxColumn";
      // 
      // rüstzeitDataGridViewTextBoxColumn
      // 
      this.rüstzeitDataGridViewTextBoxColumn.DataPropertyName = "Rüstzeit";
      this.rüstzeitDataGridViewTextBoxColumn.HeaderText = "Rüstzeit";
      this.rüstzeitDataGridViewTextBoxColumn.Name = "rüstzeitDataGridViewTextBoxColumn";
      // 
      // zeitJeEinheitDataGridViewTextBoxColumn
      // 
      this.zeitJeEinheitDataGridViewTextBoxColumn.DataPropertyName = "ZeitJeEinheit";
      this.zeitJeEinheitDataGridViewTextBoxColumn.HeaderText = "ZeitJeEinheit";
      this.zeitJeEinheitDataGridViewTextBoxColumn.Name = "zeitJeEinheitDataGridViewTextBoxColumn";
      // 
      // Form_Arbeitsplaene
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(572, 415);
      this.Controls.Add(this.splitContainer_Arbeitsplaene);
      this.Controls.Add(this.menuStrip_Arbeitsplaene);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip_Arbeitsplaene;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form_Arbeitsplaene";
      this.Text = "Arbeitsplan";
      this.Load += new System.EventHandler(this.Form_Arbeitsplaene_Load);
      this.menuStrip_Arbeitsplaene.ResumeLayout(false);
      this.menuStrip_Arbeitsplaene.PerformLayout();
      this.splitContainer_Arbeitsplaene.Panel1.ResumeLayout(false);
      this.splitContainer_Arbeitsplaene.Panel1.PerformLayout();
      this.splitContainer_Arbeitsplaene.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Arbeitsplaene)).EndInit();
      this.splitContainer_Arbeitsplaene.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Arbeitsplan)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.kundenwerkstueckarbeitsplaeneDataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Arbeitsplan)).EndInit();
      this.bindingNavigator_Arbeitsplan.ResumeLayout(false);
      this.bindingNavigator_Arbeitsplan.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Arbeitsplan)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip_Arbeitsplaene;
    private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer_Arbeitsplaene;
    private System.Windows.Forms.BindingSource bindingSource_Arbeitsplan;
    private kundenwerkstueckarbeitsplaeneDataSet1 kundenwerkstueckarbeitsplaeneDataSet1;
    private kundenwerkstueckarbeitsplaeneDataSet1TableAdapters.arbeitsplanTableAdapter arbeitsplanTableAdapter;
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
    private System.Windows.Forms.DataGridView dataGridView_Arbeitsplan;
    private System.Windows.Forms.DataGridViewTextBoxColumn idWerkstueckeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idArbeitsvorgangDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn arbeitsvorgangDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn arbeitsplatzDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn rüstzeitDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn zeitJeEinheitDataGridViewTextBoxColumn;
  }
}