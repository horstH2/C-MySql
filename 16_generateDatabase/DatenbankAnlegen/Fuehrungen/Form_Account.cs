using System;
using System.Windows.Forms;
namespace Fuehrungen {
public partial class Form_Account : Form {
#region 1. Attribute
// Verbindungsstring
static string connectingString;
// Name der SQL-Datei
static string fileName;
// Instanz des Kindformulars
Form_Fuehrungen fuehrungen; // = new Form_Fuehrungen(connectingString, fileName);
#endregion 1. Attribute
public Form_Account()
{
	InitializeComponent();
}
#region 2. Ereignismethoden
/// <summary>
/// Laden der SQL-Datei
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void SqlDateiLadenToolStripMenuItem_Click(object sender, EventArgs e) {
	OpenFileDialog openFile = new OpenFileDialog();
	openFile.DefaultExt = "*.sql";
	if (openFile.ShowDialog() == DialogResult.OK)	{
		fileName = openFile.FileName;
		richTextBox_Sql.LoadFile(fileName, RichTextBoxStreamType.PlainText);
	}
}
/// <summary>
/// Verbindung zum Datenbankserver herstellen,
/// Datenbank mittels SQL-Code erzeugen
/// Wird nur ausgeführt, wenn diese Datenbank auf dem Server nicht vorhanden ist.
/// </summary>
private void datenbankErzeugenToolStripMenuItem_Click(object sender, EventArgs e) {
	string server = textBox_server.Text;
	string userId = textBox_userId.Text;
	string persist = comboBox_persist.Text;
	string password = textBox_password.Text;
	string format = "server={0}; user id= {1}; persistsecurityinfo= {2}; password= {3}";// ; database= {4}";
	// Verbindungsstring: Datenbasis entfällt, da diese erst importiert wird!
	connectingString = String.Format(format, server, userId, persist, password);
	textBox_info.Text = connectingString;
	fuehrungen = new Form_Fuehrungen(connectingString, fileName);
	fuehrungen.Show();
}
/// <summary>
/// Anwendung beenden
/// </summary>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e) {
	Close();
}
#endregion 2. Ereignismethoden
	}
}
