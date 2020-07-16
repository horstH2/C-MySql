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
public partial class Form_Werkstoffverwaltung : Form {
#region 1. Attribute, Instanzen 
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=werkstoffdatenview";
// Tabelle 
CsharpMySql dbWS = new CsharpMySql("werkstoffe", connectingString);
// View
CsharpMySql dbWSview = new CsharpMySql("werkstoffeviewsortrm", connectingString);
#endregion 1. Attribute, Instanzen 
/// <summary>
/// Konstruktor
/// </summary>
public Form_Werkstoffverwaltung() {
      InitializeComponent();
  }
#region 2. Ereignismethoden
/// <summary>
/// Laden der Daten, neu Laden
/// </summary>
private void Form_Werkstoffverwaltung_Load(object sender, EventArgs e) {
  bindingNavigator_WS.BindingSource = dbWS.getBindingSource;
  bindingNavigator_WSview.BindingSource = dbWSview.getBindingSource;
  dataGridView_WS.DataSource= dbWS.getBindingSource;
  dataGridView_WSview.DataSource= dbWSview.getBindingSource;
  // Spalte wird hier nicht benötigt
  this.dataGridView_WS.Columns["Rp"].Visible = false;
}

/// <summary>
/// Aktualisieren der Tabellen-Daten in der Datenbank
/// </summary>
private void toolStripButton_WSaktualisieren_Click(object sender, EventArgs e) {
  dbWS.aktualisieren(dataGridView_WS);
}
/// <summary>
/// Ansicht reorganisieren
/// </summary> 
private void toolStripButton_WSviewRestore_Click(object sender, EventArgs e)
{
  // Enfernen der Ansicht aus dem Datenset
  dbWSview.removeTableInDataset();
  // Aktualisierte Tabelle dem Datenset hinzufügen
  dbWSview.addTableToDataset();
}
/// <summary>
/// Beenden der Anwendung nach erfolgter Aktualisierung
/// </summary>
private void toolStripButton_Beenden_Click(object sender, EventArgs e) {
  toolStripButton_WSaktualisieren_Click(sender, e);
  Close();
}
  #endregion 2. Ereignismethoden
}
}
