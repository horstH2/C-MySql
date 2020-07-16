using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OwnMySqlDB;  // Klasse: SsharpMySql
using OwnCompCon;  // Klasse: Comp

namespace Werkzeugverwaltung
{
  public partial class Form_WZV : Form {
#region 1. Attribute, Instanzen der Klasse
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=werkzeugverwaltung";
// Hauptobjekt (Instanz´der Klasse)
CsharpMySql dbWZ = new CsharpMySql("werkzeuge", connectingString);
// is-a-Tables (Instanz der Klasse)
CsharpMySql dbWZF = new CsharpMySql("fraeswerkzeuge", connectingString);
CsharpMySql dbWZD = new CsharpMySql("drehwerkzeuge", connectingString);
CsharpMySql dbWZB = new CsharpMySql("bohrwerkzeuge", connectingString);
#endregion 1. Attribute, Instanzen der Klasse 

		#region Konstruktor der Formuarklasse
		public Form_WZV()
      {
          InitializeComponent();
      }
		#endregion Konstruktor


		#region 2. Relationen und Bindunngen
		/// <summary>
		/// Realtionen, Datentabellen, Komponenten
		/// </summary>
		private void Form_WZV_Load(object sender, EventArgs e) {
			/// ACHTUNG: Sollte vor dem Binden der Komponenten stehen!
			// Instanz der Haupttabelle: Definiert Relation zwischen der Haupttabelle und Detailtabelle 
			this.dbWZ.mainToSubRelation("fraeswerkzeuge", this.dbWZF.getBindingSource, "idWZ", "Werkzeuge_idWZ");
			this.dbWZ.mainToSubRelation("drehwerkzeuge", this.dbWZD.getBindingSource, "idWZ", "Werkzeuge_idWZ");
			this.dbWZ.mainToSubRelation("bohrwerkzeuge", this.dbWZB.getBindingSource, "idWZ", "Werkzeuge_idWZ"); 
			// Navigatoren an Datenquelle binden
			this.bindingNavigator_WZ.BindingSource  = this.dbWZ.getBindingSource;
			this.bindingNavigator_WZF.BindingSource = this.dbWZF.getBindingSource;
			this.bindingNavigator_WZD.BindingSource = this.dbWZD.getBindingSource;
			this.bindingNavigator_WZB.BindingSource = this.dbWZB.getBindingSource; 
			// Tabellensicht verbinden und gestalten
			this.dataGridView_WZ.DataSource = dbWZ.getBindingSource;
			this.dataGridView_WZ.AutoResizeColumns();
			//this.dataGridView_WZ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView_WZ.Columns["Bild"].Visible = false;
			this.dataGridView_WZ.Columns["Text"].Visible = false;
			// TEXTBOXEN
			/// Werkzeuge
			var textBoxes = new List<TextBox> { textBox_idWZ, textBox_Alias, textBox_Name };
			var attributs = new List<string> { "idWZ", "Alias", "Name" };
			Comp.textboxBinding(textBoxes, attributs, dbWZ);
			// Fräswerkzeuge
			textBoxes = new List<TextBox>{textBox_idWZF, textBox_LaengeWZF,
				textBox_DurchmesserWZF, textBox_EinstellwinkelWZF, textBox_EckenradiusWZF};
			attributs = new List<string> { "Werkzeuge_idWZ", "Laenge", "Durchmesser", "Einstellwinkel", "Eckenradius"};
			Comp.textboxBinding(textBoxes, attributs, dbWZF);
			// Drehwerkzeuge
			textBoxes = new List<TextBox>
			  { textBox_idWZD, textBox_XLaengeWZD, textBox_ZLaengeWZD, textBox_EinstellwinkelWZD, textBox_EckenradiusWZD};
			attributs = new List<string> { "Werkzeuge_idWZ", "X_Laenge", "Z_Laenge", "Einstellwinkel", "Eckenradius" };
			Comp.textboxBinding(textBoxes, attributs, dbWZD);
			// Bohrwerkzeuge
			textBoxes = new List<TextBox>
			      { textBox_idWZB, textBox_LaengeWZB,textBox_DurchmesserWZB, textBox_SpitzenwinkelWZB};
			attributs = new List<string> { "Werkzeuge_idWZ", "Laenge", "Durchmesser", "Spitzenwinkel"};
			Comp.textboxBinding(textBoxes, attributs, dbWZB);
  		// Bild an Datenbanktabelle anbinden --------------
			pictureBox_WZ.DataBindings.Add(new Binding("Image", dbWZ.bindingSource, "Bild", true));
			// Rich-Text-Box anbinden
			richTextBox_WZ.DataBindings.Add(new Binding("Text", dbWZ.bindingSource, "Text", true));
			// Auswahlbox
			comboBox_Typ.DataBindings.Add(new Binding("Text", dbWZ.bindingSource, "Typ", true));
		}
		#endregion 2.  Relationen und Bindunngen
		#region 3. Aktualisieren der Tabellendaten
		/// <summary>
		/// Aktualisiert die Werkzeugbasisdatentabelle
		/// </summary>
		private void toolStripButton_AktualisierenWerkzeug_Click(object sender, EventArgs e) {
	dbWZ.aktualisieren();
	CsharpMySql.dataSet.AcceptChanges();
}
/// <summary>
/// Aktualisiert die Fräswerkzeugdatentabelle
/// und prüft die (1,1)-(0,1)-Beziehung
/// </summary>
private void toolStripButton_AktualisierenFraeswerkzeuge_Click(object sender, EventArgs e) {
	dbWZF.aktualisieren();
	tryAccept("Fräswerkzeug", this.dbWZF.getBindingSource.Count);
}
/// <summary>
/// Aktualisiert die Drehwerkzeugdatentabelle
/// und prüft die (1,1)-(0,1)-Beziehung
/// </summary>
private void toolStripButton_AktualisierenDrehwerkzeuge_Click(object sender, EventArgs e) {
	dbWZD.aktualisieren();
	tryAccept("Drehwerkzeug", this.dbWZD.getBindingSource.Count);
}
/// <summary>
/// Aktualisiert die Bohrwerkzeugdatentabelle
/// und prüft die (1,1)-(0,1)-Beziehung
/// </summary>
private void toolStripButton_AktualisierenBohrwerkzeug_Click(object sender, EventArgs e) {
	dbWZB.aktualisieren();
	this.tryAccept("Bohrwerkzeug", this.dbWZB.getBindingSource.Count);
}
/// <summary>
/// Prüft auf Akzeptanz
/// </summary>
public int tryAccept(string typ, int anzahl) {

	label_info.Text = " Records: " + anzahl;
	if (anzahl>1) {
label_info.Text =  
"Achtung (Records " + anzahl.ToString()+ "): \r\n" +
"Pro Werkzeug ist nur eine Spezifikation erlaubt! \r\n" +
"Es handelt sich um eine 1-1-Beziehung. \r\n" +
"Ein " + typ + " ist ein Werkzeug.";
	}
try {CsharpMySql.dataSet.AcceptChanges();}
catch (Exception ex) { label_info.Text = ex.ToString(); }
return anzahl;
}
/// <summary>
/// Fräaen Meldung löschen
/// </summary>
private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
{
label_info.Text = " Info ";
}


/// <summary>
/// Aktualisiert die Daten der Datenbank und
/// beendet die Anwendung
/// </summary>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e) {
	toolStripButton_AktualisierenWerkzeug_Click(sender, e);
	toolStripButton_AktualisierenFraeswerkzeuge_Click(sender, e);
	toolStripButton_AktualisierenDrehwerkzeuge_Click(sender, e);
	toolStripButton_AktualisierenBohrwerkzeug_Click(sender, e);
	CsharpMySql.con.Close();
	Close();
}
#endregion 3. Aktualisieren der Tabellendaten

#region 4. Spezifiziert die Maske
/// <summary>
/// Wählt die zutreffende Eingabemaske mit Bindung an Datenbanktabelle
/// </summary>
private void bindingNavigator_Werkzeuge_RefreshItems(object sender, EventArgs e) {
	try {
			tabControl_SubTabellen.SelectTab("tabPage_" + comboBox_Typ.Text);   
	}
	catch {
		//Wenn kein Werzeugtyp bekannt ist, dann wähle die Fräswerkzeugmaske
		tabControl_SubTabellen.SelectTab("tabPage_Fraeswerkzeug");
	}
}
/// <summary>
/// Bezug zur Submaske nach Programmstart
/// </summary>
private void Form_WZV_Shown(object sender, EventArgs e) {
	bindingNavigator_Werkzeuge_RefreshItems(sender, e);
}
#endregion 4. Spezifizierung der Maske
#region 5. Bild bearbeiten
/// <summary>
/// Zuweisung eines Bildes aus der Zwischenablage
/// </summary>
private void toolStripMenuItem_Einfuegen_Click(object sender, EventArgs e) {
	pictureBox_WZ.Image = Clipboard.GetImage();
}
/// <summary>
/// Kopieren eines Bildes in die Zwischenablage
/// </summary>
private void toolStripMenuItem_Kopieren_Click(object sender, EventArgs e) {
	Clipboard.SetImage(pictureBox_WZ.Image);
}
/// <summary>
/// Löschen eines Bildes
/// </summary>
private void toolStripMenuItem_Löschen_Click(object sender, EventArgs e) {
	pictureBox_WZ.Image = null;
} 
#endregion 5. Bild bearbeiten


	}
}
