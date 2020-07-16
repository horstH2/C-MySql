using System;
using System.Windows.Forms;
using MySqlDB; // Klasse "CsharpMySql"

namespace TabellenVerwalten {
	public partial class Form_Teiletabellen : Form {
#region 1. Attribute, Instanzen der Klasse
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=vorschubantrieb";
// Datenbankobjekte (Instanz´der Klasse)
CsharpMySql dbLager = new CsharpMySql("lager", connectingString);
CsharpMySql dbMotor = new CsharpMySql("motor", connectingString);
CsharpMySql dbPassfedern = new CsharpMySql("passfedern", connectingString);
CsharpMySql dbSchrauben = new CsharpMySql("schrauben", connectingString);
CsharpMySql dbSpindel = new CsharpMySql("spindel", connectingString);
CsharpMySql dbZahnriemen = new CsharpMySql("zahnriemen", connectingString);
CsharpMySql dbZahnscheiben = new CsharpMySql("zahnscheiben", connectingString);
#endregion 1. Attribute, Instanzen der Klasse
/// <summary>
/// Formularkonstruktor
/// </summary>
public Form_Teiletabellen(){
	InitializeComponent();
}

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
/// <summary>
/// UPDATE: Aktualisieren der Tabellen nach einer Änderung.
/// Änderungen werden persistent in den Datenbanktabellen gespeichert.
/// </summary>
#region Aktualisieren
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
#endregion Aktualisieren

/// <summary>
/// Anwendung beenden
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
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

	}
}
