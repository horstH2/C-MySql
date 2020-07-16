using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auftrag_Kunde
{
  public partial class Form_Arbeitsplan : Form
  {
    public Form_Arbeitsplan()
    {
      InitializeComponent();
    }

    private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Form_Arbeitsplan_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "kundenwerkstueckarbeitsplaeneDataSet3.arbeitsplan". Sie können sie bei Bedarf verschieben oder entfernen.
      this.arbeitsplanTableAdapter.Fill(this.kundenwerkstueckarbeitsplaeneDataSet3.arbeitsplan);
      // TODO: Diese Codezeile lädt Daten in die Tabelle "kundenwerkstueckarbeitsplaeneDataSet3.werkstuecke". Sie können sie bei Bedarf verschieben oder entfernen.
      this.werkstueckeTableAdapter.Fill(this.kundenwerkstueckarbeitsplaeneDataSet3.werkstuecke);
      
    }

    private void toolStripButton_ArbeitsplanAktualisieren_Click(object sender, EventArgs e)
    {
      this.bindingSource_Arbeitsplan.EndEdit();
      this.arbeitsplanTableAdapter.Update(this.kundenwerkstueckarbeitsplaeneDataSet3.arbeitsplan);
    }

    private void bindingNavigator_Arbeitsplan_RefreshItems(object sender, EventArgs e)
    {
      //Aktualisieren
      
    }





  }
}
