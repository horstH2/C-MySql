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
	#endregion 1. MySql-Datenbank-Objekte -----------------------------------------
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
			CsharpMySql.dataSet.Tables.Add(this.tableName);
			this.dataAdapter.Fill(dataSet.Tables[this.tableName]);
			this.bindingSource.DataSource = dataSet.Tables[this.tableName];
		}
	#endregion 2. Konstruktoren mit Inhalts-Methode ------------------------------------
	#region 3. Getter
		/// <summary>
		///  Gibt die Bindingsource 
		/// </summary>
		/// <returns></returns>
		public BindingSource getBindingSource()
		{
			return this.bindingSource;
		}
	#endregion 3. Getter
	#region 4. Instanzmethoden
		#region 4.1 Methoden
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
		#endregion 4.1 Methoden
		#region 4.2 Relationen zwischen der Haupt- und Detailtabelle
		/// <summary>
		/// Stellt eine Relation zwischen der Haupttabelle und einer Detailtabelle her.
		/// Die Detailtabelle zeigt nur die Datensätze mit Bezug zum Datensatz der Haupttabelle.
		/// </summary>
		/// <param name="detailTableName"></param> Name der anzubindenden Detailtabelle
		/// <param name="dateilBindingSource"></param> Bindingsource der Detailtabelle
		/// <param name="idColumnumber"></param> Spaltennummer der Indizes zum Verbinden, Columns["id"] <=> Columns[0]
		///                                      -> in beiden Tabellen identisch
		/// <returns></returns> Name der relation zur Information
		public string mainDetailRelation(string detailTableName, BindingSource dateilBindingSource, int idColumNumber=0 )
		{
			string relationName= "relation_"+this.tableName+"_"+detailTableName;
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
		/// <summary>
		/// Stellt eine Relation zwischen der Haupttabelle und einer Detailtabelle her.
		/// Die Detailtabelle zeigt nur die Datensätze mit Bezug zum Datensatz der Haupttabelle.
		/// </summary>
		/// <param name="detailTableName"></param> Name der anzubindenden Detailtabelle
		/// <param name="dateilBindingSource"></param> Bindingsource der Detailtabelle
		/// <param name="idMainColumnName"></param> Spaltennamen des Schlüsselattributs in der Haupttabelle
		/// <param name="idTableColumnName"></param> Spaltennamen des Schlüsselattributs in der Detailtabelle                             
		/// <returns></returns> Name der relation zur Information
		public string tablesRelation(string relationTableName, BindingSource relationBindingSource, string idMainColumName, string idTableColumName)
		{
			string relationName = "relation_" + this.tableName + "_" + relationTableName;
			DataRelation relation = new DataRelation(relationName,
					CsharpMySql.dataSet.Tables[this.tableName].Columns[idMainColumName],
					CsharpMySql.dataSet.Tables[relationTableName].Columns[idTableColumName]);

			CsharpMySql.dataSet.Relations.Add(relation);
			this.bindingSource.DataSource = CsharpMySql.dataSet;
			this.bindingSource.DataMember = this.tableName;
			relationBindingSource.DataSource = this.bindingSource;
			relationBindingSource.DataMember = relationName;
			return relationName;
		}

		/// <summary>
		/// Stellt eine Relation zwischen der Haupttabelle und einer Detailtabelle her.
		/// Die Detailtabelle zeigt nur die Datensätze mit Bezug zum Datensatz der Haupttabelle.
		/// </summary>
		/// <param name="detailTableName"></param> Name der anzubindenden Detailtabelle
		/// <param name="dateilBindingSource"></param> Bindingsource der Detailtabelle
		/// <param name="idMainColumNumber"></param> Spaltennummer des Schlüsselattributs in der Haupttabelle
		/// <param name="idTableColumNumber"></param> Spaltennummer des Schlüsselattributs in der Detailtabelle
		/// <returns></returns> Name der relation zur Information
		public string tablesRelation(string relationTableName, BindingSource relationBindingSource, ushort idMainColumNumber, ushort idTableColumNumber)
		{
			string relationName = "relation_" + this.tableName + "_" + relationTableName;
			DataRelation relation = new DataRelation(relationName,
					CsharpMySql.dataSet.Tables[this.tableName].Columns[idMainColumNumber],
					CsharpMySql.dataSet.Tables[relationTableName].Columns[idTableColumNumber]);

			CsharpMySql.dataSet.Relations.Add(relation);
			this.bindingSource.DataSource = CsharpMySql.dataSet;
			this.bindingSource.DataMember = this.tableName;
			relationBindingSource.DataSource = this.bindingSource;
			relationBindingSource.DataMember = relationName;
			return relationName;
		}
		#endregion 4.2 Relationen zwischen der Haupt- und Detailtabelle
	#endregion 4. Instanzmethoden
	}
}

