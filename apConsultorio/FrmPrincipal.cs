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
  public partial class FrmPrincipal : Form
  {
    public FrmPrincipal()
    {
      InitializeComponent();
    }

    private void btnMedicos_Click(object sender, EventArgs e)
    {
      if (txtSenha.Text != "" && txtUsuario.Text != "")
      {
        FrmMedico medico = new FrmMedico();
        medico.usuario = txtUsuario.Text;
        medico.senha = txtSenha.Text;
        medico.Show();
      }
    }

    private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape) 
      {
        Close();
      }
    }

    private void btnPacientes_Click(object sender, EventArgs e)
    {
      if (txtSenha.Text != "" && txtUsuario.Text != "")
      {
        FrmPacientes paciente = new FrmPacientes();
        paciente.usuario = txtUsuario.Text;
        paciente.senha = txtSenha.Text;
        paciente.Show();
      }
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnConsultas_Click(object sender, EventArgs e)
    {
      if (txtSenha.Text != "" && txtUsuario.Text != "")
      {
        FrmConsultas consulta = new FrmConsultas();
        consulta.usuario = txtUsuario.Text;
        consulta.senha = txtSenha.Text;
        consulta.Show();
      }
    }
  }
}
