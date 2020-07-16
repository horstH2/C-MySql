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
    
    #region MySql-Datenbank-Objekte
    // Verbindungsstring zur Datenbank "werkstoffdaten" und Verbindung
    static String connectingStringWst = "server=localhost; user id=root; persistsecurityinfo=True; password=root; database=werkstoffdaten";
    static MySqlConnection conWst = new MySqlConnection(connectingStringWst);
    // Abfragestring und Kommando für alle Atribute einer Tabelle
    static  String queryWstAll = "SELECT * FROM werkstoffe";
    static MySqlCommand cmdWstAll = new MySqlCommand(queryWstAll);
    // Zwischenspeicher (cache) für die Daten
    static DataSet dataSet_Wst = new DataSet();
    // Stellt die Verbindung zur Datenbank her und erledigt die Selektion
    static MySqlDataAdapter dataAdapter_Wst = new MySqlDataAdapter(queryWstAll, conWst);
    // Datenabgleich zwischen Datenset und Datenbank
    MySqlCommandBuilder builder = new MySqlCommandBuilder(dataAdapter_Wst);
    #endregion MySql-Datenbank-Objekte
    

    /// <summary>
    /// Standardinitialisierung
    /// </summary>
    public Form_WSt()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Beendet den Datenbankzugriff und die Anwendung
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      
      /*conWst.Close(); // Verbindung zur Datenbank schließen*/
      Close(); //Formular und Anwendung schließen
    }

    /// <summary>
    /// Zeigt das Formular mit dem Inhalt der Datenbanktabelle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form_WSt_Load(object sender, EventArgs e)
    {
      // Verbindung  zur Datenbank öffnen
      conWst.Open();
      // Das Datenset wird mit den Daten der Datenbank gefüllt
      dataAdapter_Wst.Fill(dataSet_Wst);
      // Zeige Daten auf dem Formular als Tabelle
      dataGridView_WSt.DataSource = dataSet_Wst.Tables[0];
      // Zur Information
      label_infoWSt.Text = " Zur Information:\n";
      label_infoWSt.Text += connectingStringWst+"\n";
      label_infoWSt.Text += queryWstAll;
    }

    /// <summary>
    /// Aktualisert geänderte Daten in der Datenbank
    /// Siehe auch: https://www.dreamincode.net/forums/topic/82058-c%23-update-record-in-a-mysql-database/
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
    {
     
      builder.GetUpdateCommand();
      dataAdapter_Wst.Update(dataSet_Wst);
      dataSet_Wst.AcceptChanges();
      
    }

    private void zeileLöschenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      
      dataGridView_WSt.Rows.RemoveAt(dataGridView_WSt.CurrentCell.RowIndex);
      aktualisierenToolStripMenuItem_Click(sender, e); 
      
    }
  }
}

























