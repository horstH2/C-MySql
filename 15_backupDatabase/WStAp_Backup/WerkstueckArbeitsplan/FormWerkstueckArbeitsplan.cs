using System;
using System.Drawing;
using System.Windows.Forms;
using OwnMySqlDB; // --> Eigene Klasse: CshaprpMySql

namespace WerkstueckArbeitsplan
{
	public partial class Form_WSt_Ap : Form
  {
		#region 1. Attribute, Instanzen der Klasse für Werkstücke und Arbeitsvorgangsdaten
		// Verbindungsstring ist Applikationsabhängig
		public static string connectionString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=fertigungsplanung";
		// Hauptobjekt (Instanz´der Klasse)
		CsharpMySql dbWSt = new CsharpMySql("werkstuecke", connectionString);
		// Detailobjekt (Instanz der Klasse)
		CsharpMySql dbAP = new CsharpMySql("arbeitsplaene");
		#endregion 1. Attribute, Instanzen der Klasse für Werkstücke und Arbeitsvorgangsdaten
		#region 2. Konstruktor der Formularklasse
		public Form_WSt_Ap(){
			InitializeComponent();
		}
		#endregion 2. Konstruktor der Formularklasse
		#region 3. Ereignismethoden
		/// <summary>
		/// Laden der Daten aus der Datenbank und visualisieren der Daten
		/// </summary>
		private void Form_WSt_Ap_Load(object sender, EventArgs e) {
			// Ausgabe von Informationen
			this.label_info.Text = CsharpMySql.con.ConnectionString;
			// Navigatoren an Datenquelle binden
			this.bindingNavigator_WSt.BindingSource = this.dbWSt.getBindingSource;
			this.bindingNavigator_AP.BindingSource = this.dbAP.getBindingSource;
			// Verbinden der sichtbaren Komponenten mit den Bindingsources
			this.dataGridView_WSt.DataSource = dbWSt.getBindingSource;
			this.dataGridView_AP.DataSource = dbAP.getBindingSource;
			// Instanz einer Haupttabelle: Definiert Relation zwischen der Haupttabelle und Detailtabelle 
			try { this.label_info.Text += this.dbWSt.mainDetailRelation("arbeitsplaene", this.dbAP.getBindingSource); } //
			catch (Exception ex) { this.label_info.Text += ex; }
		  // Anpassen der sichtbaren Tabellen
			this.dataGridView_WSt.AutoResizeColumns();
			this.dataGridView_AP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView_WSt.Columns["Zeichnung"].Visible = false;
			this.dataGridView_AP.Columns["Spannung"].Visible = false;
			this.dataGridView_WSt.Columns["idWSt"].ToolTipText = "Werkstücknummer";
			this.dataGridView_WSt.Columns["idWSt"].HeaderText = "ID-WSt";
			this.dataGridView_AP.Columns["idWSt"].ToolTipText = "Werkstücknummer";
			this.dataGridView_AP.Columns["idWSt"].HeaderText = "ID-WSt";
			this.dataGridView_AP.Columns["idAV"].ToolTipText = "Vorgangsnummer";
			this.dataGridView_AP.Columns["idAV"].HeaderText = "ID-AV";
		}
		/// <summary>
		/// Aktualisieren der editierten Daten in der Datenbank
		/// </summary>
		private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e) {
			// Die Detailtabelle vor der Haupttabelle aktualisieren
			this.label_info.Text=this.dbAP.aktualisieren(dataGridView_AP);
			this.label_info.Text=this.dbWSt.aktualisieren(dataGridView_WSt);
			// Commit für alle Änderungen an diesem Datenset
			CsharpMySql.dataSet.AcceptChanges();
		}
#region Backup
/// <summary>
/// Export der Datenbank
/// </summary>
private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
	// Zeitstempel
	string datumZeit = DateTime.Now.ToString("yyyyMMdd_HHmmss");
	// Dialog zum Speichern der Exportdatei
	SaveFileDialog saveFileDialog = new SaveFileDialog();
	saveFileDialog.FileName = "dump" + datumZeit;
	saveFileDialog.DefaultExt = "sql";
	if (saveFileDialog.ShowDialog() == DialogResult.OK) {
		// statische Methode zum Sichern
		CsharpMySql.dbExportToSql(saveFileDialog.FileName);
	}
}
/// <summary>
/// Import, Wiederherstellen einer Datenbank
/// </summary>
private void importRestoreToolStripMenuItem_Click(object sender, EventArgs e) {
	// Dialog zum Öffnen der Importdatei
	OpenFileDialog openFileDialog = new OpenFileDialog();
	openFileDialog.DefaultExt = "sql";
	if (openFileDialog.ShowDialog() == DialogResult.OK) {
		// statische Methode zum Wiederherstellen
		CsharpMySql.dbImportFromSql(openFileDialog.FileName);
	}
	// Neustart der Anwendung mit den wiederhergestellten Daten
	Application.Restart();
}
#endregion Backup
		/// <summary>
		/// Sichern, Schließen und Beenden
		/// </summary>
		private void beendenToolStripMenuItem_Click(object sender, EventArgs e) {
			// Vor dem beenden Änderungen aktualisieren
			aktualisierenToolStripMenuItem_Click(sender, e);
			// Datenbankverbindung beenden
			CsharpMySql.con.Close();
			// Anwendung schließen
			this.Close();
		}
		#endregion 3. Ereignismethoden
	}
}
