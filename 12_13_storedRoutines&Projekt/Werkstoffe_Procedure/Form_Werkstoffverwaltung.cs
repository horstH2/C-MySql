using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OwnMySqlDB;
namespace Werkstoffverwaltung {
public partial class Form_Werkstoffverwaltung : Form {
#region 1. Attribute, Instanzen 
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=werkstoffdatenroutine";
// Tabelle 
CsharpMySql dbWS = new CsharpMySql("werkstoffe", connectingString);
#endregion 1. Attribute, Instanzen 
public Form_Werkstoffverwaltung()
{
    InitializeComponent();
}
#region 2. Ereignismethoden
/// <summary>
/// Laden der Daten "Fill"
/// </summary>
private void Form_Werkstoffverwaltung_Load(object sender, EventArgs e) {
  bindingNavigator_WS.BindingSource = dbWS.getBindingSource;
  dataGrid_WS.DataSource = dbWS.getBindingSource;
      // Spalte wird hier nicht benötigt
  this.dataGrid_WS.Columns["Rp"].Visible = false;
}
/// <summary>
/// Aktualisieren der Tabellen-Daten in der Datenbank
/// </summary>
private void toolStripButton_Aktualisieren_Click(object sender, EventArgs e) {
  dbWS.aktualisieren(dataGrid_WS);
}
/// <summary>
/// Beenden der Anwendung nach erfolgter Aktualisierung
/// </summary>
private void toolStripButton_Beenden_Click(object sender, EventArgs e)
{
  toolStripButton_Aktualisieren_Click(sender, e);
  Close();
}
#endregion 2. Ereignismethoden
#region 3. OK-Ereignismethode: Stored Procedure
/// <summary>
/// Stored Prozedur mit Parameterübergabe
/// http://www.csharp-station.com/Tutorial/AdoDotNet/Lesson07
/// </summary>
private void button_OK_Click(object sender, EventArgs e)
{
  #region 3.1. Stored Procedure
  // Erzeugt und öffnet ein Verbindungsobjekt,
  // übergeben dwird der bekannte Verbindungsstring zur Datenbank
  MySqlConnection conn = new MySqlConnection(connectingString);
  conn.Open();
  // Erzeugt ein Kommandoobjekt,
  // übergeben werden Name der Stored Procedure und das Verbindungsobjekt
  MySqlCommand cmd = new MySqlCommand("mindestZugfestigkeit", conn);
  cmd.CommandType = CommandType.StoredProcedure;
  // Parameterübergabe an die Stored Procedure;
  // AT (@) kennzeichnet den Parameter der Stored Prozedure
  cmd.Parameters.Add(new MySqlParameter("@parRmMin", textBox_RmMin.Text));
  //Führt die Stored Precedure aus und übergibt deren 
  // Select-Ergebnis an die Variable des Datenreaders
  MySqlDataReader rdr = cmd.ExecuteReader();
  #endregion 3.1. Stored Procedure

  #region 3.2. Ausgabe
  richTextBox_RmMin.Clear();
  // Überschrift
  richTextBox_RmMin.Text += "Werkstoffe mit einer Mindestzugfestigkeit Rm von " + textBox_RmMin.Text +" N/mm²\r\n\n";
  // Tabellarisches Ausgabeformat
  string format = "| {0,10} | {1,-20} |  {2,11} | \r\n";
  // Tabellenkopf
  richTextBox_RmMin.Text += String.Format(format, "ID WS", "Bezeichnung", "Rm in N/mm²");
  // Datensätze ausgeben
  while (rdr.Read()) {
    richTextBox_RmMin.Text += String.Format(format, rdr["idWS"], rdr["Bezeichnung"], rdr["Rm"]);
  }
  #endregion 3.2. Aussgabe
  // Schließen der Verbindung und des Readers
  if (conn != null) conn.Close();
  if (rdr != null) rdr.Close();
}
#endregion 3. OK-Ereignismethode: Stored Procedure


  }
}
