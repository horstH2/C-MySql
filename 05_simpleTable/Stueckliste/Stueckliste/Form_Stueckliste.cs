using System;
using System.Data;
using System.Windows.Forms;
// Stellt die MySql-Datenbankklassen bereit
using MySql.Data.MySqlClient;

namespace Stueckliste
{
  public partial class Form_Stueckliste : Form
  {

    #region MySql-Datenbank-Objekte
    // Verbindungsstring->Verbindung zur Datenbank "stueckliste - Stl"
    static String connectingString_Stl = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=stueckliste";
    static MySqlConnection con_Stl =  new MySqlConnection(connectingString_Stl);
    // Abfragestring und Kommando für alle Atribute einer Tabelle
    static String query_StlAll = "SELECT * FROM antrieb";
    static MySqlCommand cmd_StlAll = new MySqlCommand(query_StlAll);
    // Zwischenspeicher (cache) für die Daten
    static DataSet dataSet_Stl = new DataSet("Stl");
    // Stellt Verbindung zur Datenbank her und selektiert
    static MySqlDataAdapter dataAdapter_Stl = new MySqlDataAdapter(query_StlAll, con_Stl);
    // Datenabgleich zwischen Datenset und Datenbank
    MySqlCommandBuilder commandBuilder_Stl = new MySqlCommandBuilder(dataAdapter_Stl);
    // Verbindungskomponente
    BindingSource bindingSource_Stl= new BindingSource();
 

    #endregion MySql-Datenbank-Objekte
    /// <summary>
    /// Initialisierung
    /// </summary>
    public Form_Stueckliste()
    {
      InitializeComponent();
    }

    /// IN ARBEIT ...

