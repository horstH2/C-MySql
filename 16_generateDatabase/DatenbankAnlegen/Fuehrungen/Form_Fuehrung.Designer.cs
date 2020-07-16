namespace Fuehrungen
{
	partial class Form_Fuehrungen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Fuehrungen));
			this.menuStrip_Fuehrung = new System.Windows.Forms.MenuStrip();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingNavigator_Fuehrung = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.toolStripButton_aktualisieren = new System.Windows.Forms.ToolStripButton();
			this.dataGridView_Fuehrung = new System.Windows.Forms.DataGridView();
			this.textBox_info = new System.Windows.Forms.TextBox();
			this.menuStrip_Fuehrung.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Fuehrung)).BeginInit();
			this.bindingNavigator_Fuehrung.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fuehrung)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip_Fuehrung
			// 
			this.menuStrip_Fuehrung.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip_Fuehrung.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip_Fuehrung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem,
            this.zeigenToolStripMenuItem});
			this.menuStrip_Fuehrung.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_Fuehrung.Name = "menuStrip_Fuehrung";
			this.menuStrip_Fuehrung.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip_Fuehrung.Size = new System.Drawing.Size(722, 32);
			this.menuStrip_Fuehrung.TabIndex = 0;
			this.menuStrip_Fuehrung.Text = "menuStrip1";
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Image = global::Fuehrungen.Properties.Resources.beenden_2;
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
			this.beendenToolStripMenuItem.Text = "Beenden";
			this.beendenToolStripMenuItem.ToolTipText = "Schließt die Anwendung";
			this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
			// 
			// zeigenToolStripMenuItem
			// 
			this.zeigenToolStripMenuItem.Image = global::Fuehrungen.Properties.Resources.Ablauf;
			this.zeigenToolStripMenuItem.Name = "zeigenToolStripMenuItem";
			this.zeigenToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
			this.zeigenToolStripMenuItem.Text = "Zeigen";
			this.zeigenToolStripMenuItem.Click += new System.EventHandler(this.zeigenToolStripMenuItem_Click);
			// 
			// bindingNavigator_Fuehrung
			// 
			this.bindingNavigator_Fuehrung.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator_Fuehrung.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator_Fuehrung.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator_Fuehrung.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_Fuehrung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton_aktualisieren});
			this.bindingNavigator_Fuehrung.Location = new System.Drawing.Point(0, 32);
			this.bindingNavigator_Fuehrung.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator_Fuehrung.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator_Fuehrung.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator_Fuehrung.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator_Fuehrung.Name = "bindingNavigator_Fuehrung";
			this.bindingNavigator_Fuehrung.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator_Fuehrung.Size = new System.Drawing.Size(722, 31);
			this.bindingNavigator_Fuehrung.TabIndex = 1;
			this.bindingNavigator_Fuehrung.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripButton_aktualisieren
			// 
			this.toolStripButton_aktualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_aktualisieren.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_aktualisieren.Image")));
			this.toolStripButton_aktualisieren.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_aktualisieren.Name = "toolStripButton_aktualisieren";
			this.toolStripButton_aktualisieren.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton_aktualisieren.Text = "toolStripButton1";
			this.toolStripButton_aktualisieren.Click += new System.EventHandler(this.toolStripButton_aktualisieren_Click);
			// 
			// dataGridView_Fuehrung
			// 
			this.dataGridView_Fuehrung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Fuehrung.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Fuehrung.Location = new System.Drawing.Point(0, 63);
			this.dataGridView_Fuehrung.Name = "dataGridView_Fuehrung";
			this.dataGridView_Fuehrung.RowHeadersWidth = 62;
			this.dataGridView_Fuehrung.Size = new System.Drawing.Size(722, 222);
			this.dataGridView_Fuehrung.TabIndex = 2;
			// 
			// textBox_info
			// 
			this.textBox_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_info.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBox_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_info.Location = new System.Drawing.Point(0, 263);
			this.textBox_info.Name = "textBox_info";
			this.textBox_info.Size = new System.Drawing.Size(722, 22);
			this.textBox_info.TabIndex = 17;
			this.textBox_info.Text = "info";
			// 
			// Form_Fuehrungen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 285);
			this.Controls.Add(this.textBox_info);
			this.Controls.Add(this.dataGridView_Fuehrung);
			this.Controls.Add(this.bindingNavigator_Fuehrung);
			this.Controls.Add(this.menuStrip_Fuehrung);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip_Fuehrung;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form_Fuehrungen";
			this.Text = "Datenbank anlegen";
			this.menuStrip_Fuehrung.ResumeLayout(false);
			this.menuStrip_Fuehrung.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Fuehrung)).EndInit();
			this.bindingNavigator_Fuehrung.ResumeLayout(false);
			this.bindingNavigator_Fuehrung.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fuehrung)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip_Fuehrung;
		private System.Windows.Forms.BindingNavigator bindingNavigator_Fuehrung;
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
		private System.Windows.Forms.DataGridView dataGridView_Fuehrung;
		private System.Windows.Forms.ToolStripButton toolStripButton_aktualisieren;
		private System.Windows.Forms.TextBox textBox_info;
		private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zeigenToolStripMenuItem;
	}
}

