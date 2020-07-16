using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using OwnMySqlDB;


namespace Werkstoffverwaltung
{
    public partial class Form_Werkstoffverwaltung : Form
    {
    #region 1. Attribute, Instanzen 
    // Verbindungsstring ist Applikationsabhängig
    static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=werkstoffdatenroutine";
    // Tabelle 
    CsharpMySql dbWS = new CsharpMySql("werkstoffe", connectingString);
		#endregion Attribute, Instanzen
		public Form_Werkstoffverwaltung()
        {
            InitializeComponent();
        }

/// <summary>
/// Laden der Daten "Fill"
/// </summary>
private void Form_Werkstoffverwaltung_Load(object sender, EventArgs e)
{
      bindingNavigator_WS.BindingSource = dbWS.getBindingSource;
      dataGrid_WS.DataSource = dbWS.getBindingSource;
      // Spalte wird hier nicht benötigt
      this.dataGrid_WS.Columns["Rp"].Visible = false;

    }
/// <summary>
/// Aktualisieren der Tabellen-Daten in der Datenbank
/// </summary>
private void toolStripButton_Aktualisieren_Click
                    (object sender, EventArgs e)
{
      dbWS.aktualisieren(dataGrid_WS);

    }
/// <summary>
/// Beenden der Anwendung nach erfolgter Aktualisierung
/// </summary>
private void toolStripButton_Beenden_Click
                        (object sender, EventArgs e)
{
    toolStripButton_Aktualisieren_Click(sender, e);
    Close();
}
    /// <summary>
    /// Stored Prozedur mit Parameterübergabe
    /// http://www.csharp-station.com/Tutorial/AdoDotNet/Lesson07
    /// Diese Stored Prozedur ermittelt alle Werkstoffe, deren Zugfestigkeit
    /// größer ist als ein minimaler Vorgabewert und schreibt diese Datensätze
    /// in ein Textfeld.
    /// </summary>
    private void button_okRmin_Click(object sender, EventArgs e)
    {
      #region Stored Procedure
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
      #endregion Stored Procedure

      #region Ausgabe
      richTextBox_RmMin.Clear();
      // Überschrift
      richTextBox_RmMin.Text += "Werkstoffe mit einer Mindestzugfestigkeit Rm von " + textBox_RmMin.Text + " N/mm²\r\n\n";
      // Tabellarisches Ausgabeformat
      string format = "| {0,10} | {1,-20} |  {2,11} | \r\n";
      // Tabellenkopf
      richTextBox_RmMin.Text += String.Format(format, "ID WS", "Bezeichnung", "Rm in N/mm²");
      // Datensätze ausgeben
      while (rdr.Read())
      {
        richTextBox_RmMin.Text += String.Format(format, rdr["idWS"], rdr["Bezeichnung"], rdr["Rm"]);
      }
      #endregion Aussgabe
      // Schließen der Verbindung und des Readers
      if (conn != null) conn.Close();
      if (rdr != null) rdr.Close();
    }
/// <summary>
/// Gespeicherte Funktion mit Parameterübergabe
/// http://stackoverflow.com/questions/2013144/how-can-i-call-a-mysql-function-using-mysqlconnector
/// Stored Funktion zählt die Datensätze, deren Zugfestigkeit Rm größer ist
/// als der minimale Vorgabewert und schreibt die Anzahl in eine Textbox.
/// </summary>
private void button_okCount_Click(object sender, EventArgs e) {
	#region Stored Function
	// Erzeugt und öffnet ein Verbindungsobjekt,
	// übergeben wird der bekannte Verbindungsstring zur Datenbank
	MySqlConnection conn = new MySqlConnection(connectingString);
  conn.Open();
  // Erzeugt ein Kommandoobjekt,
  // übergeben werden Name der Stored Function und das Verbindungsobjekt
  MySqlCommand cmd =new MySqlCommand("AnzahlSaetze", conn);
  cmd.CommandType = CommandType.StoredProcedure;
  // Parameterübergabe an die Stored Function;
  // AT (@) kennzeichnet den Übergabeparameter
  cmd.Parameters.Add(new MySqlParameter("@parRmMin", textBox_RmMin.Text));
  /// Erzeugt einen Platzhalter für den Rückgabewert
  /// und ruft die gespeicherte Funktion auf (Stored Function)
  MySqlParameter anzahl = new MySqlParameter();
  anzahl.Direction = ParameterDirection.ReturnValue;
  cmd.Parameters.Add(anzahl);
  cmd.ExecuteNonQuery();
  #endregion Stored Function
  // Ausgabe
  textBox_Anzahl.Text = anzahl.Value.ToString();
  // Verbindung schließen
  if (conn != null) conn.Close();
}


  }
}
