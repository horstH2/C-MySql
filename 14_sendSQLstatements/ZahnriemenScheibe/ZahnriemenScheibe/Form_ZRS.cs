using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //++
using OwnMySqlDB; //-> CsharpMySql
namespace ZahnriemenScheibe {
/// <summary>
/// Senden einer SQL-Anweisung zur Selektion von Datensätzen
/// </summary>
public partial class Form_ZRS : Form   {
#region 1. Attribute, Instanzen der Klasse
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=vorschubantrieb";
CsharpMySql dbZR = new CsharpMySql("zahnriemen", connectingString);
CsharpMySql dbZRS = new CsharpMySql("zahnscheiben", connectingString);
#endregion 1. Attribute, Instanzen der Klasse
/// <summary>
/// Konstruktor
/// </summary>
public Form_ZRS() {
  InitializeComponent();
}
#region 2. Ereignismethoden
/// <summary>
/// Sichtbare Komponenten an die Datenquelle binden
/// ZR - Zahnriemen
/// ZRS - Zahnriemenscheibe(n)
/// </summary>
private void Form_ZRS_Load(object sender, EventArgs e) {
  // Navigatoren an Datenquelle binden
  bindingNavigator_ZR.BindingSource = dbZR.getBindingSource;
  bindingNavigator_ZRSrecherche.BindingSource = dbZRS.getBindingSource;
  // Sichtbare Tabellen an Datenquelle binden
  dataGridView_ZR.DataSource = dbZR.getBindingSource;
  dataGridView_ZRSrecherche.DataSource = dbZRS.getBindingSource;
}
/// <summary>
/// Sendet eine SQL-Anweisung und führt diese aus.
/// Darstellung der Rechercheergebnisse in Tabellenform.
/// ZRSrecherche - Selektergebnis bezüglich der Zahnriemenscheiben
/// </summary>
private void dataGridView_ZR_CellClick(object sender, DataGridViewCellEventArgs e) {
  //Auswahl des Zahnriemens und lesen des Typs
  int i = dataGridView_ZR.CurrentCell.RowIndex;
  string typ = (string)dataGridView_ZR["Typ", i].Value;
  // Erzeugt und öffnet ein Verbindungsobjekt zur Datenbank 
  MySqlConnection conn = new MySqlConnection(connectingString);
  conn.Open();
  /// +++++++++++++++++++++++++++++++++++
  // Generiert eine SQL-Anweisung
  MySqlCommand cmd = conn.CreateCommand();
  cmd.CommandText = "SELECT * FROM zahnscheiben WHERE (zahnscheiben.typ= @typ);";
  // Parameterübergabe
  cmd.Parameters.AddWithValue("@typ", typ);
  /// +++++++++++++++++++++++++++++++
  /// SQL-Anweisung wird ausgeführt 
  MySqlDataAdapter dataAdapter_ZRSrecherche = new MySqlDataAdapter(cmd);
  // Ein neues Dataset wird mit den selektierten Daten gefüllt
  DataSet DataSet_ZRSrecherche = new DataSet();
  dataAdapter_ZRSrecherche.Fill(DataSet_ZRSrecherche);
  // Neues Verbindungsobjekt mit Übernahme der Rechercheergebnisse
  BindingSource bindingSource_recherche = new BindingSource();
  bindingSource_recherche.DataSource = DataSet_ZRSrecherche.Tables[0].DefaultView;
  // Sichtbare Tabelle und Navigator an das Rechercheergebnis binden
  dataGridView_ZRSrecherche.DataSource = bindingSource_recherche;
  bindingNavigator_ZRSrecherche.BindingSource = bindingSource_recherche;
  // Schließen der Verbindung "conn"
  if (conn != null) conn.Close();
}
/// <summary>
/// Zeigt alle Zahnriemenscheiben
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void toolStripButton_Off_Click(object sender, EventArgs e) {
  // Bindung mit dem kompletten Zahnriemenscheiben-Datenbankobjekt
  dataGridView_ZRSrecherche.DataSource = dbZRS.getBindingSource;
  bindingNavigator_ZRSrecherche.BindingSource = dbZRS.getBindingSource;
}
/// <summary>
/// Beenden der Anwendung
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void toolStripButton_Beenden_Click(object sender, EventArgs e) {
  Close();
}
#endregion Ereignismethoden
}
}
