namespace apConsultorio
{
  partial class FrmPrincipal
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.btnMedicos = new System.Windows.Forms.ToolStripButton();
      this.btnPacientes = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.btnConsultas = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.btnSair = new System.Windows.Forms.ToolStripButton();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMedicos,
            this.btnPacientes,
            this.toolStripSeparator1,
            this.btnConsultas,
            this.toolStripSeparator2,
            this.btnSair});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(276, 38);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // btnMedicos
      // 
      this.btnMedicos.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicos.Image")));
      this.btnMedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnMedicos.Name = "btnMedicos";
      this.btnMedicos.Size = new System.Drawing.Size(56, 35);
      this.btnMedicos.Text = "Médicos";
      this.btnMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnMedicos.ToolTipText = "Cadatro de Médicos";
      this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
      // 
      // btnPacientes
      // 
      this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
      this.btnPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnPacientes.Name = "btnPacientes";
      this.btnPacientes.Size = new System.Drawing.Size(61, 35);
      this.btnPacientes.Text = "Pacientes";
      this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnPacientes.ToolTipText = "Cadastro de Pacientes";
      this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
      // 
      // btnConsultas
      // 
      this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
      this.btnConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnConsultas.Name = "btnConsultas";
      this.btnConsultas.Size = new System.Drawing.Size(63, 35);
      this.btnConsultas.Text = "Consultas";
      this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
      // 
      // btnSair
      // 
      this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
      this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(30, 35);
      this.btnSair.Text = "Sair";
      this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 54);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Usuário:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Senha:";
      // 
      // txtUsuario
      // 
      this.txtUsuario.Location = new System.Drawing.Point(88, 51);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(148, 26);
      this.txtUsuario.TabIndex = 3;
      // 
      // txtSenha
      // 
      this.txtSenha.Location = new System.Drawing.Point(88, 84);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '*';
      this.txtSenha.Size = new System.Drawing.Size(148, 26);
      this.txtSenha.TabIndex = 4;
      // 
      // FrmPrincipal
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(276, 129);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.toolStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmPrincipal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Gerenciamento de Consultório Médico";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton btnMedicos;
    private System.Windows.Forms.ToolStripButton btnPacientes;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton btnConsultas;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnSair;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.TextBox txtSenha;
  }
}

