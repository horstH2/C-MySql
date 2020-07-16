namespace KombinationenZahnriemenRiemenscheibe_KZRRS
{
  partial class Form_KZRRS
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
			this.menuStrip_KZRRS = new System.Windows.Forms.MenuStrip();
			this.kombinationenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer_KZRRS = new System.Windows.Forms.SplitContainer();
			this.richTextBox_KZRRS = new System.Windows.Forms.RichTextBox();
			this.dataGridView_KZRRS = new System.Windows.Forms.DataGridView();
			this.menuStrip_KZRRS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_KZRRS)).BeginInit();
			this.splitContainer_KZRRS.Panel1.SuspendLayout();
			this.splitContainer_KZRRS.Panel2.SuspendLayout();
			this.splitContainer_KZRRS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_KZRRS)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip_KZRRS
			// 
			this.menuStrip_KZRRS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip_KZRRS.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip_KZRRS.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip_KZRRS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kombinationenToolStripMenuItem,
            this.beendenToolStripMenuItem});
			this.menuStrip_KZRRS.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_KZRRS.Name = "menuStrip_KZRRS";
			this.menuStrip_KZRRS.Size = new System.Drawing.Size(1116, 39);
			this.menuStrip_KZRRS.TabIndex = 0;
			this.menuStrip_KZRRS.Text = "menuStrip1";
			// 
			// kombinationenToolStripMenuItem
			// 
			this.kombinationenToolStripMenuItem.Image = global::KombinationenZahnriemenRiemenscheibe_KZRRS.Properties.Resources.Sortieren;
			this.kombinationenToolStripMenuItem.Name = "kombinationenToolStripMenuItem";
			this.kombinationenToolStripMenuItem.Size = new System.Drawing.Size(209, 35);
			this.kombinationenToolStripMenuItem.Text = "Kombinationen";
			this.kombinationenToolStripMenuItem.Click += new System.EventHandler(this.kombinationenToolStripMenuItem_Click);
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Image = global::KombinationenZahnriemenRiemenscheibe_KZRRS.Properties.Resources.beenden_2;
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
			this.beendenToolStripMenuItem.Text = "Beenden";
			this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
			// 
			// splitContainer_KZRRS
			// 
			this.splitContainer_KZRRS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_KZRRS.Location = new System.Drawing.Point(0, 39);
			this.splitContainer_KZRRS.Name = "splitContainer_KZRRS";
			this.splitContainer_KZRRS.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_KZRRS.Panel1
			// 
			this.splitContainer_KZRRS.Panel1.Controls.Add(this.richTextBox_KZRRS);
			this.splitContainer_KZRRS.Panel1MinSize = 40;
			// 
			// splitContainer_KZRRS.Panel2
			// 
			this.splitContainer_KZRRS.Panel2.Controls.Add(this.dataGridView_KZRRS);
			this.splitContainer_KZRRS.Size = new System.Drawing.Size(1116, 585);
			this.splitContainer_KZRRS.SplitterDistance = 95;
			this.splitContainer_KZRRS.TabIndex = 1;
			// 
			// richTextBox_KZRRS
			// 
			this.richTextBox_KZRRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.richTextBox_KZRRS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox_KZRRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox_KZRRS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.richTextBox_KZRRS.Location = new System.Drawing.Point(0, 0);
			this.richTextBox_KZRRS.Name = "richTextBox_KZRRS";
			this.richTextBox_KZRRS.Size = new System.Drawing.Size(1116, 95);
			this.richTextBox_KZRRS.TabIndex = 0;
			this.richTextBox_KZRRS.Text = "\nLiefert alle gültigen Zahnriemen-Zahnscheiben-Kombination der Datenbank \"Zahnrie" +
    "mengetriebe\".";
			// 
			// dataGridView_KZRRS
			// 
			this.dataGridView_KZRRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_KZRRS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_KZRRS.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_KZRRS.Name = "dataGridView_KZRRS";
			this.dataGridView_KZRRS.RowHeadersWidth = 62;
			this.dataGridView_KZRRS.Size = new System.Drawing.Size(1116, 486);
			this.dataGridView_KZRRS.TabIndex = 0;
			// 
			// Form_KZRRS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1116, 624);
			this.Controls.Add(this.splitContainer_KZRRS);
			this.Controls.Add(this.menuStrip_KZRRS);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip_KZRRS;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form_KZRRS";
			this.Text = "Kombination: Zahnriemen-Riemenscheibe (KZRRS)";
			this.Load += new System.EventHandler(this.Form_KZRRS_Load);
			this.menuStrip_KZRRS.ResumeLayout(false);
			this.menuStrip_KZRRS.PerformLayout();
			this.splitContainer_KZRRS.Panel1.ResumeLayout(false);
			this.splitContainer_KZRRS.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_KZRRS)).EndInit();
			this.splitContainer_KZRRS.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_KZRRS)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip_KZRRS;
    private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer_KZRRS;
    private System.Windows.Forms.DataGridView dataGridView_KZRRS;
    private System.Windows.Forms.ToolStripMenuItem kombinationenToolStripMenuItem;
    private System.Windows.Forms.RichTextBox richTextBox_KZRRS;
  }
}

