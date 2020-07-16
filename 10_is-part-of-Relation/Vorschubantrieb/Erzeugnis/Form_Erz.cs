using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OwnMySqlDB; // Klassen: "CsharpMySql"
using OwnCompCon; // Klasse: "CompCon"
namespace Erzeugnis {
	public partial class Form_Erz : Form	{
#region 1. Attribute, Instanzen der Klasse
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=vorschubantrieb";
// Datenbankobjekte (Instanz´der Klasse)
CsharpMySql dbLager = new CsharpMySql("lager", connectingString);
CsharpMySql dbMotor = new CsharpMySql("motor", connectingString);
CsharpMySql dbPassfedern = new CsharpMySql("passfedern", connectingString);
CsharpMySql dbSchrauben = new CsharpMySql("schrauben", connectingString);
CsharpMySql dbSpindel = new CsharpMySql("spindel", connectingString);
CsharpMySql dbZahnriemen = new CsharpMySql("zahnriemen", connectingString);
CsharpMySql dbZahnscheiben = new CsharpMySql("zahnscheiben", connectingString);
// Erzeugnis und Baugruppe
CsharpMySql dbAntrieb = new CsharpMySql("Vorschubantrieb", connectingString);
CsharpMySql dbGestell = new CsharpMySql("Gestell", connectingString);
#endregion 1. Attribute
		public Form_Erz()
		{
			InitializeComponent();
		}
#region 2. Start
/// <summary>
/// Starten der Anwendung
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void Form_Erz_Load(object sender, EventArgs e)
{
	#region 2.1 Komponenten an Datenquellenattribute binden
	// Navigatoren
	bindingNavigator_Antrieb.BindingSource = dbAntrieb.getBindingSource;
	bindingNavigator_Gestell.BindingSource = dbGestell.getBindingSource;
	// Datentabellensicht
	dataGridView_Antrieb.DataSource = dbAntrieb.getBindingSource;
	dataGridView_Gestell.DataSource = dbGestell.getBindingSource;
	// Textkomponenten,  per Listen und eigener Methode 
	var textBoxes = new List<TextBox> //- Vorschubantrieb
						{ textBox_idAntrieb,  textBox_Antrieb, textBox_AnzahlPassfedern, textBox_AnzahlSchrauben };
	var attributs = new List<string>
						{ "idAntrieb", "Vorschubantrieb", "passfederAnzahl", "schraubenAnzahl" };
	Comp.textboxBinding(textBoxes, attributs, dbAntrieb);
	textBoxes = new List<TextBox> 			// Gestell
						{ textBox_idGestell,  textBox_Gestell, textBox_AnzahlLager, textBox_AnzahlSchrauben_ };
	attributs = new List<string>
						{ "idGestell", "Gestellbaugruppe", "lagerAnzahl", "schraubenAnzahl" };
	Comp.textboxBinding(textBoxes, attributs, dbGestell);
	#endregion 2.1 Komponenten an Datenquellenattribute binden
	#region 2.2 Auswahlboxen und Part-Of-Tabellen (Nachschlagetabellen)
	// - Bereitstellen der Teile und der Baugruppe in den Comboboxen
	// -- Baugruppe Gestell
	Comp.nachschlagen(comboBox_idSpindel, dbSpindel, "Bezeichnung", "idSpindel");
	Comp.nachschlagen(comboBox_idLager, dbLager, "Bezeichnung", "idLager");
	Comp.nachschlagen(comboBox_idMotor, dbMotor, "Bezeichnung", "idMotor");
	Comp.nachschlagen(comboBox_idSchrauben_, dbSchrauben, "Typ", "idSchrauben");
	// -- Erzeugnis Vorschubantrieb 
	Comp.nachschlagen(comboBox_idGestell, dbGestell, "Gestellbaugruppe", "idGestell");
	Comp.nachschlagen(comboBox_idAntriebsscheibe, dbZahnscheiben, "Bezeichnung", "idScheiben");
	Comp.nachschlagen(comboBox_idAbtriebsscheibe, dbZahnscheiben, "Bezeichnung", "idScheiben");
	Comp.nachschlagen(comboBox_idZahnriemen, dbZahnriemen, "Bezeichnung", "idZahnriemen");
	Comp.nachschlagen(comboBox_idPassfedern, dbPassfedern, "Typ", "idPassfedern");
	Comp.nachschlagen(comboBox_idSchrauben, dbSchrauben, "Typ", "idSchrauben");
	#endregion 2.2 Auswahlbox und Part-Of-Tabellen (Nachschlagetabellen)
	// Datentabellen anpassen
	bindingNavigator_Gestell.BindingSource.ResetBindings(true);
	bindingNavigator_Antrieb.BindingSource.ResetBindings(true);
	dataGridView_Gestell.Columns["idGestell"].Visible = false;
	dataGridView_Antrieb.Columns["idAntrieb"].Visible = false;

}
#endregion 2. Start
#region 3. Aktualisieren
/// <summary>
/// Aktualisiert den Antrieb
/// </summary>
private void toolStripButton_AktualisierenAntrieb_Click(object sender, EventArgs e) {
	dbAntrieb.aktualisieren();
	CsharpMySql.dataSet.AcceptChanges();
}
/// <summary>
/// Aktualisiert das Gestell
/// </summary>
private void toolStripButton_AktualisierenGestell_Click(object sender, EventArgs e) {
	dbGestell.aktualisieren();
	CsharpMySql.dataSet.AcceptChanges();
}
#endregion 3. Aktualisieren
#region 4. Select, Teile in Baugruppe und Erzeugnis übernehmen
#region 4.1 Baugruppe: Gestell
private void comboBox_idSpindel_SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Gestell.CurrentRow.Cells["idSpindel"].Value = comboBox_idSpindel.SelectedValue;
}
private void comboBox_idLager_SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Gestell.CurrentRow.Cells["idLager"].Value = comboBox_idLager.SelectedValue;
}
private void comboBox_idSchrauben__SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Gestell.CurrentRow.Cells["idSchrauben"].Value = comboBox_idSchrauben_.SelectedValue;
}
private void comboBox_idMotor_SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Gestell.CurrentRow.Cells["idMotor"].Value = comboBox_idMotor.SelectedValue;
}
#endregion 4.1 Baugruppe: Gestell
#region 4.2 Erzeugnis: Vorschubantrieb
private void comboBox_idGestell_SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Antrieb.CurrentRow.Cells["idGestell"].Value = comboBox_idGestell.SelectedValue;
}
private void comboBox_idAntriebsscheibe_SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Antrieb.CurrentRow.Cells["idAntriebsscheibe"].Value = comboBox_idAntriebsscheibe.SelectedValue;
}

