/// <summary> ---------------------------------------------------------------------------------------
/// Urheber: Horst-Christian Heinke
/// Ort: Magdeburg, Datum: 26.05.2020
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
		#region 3. nachschlage
		/// <summary>
		/// Bindet Combobox-Items an Attributwerte der Subtabelle (Nachschlagetabelle)
		/// </summary>
		/// <param name="comboBox"></param> Name der AUswahlbox
		/// <param name="dbObj"></param> Datenbankobjekt
		/// <param name="displayMember"></param> anzuzeigendes Attribut
		/// <param name="valueMember"></param> Identifikationsschlüssel
		public static void nachschlagen(ComboBox comboBox, CsharpMySql dbObj, string displayMember, string valueMember)
{
	// Bindung
	comboBox.DataSource = dbObj.getBindingSource;
	// - Attribut zum Anzeigen
	comboBox.DisplayMember = displayMember;
	// - Sekundärschlüssel in der Haupttabelle
	comboBox.ValueMember = valueMember;
}
		#endregion 3. nachschlage
		#region 4. is-part-of
		/// <summary>
		/// Findet den Datensatz in einer Part-Of-Tabelle nach Anwahl einer
		/// Datenzeile in einer Datagridview
		/// </summary>
		/// <param name="dataGridView"></param> Datentabellensicht
		/// <param name="id"></param>  Identifikationsschlüssel
		/// <param name="dbObj"></param> Datenbankobjekt der Datenbank-Subtabelle
		public static void isPartOf(DataGridView dataGridView, string id, CsharpMySql dbObj)
{
	//dataGridView_Gestell.CurrentRow.SetValues(0);
	try
	{  // Attribut
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
	try
	{  // Ermittelt die Id in der Baugruppe/Erzeugnis
		var find = dataGridView.CurrentRow.Cells[idGruppe].Value;
		// Findet Auswahl in der Part-Of-Tabelle
		dbObj.bindingSource.Position = dbObj.bindingSource.Find(idPartOf, find);
	}
	catch (Exception ex) { }
}
#endregion is-part-Of
}
}

