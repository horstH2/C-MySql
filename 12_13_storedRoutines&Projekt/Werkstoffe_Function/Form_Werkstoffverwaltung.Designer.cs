namespace Werkstoffverwaltung
{
    partial class Form_Werkstoffverwaltung
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Werkstoffverwaltung));
			this.splitContainer_Werkstoffe = new System.Windows.Forms.SplitContainer();
			this.dataGrid_WS = new System.Windows.Forms.DataGridView();
			this.bindingNavigator_WS = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.splitContainer_mindestZugfestigkeit = new System.Windows.Forms.SplitContainer();
			this.textBox_Anzahl = new System.Windows.Forms.TextBox();
			this.label_Anzahl = new System.Windows.Forms.Label();
			this.label_RmMin = new System.Windows.Forms.Label();
			this.textBox_RmMin = new System.Windows.Forms.TextBox();
			this.richTextBox_RmMin = new System.Windows.Forms.RichTextBox();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Aktualisieren = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Beenden = new System.Windows.Forms.ToolStripButton();
			this.button_okCount = new System.Windows.Forms.Button();
			this.button_okRmin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Werkstoffe)).BeginInit();
			this.splitContainer_Werkstoffe.Panel1.SuspendLayout();
			this.splitContainer_Werkstoffe.Panel2.SuspendLayout();
			this.splitContainer_Werkstoffe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_WS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_WS)).BeginInit();
			this.bindingNavigator_WS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_mindestZugfestigkeit)).BeginInit();
			this.splitContainer_mindestZugfestigkeit.Panel1.SuspendLayout();
			this.splitContainer_mindestZugfestigkeit.Panel2.SuspendLayout();
			this.splitContainer_mindestZugfestigkeit.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer_Werkstoffe
			// 
			this.splitContainer_Werkstoffe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Werkstoffe.Location = new System.Drawing.Point(0, 0);
			this.splitContainer_Werkstoffe.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer_Werkstoffe.Name = "splitContainer_Werkstoffe";
			this.splitContainer_Werkstoffe.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_Werkstoffe.Panel1
			// 
			this.splitContainer_Werkstoffe.Panel1.Controls.Add(this.dataGrid_WS);
			this.splitContainer_Werkstoffe.Panel1.Controls.Add(this.bindingNavigator_WS);
			// 
			// splitContainer_Werkstoffe.Panel2
			// 
			this.splitContainer_Werkstoffe.Panel2.AllowDrop = true;
			this.splitContainer_Werkstoffe.Panel2.Controls.Add(this.splitContainer_mindestZugfestigkeit);
			this.splitContainer_Werkstoffe.Size = new System.Drawing.Size(583, 521);
			this.splitContainer_Werkstoffe.SplitterDistance = 227;
			this.splitContainer_Werkstoffe.SplitterWidth = 6;
			this.splitContainer_Werkstoffe.TabIndex = 0;
			// 
			// dataGrid_WS
			// 
			this.dataGrid_WS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dataGrid_WS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_WS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid_WS.Location = new System.Drawing.Point(0, 25);
			this.dataGrid_WS.Margin = new System.Windows.Forms.Padding(4);
			this.dataGrid_WS.Name = "dataGrid_WS";
			this.dataGrid_WS.Size = new System.Drawing.Size(583, 202);
			this.dataGrid_WS.TabIndex = 2;
			// 
			// bindingNavigator_WS
			// 
			this.bindingNavigator_WS.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator_WS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.bindingNavigator_WS.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator_WS.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator_WS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingNavigator_WS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton_Aktualisieren,
            this.toolStripButton_Beenden});
			this.bindingNavigator_WS.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator_WS.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator_WS.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator_WS.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator_WS.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator_WS.Name = "bindingNavigator_WS";
			this.bindingNavigator_WS.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.bindingNavigator_WS.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator_WS.Size = new System.Drawing.Size(583, 25);
			this.bindingNavigator_WS.TabIndex = 0;
			this.bindingNavigator_WS.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
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
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// splitContainer_mindestZugfestigkeit
			// 
			this.splitContainer_mindestZugfestigkeit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_mindestZugfestigkeit.Location = new System.Drawing.Point(0, 0);
			this.splitContainer_mindestZugfestigkeit.Name = "splitContainer_mindestZugfestigkeit";
			this.splitContainer_mindestZugfestigkeit.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_mindestZugfestigkeit.Panel1
			// 
			this.splitContainer_mindestZugfestigkeit.Panel1.AutoScroll = true;
			this.splitContainer_mindestZugfestigkeit.Panel1.AutoScrollMinSize = new System.Drawing.Size(0, 40);
			this.splitContainer_mindestZugfestigkeit.Panel1.Controls.Add(this.textBox_Anzahl);
			this.splitContainer_mindestZugfestigkeit.Panel1.Controls.Add(this.label_Anzahl);
			this.splitContainer_mindestZugfestigkeit.Panel1.Controls.Add(this.button_okCount);
			this.splitContainer_mindestZugfestigkeit.Panel1.Controls.Add(this.button_okRmin);
			this.splitContainer_mindestZugfestigkeit.Panel1.Controls.Add(this.label_RmMin);
			this.splitContainer_mindestZugfestigkeit.Panel1.Controls.Add(this.textBox_RmMin);
			// 
			// splitContainer_mindestZugfestigkeit.Panel2
			// 
			this.splitContainer_mindestZugfestigkeit.Panel2.Controls.Add(this.richTextBox_RmMin);
			this.splitContainer_mindestZugfestigkeit.Size = new System.Drawing.Size(583, 288);
			this.splitContainer_mindestZugfestigkeit.SplitterDistance = 110;
			this.splitContainer_mindestZugfestigkeit.TabIndex = 2;
			// 
			// textBox_Anzahl
			// 
			this.textBox_Anzahl.BackColor = System.Drawing.Color.Silver;
			this.textBox_Anzahl.Location = new System.Drawing.Point(470, 61);
			this.textBox_Anzahl.Name = "textBox_Anzahl";
			this.textBox_Anzahl.Size = new System.Drawing.Size(80, 24);
			this.textBox_Anzahl.TabIndex = 6;
			this.textBox_Anzahl.Text = "0";
			// 
			// label_Anzahl
			// 
			this.label_Anzahl.AutoSize = true;
			this.label_Anzahl.Location = new System.Drawing.Point(142, 61);
			this.label_Anzahl.Name = "label_Anzahl";
			this.label_Anzahl.Size = new System.Drawing.Size(234, 18);
			this.label_Anzahl.TabIndex = 5;
			this.label_Anzahl.Text = "Anzahl der gefundenen Werkstoffe";
			// 
			// label_RmMin
			// 
			this.label_RmMin.AutoSize = true;
			this.label_RmMin.Location = new System.Drawing.Point(12, 16);
			this.label_RmMin.Name = "label_RmMin";
			this.label_RmMin.Size = new System.Drawing.Size(267, 18);
			this.label_RmMin.TabIndex = 3;
			this.label_RmMin.Text = "Mindestzugfestigkeit Rm, min in N/mm²";
			// 
			// textBox_RmMin
			// 
			this.textBox_RmMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_RmMin.Location = new System.Drawing.Point(296, 16);
			this.textBox_RmMin.Name = "textBox_RmMin";
			this.textBox_RmMin.Size = new System.Drawing.Size(80, 24);
			this.textBox_RmMin.TabIndex = 2;
			this.textBox_RmMin.Text = "0";
			// 
			// richTextBox_RmMin
			// 
			this.richTextBox_RmMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.richTextBox_RmMin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox_RmMin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox_RmMin.Location = new System.Drawing.Point(0, 0);
			this.richTextBox_RmMin.Name = "richTextBox_RmMin";
			this.richTextBox_RmMin.Size = new System.Drawing.Size(583, 174);
			this.richTextBox_RmMin.TabIndex = 3;
			this.richTextBox_RmMin.Text = "";
			this.richTextBox_RmMin.WordWrap = false;
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
			// toolStripButton_Aktualisieren
			// 
			this.toolStripButton_Aktualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_Aktualisieren.Image = global::Werkstoffe_Function.Properties.Resources.accept;
			this.toolStripButton_Aktualisieren.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Aktualisieren.Name = "toolStripButton_Aktualisieren";
			this.toolStripButton_Aktualisieren.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton_Aktualisieren.Text = "Aktualisieren";
			this.toolStripButton_Aktualisieren.Click += new System.EventHandler(this.toolStripButton_Aktualisieren_Click);
			// 
			// toolStripButton_Beenden
			// 
			this.toolStripButton_Beenden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_Beenden.Image = global::Werkstoffe_Function.Properties.Resources.beenden_2;
			this.toolStripButton_Beenden.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Beenden.Name = "toolStripButton_Beenden";
			this.toolStripButton_Beenden.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton_Beenden.Text = "Beenden";
			this.toolStripButton_Beenden.Click += new System.EventHandler(this.toolStripButton_Beenden_Click);
			// 
			// button_okCount
			// 
			this.button_okCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_okCount.Image = global::Werkstoffe_Function.Properties.Resources.Hinzufügen;
			this.button_okCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_okCount.Location = new System.Drawing.Point(397, 59);
			this.button_okCount.Name = "button_okCount";
			this.button_okCount.Size = new System.Drawing.Size(57, 29);
			this.button_okCount.TabIndex = 4;
			this.button_okCount.Text = "OK";
			this.button_okCount.UseVisualStyleBackColor = false;
			this.button_okCount.Click += new System.EventHandler(this.button_okCount_Click);
			// 
			// button_okRmin
			// 
			this.button_okRmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_okRmin.Image = global::Werkstoffe_Function.Properties.Resources.ImportStart_1;
			this.button_okRmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_okRmin.Location = new System.Drawing.Point(397, 11);
			this.button_okRmin.Name = "button_okRmin";
			this.button_okRmin.Size = new System.Drawing.Size(57, 29);
			this.button_okRmin.TabIndex = 4;
			this.button_okRmin.Text = "OK";
			this.button_okRmin.UseVisualStyleBackColor = false;
			this.button_okRmin.Click += new System.EventHandler(this.button_okRmin_Click);
			// 
			// Form_Werkstoffverwaltung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 521);
			this.Controls.Add(this.splitContainer_Werkstoffe);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form_Werkstoffverwaltung";
			this.Text = "Werkstoffverwaltung";
			this.Load += new System.EventHandler(this.Form_Werkstoffverwaltung_Load);
			this.splitContainer_Werkstoffe.Panel1.ResumeLayout(false);
			this.splitContainer_Werkstoffe.Panel1.PerformLayout();
			this.splitContainer_Werkstoffe.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Werkstoffe)).EndInit();
			this.splitContainer_Werkstoffe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_WS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_WS)).EndInit();
			this.bindingNavigator_WS.ResumeLayout(false);
			this.bindingNavigator_WS.PerformLayout();
			this.splitContainer_mindestZugfestigkeit.Panel1.ResumeLayout(false);
			this.splitContainer_mindestZugfestigkeit.Panel1.PerformLayout();
			this.splitContainer_mindestZugfestigkeit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_mindestZugfestigkeit)).EndInit();
			this.splitContainer_mindestZugfestigkeit.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Werkstoffe;
        private System.Windows.Forms.DataGridView dataGrid_WS;
        private System.Windows.Forms.BindingNavigator bindingNavigator_WS;
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
        private System.Windows.Forms.ToolStripButton toolStripButton_Aktualisieren;
        private System.Windows.Forms.ToolStripButton toolStripButton_Beenden;
        private System.Windows.Forms.SplitContainer splitContainer_mindestZugfestigkeit;
        private System.Windows.Forms.Label label_RmMin;
        private System.Windows.Forms.TextBox textBox_RmMin;
        private System.Windows.Forms.RichTextBox richTextBox_RmMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWerkstoffeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kc11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bemerkungDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_okRmin;
        private System.Windows.Forms.TextBox textBox_Anzahl;
        private System.Windows.Forms.Label label_Anzahl;
        private System.Windows.Forms.Button button_okCount;
    }
}

