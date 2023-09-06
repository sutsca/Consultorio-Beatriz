using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apConsultorio
{
  public partial class FrmMedico : Form
  {
    public string senha, usuario;
    
    public FrmMedico()
    {
      InitializeComponent();
    }

    private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.medicoBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.consDataSet);
    }

    private void FrmMedico_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Close();
      }
    }

    private void FrmMedico_Load(object sender, EventArgs e)
    {
      medicoTableAdapter.Connection.ConnectionString += 
                       ";User Id="+usuario+";Password="+senha;
      // TODO: esta linha de código carrega dados na tabela 'consDataSet.Medico'. Você pode movê-la ou removê-la conforme necessário.
      this.medicoTableAdapter.Fill(this.consDataSet.Medico);

    }
  }
}
