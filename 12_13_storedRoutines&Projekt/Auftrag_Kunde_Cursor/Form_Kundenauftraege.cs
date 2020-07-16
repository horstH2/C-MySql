using System;
using System.Collections.Generic;
using System.Windows.Forms;
/// Eigene Klassen
using OwnMySqlDB; // -> CsharpMySql
using OwnCompCon; // -> Comp
namespace Auftrag_Kunde {
public partial class Form_Kundenauftraege : Form  {
#region 1. Attribute, Instanzen der Klasse
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=kundenwerkstueckarbeitsplaene";
// Hauptobjekt (Instanz´der Klasse)
CsharpMySql dbAT = new CsharpMySql("auftraege", connectingString);
// Nachschlageobjekt (Instanz der Klasse)
CsharpMySql dbKD = new CsharpMySql("kunden", connectingString);
// Nachschlageobjekt (Instanz der Klasse)
CsharpMySql dbWSt = new CsharpMySql("werkstuecke", connectingString);
// Detailtabelle (Instanz der Klasse)
CsharpMySql dbAP = new CsharpMySql("arbeitsplan", connectingString);
// Rechercheformular-Instanz
Form_Recherche recherche = new Form_Recherche(connectingString);
#endregion 1. Attribute
public Form_Kundenauftraege() {
  InitializeComponent();
}
#region 2. Formularansicht aktualisiern
/// <summary>
/// Stellt Datensätze bereit
/// </summary>
private void Form_Kundenauftraege_Load(object sender, EventArgs e) {
  #region 2.1. Binden, Relation
  // Navigatoren an Datenquelle binden
  bindingNavigator_AT.BindingSource = dbAT.getBindingSource;
  this.bindingNavigator_KD.BindingSource = this.dbKD.getBindingSource;
  this.bindingNavigator_WSt.BindingSource = this.dbWSt.getBindingSource;
  this.bindingNavigator_AP.BindingSource = this.dbAP.getBindingSource;
  // Sichtbare Tabellen an Datenquelle binden
  this.dataGridView_AT.DataSource = this.dbAT.getBindingSource;
  this.dataGridView_KD.DataSource = this.dbKD.getBindingSource;
  this.dataGridView_WSt.DataSource = this.dbWSt.getBindingSource;
  this.dataGridView_WStAP.DataSource = this.dbAP.getBindingSource;
  this.dataGridView_AP.DataSource = this.dbAP.getBindingSource;
  // Instanz einer Haupttabelle: Definiert Relation zwischen der Haupttabelle und Detailtabelle 
  dbWSt.mainToSubRelation("arbeitsplan", dbAP.getBindingSource, 0, 0);
  #endregion 2.1. Binden, Relation
  #region 2.2. Textkomponenten an Datenquellenattribute binden per Listen und eigener Methode 
  /// AUFTRAGSFORMULAR ----------------------------
  var textBoxes = new List<TextBox>
{ textBox_idAT,  textBox_Auftrag, textBox_Stueckzahl, textBox_Liefertermin};
  var attributs = new List<string>
{ "idAT", "Auftrag", "Stueckzahl", "Liefertermin" };
  Comp.textboxBinding(textBoxes, attributs, dbAT);
  /// NACHSCHLAGERELATION ZWISCHEN AUSWAHLBOX UND NACHSCHLAGETABELLE "Kunden" -----
  // - Binden an die Nachschlagetabelle
  comboBox_AT_idKD.DataSource = dbKD.getBindingSource;
  // - Attribut zum Anzeigen
  comboBox_AT_idKD.DisplayMember = "Kunde";
  // - Sekundärschlüssel in der Haupttabelle
  comboBox_AT_idKD.ValueMember = "idKD";
  /// KUNDENFORMULAR ------------------------
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
  Comp.textboxBinding(textBoxes, attributs, dbKD);
  /// NACHSCHLAGERELATION ZWISCHEN AUSWAHLBOX UND NACHSCHLAGETABELLE "Werkstücke" ----
  // - Binden an die Nachschlagetabelle
  comboBox_AT_idWSt.DataSource = dbWSt.getBindingSource;
  // - Attribut zum Anzeigen
  comboBox_AT_idWSt.DisplayMember = "Werkstueck";
  // - Sekundärschlüssel in der Haupttabelle
  comboBox_AT_idWSt.ValueMember = "idWSt";
  /// WERKSTÜCKFORMULAR  ----------------------
  textBoxes = new List<TextBox>
{textBox_idWSt , textBox_Werkstueck, textBox_Bearbeiter,
  textBox_infoIdWSt, textBox_infoWerkstueck, textBox_infoWStBearbeiter, textBox_idWSt_AV };
  attributs = new List<string>
{"idWSt", "Werkstueck","Bearbeiter",
"idWSt", "Werkstueck","Bearbeiter", "idWSt"};
  Comp.textboxBinding(textBoxes, attributs, dbWSt);
  /// ARBEITSVORGANGSFORMULAR --------------
  textBoxes = new List<TextBox>
{textBox_idAV , textBox_Vorgang, textBox_Arbeitsplatz, textBox_tr, textBox_te };
  attributs = new List<string>
{"idAV", "Arbeitsvorgang","Arbeitsplatz", "Ruestzeit", "ZeitJeEinheit"};
  Comp.textboxBinding(textBoxes, attributs, dbAP);
  #endregion 2.2. Textboxen binden
  // Bildbox für Zeichnung an Datenbanktabelle anbinden
  pictureBox_Werkstueck.DataBindings.Add(new Binding("Image", dbWSt.getBindingSource, "Zeichnung", true));
  // Zeichnungen in Tabellen unerwünscht
  dataGridView_WSt.Columns["Zeichnung"].Visible = false;
}
/// <summary>
/// Zeigt den passenden Datensatz der Nachschlagetabelle
/// in Bezug zum Datensatz der Haupttabelle
/// </summary>
private void Form_Kundenauftraege_Shown(object sender, EventArgs e) {
  dbKD.showSubTableSynchronous(dataGridView_AT, "idKD");
  dbWSt.showSubTableSynchronous(dataGridView_AT, "idWSt");
}
#endregion 2. Formularansicht aktualisiern
#region 3. Datenbank aktualisiern
/// <summary>
/// Übernimmt den aktuell editierten Datensatz
/// </summary>
private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e) {
  toolStripButton_WStaktualisieren_Click(sender, e);
  toolStripButton_KDaktualisieren_Click(sender, e);
  toolStripButton_ATaktualisieren_Click(sender, e);
  toolStripButton_APaktualisieren_Click(sender, e);
}
/// <summary>
/// Aktualisiert Auftragsdaten
/// </summary>
private void toolStripButton_ATaktualisieren_Click(object sender, EventArgs e) {
  dbAT.aktualisieren(dataGridView_AT);
}
/// <summary>
/// Aktualisiert Kundendaten
/// </summary>
private void toolStripButton_KDaktualisieren_Click(object sender, EventArgs e) {
  dbKD.aktualisieren(dataGridView_KD);
}
/// <summary>
/// Aktualisiert Werkstückdaten
/// </summary>
private void toolStripButton_WStaktualisieren_Click(object sender, EventArgs e) {
  dbWSt.aktualisieren(dataGridView_WSt);
}
/// <summary>
/// Aktualiert Arbeitsplandaten
/// </summary>
private void toolStripButton_APaktualisieren_Click(object sender, EventArgs e) {
  dbAP.aktualisieren(dataGridView_AP);
}
#endregion 3. Datenbank aktualisiern
#region 4. Nachschlagen und synchronisieren
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
private void comboBox_AT_idWSt_SelectionChangeCommitted(object sender, EventArgs e) {
  int aktuelleZeile = dataGridView_AT.CurrentCell.RowIndex;
  dataGridView_AT.Rows[aktuelleZeile].Cells["idWSt"].Value = comboBox_AT_idWSt.SelectedValue.ToString();
}
/// <summary>
/// Zeigt auf die Partnerzeile in den Nachschlagetabellen
/// Gegenüberstellung: Instanzmethoden - Klassenmethoden
/// (Beide Varianten sind möglich)
/// </summary>
private void dataGridView_AT_CellEnter(object sender, DataGridViewCellEventArgs e) {
  // Aufruf als Instanzmethoden der Klasse CsharpMySql
  // dbKD.showSubTableSynchronous(dataGridView_AT, "idKD");
  // dbWSt.showSubTableSynchronous(dataGridView_AT, "idWSt");
  // Aufruf als Klassenmethoden der Klasse Comp
  Comp.showSubTableSynchronous(dataGridView_AT, "idKD", dbKD.getBindingSource);
  Comp.showSubTableSynchronous(dataGridView_AT, "idWSt", dbWSt.getBindingSource);
}
#endregion 4. Nachschlagen und synchronisieren
#region 5. Bild
/// <summary>
/// Fügt aus der Zwischenablage ein Bild eine
/// </summary>
private void toolStripMenuItem_Einfuegen_Click(object sender, EventArgs e) {
  pictureBox_Werkstueck.Image = Clipboard.GetImage();
}
/// <summary>
/// Kopiert das Bild in die Zwischenablage
/// </summary>
private void toolStripMenuItem_Kopieren_Click(object sender, EventArgs e) {
  Clipboard.SetImage(pictureBox_Werkstueck.Image);
}
/// <summary>
/// Löscht das Bild
/// </summary>
private void toolStripMenuItem_Loeschen_Click(object sender, EventArgs e) {
  pictureBox_Werkstueck.Image = null;
}
#endregion 5. Bild
#region 6. Formular 
/// <summary>
/// Ruft das Rechercheformular
/// </summary>
private void durchlaufzeitRechercheToolStripMenuItem_Click(object sender, EventArgs e) {
  recherche.Show(); //Zeige Kindformular
  recherche.Activate(); // Kindformular aktivieren
}
/// <summary>
/// Schließt nach der Aktualisierung der Datenbank die Anwendung
/// </summary>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e) {
  aktualisierenToolStripMenuItem_Click(sender, e);
  Close();
}
#endregion 6. Formular


 
  }
}