    /// <summary>
    /// Öffnet die Datenbank und zeigt den Inhalt
    /// </summary>
    private void Form_Stueckliste_Load(object sender, EventArgs e)
    {
      // Ausgabe zur Information
      label_Info.Text = " Zur Information:\n";
      label_Info.Text += connectingString_Stl + "\n";
      label_Info.Text += query_StlAll;
      //--------------------------------------
      // Verbindung zur Datenbank öffnen
      con_Stl.Open();
      // Das Datenset wird mit den Daten der Datenbank gefüllt
      dataSet_Stl.Tables.Add("antrieb");
      //dataAdapter_Stl.Fill(dataSet: dataSet_Stl);
      dataAdapter_Stl.Fill(dataSet_Stl.Tables["antrieb"]);
      // Bindet mehrere Komponenten an eine Datenquelle
      bindingSource_Stl.DataSource = dataSet_Stl.Tables["antrieb"];
      // Navigation 
      bindingNavigator_Stl.BindingSource = bindingSource_Stl;
      // Zeige Daten auf dem Formular als Tabelle
      this.dataGridView_Stl.DataSource = bindingSource_Stl;
      // -> dataGridView_stueckliste.DataSource = dataSet_Stl.Tables[0]; // sollte auch gehen
      //  Tabellengestaltung: Umbennen von Spaltenüberschriften
      this.dataGridView_Stl.Columns[0].HeaderText = String.Concat("Pos.");
      this.dataGridView_Stl.Columns[3].HeaderText = String.Concat("Bezeichnung");
      // Tabellengestaltung: - Ausblenden von Spalten
      int[] idx = { 2, 4, 8, 9, 10 }; // Feld mit Indizes (Konstanten)
      foreach (int i in idx) dataGridView_Stl.Columns[i].Visible = false; //Schleife
      // Bindet Eigenschaften der sichtbaren Komponenten an die Attribute der Datenbanktabelle
      this.textBox_idPosition.DataBindings.Add(new Binding("Text", this.bindingSource_Stl,"idPosition", true));
      this.textBox_Menge.DataBindings.Add(new Binding("Text", this.bindingSource_Stl, "Menge", true));
      this.textBox_Einheit.DataBindings.Add(new Binding("Text", this.bindingSource_Stl, "Einheit", true));
      this.textBox_Benennung.DataBindings.Add(new Binding("Text", this.bindingSource_Stl, "Benennung", true));
      this.textBox_Fertiggewicht.DataBindings.Add(new Binding("Text", this.bindingSource_Stl, "Fertiggewicht", true));
      this.textBox_Sachnummer.DataBindings.Add(new Binding("Text", this.bindingSource_Stl, "Sachnummer", true));
      this.textBox_Werkstoff.DataBindings.Add(new Binding("Text", this.bindingSource_Stl, "Werkstoff", true));
      this.textBox_Lieferant.DataBindings.Add(new Binding("Text", this.bindingSource_Stl, "Lieferant", true));
      this.textBox_Rohgewicht.DataBindings.Add(new Binding("Text", this.bindingSource_Stl, "Rohgewicht", true));
      this.richTextBox_Bemerkung.DataBindings.Add(new Binding("Text", this.bindingSource_Stl, "Bemerkung", true));
      this.pictureBox_Bild.DataBindings.Add(new Binding("Image", this.bindingSource_Stl, "Bild", true));

    }
/// <summary>
/// Schreibt die editierten Daten in die Datenbank
/// https://www.dreamincode.net/forums/topic/82058-c%23-update-record-in-a-mysql-database/
/// </summary>
private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
{
  // Editieren bzw. Eingabe beenden
  bindingSource_Stl.EndEdit();
  // Datenabgleich zwischen Datenset und Datenbank
  dataAdapter_Stl.UpdateCommand= commandBuilder_Stl.GetUpdateCommand(); 
  // geänderte Daten in der Datenbank aktualisieren
  dataAdapter_Stl.Update(dataSet_Stl.Tables["antrieb"]);
  // Commit für alle Änderungen an diesem Datenset
  dataSet_Stl.AcceptChanges();
}
    /// <summary>
    /// Aktualisiert die geänderten Daten und schließt die Anwendung
    /// </summary>
    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
       aktualisierenToolStripMenuItem_Click(sender, e);
       Close();
    }
    /// <summary>
    /// Filtert nach Lieferanten
    /// </summary>
    private void textBox_FilterLieferant_Leave(object sender, EventArgs e)
    {
       // Filterstring vorbereiten
       string filterLieferant = textBox_FilterLieferant.Text.Trim();
       // Filterstring setzen
       bindingSource_Stl.Filter = "Lieferant =  '" + filterLieferant + "' ";
       // Filter ausschalten
       if (filterLieferant == "") bindingSource_Stl.Filter = null;
    }
#region Sortieren
/// <summary>
/// Sortierung nach Identifikationsschlüssel
/// </summary>
private void radioButton_Positionsnummer_CheckedChanged(object sender, EventArgs e)
{
  //idPosition ist der Identifikationsschlüssel
  bindingSource_Stl.Sort = null;
}
/// <summary>
/// Sortierung nach Benennung
/// </summary>
private void radioButton_Benennung_CheckedChanged(object sender, EventArgs e)
{
  bindingSource_Stl.Sort = "Benennung";
}
/// <summary>
/// Sortierung hierachisch nach Lieferant und Sachnummer
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void radioButton_LieferantSachnummer_CheckedChanged(object sender, EventArgs e)
{
  bindingSource_Stl.Sort = "Lieferant, Sachnummer";
}
#endregion Sortieren
    /// <summary>
    /// Sucht exakt nach dem Suchstring "textBox_Suchen.Text" 
    /// in der angegebenen Spalte
    /// </summary>
    private void textBox_Suchen_TextChanged(object sender, EventArgs e)
    {
      int foundIndex = bindingSource_Stl.Find("Benennung", textBox_SuchenBezeichnung.Text);
      bindingSource_Stl.Position = foundIndex;
    }

    #region PopUp-Menü zum Bild
    /// <summary>
    /// Zuweisung eines Bildes aus der Zwischenablage
    /// </summary>
    private void toolStripMenuItem_Einfuegen_Click(object sender, EventArgs e)
    {
      pictureBox_Bild.Image = Clipboard.GetImage();
    }
    /// <summary>
    /// Kopieren eines Bildes in die Zwischenablage
    /// </summary>
    private void toolStripMenuItem_Kopieren_Click(object sender, EventArgs e)
    {
      Clipboard.SetImage(pictureBox_Bild.Image) ;
    }
    /// <summary>
    /// Löschen eines Bildes
    /// </summary>
    private void toolStripMenuItem_Loeschen_Click(object sender, EventArgs e)
    {
      pictureBox_Bild.Image = null;
    }
    #endregion PopUp-Menü zum Bild




  }
}
