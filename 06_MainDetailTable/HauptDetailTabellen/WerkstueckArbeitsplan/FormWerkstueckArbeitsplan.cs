using System;
using System.Windows.Forms;
using OwnMySqlDB;  // Namespace hinzufügen: Eigene Klasse zur Kommunikation mit einer MySql-Datenbank

namespace WerkstueckArbeitsplan
{
	public partial class Form_WSt_Ap : Form
  {
		#region 1. Attribute, Instanzen der Klasse für Werkstücke und Arbeitsvorgangsdaten
		// Verbindungsstring ist Applikationsabhängig
		static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=fertigungsplanung";
		// Hauptobjekt (Instanz´der Klasse)
		CsharpMySql dbWSt = new CsharpMySql("werkstuecke", connectingString);
		// Detailobjekt (Instanz der Klasse)
		CsharpMySql dbAP = new CsharpMySql("arbeitsplaene", connectingString);
		#endregion 1. Attribute, Instanzen der Klasse für Werkstücke und Arbeitsvorgangsdaten
		#region 2. Konstruktor der Formularklasse
		public Form_WSt_Ap()
    {
       InitializeComponent();
		}
		#endregion 2. Konstruktor der Formularklasse
		#region 3. Ereignismethoden
		/// <summary>
		/// Laden der Daten aus der Datenbank und visualisieren der Daten
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form_WSt_Ap_Load(object sender, EventArgs e)
		{
			// Ausgabe von Informationen
			this.label_info.Text = CsharpMySql.con.ConnectionString;
			// Navigatoren an Datenquelle binden
			this.bindingNavigator_WSt.BindingSource = this.dbWSt.getBindingSource;
			this.bindingNavigator_AP.BindingSource = this.dbAP.getBindingSource;
			// Verbinden der sichtbaren Komponenten mit den Bindingsources
			this.dataGridView_WSt.DataSource = dbWSt.getBindingSource;
			this.dataGridView_AP.DataSource = dbAP.getBindingSource;
			// Instanz einer Haupttabelle: Definiert Relation zwischen der Haupttabelle und Detailtabelle 
			this.label_info.Text += this.dbWSt.mainDetailRelation("arbeitsplaene", this.dbAP.getBindingSource); //
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
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e) {
			// Die detailtabelle vor der Haupttabelle aktualisieren
			this.label_info.Text=this.dbAP.aktualisieren(dataGridView_AP);
			this.label_info.Text=this.dbWSt.aktualisieren(dataGridView_WSt);
			// Commit für alle Änderungen an diesem Datenset
			CsharpMySql.dataSet.AcceptChanges();
		}
		/// <summary>
		/// Sichern, Schließen und Beenden
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
			// Vor dem beenden Änderungen aktualisieren
			aktualisierenToolStripMenuItem_Click(sender, e);
			// Datenbankverbindung beenden
			CsharpMySql.con.Close();
			// Anwendung schließen
			this.Close();
    }
		#endregion 2. Ereignismethoden
	}
}
