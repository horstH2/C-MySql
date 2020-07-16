using System;
using System.Windows.Forms;
using OwnMySqlDB;
namespace View {
public partial class Form_View : Form {
#region 1. Attribute, Instanzen 
// Verbindungsstring ist Applikationsabhängig
static string connectingString = "server=localhost; user id = root; persistsecurityinfo=True; password=root; database=kundenwerkstueckeview";
// View
CsharpMySql dbView = new CsharpMySql("werkstuecklieferdienst", connectingString);
#endregion 1. Attribute, Instanzen 
public Form_View() {
	InitializeComponent();
}
#region 2. Menü
private void Form_View_Load(object sender, EventArgs e) {
	// Binden der sichtbaren Komponenten
	bindingNavigator_View.BindingSource = dbView.getBindingSource;
	dataGridView_View.DataSource = dbView.getBindingSource;
}
/// <summary>
/// Bei Aktivierung werden die Daten neu geladen (Reorganisation)
/// </summary>
private void Form_View_Activated(object sender, EventArgs e) {
	toolStripButton_Restore_Click(sender, e);
}
/// <summary>
/// Neu laden der Daten (Reorganisation)
/// </summary>
private void toolStripButton_Restore_Click(object sender, EventArgs e) {
	// Enfernen der Ansicht aus dem Datenset
	dbView.removeTableInDataset();
	// Aktualisierte Tabelle dem Datenset hinzufügen
	dbView.addTableToDataset();
}
/// <summary>
/// Schaltet Kindformular unsichtbar,
///  wird erst mit der kompletten Anwendung geschlossen.
/// </summary>
private void toolStripButton_Schliessen_Click(object sender, EventArgs e) {
	Form_View.ActiveForm.Visible = false;
}
#endregion 2. Menü
}
}
