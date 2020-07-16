using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OwnMySqlDB; // Klasse "CsharpMySql"

namespace KundenWerkstuecke
{
  public partial class Form_KundenBestellenWerkstuecke : Form
  {
		#region 1. Attribute, Instanzen der Klasse
		// Verbindungsstring ist Applikationsabhängig
		static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=kundenwerkstuecke";
		// Hauptobjekt (Instanz´der Klasse)
		CsharpMySql dbAT = new CsharpMySql("auftraege", connectingString);
		// Nachschlageobjekt (Instanz der Klasse)
		CsharpMySql dbKD = new CsharpMySql("kunden", connectingString);
		// Nachschlageobjekt (Instanz der Klasse)
		CsharpMySql dbWSt = new CsharpMySql("werkstuecke", connectingString);
		#endregion 1. Attribute
		/// <summary>
		/// Konstruktor
		/// </summary>
		public Form_KundenBestellenWerkstuecke() {
    InitializeComponent();
		}
	#region 2. Ereignismethoden
#region 2.1 Formular
/// <summary>
/// Holt die Daten aus der Datenbank beim Laden des Formulars
/// </summary>
private void Form_KundenBestellungen_Load(object sender, EventArgs e) {
	// Navigatoren an Datenquelle binden
	bindingNavigator_AT.BindingSource = dbAT.getBindingSource;
	bindingNavigator_KD.BindingSource = dbKD.getBindingSource;
	bindingNavigator_WSt.BindingSource = this.dbWSt.getBindingSource;
	// Sichtbare Tabellen an Datenquelle binden
	dataGridView_AT.DataSource = dbAT.getBindingSource;
	dataGridView_KD.DataSource = dbKD.getBindingSource;
	dataGridView_WSt.DataSource = dbWSt.getBindingSource;
	// Anpassen der sichtbaren Tabellen
	dataGridView_AT.AutoResizeColumns();
	dataGridView_KD.AutoResizeColumns();
	dataGridView_WSt.AutoResizeColumns();
	dataGridView_WSt.Columns["Zeichnung"].Visible = false;
	/// AUFTRAGSFORMULAR
	// - Textkomponenten an Datenquellenattribute binden
	//   per Listen und eigener Methode 
	var textBoxes = new List<TextBox>
		{ textBox_idAT,  textBox_Auftrag, textBox_Liefertermin};
	var attributs = new List<string>
		{ "idAT", "Auftrag", "Liefertermin" };
	textboxBinding(textBoxes, attributs, dbAT);
	/// RELATION ZWISCHEN AUSWAHLBOX UND NACHSCHLAGETABELLE "Kunden" -----
	// - Binden an die Nachschlagetabelle
	comboBox_AT_idKD.DataSource = dbKD.getBindingSource;
	// - Attribut zum Anzeigen
	comboBox_AT_idKD.DisplayMember = "Kunde";
	// - Sekundärschlüssel in der Haupttabelle
	comboBox_AT_idKD.ValueMember = "idKD";
	/// KUNDENFORMULAR
	textBoxes = new List<TextBox>
		{textBox_idKD, textBox_Kunde, textBox_Strasse, textBox_Nr,
			textBox_PLZ, textBox_Ort,textBox_Email, textBox_Telefon,
			textBox_infoIdKD, textBox_infoKunde, textBox_infoKDstrasse, textBox_infoKDnr,
			textBox_infoKDplz, textBox_infoKDort,textBox_infoKDemail, textBox_infoKDtelefon};
	attributs = new List<string>
			{"idKD", "kunde",  "strasse", "nr",
			"plz", "ort", "telefon", "email",
			"idKD", "kunde",  "strasse", "nr",
			"plz", "ort", "telefon", "email"};
	textboxBinding(textBoxes, attributs, dbKD);
	/// RELATION ZWISCHEN AUSWAHLBOX UND NACHSCHLAGETABELLE "Werkstücke" ----
	// - Binden an die Nachschlagetabelle
	comboBox_AT_idWSt.DataSource = dbWSt.getBindingSource;
	// - Attribut zum Anzeigen
	comboBox_AT_idWSt.DisplayMember = "Werkstueck";
	// - Sekundärschlüssel in der Haupttabelle
	comboBox_AT_idWSt.ValueMember = "idWSt";
	/// WERKSTÜCKFORMULAR
	textBoxes = new List<TextBox>
		{textBox_idWSt , textBox_Werkstueck, textBox_Bearbeiter,
			textBox_infoIdWst, textBox_infoWerkstueck, textBox_infoWStBearbeiter};
	attributs = new List<string>
		{"idWSt", "Werkstueck","Bearbeiter",
		"idWSt", "Werkstueck","Bearbeiter"};
	textboxBinding(textBoxes, attributs, dbWSt);
	// Zeichnung an Datenbanktabelle anbinden
	pictureBox_Werkstueck.DataBindings.Add(new Binding("Image", dbWSt.bindingSource, "Zeichnung", true));
}
/// <summary>
/// Bindet die Textboxen, an die Tabellenattributte der Danbankobjekte
/// </summary>
/// <param name="textBoxes"></param> Textboxobjektnamen
/// <param name="attributs"></param> Attributnamen
/// <param name="dbObj"></param>     Datennbank-Tabellen-Objekt
/// <param name="eigenschaft"></param> zu setzende Eigenschaft, Standard ist "Text"
private void textboxBinding(List<TextBox> textboxes, List<string> attributs, CsharpMySql dbObj, string eigenschaft="Text") {
	for (int idx = 0; idx < textboxes.Count; idx++) {
		textboxes[idx].DataBindings.Add(new Binding(eigenschaft, dbObj.bindingSource, attributs[idx], true));
	}
}
/// <summary>
/// Zeigt auf die Partnerzeile in den Nachschlagetabellen +
/// </summary>
private void Form_KundenBestellungen_Shown(object sender, EventArgs e) {
		showSubTableSynchronous(); 
}




