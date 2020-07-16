namespace View
{
	partial class Form_View
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_View));
			this.bindingNavigator_View = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.toolStripButton_Restore = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Schliessen = new System.Windows.Forms.ToolStripButton();
			this.dataGridView_View = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_View)).BeginInit();
			this.bindingNavigator_View.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_View)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingNavigator_View
			// 
			this.bindingNavigator_View.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator_View.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator_View.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator_View.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingNavigator_View.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.bindingNavigator_View.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton_Restore,
            this.toolStripButton_Schliessen});
			this.bindingNavigator_View.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator_View.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator_View.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator_View.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator_View.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator_View.Name = "bindingNavigator_View";
			this.bindingNavigator_View.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator_View.Size = new System.Drawing.Size(712, 36);
			this.bindingNavigator_View.TabIndex = 0;
			this.bindingNavigator_View.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 31);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorAddNewItem.Visible = false;
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(66, 31);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 31);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Visible = false;
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 31);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 31);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 36);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 36);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 31);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 31);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 36);
			// 
			// toolStripButton_Restore
			// 
			this.toolStripButton_Restore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_Restore.Image = global::Auftrag_Kunde.Properties.Resources.ImportStart_1;
			this.toolStripButton_Restore.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Restore.Name = "toolStripButton_Restore";
			this.toolStripButton_Restore.Size = new System.Drawing.Size(34, 31);
			this.toolStripButton_Restore.Text = "Neu laden";
			this.toolStripButton_Restore.Click += new System.EventHandler(this.toolStripButton_Restore_Click);
			// 
			// toolStripButton_Schliessen
			// 
			this.toolStripButton_Schliessen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_Schliessen.Image = global::Auftrag_Kunde.Properties.Resources.SCHLIESSEN_gruen_weiß_blau;
			this.toolStripButton_Schliessen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Schliessen.Name = "toolStripButton_Schliessen";
			this.toolStripButton_Schliessen.Size = new System.Drawing.Size(34, 31);
			this.toolStripButton_Schliessen.Text = "Schließen";
			this.toolStripButton_Schliessen.Click += new System.EventHandler(this.toolStripButton_Schliessen_Click);
			// 
			// dataGridView_View
			// 
			this.dataGridView_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_View.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_View.Location = new System.Drawing.Point(0, 36);
			this.dataGridView_View.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_View.Name = "dataGridView_View";
			this.dataGridView_View.RowHeadersWidth = 62;
			this.dataGridView_View.Size = new System.Drawing.Size(712, 335);
			this.dataGridView_View.TabIndex = 1;
			// 
			// Form_View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 371);
			this.Controls.Add(this.dataGridView_View);
			this.Controls.Add(this.bindingNavigator_View);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form_View";
			this.Text = "View Lieferdienst";
			this.Activated += new System.EventHandler(this.Form_View_Activated);
			this.Load += new System.EventHandler(this.Form_View_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_View)).EndInit();
			this.bindingNavigator_View.ResumeLayout(false);
			this.bindingNavigator_View.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_View)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingNavigator bindingNavigator_View;
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
		private System.Windows.Forms.ToolStripButton toolStripButton_Restore;
		private System.Windows.Forms.DataGridView dataGridView_View;
		private System.Windows.Forms.ToolStripButton toolStripButton_Schliessen;
	}
}