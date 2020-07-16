namespace Fuehrungen
{
	partial class Form_Account
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
			this.splitContainer_Account = new System.Windows.Forms.SplitContainer();
			this.textBox_info = new System.Windows.Forms.TextBox();
			this.menuStrip_Account = new System.Windows.Forms.MenuStrip();
			this.SqlDateiLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.speichernSQLDateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.datenbankErzeugenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer_Edit = new System.Windows.Forms.SplitContainer();
			this.label_Verbindung = new System.Windows.Forms.Label();
			this.button_datenbankErzeugen = new System.Windows.Forms.Button();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.comboBox_persist = new System.Windows.Forms.ComboBox();
			this.textBox_userId = new System.Windows.Forms.TextBox();
			this.textBox_server = new System.Windows.Forms.TextBox();
			this.label_password = new System.Windows.Forms.Label();
			this.label_persist = new System.Windows.Forms.Label();
			this.label_userId = new System.Windows.Forms.Label();
			this.label_server = new System.Windows.Forms.Label();
			this.richTextBox_Sql = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Account)).BeginInit();
			this.splitContainer_Account.Panel1.SuspendLayout();
			this.splitContainer_Account.Panel2.SuspendLayout();
			this.splitContainer_Account.SuspendLayout();
			this.menuStrip_Account.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Edit)).BeginInit();
			this.splitContainer_Edit.Panel1.SuspendLayout();
			this.splitContainer_Edit.Panel2.SuspendLayout();
			this.splitContainer_Edit.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer_Account
			// 
			this.splitContainer_Account.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Account.Location = new System.Drawing.Point(0, 0);
			this.splitContainer_Account.Name = "splitContainer_Account";
			this.splitContainer_Account.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_Account.Panel1
			// 
			this.splitContainer_Account.Panel1.Controls.Add(this.textBox_info);
			this.splitContainer_Account.Panel1.Controls.Add(this.menuStrip_Account);
			// 
			// splitContainer_Account.Panel2
			// 
			this.splitContainer_Account.Panel2.Controls.Add(this.splitContainer_Edit);
			this.splitContainer_Account.Size = new System.Drawing.Size(686, 435);
			this.splitContainer_Account.SplitterDistance = 56;
			this.splitContainer_Account.TabIndex = 1;
			// 
			// textBox_info
			// 
			this.textBox_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_info.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_info.Location = new System.Drawing.Point(0, 30);
			this.textBox_info.Name = "textBox_info";
			this.textBox_info.Size = new System.Drawing.Size(686, 22);
			this.textBox_info.TabIndex = 16;
			this.textBox_info.Text = "info";
			// 
			// menuStrip_Account
			// 
			this.menuStrip_Account.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip_Account.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip_Account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SqlDateiLadenToolStripMenuItem,
            this.speichernSQLDateiToolStripMenuItem,
            this.datenbankErzeugenToolStripMenuItem,
            this.beendenToolStripMenuItem});
			this.menuStrip_Account.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_Account.Name = "menuStrip_Account";
			this.menuStrip_Account.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip_Account.Size = new System.Drawing.Size(686, 30);
			this.menuStrip_Account.TabIndex = 5;
			this.menuStrip_Account.Text = "menuStrip1";
			// 
			// SqlDateiLadenToolStripMenuItem
			// 
			this.SqlDateiLadenToolStripMenuItem.Image = global::Fuehrungen.Properties.Resources.LadenSQL_1;
			this.SqlDateiLadenToolStripMenuItem.Name = "SqlDateiLadenToolStripMenuItem";
			this.SqlDateiLadenToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
			this.SqlDateiLadenToolStripMenuItem.Text = "Laden SQL-Datei";
			this.SqlDateiLadenToolStripMenuItem.Click += new System.EventHandler(this.SqlDateiLadenToolStripMenuItem_Click);
			// 
			// speichernSQLDateiToolStripMenuItem
			// 
			this.speichernSQLDateiToolStripMenuItem.Image = global::Fuehrungen.Properties.Resources.SpeichernSQL1;
			this.speichernSQLDateiToolStripMenuItem.Name = "speichernSQLDateiToolStripMenuItem";
			this.speichernSQLDateiToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
			this.speichernSQLDateiToolStripMenuItem.Text = "Speichern SQL-Datei";
			// 
			// datenbankErzeugenToolStripMenuItem
			// 
			this.datenbankErzeugenToolStripMenuItem.Image = global::Fuehrungen.Properties.Resources.GeneriereDB;
			this.datenbankErzeugenToolStripMenuItem.Name = "datenbankErzeugenToolStripMenuItem";
			this.datenbankErzeugenToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
			this.datenbankErzeugenToolStripMenuItem.Text = "Datenbank erzeugen";
			this.datenbankErzeugenToolStripMenuItem.Click += new System.EventHandler(this.datenbankErzeugenToolStripMenuItem_Click);
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Image = global::Fuehrungen.Properties.Resources.beenden_2;
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
			this.beendenToolStripMenuItem.Text = "Beenden";
			this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
			// 
			// splitContainer_Edit
			// 
			this.splitContainer_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer_Edit.Location = new System.Drawing.Point(0, 0);
			this.splitContainer_Edit.Name = "splitContainer_Edit";
			// 
			// splitContainer_Edit.Panel1
			// 
			this.splitContainer_Edit.Panel1.Controls.Add(this.label_Verbindung);
			this.splitContainer_Edit.Panel1.Controls.Add(this.button_datenbankErzeugen);
			this.splitContainer_Edit.Panel1.Controls.Add(this.textBox_password);
			this.splitContainer_Edit.Panel1.Controls.Add(this.comboBox_persist);
			this.splitContainer_Edit.Panel1.Controls.Add(this.textBox_userId);
			this.splitContainer_Edit.Panel1.Controls.Add(this.textBox_server);
			this.splitContainer_Edit.Panel1.Controls.Add(this.label_password);
			this.splitContainer_Edit.Panel1.Controls.Add(this.label_persist);
			this.splitContainer_Edit.Panel1.Controls.Add(this.label_userId);
			this.splitContainer_Edit.Panel1.Controls.Add(this.label_server);
			this.splitContainer_Edit.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// splitContainer_Edit.Panel2
			// 
			this.splitContainer_Edit.Panel2.Controls.Add(this.richTextBox_Sql);
			this.splitContainer_Edit.Size = new System.Drawing.Size(686, 375);
			this.splitContainer_Edit.SplitterDistance = 260;
			this.splitContainer_Edit.TabIndex = 0;
			// 
			// label_Verbindung
			// 
			this.label_Verbindung.AutoSize = true;
			this.label_Verbindung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Verbindung.Location = new System.Drawing.Point(8, 9);
			this.label_Verbindung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Verbindung.Name = "label_Verbindung";
			this.label_Verbindung.Size = new System.Drawing.Size(235, 20);
			this.label_Verbindung.TabIndex = 11;
			this.label_Verbindung.Text = "Verbindungsdaten eingeben";
			// 
			// button_datenbankErzeugen
			// 
			this.button_datenbankErzeugen.Image = global::Fuehrungen.Properties.Resources.SQLtoDB_1;
			this.button_datenbankErzeugen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_datenbankErzeugen.Location = new System.Drawing.Point(26, 304);
			this.button_datenbankErzeugen.Margin = new System.Windows.Forms.Padding(2);
			this.button_datenbankErzeugen.Name = "button_datenbankErzeugen";
			this.button_datenbankErzeugen.Size = new System.Drawing.Size(196, 45);
			this.button_datenbankErzeugen.TabIndex = 10;
			this.button_datenbankErzeugen.Text = "Datenbank erzeugen";
			this.button_datenbankErzeugen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_datenbankErzeugen.UseVisualStyleBackColor = true;
			this.button_datenbankErzeugen.Click += new System.EventHandler(this.datenbankErzeugenToolStripMenuItem_Click);
			// 
			// textBox_password
			// 
			this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_password.Location = new System.Drawing.Point(8, 263);
			this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.Size = new System.Drawing.Size(238, 24);
			this.textBox_password.TabIndex = 8;
			this.textBox_password.Text = "root";
			// 
			// comboBox_persist
			// 
			this.comboBox_persist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.comboBox_persist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_persist.FormattingEnabled = true;
			this.comboBox_persist.Items.AddRange(new object[] {
            "True",
            "False"});
			this.comboBox_persist.Location = new System.Drawing.Point(11, 200);
			this.comboBox_persist.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox_persist.Name = "comboBox_persist";
			this.comboBox_persist.Size = new System.Drawing.Size(82, 26);
			this.comboBox_persist.TabIndex = 7;
			this.comboBox_persist.Text = "True";
			// 
			// textBox_userId
			// 
			this.textBox_userId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_userId.Location = new System.Drawing.Point(9, 138);
			this.textBox_userId.Margin = new System.Windows.Forms.Padding(2);
			this.textBox_userId.Name = "textBox_userId";
			this.textBox_userId.Size = new System.Drawing.Size(237, 24);
			this.textBox_userId.TabIndex = 6;
			this.textBox_userId.Text = "root";
			// 
			// textBox_server
			// 
			this.textBox_server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_server.Location = new System.Drawing.Point(9, 71);
			this.textBox_server.Margin = new System.Windows.Forms.Padding(2);
			this.textBox_server.Name = "textBox_server";
			this.textBox_server.Size = new System.Drawing.Size(238, 24);
			this.textBox_server.TabIndex = 5;
			this.textBox_server.Text = "localhost";
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.Location = new System.Drawing.Point(8, 237);
			this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(68, 17);
			this.label_password.TabIndex = 3;
			this.label_password.Text = "password";
			// 
			// label_persist
			// 
			this.label_persist.AutoSize = true;
			this.label_persist.Location = new System.Drawing.Point(8, 173);
			this.label_persist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_persist.Name = "label_persist";
			this.label_persist.Size = new System.Drawing.Size(130, 17);
			this.label_persist.TabIndex = 2;
			this.label_persist.Text = "persist security info";
			// 
			// label_userId
			// 
			this.label_userId.AutoSize = true;
			this.label_userId.Location = new System.Drawing.Point(12, 112);
			this.label_userId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_userId.Name = "label_userId";
			this.label_userId.Size = new System.Drawing.Size(51, 17);
			this.label_userId.TabIndex = 1;
			this.label_userId.Text = "user id";
			// 
			// label_server
			// 
			this.label_server.AutoSize = true;
			this.label_server.Location = new System.Drawing.Point(12, 45);
			this.label_server.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_server.Name = "label_server";
			this.label_server.Size = new System.Drawing.Size(48, 17);
			this.label_server.TabIndex = 0;
			this.label_server.Text = "server";
			// 
			// richTextBox_Sql
			// 
			this.richTextBox_Sql.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox_Sql.Location = new System.Drawing.Point(0, 0);
			this.richTextBox_Sql.Name = "richTextBox_Sql";
			this.richTextBox_Sql.Size = new System.Drawing.Size(422, 375);
			this.richTextBox_Sql.TabIndex = 1;
			this.richTextBox_Sql.Text = "";
			// 
			// Form_Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 435);
			this.Controls.Add(this.splitContainer_Account);
			this.Name = "Form_Account";
			this.Text = "Datenbank anlegen";
			this.splitContainer_Account.Panel1.ResumeLayout(false);
			this.splitContainer_Account.Panel1.PerformLayout();
			this.splitContainer_Account.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Account)).EndInit();
			this.splitContainer_Account.ResumeLayout(false);
			this.menuStrip_Account.ResumeLayout(false);
			this.menuStrip_Account.PerformLayout();
			this.splitContainer_Edit.Panel1.ResumeLayout(false);
			this.splitContainer_Edit.Panel1.PerformLayout();
			this.splitContainer_Edit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_Edit)).EndInit();
			this.splitContainer_Edit.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer_Account;
		private System.Windows.Forms.MenuStrip menuStrip_Account;
		private System.Windows.Forms.ToolStripMenuItem SqlDateiLadenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem speichernSQLDateiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem datenbankErzeugenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer_Edit;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.Label label_persist;
		private System.Windows.Forms.Label label_userId;
		private System.Windows.Forms.Label label_server;
		private System.Windows.Forms.TextBox textBox_server;
		private System.Windows.Forms.Label label_Verbindung;
		private System.Windows.Forms.Button button_datenbankErzeugen;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.ComboBox comboBox_persist;
		private System.Windows.Forms.TextBox textBox_userId;
		private System.Windows.Forms.TextBox textBox_info;
		private System.Windows.Forms.RichTextBox richTextBox_Sql;
	}
}