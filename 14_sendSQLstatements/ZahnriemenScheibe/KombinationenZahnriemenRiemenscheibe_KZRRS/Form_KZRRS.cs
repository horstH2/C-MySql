using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace KombinationenZahnriemenRiemenscheibe_KZRRS {
/// <summary>
///  Kombinationen
///  KZRRS - Kominationen Zahnriemen - Riemenscheibe
/// </summary>
public partial class Form_KZRRS : Form {
#region 1. Attribute, Instanzen der Klasse
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=vorschubantrieb";
#endregion 1. Attribute, Instanzen der Klasse
/// <summary>
/// Konstruktor
/// </summary>
public Form_KZRRS() {
  InitializeComponent();
}
#region Ereignismethoden
/// <summary>
/// Ruft die Methode zum Selektieren und Laden
/// der Kombinationen: Zahnriemen-Riemenscheibe
/// </summary>
private void Form_KZRRS_Load(object sender, EventArgs e) {
  kombinationenToolStripMenuItem_Click(sender, e);
}
/// <summary>
/// Selektieren und Laden der Kombinationen: Zahnriemen-Riemenscheibe
/// </summary>
private void kombinationenToolStripMenuItem_Click(object sender, EventArgs e) {
  // Erzeugt und öffnet ein Verbindungsobjekt 
  // zur Datenbank 
  MySqlConnection conn = new MySqlConnection(connectingString);
  conn.Open();
  // Generiert eine SQL-Anweisung mit Daten
  // der Datenbank "Vorschubantrieb"
  MySqlCommand cmd = conn.CreateCommand();
  cmd.CommandText = 
  "SELECT zahnriemen.idZahnriemen, " +
        "zahnriemen.Typ, " +
        "zahnriemen.Bezeichnung, "+
        "zahnriemen.Laenge, " +
        "zahnscheiben.idScheiben, " +
         "zahnscheiben.Typ, "+
        "zahnscheiben.Bezeichnung, " +
        "zahnscheiben.Durchmesser, " +
        "zahnscheiben.Zaehnezahl " +
        "FROM zahnriemen " +
        "JOIN zahnscheiben " +
        "WHERE (zahnriemen.Typ=zahnscheiben.Typ) " +
        "ORDER By zahnriemen.Typ;";
  // Verbindung zur Datenbank und Ausführen der SQL-Anweisung
  MySqlDataAdapter dataAdapter_KZRRS = new MySqlDataAdapter(cmd);
  // Ein neues Dataset wird mit den selektierten Daten gefüllt
  DataSet DataSet_KZRRS = new DataSet();
  dataAdapter_KZRRS.Fill(DataSet_KZRRS);
  // Tabellarische Darstellung der Selektion
  dataGridView_KZRRS.DataSource = DataSet_KZRRS.Tables[0].DefaultView;
  // Schließen der Verbindung "conn"
  if (conn != null) conn.Close();
}
/// <summary>
/// Beendet die Anwendung
/// </summary>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e) {
  Close();
}
#endregion Ereignismethoden
  }
}
