using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //+
using OwnMySqlDB;
namespace Auftrag_Kunde {
  public partial class Form_Recherche : Form {
#region 1. Attribute, Instanzen 
private
CsharpMySql dbDLZ;
string connStr;
#endregion 1. Attribute, Instanzen 
#region 2. Konstruktor
/// <summary>
/// Konstruktor des Rechercheformulars verarbeitet zusätzlich
/// den Verbindungsstring und erezugt ein Objekt zur Durchlaufzeitberechneung
/// </summary>
/// <param name="connectingString"></param> Verbindungsstring zur Datenbank
public Form_Recherche(string connectingString) {
  InitializeComponent();
  // Übernahme des Verbindungsstrings
  connStr = connectingString;
  // Rechercheergebnis (Instanz der Klasse)
  dbDLZ = new CsharpMySql("rechercheDurchlaufzeit", connStr); //+
}
#endregion 2. Konstruktor
#region 3.  Objekte binden und Recherche
/// <summary>
/// Laden der Rechercheergebnisse
/// </summary>
private void Form_Recherche_Load(object sender, EventArgs e) {
  // Navigatoren an Datenquelle binden
  this.bindingNavigator_DLZ.BindingSource = this.dbDLZ.getBindingSource;
  // Sichtbare Tabelle an Datenquelle binden
  this.dataGridView_DLZ.DataSource = this.dbDLZ.getBindingSource;
  // toolStripButton_RechercheAuftragsdurchlauf_Click(sender, e);
}
/// <summary>
/// Rechercheauftrag wird angestoßen
/// Ruft die Strored Methode
/// </summary>
private void toolStripButton_RechercheAuftragsdurchlauf_Click(object sender, EventArgs e) {
  // Starttermin
  DateTime startTermin = Convert.ToDateTime(textBox_StartTermin.Text);
  // Endtermin
DateTime endTermin = Convert.ToDateTime(textBox_EndTermin.Text);
  MySqlConnection conn = new MySqlConnection(connStr);
  conn.Open();
  MySqlCommand cmd = new MySqlCommand("Durchlaufzeit", conn);
  cmd.CommandType = CommandType.StoredProcedure;
  cmd.Parameters.Add(new MySqlParameter("@parStartTermin", startTermin));
  cmd.Parameters.Add(new MySqlParameter("@parEndTermin", endTermin));
  cmd.ExecuteNonQuery();
  // Verbindung schließen, falls offen
  if (conn != null) conn.Close();
  // Datenset entfernen und neu aufbauen damit das
  // aktuelle Rechercheergebnis gezeigt werden kann.
  dbDLZ.removeTableInDataset();
  dbDLZ.addTableToDataset();
}
#endregion  3. Objekte binden und Recherche
#region 4. Formular verlassen
/// <summary>
/// Formular schließen und zurück zum Hauptformular
/// </summary>
private void schließenToolStripMenuItem_Click(object sender, EventArgs e) {
  Form_Recherche.ActiveForm.Visible = false;
}
#endregion 4.  Formular verlassen








    ///----------------------------------------
  }
}
