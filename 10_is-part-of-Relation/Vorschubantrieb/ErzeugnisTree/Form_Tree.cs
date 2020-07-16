#region Bibliotheken
using System;
using System.Windows.Forms;
using System.Drawing; //Typ Point
// Zum Speichern und Lafen der TreeView als Binärdatei
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 
using System.Linq; 
using System.Collections.Generic;
// Namespaces der eigene Klassen
using OwnMySqlDB; // Klasse "CsharpMySql"
using OwnCompCon; // Klasse "Comp"
#endregion Bibliotheken

namespace Erzeugnisstruktur {
public partial class Form_Tree : Form {
#region 1. Attribute, Instanzen der Klasse
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=vorschubantrieb";
// Datenbankobjekte (Instanzen der Klasse)
CsharpMySql dbLager = new CsharpMySql("lager", connectingString);
CsharpMySql dbMotor = new CsharpMySql("motor", connectingString);
CsharpMySql dbPassfedern = new CsharpMySql("passfedern", connectingString);
CsharpMySql dbSchrauben = new CsharpMySql("schrauben", connectingString);
CsharpMySql dbSpindel = new CsharpMySql("spindel", connectingString);
CsharpMySql dbZahnriemen = new CsharpMySql("zahnriemen", connectingString);
CsharpMySql dbZahnscheiben = new CsharpMySql("zahnscheiben", connectingString);
// Merker
string nodeCurrentText = "";
int nodeCurrent = 0;
//int nodeParentCurrent = 0;
#endregion 1. Attribute, Instanzen der Klasse
		/// <summary>
		/// Formularkonstruktor
		/// </summary>
		public Form_Tree(){
			InitializeComponent();
		}
#region 2. Bindungen
/// <summary>
/// Sichtbare Komponenten an die Datenquelle binden
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void Form_TabOrg_Load(object sender, EventArgs e) {
// Navigatoren an Datenquelle binden
bindingNavigator_Lager.BindingSource = dbLager.getBindingSource;
bindingNavigator_Motor.BindingSource = dbMotor.getBindingSource;
bindingNavigator_Passfedern.BindingSource = dbPassfedern.getBindingSource;
bindingNavigator_Schrauben.BindingSource = dbSchrauben.getBindingSource;
bindingNavigator_Spindel.BindingSource = dbSpindel.getBindingSource;
bindingNavigator_Zahnriemen.BindingSource = dbZahnriemen.getBindingSource;
bindingNavigator_Zahnscheiben.BindingSource = dbZahnscheiben.getBindingSource;
// Sichtbare Tabellen an Datenquelle binden
dataGridView_Lager.DataSource = dbLager.getBindingSource;
dataGridView_Motor.DataSource = dbMotor.getBindingSource;
dataGridView_Passfedern.DataSource = dbPassfedern.getBindingSource;
dataGridView_Schrauben.DataSource = dbSchrauben.getBindingSource;
dataGridView_Spindel.DataSource = dbSpindel.getBindingSource;
dataGridView_Zahnriemen.DataSource = dbZahnriemen.getBindingSource;
dataGridView_Zahnscheiben.DataSource = dbZahnscheiben.getBindingSource;
}
#endregion 2. Bindungen
#region 3. Aktualisieren der Datentabellen
/// <summary>
/// UPDATE: Aktualisieren der Tabellen nach einer Änderung.
/// Änderungen werden persistent in den Datenbanktabellen gespeichert.
/// </summary>
private void toolStripButton_SpindelUpdate_Click(object sender, EventArgs e) {
dbSpindel.aktualisieren(dataGridView_Spindel);
CsharpMySql.dataSet.AcceptChanges();
}
private void toolStripButton_MotorUpdate_Click(object sender, EventArgs e) {
dbMotor.aktualisieren(dataGridView_Motor);
CsharpMySql.dataSet.AcceptChanges();
}
private void toolStripButton_LagerUpdate_Click(object sender, EventArgs e) {
dbLager.aktualisieren(dataGridView_Lager);
CsharpMySql.dataSet.AcceptChanges();
}
private void toolStripButton_SchraubenUpdate_Click(object sender, EventArgs e) {
dbSchrauben.aktualisieren(dataGridView_Schrauben);
CsharpMySql.dataSet.AcceptChanges();
}
private void toolStripButton_PassfedernUpdate_Click(object sender, EventArgs e) {
dbPassfedern.aktualisieren(dataGridView_Passfedern);
CsharpMySql.dataSet.AcceptChanges();
}
private void toolStripButton_ZahnriemenUpdate_Click(object sender, EventArgs e) {
dbZahnriemen.aktualisieren(dataGridView_Zahnriemen);
CsharpMySql.dataSet.AcceptChanges();
}
private void toolStripButton_ZahnscheibenUpdate_Click(object sender, EventArgs e) {
dbZahnscheiben.aktualisieren(dataGridView_Zahnscheiben);
CsharpMySql.dataSet.AcceptChanges();
}
#endregion 3. Aktualisieren der Datentabellen
#region 4. TreeView -------------------------
#region 4.1. Erzeugnis-, Baugruppenknoten erzeugen
//-------https://docs.microsoft.com/de-de/dotnet/framework/winforms/controls/how-to-add-and-remove-nodes-with-the-windows-forms-treeview-control
/// <summary>
/// Merker setzen
/// </summary>
private void treeView_Erz_AfterSelect(object sender, TreeViewEventArgs e) {
	this.nodeCurrentText = e.Node.Text;  //Merker
	this.nodeCurrent = e.Node.Index + '\n';
	label_Info.Text = e.Node.Text +" ("+ e.Node.Index +")\n";
}
/// <summary>
/// Erzeugnis-Knoten anlegen (Startknoten)
/// </summary>
private void erzeugnisAnlegenToolStripMenuItem_Click(object sender, EventArgs e) {
	string erzeugnis = "Erzeugnis";
	TreeNode treeNode = new TreeNode(erzeugnis);
	treeNode.Tag = "erz";
	treeView_Erz.Nodes.Insert(0, treeNode);
}
/// <summary>
/// Baugruppen-Knoten in einer beliebigen Ebene anlegen
/// </summary>
private void baugruppeAnlegenToolStripMenuItem_Click(object sender, EventArgs e) {
	TreeNode treeNode = new TreeNode();
	treeNode.Tag = "bgr";
	treeNode.Text = "neue Baugruppe";
	treeView_Erz.SelectedNode.Nodes.Add(treeNode.Text);
}
#endregion 4.1 Erzeugnis-, Baugruppenknoten erzeugen
#region 4.2. Teile in Erzeugnisstruktur übernehmen (add)
/// <summary> -----------------------------------------------------
/// Tabellenbezogene Ereignismethoden
/// </summary> -----------------------------------------------------
private void toolStripButton_AddSpindel_Click(object sender, EventArgs e) {
	treeView_Erz.SelectedNode.Nodes.Add(Comp.addTeil(dataGridView_Spindel, tabControl_Teile));
}
private void toolStripButton_AddMotor_Click(object sender, EventArgs e) {
	treeView_Erz.SelectedNode.Nodes.Add(Comp.addTeil(dataGridView_Motor, tabControl_Teile));
}
private void toolStripButton_AddLager_Click(object sender, EventArgs e) {
	treeView_Erz = Comp.addTeil(dataGridView_Lager, tabControl_Teile, treeView_Erz);
}
private void toolStripButton_AddSchraube_Click(object sender, EventArgs e) {
	treeView_Erz = Comp.addTeil(dataGridView_Schrauben, tabControl_Teile, treeView_Erz);
}
private void toolStripButton_Passfeder_Click(object sender, EventArgs e) {
	treeView_Erz = Comp.addTeil(dataGridView_Passfedern, tabControl_Teile, treeView_Erz);
}
private void toolStripButton_AddZahnriemen_Click(object sender, EventArgs e) {
	treeView_Erz = Comp.addTeil(dataGridView_Zahnriemen, tabControl_Teile, treeView_Erz);
}
private void toolStripButton_AddZahnscheibe_Click(object sender, EventArgs e) {
	treeView_Erz = Comp.addTeil(dataGridView_Zahnscheiben, tabControl_Teile, treeView_Erz);
}
#endregion 4.2. Teile in Erzeugnisstruktur übernehmen (add)
#region 4.3. Speichern und Laden einer Erzeugnisstruktur als Datei im Binärformat
/// <summary>
/// Speichert die Erzeugnisstruktur
/// https://stackoverflow.com/questions/5868790/saving-content-of-a-treeview-to-a-file-and-load-it-later
/// </summary>
private void speichernAlsToolStripMenuItem_Click(object sender, EventArgs e) {
	SaveFileDialog saveDialog = new SaveFileDialog();
	saveDialog.DefaultExt = "*.bin";
	saveDialog.Filter = "Binärdatei|*.bin";
	if (saveDialog.ShowDialog() == DialogResult.OK) {
		using (Stream file = File.Open(saveDialog.FileName, FileMode.Create)) {
			BinaryFormatter bf = new BinaryFormatter();
			bf.Serialize(file, treeView_Erz.Nodes.Cast<TreeNode>().ToList());
		}
	}
}
/// <summary>
/// Lädt die Erzeugnisstruktur
/// </summary>
private void ladenToolStripMenuItem_Click(object sender, EventArgs e) {
	OpenFileDialog openDialog = new OpenFileDialog();
	openDialog.DefaultExt = "*.bin";
	openDialog.Filter = "Binärdatei|*.bin";

	if (openDialog.ShowDialog() == DialogResult.OK) {
		using (Stream file = File.Open(openDialog.FileName, FileMode.Open)) {
			BinaryFormatter bf = new BinaryFormatter();
			object obj = bf.Deserialize(file);
			TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
			treeView_Erz.Nodes.AddRange(nodeList);
		}
	}
	treeView_Erz.ExpandAll();
}
#endregion 4.3. Speichern und Laden einer Erzeugnisstruktur als Datei im Binärformat
#region 4.4. Löschen von Knoten
/// <summary>
/// Entfern den ausgewählten Knoten
/// </summary>
private void teilBaugruppeEntfernenToolStripMenuItem_Click(object sender, EventArgs e) {
	treeView_Erz.Nodes.Remove(treeView_Erz.SelectedNode);
}

/// <summary>
/// Löscht die gesamte Erzeugnisstruktur
/// </summary>
private void löschenToolStripMenuItem_Click(object sender, EventArgs e) {
		treeView_Erz.Nodes.Clear();
	}
#endregion 4.4. Löschen von Knoten
#region 4.5. Editieren eines Knotentextes
/// <summary>
/// Ändern des Knotentextes in einer Textbox
/// </summary>
private void editierenToolStripMenuItem_Click(object sender, EventArgs e) {
	//TextBox textBox = new System.Windows.Forms.TextBox();
	textBox_edit.Name = "textBox";
	textBox_edit.Text = nodeCurrentText;
	Point pos = Cursor.Position; pos.X -= 52; pos.Y -= 71;
	// Umrechnung der Formularposition in Komponentenposition (Client)
	pos=treeView_Erz.PointToClient(pos);
	label_Info.Text = pos.ToString();
	textBox_edit.Location = pos;
	// Textbox sichtbar schalten
	textBox_edit.Visible = true;
	textBox_edit.BringToFront();
}
/// <summary>
/// Änderung in die Erzeugnisstruktur übernehmen
/// </summary>
private void textBox_Leave(object sender, EventArgs e ) {
	// Änderung übernehmen
	treeView_Erz.SelectedNode.Text = textBox_edit.Text;
	// Textbox unsichtbar schalten
	textBox_edit.Visible = false;
}
#endregion 4.5. Editieren eines Knotentextes
		#endregion 4. TreeView
#region 5. Beenden
/// <summary>
/// Anwendung beenden
/// </summary>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e) {
	// Tabellen aktualisieren
	toolStripButton_SpindelUpdate_Click(sender, e);
	toolStripButton_MotorUpdate_Click(sender, e);
	toolStripButton_LagerUpdate_Click(sender, e);
	toolStripButton_PassfedernUpdate_Click(sender, e);
	toolStripButton_ZahnriemenUpdate_Click(sender, e);
	toolStripButton_ZahnscheibenUpdate_Click(sender, e);
	// Datenbankverbindung beenden
	CsharpMySql.con.Close();
	// Anwendung schließen
	Close();
}
#endregion 5. Beenden


	}
}

