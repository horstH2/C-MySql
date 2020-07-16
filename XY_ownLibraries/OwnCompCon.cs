/// <summary> ---------------------------------------------------------------------------------------
/// Autor: Horst-Christian Heinke
/// Ort: Magdeburg, Datum: 24.06.2020
/// Klasse mit statischen Methoden zur Kommunikation zwischen
/// Komponenten und Datenbankobjekten
/// </summary>
#region 1. Namespaces
using System;
using System.Collections.Generic;
using System.Windows.Forms;  //+ für BindingSource
using OwnMySqlDB;  // eigene Klasse "CsharpMySql"
namespace OwnCompCon {
#endregion 1. Namespaces
class Comp {
		#region 2. Textbox
		/// <summary>
		/// Bindet die Textboxen, an die Tabellenattributte der Datenbankobjekte
		/// </summary>
		/// <param name="textBoxes"></param> Textboxobjektnamen
		/// <param name="attributs"></param> Attributnamen
		/// <param name="dbObj"></param>     Datennbank-Tabellen-Objekt
		/// <param name="eigenschaft"></param> zu setzende Eigenschaft, Standard ist "Text"
		public static void textboxBinding(List<TextBox> textboxes, List<string> attributs, CsharpMySql dbObj, string eigenschaft = "Text") {
	for (int idx = 0; idx < textboxes.Count; idx++) {
		textboxes[idx].DataBindings.Add(new Binding(eigenschaft, dbObj.bindingSource, attributs[idx], true));
	}
}
		#endregion 2. Textbox
		#region 3. Nachschlagen
		/// <summary>
		/// Bindet Combobox-Items an Attributwerte der Subtabelle (Nachschlagetabelle)
		/// </summary>
		/// <param name="comboBox"></param> Name der AUswahlbox
		/// <param name="dbObj"></param> Datenbankobjekt
		/// <param name="displayMember"></param> anzuzeigendes Attribut
		/// <param name="valueMember"></param> Identifikationsschlüssel
		public static void nachschlagen(ComboBox comboBox, CsharpMySql dbObj, string displayMember, string valueMember) {
	// Bindung
	comboBox.DataSource = dbObj.getBindingSource;
	// - Attribut zum Anzeigen
	comboBox.DisplayMember = displayMember;
	// - Sekundärschlüssel in der Haupttabelle
	comboBox.ValueMember = valueMember;
}
		#endregion 3. Nachschlagen
		#region 4. is-part-of
		/// <summary>
		/// Findet den Datensatz in einer Part-Of-Tabelle nach Anwahl einer
		/// Datenzeile in einer Datagridview
		/// </summary>
		/// <param name="dataGridView"></param> Datentabellensicht
		/// <param name="id"></param>  Identifikationsschlüssel
		/// <param name="dbObj"></param> Datenbankobjekt der Datenbank-Subtabelle
		public static void isPartOf(DataGridView dataGridView, string id, CsharpMySql dbObj) {
	//dataGridView_Gestell.CurrentRow.SetValues(0);
	try { 
		// Attribut holen
		var find = dataGridView.CurrentRow.Cells[id].Value;
		// Findet Auswahl in der Part-Of-Tabelle
		dbObj.bindingSource.Position = dbObj.bindingSource.Find(id, find);
	}
	catch (Exception ex) { }
}
/// <summary> ÜBERLADUNG
/// Findet den Datensatz in einer Part-Of-Tabelle nach Anwahl einer
/// Datenzeile in einer Datagridview. Die Namen der Identifikationsschlüssel
/// zwischen Haupt- und der Nachschlagetabelle können sich unterscheiden.
/// </summary>
/// <param name="dataGridView"></param> Datentabellensicht
/// <param name="idGruppe"></param> Id in der Baugruppentabelle
/// <param name="idPartOf"></param> Id in der Nachschlagetabelle
/// <param name="dbObj"></param> Datenbankobjekt der Datenbank-Subtabelle
public static void isPartOf(DataGridView dataGridView, string idGruppe, string idPartOf, CsharpMySql dbObj) {
	//dataGridView_Gestell.CurrentRow.SetValues(0);
	try {  // Ermittelt die Id in der Baugruppe/Erzeugnis
		var find = dataGridView.CurrentRow.Cells[idGruppe].Value;
		// Findet Auswahl in der Part-Of-Tabelle
		dbObj.bindingSource.Position = dbObj.bindingSource.Find(idPartOf, find);
	} catch (Exception ex) { }
}
		#endregion is-part-Of
		#region 5. TreeView - Add Node
		/// <summary> 
		/// Bereitstellung eines Datensatzes (Einzelteil) einer Datentabelle als Knoten,
		/// um ihn einem Strukturbaum hinzuzufügen
		/// </summary>
		/// <param name="dataGrid"></param> Name der sichtbaren Datententabelle
		/// <param name="tabControl"></param> Name der übergeordneten Tabellenregisters
		/// <returns></returns> Knotene (Node) der hinzugefügt werden soll
		public static TreeNode addTeil(DataGridView dataGrid, TabControl tabControl) {
			// Teilebezeichnung eines hinzugefügten Knotens
			string teil = tabControl.TabPages[tabControl.SelectedIndex].Text;
			// Tabellenattribute, die in der Erzeugnisstruktur genannt werden
			string id = dataGrid.CurrentRow.Cells[0].Value.ToString();
			string bez = dataGrid.CurrentRow.Cells[1].Value.ToString();
			// Knoten erzeugen, beschriften und übernehmen
			TreeNode treeNode = new TreeNode();
			treeNode.Tag = "teil";
			treeNode.Text = teil + " | ID: " + id + " | " + bez;
			return treeNode;
		}
		/// <summary> ÜBERLADUNG
		/// Übernahme eines Datensatzes (Einzelteil) einer Datentabelle in einen Strukturbaum (Erzeugnisstruktur)
		/// <param name="dataGrid"></param> Name der sichtbaren Datententabelle
		/// <param name="tabControl"></param> Name der übergeordneten Tabellenregisters
		/// <param name="treeView"></param>  // Aktueller stand des Strukturbaums
		/// <returns></returns> //Neuer Stand des Strukturbaums
		public static TreeView addTeil(DataGridView dataGrid, TabControl tabControl, TreeView treeView) {
			//Aufruf der überladenen Methode als Parameter
			treeView.SelectedNode.Nodes.Add(Comp.addTeil(dataGrid, tabControl));
			return treeView;
		}
		#endregion 5. TreeView -Add Node
		#region 6 Nachschletabelle Synchronisieren
		/// <summary>
		/// Zeigt auf den Datensatz der Nachschlagetabelle synchron zum
		/// ausgewählten Datensatz in Haupttanbelle. Die Darstellung der Haupt-Daten muss 
		/// mithilfe der Komponente "DtaGridView" erfolgen.
		/// <param name="mainDataGrid"></param> Hauptdatentabellensicht (DataGridView)
		/// <param name="subIdName"></param> Name des Identifikationsschlüssels der Subtabelle
		/// beziehungsweiese der Lookup-Tabelle
		/// <param name="subBindingSource"></param> Verbindungsobjekt der Subtabelle
		/// </summary>
		public static void showSubTableSynchronous(DataGridView mainDataGrid, string subIdName, BindingSource subBindingSource) {
			// aktuelle Zeile
			int aktuelleZeile = 0;
			try
			{  //Leere Tabellen sollten nicht zu einem Fehler führen
				aktuelleZeile = mainDataGrid.CurrentCell.RowIndex;
				// Kunden synchronisieren
				string id = mainDataGrid.Rows[aktuelleZeile].Cells[subIdName].Value.ToString();
				// Findet Auswahl in der Nachschlagetabelle Kunden
				subBindingSource.Position = subBindingSource.Find(subIdName, id);
			}
			catch (Exception ex) { aktuelleZeile = 0; }
		}
		#endregion 4.4. Nachschletabelle Synchronisieren

	}
}

