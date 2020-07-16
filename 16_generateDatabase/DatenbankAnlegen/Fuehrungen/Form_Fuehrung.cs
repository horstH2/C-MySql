using System;
using System.Windows.Forms;
using OwnMySqlDB;
namespace Fuehrungen {
public partial class Form_Fuehrungen : Form	{
#region 1. Attribute
// Verbindungsstring ist Applikationsabhängig
public static string connStr;
// Tabellenobjekt Fuehrungen
CsharpMySql dbFr;
#endregion 1. Attribute
#region 2. Konstruktor
/// <summary>
/// Konstruktor 
/// </summary>
/// <param name="connectingString"></param> Verbindungsstring
/// <param name="fileName"></param> Name der SQL-Datei
public Form_Fuehrungen(string connectingString, string fileName) {
	InitializeComponent();
	connStr = connectingString;
  // Objekt stellt Verbindung zum Datenbankserver her
	CsharpMySql db = new CsharpMySql(connStr, 1);
	// statische Methode der Klasse CsharpMySql zum Erzeugen der Datenbank
	CsharpMySql.dbImportFromSql(fileName);
}
#endregion 2. Konstruktor
#region 3. Ereignismethoden
/// <summary>
/// Zeige Tabelle
/// </summary>
private void zeigenToolStripMenuItem_Click(object sender, EventArgs e) {
	// Entfern Daten aus dem Datenset
	CsharpMySql.dataSet.Clear();
	// Verbindungsstring wird um den Namen der Datenbasis ergänzt;
	connStr += "; database = Fuehrungen";
	textBox_info.Text = connStr;
	// Datenbank-Tabellenobjekt erhält den aktualisierten Verbindungsstring
	//  und den Namen der Tabelle
	dbFr = new CsharpMySql("Laufwagen", connStr);
	// Darstellen der aktuellen Daten als Tabelle
	bindingNavigator_Fuehrung.BindingSource = dbFr.getBindingSource;
	dataGridView_Fuehrung.DataSource = dbFr.getBindingSource;
}
/// <summary>
/// // Änderungen der Daten aktualisieren
/// </summary>
private void toolStripButton_aktualisieren_Click(object sender, EventArgs e) {
	this.dbFr.aktualisieren(dataGridView_Fuehrung);
}
/// <summary>
/// Anwendung beenden
/// </summary>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
	Close();
}
#endregion 3. Ereignismethoden
	}
}
