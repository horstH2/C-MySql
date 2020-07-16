using System;
using System.Data;
using System.Windows.Forms;
// Siehe auch: https://dev.mysql.com/doc/
//             https://dev.mysql.com/doc/connector-net/en/preface.html
using MySql.Data.MySqlClient;  //stellt die MySql-Datenbankklassen bereit

namespace DasErsteProgramm_wekstoffe_
{
  public partial class Form_WSt : Form
  {
   
    /// <summary>
    /// Standardinitialisierung
    /// </summary>
    public Form_WSt()
    {
      InitializeComponent();
    }

    

/// <summary>
/// Zeigt das Formular mit dem Inhalt der Datenbanktabelle
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void Form_WSt_Load(object sender, EventArgs e)
{
      // TODO: Diese Codezeile lädt Daten in die Tabelle "werkstoffdatenDataSet1.werkstoffe". Sie können sie bei Bedarf verschieben oder entfernen.
      this.werkstoffeTableAdapter.Fill(this.werkstoffdatenDataSet1.werkstoffe);

    }
    /// <summary>
    /// Aktualisert geänderte Daten in der Datenbank
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
{
  // Übernimmt den aktuell editierten Datensatz
  this.bindingSource_Wst.EndEdit();

}
/// <summary>
/// Beendet den Datenbankzugriff und die Anwendung
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
  Close(); //Formular und Anwendung schließen
}


  }
}

























