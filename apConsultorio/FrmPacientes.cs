using apConsultorio.consDataSetTableAdapters;
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
  public partial class FrmPacientes : Form
  {
    public string usuario, senha;
    public FrmPacientes()
    {
      InitializeComponent();
    }

    private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.pacienteBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.consDataSet);
    }

    private void FrmPacientes_Load(object sender, EventArgs e)
    {
      pacienteTableAdapter.Connection.ConnectionString +=
                 ";User Id=" + usuario + ";Password=" + senha;
      // TODO: esta linha de código carrega dados na tabela 'consDataSet.Paciente'. Você pode movê-la ou removê-la conforme necessário.
      this.pacienteTableAdapter.Fill(this.consDataSet.Paciente);
    }
  }
}