private void comboBox_idAbtriebsscheibe_SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Antrieb.CurrentRow.Cells["idAbtriebsscheibe"].Value = comboBox_idAbtriebsscheibe.SelectedValue;
}

private void comboBox_idZahnriemen_SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Antrieb.CurrentRow.Cells["idZahnriemen"].Value = comboBox_idZahnriemen.SelectedValue;
}

private void comboBox_idPassfeder_SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Antrieb.CurrentRow.Cells["idPassfeder"].Value = comboBox_idPassfedern.SelectedValue;
}
private void comboBox_idSchrauben_SelectionChangeCommitted(object sender, EventArgs e) {
	dataGridView_Antrieb.CurrentRow.Cells["idSchrauben"].Value = comboBox_idSchrauben.SelectedValue;
}
#endregion 4.2 Erzeugnis: Vorschubantrieb
#endregion 4. Aktualisieren
#region 5. Finde Datensätze in den Part-Of-Tabellen
/// <summary>
/// Gestellbaugruppe
/// </summary>
private void dataGridView_Gestell_CellEnter(object sender, DataGridViewCellEventArgs e) {
	Comp.isPartOf(dataGridView_Gestell, "idSpindel", dbSpindel);
	Comp.isPartOf(dataGridView_Gestell, "idMotor", dbMotor);
	Comp.isPartOf(dataGridView_Gestell, "idLager", dbLager);
	Comp.isPartOf(dataGridView_Gestell, "idSchrauben", dbSchrauben);
	textBox_Schrauben_.Text = comboBox_idSchrauben_.Text;
}
/// <summary>
/// Vorschubantrieb
/// </summary>
private void dataGridView_Antrieb_CellEnter(object sender, DataGridViewCellEventArgs e) {
	Comp.isPartOf(dataGridView_Antrieb, "idGestell", dbGestell);
	Comp.isPartOf(dataGridView_Antrieb, "idAntriebsscheibe", "idScheiben", dbZahnscheiben);
	textBox_Antriebsscheibe.Text = comboBox_idAntriebsscheibe.Text;
	Comp.isPartOf(dataGridView_Antrieb, "idAbtriebsscheibe", "idScheiben", dbZahnscheiben);
	textBox_Abtriebsscheibe.Text = comboBox_idAbtriebsscheibe.Text;
	Comp.isPartOf(dataGridView_Antrieb, "idZahnriemen", dbZahnriemen);
	Comp.isPartOf(dataGridView_Antrieb, "idPassfedern", dbPassfedern);
	Comp.isPartOf(dataGridView_Antrieb, "idSchrauben", dbSchrauben);
	textBox_Schrauben.Text = comboBox_idSchrauben.Text;
}
#endregion 5. Finde Datensätze in den Part-Of-Tabellen
/// <summary> ---------------------------------------------------------------
/// Beenden der Anwendung
/// </summary>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
	// Tabellen aktualisieren
	toolStripButton_AktualisierenGestell_Click(sender, e);
	toolStripButton_AktualisierenAntrieb_Click(sender, e);
	// Datenbankverbindung beenden
	CsharpMySql.con.Close();
	//Anwendung schließen
	Close();
}


	}
}
