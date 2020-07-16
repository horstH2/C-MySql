/* Klasse fasst Komponenten zum Aufbau einer Datenbank zusammen mit dem Ziel
 * die Kommunikation zwischen Anwendung und Datenbank auch bei Verwendung mehrere Tabellen zu vereinfachen. 
 * Urheber: Horst-Christian Heinke, Magdeburg 26.05.2020
 * Hinzugezogene Quellen:
  * https://docs.microsoft.com/de-de/dotnet/framework/winforms/controls/creating-a-master-detail-form-using-two-datagridviews
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;    //+ für DataSet
using System.Windows.Forms;  //+ für BindingSource
using MySql.Data.MySqlClient;  //+ für MySql-Klassen
namespace OwnMySqlDB
{
	class CsharpMySql
	{
#region 1. MySql-Datenbank-Objekte, Attribute ----------------------------------
/// STATIC mit Bezug zur kompletten Datenbank ---
// Verbindungsstring
public static string connectionString;
		// Verbindung zur Datenbank, alle Tabellen in einer Datenbank
		public static MySqlConnection con; // = new MySqlConnection(connectionString);
// Zwischenspeicher (cache) für die Daten - alle Tabellen im gleichen DataSet
// (Anforderung, um Realtion zwischen Tabellen zu erstellen)
public static DataSet dataSet = new DataSet();
// Kommando für komplette Datenbank
public static MySqlCommand cmd = new MySqlCommand();
/// INSTANZEN mit Bezug zu den Tabellen ---------------------
// Name der Datenbanktabelle
public string tableName;
// Abfragestring und Kommando für alle Attribute einer Tabelle
public string query;
public MySqlCommand cmdTable;
// Stellt Verbindung zur Datenbank her und selektiert
public MySqlDataAdapter dataAdapter;
// Datenabgleich zwischen Datenset und Datenbank
public MySqlCommandBuilder commandBuilder;
// Verbindungskomponente
public BindingSource bindingSource;
#endregion 1. MySql-Datenbank-Objekte -----------------------------------------
#region 2. Konstruktor
/// <summary>
/// Konstruktor einer Datenbank-Tabelle
/// Der Verbindungsstring wird beim erstmaligen instanziieren
/// als Pflichtparameter übergeben.
/// </summary>
/// <param name="tableName"></param> Name der Tabelle zur Bearbeitung
/// <param name="conStr"></param> Verbindungsstring optional
public CsharpMySql(string tableName, string conStr = null) {
	if (conStr != null){ CsharpMySql.connectionString = conStr; }
	CsharpMySql.con = new MySqlConnection(connectionString);
	this.tableName = tableName;
	this.query = "SELECT * FROM " + this.tableName;
	this.cmdTable = new MySqlCommand(query);
	this.dataAdapter = new MySqlDataAdapter(query, con);
	this.commandBuilder = new MySqlCommandBuilder(dataAdapter);
	this.bindingSource = new BindingSource();
	try { CsharpMySql.con.Open(); } catch { }  // DB kann nur einmal geöffnet werden
	try { CsharpMySql.dataSet.Tables.Add(tableName); } catch { };
	this.dataAdapter.Fill(dataSet.Tables[tableName]);
	this.bindingSource.DataSource = dataSet.Tables[tableName];
}
#endregion 2. Konstruktor
		#region 3. Getter, Setter
		/// <summary>
		///  Getter, Setter der Bindingsource 
		/// </summary>
		/// <returns></returns>
		public BindingSource getBindingSource
		{
			get { return this.bindingSource; }
			//set { this.bindingSource = value;}
		}
		#endregion 3. Getter, Setter
		#region 4. Instanzmethoden
		#region 4.1. Aktualisieren
		/// <summary>
		/// Akualisiert die editierten Daten in der Datenbank
		/// </summary>
		/// <returns></returns> Information über Updateverlauf
		public string aktualisieren()
		{
			string info = "";
			// Editieren bzw. Eingabe beenden
			this.bindingSource.EndEdit();
			// Datenabgleich zwischen Datenset und Datenbank
			this.dataAdapter.UpdateCommand = this.commandBuilder.GetUpdateCommand();
			// geänderte Daten in der Datenbank aktualisieren
			try { this.dataAdapter.Update(dataSet.Tables[tableName]); } catch (Exception) { info = "Vermutlich leerer Datensatz"; }
			return info;
		}
		/// <summary> + Überladung
		/// Akualisiert die editierten Daten in der Datenbank
		/// Die Eingabe erfolgt über die Datentabellenansicht.
		/// </summary>
		/// <param name="dataGridView"></param> Name mit der zu aktualisierenden Tabelle
		/// <returns></returns>  Information über Updateverlauf
		public string aktualisieren(DataGridView dataGridView)
		{
			// Eingabe per Datentabellenansicht beenden
			dataGridView.EndEdit();
			return aktualisieren();
		}
		#endregion 4.1. Aktualisieren
		#region 4.2. Relationen
		/// <summary> (*) Kompatibiltätsgründen beibehalten
		/// Stellt eine Relation zwischen der Haupttabelle und einer Detailtabelle her.
		/// Die Detailtabelle zeigt nur die Datensätze mit Bezug zum Datensatz der Haupttabelle.
		/// </summary>
		/// <param name="detailTableName"></param> Name der anzubindenden Detailtabelle
		/// <param name="dateilBindingSource"></param> Bindingsource der Detailtabelle
		/// <param name="idColumnumber"></param> Spaltennummer der Indizes zum Verbinden, Columns["id"] <=> Columns[0]
		///                                      -> in beiden Tabellen identisch
		/// <returns></returns> Name der relation zur Information
		public string mainDetailRelation(string detailTableName, BindingSource dateilBindingSource, int idColumNumber = 0) {
			string relationName = "relation_" + this.tableName + "_" + detailTableName;
			DataRelation relation = new DataRelation(relationName,
					CsharpMySql.dataSet.Tables[this.tableName].Columns[idColumNumber],
					CsharpMySql.dataSet.Tables[detailTableName].Columns[idColumNumber]);

			CsharpMySql.dataSet.Relations.Add(relation);
			this.bindingSource.DataSource = CsharpMySql.dataSet;
			this.bindingSource.DataMember = this.tableName;
			dateilBindingSource.DataSource = this.bindingSource;
			dateilBindingSource.DataMember = relationName;
			return relationName;
		}
		/// <summary> Überladung
		/// Stellt eine Relation zwischen der Haupttabelle und einer Subtabelle her.
		/// Die Subtabelle können eine Detaitabelle oder auch eine Kindtablle einer 1-1-Beziehung sein.
		/// </summary>
		/// <param name="subTableName"></param> Name der Subtabelle (Kindtabelle)
		/// <param name="subBindingSource"></param> Name der Bindingsource der Subtabelle
		/// <param name="mainIdColumnIdx"></param>Index des Identifikationsschlüssels der Haupttabelle
		/// <param name="subIdColumnIdx"></param> Index des Identifikationsschlüssels der Subtabelle
		/// <returns></returns> Name der relation zur Information
		public string mainToSubRelation(string subTableName, BindingSource subBindingSource, int mainIdColumnIdx = 0, int subIdColumnIdx = 0) {
			string relationName = "relation_" + this.tableName + "_" + subTableName;
			DataRelation relation = new DataRelation(relationName,
					CsharpMySql.dataSet.Tables[this.tableName].Columns[mainIdColumnIdx],
					CsharpMySql.dataSet.Tables[subTableName].Columns[subIdColumnIdx]);
			CsharpMySql.dataSet.Relations.Add(relation);
			this.bindingSource.DataSource = CsharpMySql.dataSet;
			this.bindingSource.DataMember = this.tableName;
			subBindingSource.DataSource = this.bindingSource;
			subBindingSource.DataMember = relationName;
			return relationName;
		}
		/// <summary> ÜBERLADUNG
		/// Stellt eine Relation zwischen der Haupttabelle und einer Subtabelle her.
		/// Die Subtabelle können eine Detaitabelle oder auch eine Kindtablle einer 1-1-Beziehung sein.
		/// </summary>
		/// <param name="subTableName"></param> Name der Subtabelle (Kindtabelle)
		/// <param name="subBindingSource"></param> Name der Bindingsource der Subtabelle
		/// <param name="mainIdColumnName"></param>Name des Identifikationsschlüssels der Haupttabelle
		/// <param name="subIdColumnName"></param> Name des Identifikationsschlüssels der Subtabelle
		/// <returns></returns> Name der relation zur Information
		public string mainToSubRelation(string subTableName, BindingSource subBindingSource, string mainIdColumnName, string subIdColumnName) {
			int mainIdColumnIdx = dataSet.Tables[this.tableName].Columns.IndexOf(mainIdColumnName);
			int subIdColumnIdx = dataSet.Tables[subTableName].Columns.IndexOf(mainIdColumnName);
			return mainToSubRelation(subTableName, subBindingSource, mainIdColumnIdx, subIdColumnIdx);
		}
		#endregion 4.2 Relationen
		#endregion 4. Instanzmethoden
		#region 5. statische Methoden für gesamte Datenbank
#region 5.1. Backup
/// <summary>
/// Export einer Datenbank im SQL-Format
/// </summary>
/// <param name="backupFile"></param> Name der SQL-Datei
public static void dbExportToSql(string backupFile) {
	// Verbindung aufbauen
	cmd.Connection = con;
	try { con.Open(); } catch { }
			// Backupinstanz
	MySqlBackup backup = new MySqlBackup(cmd);
			// Exportieren
	backup.ExportToFile(backupFile);
}
/// <summary>
/// Import, Wiederherstellung einer Datenbank
/// </summary>
/// <param name="backupFile"></param> Name der SQL-Datei
public static void dbImportFromSql(string backupFile) {
	cmd.Connection = con;
	try { con.Open(); } catch { }
			// Backupinstanz und importieren
	MySqlBackup backup = new MySqlBackup(cmd);
	backup.ImportFromFile(backupFile);
}
#endregion 5.1. Backup
		#endregion 5. statische Methoden
	}
}