		#endregion 2.1 Formular
		#region 2.2 Nachschlagen und synchronisieren
		/// <summary>
		/// Zeigt auf die Partnerzeile in der Nachschlagetabelle
		/// -> Ereignismethode
		/// </summary>
		private void dataGridView_AT_CellEnter(object sender, DataGridViewCellEventArgs e) {
	
			showSubTableSynchronous();
}
	/// <summary>
	/// Kunde in die Auftragstabelle übernehmen
	/// </summary>
	private void comboBox_AT_idKD_SelectionChangeCommitted(object sender, EventArgs e) {
		int aktuelleZeile = dataGridView_AT.CurrentCell.RowIndex;
		dataGridView_AT.Rows[aktuelleZeile].Cells["idKD"].Value = comboBox_AT_idKD.SelectedValue.ToString();
}
/// <summary>
/// Werkstück in die Auftragstabelle übernehmen
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void comboBox_AT_idWSt_SelectionChangeCommitted(object sender, EventArgs e){
	int aktuelleZeile = dataGridView_AT.CurrentCell.RowIndex;
	dataGridView_AT.Rows[aktuelleZeile].Cells["idWSt"].Value = comboBox_AT_idWSt.SelectedValue.ToString();
}


	 /// <summary>
	 /// Zeigt die Datensätze der Nachschlagetabellen synchron zur Haupttanbelle
	 /// - Lokale Methode des Formulars
	 /// </summary>
	 private void showSubTableSynchronous() {
		 // aktuelle Zeile
		 int aktuelleZeile = 0;
		 try
		 {  //Leere Tabellen sollten nicht zu einem Fehler führen
			 aktuelleZeile = dataGridView_AT.CurrentCell.RowIndex;
			 // Kunden synchronisieren
			 string idKD = dataGridView_AT.Rows[aktuelleZeile].Cells["idKD"].Value.ToString();
			 // Findet Auswahl in der Nachschlagetabelle Kunden
			 dbKD.bindingSource.Position = dbKD.bindingSource.Find("idKD", idKD);
			 // Werkstücke synchronisieren
			 string idWSt = dataGridView_AT.Rows[aktuelleZeile].Cells["idWSt"].Value.ToString();
			 // Findet Auswahl in der Nachschlagetabelle Weekstücke
			 dbWSt.bindingSource.Position = dbWSt.bindingSource.Find("idWSt", idWSt);
		 }
		 catch (Exception ex) { aktuelleZeile = 0; }
	 }

		#endregion 2.2 Nachschlagen und synchronisieren
		#region 2.3 Navigatormenüs und Mainmenü
		/// <summary>
		/// Aktualisiert die Auftragsdaten
		/// </summary>
		private void toolStripButton_AuftragAktualisieren_Click(object sender, EventArgs e) {
	dbAT.aktualisieren();
	CsharpMySql.dataSet.AcceptChanges();
}
/// <summary>
/// Aktualisiert die Kundendaten
/// </summary>
private void toolStripButton_KundeAktualisieren_Click(object sender, EventArgs e) {
	dbKD.aktualisieren();
	CsharpMySql.dataSet.AcceptChanges();
}
/// <summary>
/// Aktualisiert die Werkstücke
/// </summary>
private void toolStripButton_WerkstueckAktualisieren_Click(object sender, EventArgs e) {
	dbWSt.aktualisieren();
	CsharpMySql.dataSet.AcceptChanges();
}
/// <summary>
/// Schließt nach der Aktualisierung der Datenbank die Anwendung
/// </summary>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
	// Tabellen aktualisieren
	toolStripButton_AuftragAktualisieren_Click(sender, e);
	toolStripButton_KundeAktualisieren_Click( sender,  e);
	toolStripButton_WerkstueckAktualisieren_Click(sender, e);
	// Datenbankverbindung beenden
	CsharpMySql.con.Close();
	//Anwendung schließen
	Close();
}
#endregion 2.3 Navigatormenüs und Mainmenü
#region 2.4 Kontextmenü für Zeichnungen
// Fügt aus der Zwischenablage ein Bild eine
private void toolStripMenuItem_Einfuegen_Click(object sender, EventArgs e)
{
	pictureBox_Werkstueck.Image = Clipboard.GetImage();
}
// Kopiert das Bild in die Zwischenablage
private void toolStripMenuItem_Kopieren_Click(object sender, EventArgs e)
{
	Clipboard.SetImage(pictureBox_Werkstueck.Image);
}
// Löscht das Bild
private void toolStripMenuItem_Loeschen_Click(object sender, EventArgs e)
{
	pictureBox_Werkstueck.Image = null;
}

#endregion 2.3 Kontextmenü für Zeichnungen

		#endregion 2. Ereignismethoden


	}
}
