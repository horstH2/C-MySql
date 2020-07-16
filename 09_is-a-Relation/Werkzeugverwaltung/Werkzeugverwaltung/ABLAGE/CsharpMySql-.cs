/* Klasse fasst Komponenten zum Aufbau einer Datenbank zusammen mit dem Ziel
 * die Kommunikation zwischen Anwendung und Datenbank auch bei Verwendung mehrere Tabellen zu vereinfachen. 
 * Urheber: Horst-Christian Heinke, Magdeburg 19.04.2020
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


namespace MySqlDB
{
	class CsharpMySql
	{
		#region 1. MySql-Datenbank-Objekte, Attribute ----------------------------------
		/// STATIC -------------------------------------
		// Verbindung zur Datenbank, alle Tabellen in einer Datenbank
		public static MySqlConnection con;
		// Zwischenspeicher (cache) für die Daten - alle Tabellen im gleichen DataSet
		// (Anforderung, um Realtion zwischen Tabellen zu erstellen)
		public static DataSet dataSet = new DataSet();
		/// INSTANZEN ------------------------------
		// Name der Datenbanktabelle
		public string tableName;
		// Abfragestring und Kommando für alle Atribute einer Tabelle
		public string query;
		public MySqlCommand cmd_All;
		// Stellt Verbindung zur Datenbank her und selektiert
		public MySqlDataAdapter dataAdapter;
		// Datenabgleich zwischen Datenset und Datenbank
		public MySqlCommandBuilder commandBuilder;
		// Verbindungskomponente
		public BindingSource bindingSource;
		#endregion MySql-Datenbank-Objekte -----------------------------------------


		#region 2. Konstruktor
		/// <summary>
		/// Konstruktor für eine Tabelle
		/// </summary>
		/// <param name="tableName"></param> Name der Tabelle zur Bearbeitung 
		public CsharpMySql(string tableName, string connectingString)
		{
			CsharpMySql.con = new MySqlConnection(connectingString);
			///CsharpMySql.connectingString = connectionString;
			this.tableName = tableName;
			this.query = "SELECT * FROM " + this.tableName;
			this.cmd_All = new MySqlCommand(query);
			this.dataAdapter = new MySqlDataAdapter(query, con);
			this.commandBuilder = new MySqlCommandBuilder(dataAdapter);
			this.bindingSource = new BindingSource();
			try { CsharpMySql.con.Open(); } catch { }  // DB kann nur einmal geöffnet werden
			CsharpMySql.dataSet.Tables.Add(tableName);
			this.dataAdapter.Fill(dataSet.Tables[tableName]);
			this.bindingSource.DataSource = dataSet.Tables[tableName];
		}
		#endregion Konstruktoren mit Inhalts-Methode ------------------------------------

		#region 3. Getter
		/// <summary>
		///  Getter, Setter der Bindingsource 
		/// </summary>
		/// <returns></returns>
		public BindingSource getBindingSource
		{
			get { return this.bindingSource; }
			// set { this.bindingSource = value;}
		}

		#endregion

		#region 4. Instanzmethoden
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
			try { this.dataAdapter.Update(dataSet.Tables[tableName]); } catch (Exception) { info="Vermutlich leerer Datensatz"; }
			return info;
		}
/// <summary>
/// Stellt eine Relation zwischen der Haupttabelle und einer Subtabelle her.
/// Die Subtabelle können eine Detaitabelle oder auch eine Kindtablle einer 1-1-Beziehung sein.
/// </summary>
/// <param name="subTableName"></param> Name der Subtabelle (Kindtabelle)
/// <param name="subBindingSource"></param> Name der Bindingsource der Subtabelle
/// <param name="mainIdColumnName"></param>Name des Identifikationsschlüssels der Haupttabelle
/// <param name="subIdColumnName"></param> Name des Identifikationsschlüssels der Subtabelle
/// <returns></returns> Name der relation zur Information
public string mainToSubRelation(string subTableName, BindingSource subBindingSource, string mainIdColumnName, string subIdColumnName) {
	string relationName = "relation_" + this.tableName + "_" + subTableName;
	DataRelation relation = new DataRelation(relationName,
			CsharpMySql.dataSet.Tables[this.tableName].Columns[mainIdColumnName], 
			CsharpMySql.dataSet.Tables[subTableName].Columns[subIdColumnName]);

	CsharpMySql.dataSet.Relations.Add(relation);
	this.bindingSource.DataSource = CsharpMySql.dataSet;
	this.bindingSource.DataMember = this.tableName;
	subBindingSource.DataSource = this.bindingSource;
	subBindingSource.DataMember = relationName;
	return relationName;
}


		#endregion 4. Instanzmethoden
	}
}

