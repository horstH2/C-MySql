/*
 * Verfasser Horst-Christian Heinke
 * Magdeburg, 27.04.2020
 * Weitere Quellen:
 * https://stackoverflow.com/questions/11434556/vb-net-combobox-with-a-bindingsource-and-a-different-datasource
 * https://docs.microsoft.com/de-de/dotnet/framework/winforms/controls/how-to-create-a-lookup-table-with-the-windows-forms-bindingsource-component
 * 
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OwnMySqlDB; // Klasse "CsharpMySql"

namespace Auftrag_Kunde
{
    public partial class Form_Kundenauftraege : Form
    {
	#region 1. Attribute, Instanzen der Klasse
		// Verbindungsstring ist Applikationsabhängig
		static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=auftragsverwaltung";
		// Hauptobjekt (Instanz´der Klasse)
		CsharpMySql dbAT = new CsharpMySql("auftraege", connectingString);
		// Nachschlageobjekt (Instanz der Klasse)
		CsharpMySql dbKD = new CsharpMySql("kunden", connectingString);
	#endregion 1. Attribute

		public Form_Kundenauftraege()
        {
            InitializeComponent();
        }

	#region 2. Ereignismethoden
		#region 2.1 Formular
		/// <summary>
		/// Holt die Daten aus der Datenbank beim Laden des Formulars
		/// </summary>
		private void Form_Kundenauftraege_Load(object sender, EventArgs e)
		{
			// Navigatoren an Datenquelle binden
			this.bindingNavigator_AT.BindingSource = this.dbAT.getBindingSource;
			this.bindingNavigator_KD.BindingSource = this.dbKD.getBindingSource;
			// Sichtbare Tabellen an Datenquelle binden
			this.dataGridView_AT.DataSource = this.dbAT.getBindingSource;
			this.dataGridView_KD.DataSource = this.dbKD.getBindingSource;
			// Anpassen der sichtbaren Tabellen
			this.dataGridView_AT.AutoResizeColumns();
			this.dataGridView_KD.AutoResizeColumns();
			/// AUFTRAGSFORMULAR
			// - Textkomponenten an Datenquellenattribute binden
			this.textBox_idAT.DataBindings.Add(new Binding("Text", this.dbAT.bindingSource, "idAT", true));
			this.textBox_Auftrag.DataBindings.Add(new Binding("Text", this.dbAT.bindingSource, "Auftrag", true));
			this.textBox_Liefertermin.DataBindings.Add(new Binding("Text", this.dbAT.bindingSource, "Liefertermin", true));
			/// RELATION ZWISCHEN AUSWAHLBOX UND NACHSCHLAGETABELLE
			// - Binden an die Nachschlagetabelle
			this.comboBox_AT_idKD.DataSource = dbKD.getBindingSource;
			// - Attribut zum Anzeigen
			this.comboBox_AT_idKD.DisplayMember = "Kunde";
			// - Sekundärschlüssel in der Haupttabelle
			this.comboBox_AT_idKD.ValueMember = "idKD";
			/// KUNDENFORMULAR
			//  - Textkomponenten an Datenquellenattribute binden
			this.textBox_idKD.DataBindings.Add(new Binding("Text", this.dbKD.bindingSource, "idKD", true));
			this.textBox_Kunde.DataBindings.Add(new Binding("Text", this.dbKD.bindingSource, "kunde", true));
			this.textBox_Strasse.DataBindings.Add(new Binding("Text", this.dbKD.bindingSource, "strasse", true));
			this.textBox_Nr.DataBindings.Add(new Binding("Text", this.dbKD.bindingSource, "nr", true));
			this.textBox_PLZ.DataBindings.Add(new Binding("Text", this.dbKD.bindingSource, "plz", true));
			this.textBox_Ort.DataBindings.Add(new Binding("Text", this.dbKD.bindingSource, "ort", true));
			this.textBox_Telefon.DataBindings.Add(new Binding("Text", this.dbKD.bindingSource, "telefon", true));
			this.textBox_Email.DataBindings.Add(new Binding("Text", this.dbKD.bindingSource, "email", true));

		}
		/// <summary>
		/// Zeigt auf die Partnerzeile in der Nachschlagetabelle "Kundentabelle"
		/// wenn das Formular dargestellt wird.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form_Kundenauftraege_Shown(object sender, EventArgs e)
		{
			// aktuelle Zeile
			int aktuelleZeile = this.dataGridView_AT.CurrentCell.RowIndex;
			string wert = this.dataGridView_AT.Rows[aktuelleZeile].Cells[3].Value.ToString();
			// Findet Auswahl in der Nachschlagetabelle
			dbKD.bindingSource.Position = dbKD.bindingSource.Find("idKD", wert);
		}
		#endregion 2.1 Formular
		#region 2.2 Komponenten
		/// <summary>
		/// Zeige auf  Partnerzeile in der Nachschlagetabelle
		/// wenn der Fokus in der Auftragstabelle verändert wird.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGridView_AT_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Form_Kundenauftraege_Shown(sender, e);
		}
		/// <summary>
		/// Übernehme in Haupttabelle nach dem Auswählen eines Eintrags
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBox_AT_idKD_SelectionChangeCommitted(object sender, EventArgs e)
		{
			int aktuelleZeile = this.dataGridView_AT.CurrentCell.RowIndex;
			this.dataGridView_AT.Rows[aktuelleZeile].Cells[3].Value = this.comboBox_AT_idKD.SelectedValue.ToString();
		}
		#endregion 2.2 Komponenten
		#region 2.3 Mainmenü
		/// <summary>
		/// Aktualisiert die Daten
		/// </summary>
		private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.dbAT.aktualisieren();
			this.dbKD.aktualisieren();
			CsharpMySql.dataSet.AcceptChanges();
		}
		/// <summary>
		/// Schließt die Anwendung nach der Aktualisierung
		/// </summary>
		private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			aktualisierenToolStripMenuItem_Click(sender, e);
			// Datenbankverbindung beenden
			CsharpMySql.con.Close();
			Close();
		}
		#endregion 2.3 Mainmenü
	#endregion 2. Ereignismethoden

	}
}


