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
  public partial class FrmConsultas : Form
  {
    public string usuario, senha;
    public FrmConsultas()
    {
      InitializeComponent();
    }

    private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.consultaBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.consDataSet);

    }

    private void FrmConsultas_Load(object sender, EventArgs e)
    {
      medicoTableAdapter.Connection.ConnectionString +=
                 ";User Id=" + usuario + ";Password=" + senha;
      pacienteTableAdapter.Connection.ConnectionString +=
           ";User Id=" + usuario + ";Password=" + senha;
      consultaTableAdapter.Connection.ConnectionString +=
           ";User Id=" + usuario + ";Password=" + senha;
      this.pacienteTableAdapter.Fill(this.consDataSet.Paciente);
      this.medicoTableAdapter.Fill(this.consDataSet.Medico);
      this.consultaTableAdapter.Fill(this.consDataSet.Consulta);

    }
  }
}
