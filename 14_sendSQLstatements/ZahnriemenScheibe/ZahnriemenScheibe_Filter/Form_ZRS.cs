using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //++
using OwnMySqlDB; //-> CsharpMySql

namespace ZahnriemenScheibe {
public partial class Form_ZRS : Form {
#region 1. Attribute, Instanzen der Klasse
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=vorschubantrieb";
CsharpMySql dbZR = new CsharpMySql("zahnriemen", connectingString);
CsharpMySql dbZRS = new CsharpMySql("zahnscheiben", connectingString);
#endregion 1. Attribute, Instanzen der Klasse
public Form_ZRS() {
  InitializeComponent();
}
/// <summary>
/// Sichtbare Komponenten an die Datenquelle binden
/// ZR - Zahnriemen
/// RS - Zahnriemenscheibe(n)
/// </summary>
private void Form_ZRS_Load(object sender, EventArgs e) {
  // Navigatoren an Datenquelle binden
  bindingNavigator_ZR.BindingSource = dbZR.getBindingSource;
  bindingNavigator_ZRS.BindingSource = dbZRS.getBindingSource;
  // Sichtbare Tabellen an Datenquelle binden
  dataGridView_ZR.DataSource = dbZR.getBindingSource;
  dataGridView_ZRS.DataSource = dbZRS.getBindingSource;
}
/// <summary>
/// Filter Zahnriemenscheiben-Tabelle entsprechend der Auswahl des Zahnriemens
/// </summary>
private void dataGridView_ZR_CellClick(object sender, DataGridViewCellEventArgs e) {
  //Auswahl des Zahnriemens durch Doppeltklick auf Zeile
  int i = dataGridView_ZR.CurrentCell.RowIndex;
  //Übernahme tes Attributs "Typ" der asugewählten Datenzeile
  string typ = dataGridView_ZR["Typ", i].Value.ToString().Trim();
  // Definition des Filters
  string filter = " TRIM(Typ)= '" + typ + "' ";
  // Weitere Möglichkeiten der Filterdefinition
  /// https://docs.devexpress.com/WindowsForms/2567/controls-and-libraries/data-grid/filter-and-search/advanced-filter-and-search-concepts ///
  string filter1 = " TRIM(Typ) In('" + typ + "') ";
  string filter2 = " TRIM(Typ) Like('" + typ + "') ";
  // Filter setzen
  dbZRS.getBindingSource.Filter = filter;
}
/// <summary>
/// Filter entfernen
/// </summary>
private void toolStripButton_FilterOff_Click(object sender, EventArgs e) {
  dbZRS.getBindingSource.RemoveFilter();
}
/// <summary>
/// Beenden
/// </summary>
private void toolStripButton_Beenden_Click(object sender, EventArgs e) {
  Close();
}
    
    }
}
