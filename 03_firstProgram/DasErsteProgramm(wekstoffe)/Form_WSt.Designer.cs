namespace DasErsteProgramm_wekstoffe_
{
  partial class Form_WSt
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
      this.menuStrip_WSt = new System.Windows.Forms.MenuStrip();
      this.aktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zeileLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer_WSt = new System.Windows.Forms.SplitContainer();
      this.dataGridView_WSt = new System.Windows.Forms.DataGridView();
      this.label_infoWSt = new System.Windows.Forms.Label();
      this.menuStrip_WSt.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_WSt)).BeginInit();
      this.splitContainer_WSt.Panel1.SuspendLayout();
      this.splitContainer_WSt.Panel2.SuspendLayout();
      this.splitContainer_WSt.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WSt)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip_WSt
      // 
      this.menuStrip_WSt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuStrip_WSt.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip_WSt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktualisierenToolStripMenuItem,
            this.zeileLöschenToolStripMenuItem,
            this.beendenToolStripMenuItem});
      this.menuStrip_WSt.Location = new System.Drawing.Point(0, 0);
      this.menuStrip_WSt.Name = "menuStrip_WSt";
      this.menuStrip_WSt.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.menuStrip_WSt.Size = new System.Drawing.Size(1818, 31);
      this.menuStrip_WSt.TabIndex = 0;
      this.menuStrip_WSt.Text = "menuStrip1";
      // 
      // aktualisierenToolStripMenuItem
      // 
      this.aktualisierenToolStripMenuItem.Name = "aktualisierenToolStripMenuItem";
      this.aktualisierenToolStripMenuItem.Size = new System.Drawing.Size(112, 25);
      this.aktualisierenToolStripMenuItem.Text = "Aktualisieren";
      this.aktualisierenToolStripMenuItem.Click += new System.EventHandler(this.aktualisierenToolStripMenuItem_Click);
      // 
      // zeileLöschenToolStripMenuItem
      // 
      this.zeileLöschenToolStripMenuItem.Name = "zeileLöschenToolStripMenuItem";
      this.zeileLöschenToolStripMenuItem.Size = new System.Drawing.Size(112, 25);
      this.zeileLöschenToolStripMenuItem.Text = "Zeile löschen";
      this.zeileLöschenToolStripMenuItem.Click += new System.EventHandler(this.zeileLöschenToolStripMenuItem_Click);
      // 
      // beendenToolStripMenuItem
      // 
      this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
      this.beendenToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
      this.beendenToolStripMenuItem.Text = "Beenden";
      this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
      // 
      // splitContainer_WSt
      // 
      this.splitContainer_WSt.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer_WSt.Location = new System.Drawing.Point(0, 31);
      this.splitContainer_WSt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.splitContainer_WSt.Name = "splitContainer_WSt";
      this.splitContainer_WSt.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer_WSt.Panel1
      // 
      this.splitContainer_WSt.Panel1.Controls.Add(this.dataGridView_WSt);
      // 
      // splitContainer_WSt.Panel2
      // 
      this.splitContainer_WSt.Panel2.Controls.Add(this.label_infoWSt);
      this.splitContainer_WSt.Panel2MinSize = 80;
      this.splitContainer_WSt.Size = new System.Drawing.Size(1818, 1033);
      this.splitContainer_WSt.SplitterDistance = 911;
      this.splitContainer_WSt.SplitterWidth = 6;
      this.splitContainer_WSt.TabIndex = 1;
      // 
      // dataGridView_WSt
      // 
      this.dataGridView_WSt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.dataGridView_WSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_WSt.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView_WSt.Location = new System.Drawing.Point(0, 0);
      this.dataGridView_WSt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.dataGridView_WSt.Name = "dataGridView_WSt";
      this.dataGridView_WSt.RowTemplate.Height = 28;
      this.dataGridView_WSt.Size = new System.Drawing.Size(1818, 911);
      this.dataGridView_WSt.TabIndex = 0;
      // 
      // label_infoWSt
      // 
      this.label_infoWSt.AutoSize = true;
      this.label_infoWSt.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label_infoWSt.Location = new System.Drawing.Point(0, 0);
      this.label_infoWSt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label_infoWSt.Name = "label_infoWSt";
      this.label_infoWSt.Size = new System.Drawing.Size(160, 20);
      this.label_infoWSt.TabIndex = 0;
      this.label_infoWSt.Text = "connectionStringWSt";
      // 
      // Form_WSt
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1818, 1064);
      this.Controls.Add(this.splitContainer_WSt);
      this.Controls.Add(this.menuStrip_WSt);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip_WSt;
      this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.Name = "Form_WSt";
      this.Text = "Werkstoffe - Verwendung der MySql-Klassen im Quelltext";
      this.Load += new System.EventHandler(this.Form_WSt_Load);
      this.menuStrip_WSt.ResumeLayout(false);
      this.menuStrip_WSt.PerformLayout();
      this.splitContainer_WSt.Panel1.ResumeLayout(false);
      this.splitContainer_WSt.Panel2.ResumeLayout(false);
      this.splitContainer_WSt.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_WSt)).EndInit();
      this.splitContainer_WSt.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WSt)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip_WSt;
    private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer_WSt;
    private System.Windows.Forms.DataGridView dataGridView_WSt;
    private System.Windows.Forms.Label label_infoWSt;
    private System.Windows.Forms.ToolStripMenuItem aktualisierenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zeileLöschenToolStripMenuItem;
  }
}

