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
  public partial class Form_Arbeitsplaene : Form
  {
    public Form_Arbeitsplaene()
    {
      InitializeComponent();
    }

    private void Form_Arbeitsplaene_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "kundenwerkstueckarbeitsplaeneDataSet1.arbeitsplan". Sie können sie bei Bedarf verschieben oder entfernen.
      this.arbeitsplanTableAdapter.Fill(this.kundenwerkstueckarbeitsplaeneDataSet1.arbeitsplan);

    }
  }
}
