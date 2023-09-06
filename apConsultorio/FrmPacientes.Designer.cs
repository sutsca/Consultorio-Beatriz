namespace apConsultorio
{
  partial class FrmPacientes
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientes));
      System.Windows.Forms.Label idPacienteLabel;
      System.Windows.Forms.Label nomePacienteLabel;
      System.Windows.Forms.Label sobrenomePacLabel;
      System.Windows.Forms.Label telefoneLabel;
      System.Windows.Forms.Label nascimentoLabel;
      this.consDataSet = new apConsultorio.consDataSet();
      this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.pacienteTableAdapter = new apConsultorio.consDataSetTableAdapters.PacienteTableAdapter();
      this.tableAdapterManager = new apConsultorio.consDataSetTableAdapters.TableAdapterManager();
      this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.idPacienteLabel1 = new System.Windows.Forms.Label();
      this.nomePacienteTextBox = new System.Windows.Forms.TextBox();
      this.sobrenomePacTextBox = new System.Windows.Forms.TextBox();
      this.telefoneTextBox = new System.Windows.Forms.TextBox();
      this.nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.pacienteDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      idPacienteLabel = new System.Windows.Forms.Label();
      nomePacienteLabel = new System.Windows.Forms.Label();
      sobrenomePacLabel = new System.Windows.Forms.Label();
      telefoneLabel = new System.Windows.Forms.Label();
      nascimentoLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.consDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
      this.pacienteBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // consDataSet
      // 
      this.consDataSet.DataSetName = "consDataSet";
      this.consDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // pacienteBindingSource
      // 
      this.pacienteBindingSource.DataMember = "Paciente";
      this.pacienteBindingSource.DataSource = this.consDataSet;
      // 
      // pacienteTableAdapter
      // 
      this.pacienteTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.ConsultaTableAdapter = null;
      this.tableAdapterManager.MedicoTableAdapter = null;
      this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
      this.tableAdapterManager.UpdateOrder = apConsultorio.consDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // pacienteBindingNavigator
      // 
      this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
      this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pacienteBindingNavigatorSaveItem});
      this.pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
      this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.pacienteBindingNavigator.Size = new System.Drawing.Size(649, 25);
      this.pacienteBindingNavigator.TabIndex = 0;
      this.pacienteBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Posição";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
      this.bindingNavigatorCountItem.Text = "de {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Mover último";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorDeleteItem.Text = "Excluir";
      // 
      // pacienteBindingNavigatorSaveItem
      // 
      this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
      this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
      this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
      this.pacienteBindingNavigatorSaveItem.Text = "Salvar Dados";
      this.pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacienteBindingNavigatorSaveItem_Click);
      // 
      // idPacienteLabel
      // 
      idPacienteLabel.AutoSize = true;
      idPacienteLabel.Location = new System.Drawing.Point(11, 32);
      idPacienteLabel.Name = "idPacienteLabel";
      idPacienteLabel.Size = new System.Drawing.Size(63, 20);
      idPacienteLabel.TabIndex = 1;
      idPacienteLabel.Text = "Código:";
      // 
      // idPacienteLabel1
      // 
      this.idPacienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "idPaciente", true));
      this.idPacienteLabel1.Location = new System.Drawing.Point(141, 32);
      this.idPacienteLabel1.Name = "idPacienteLabel1";
      this.idPacienteLabel1.Size = new System.Drawing.Size(200, 23);
      this.idPacienteLabel1.TabIndex = 2;
      this.idPacienteLabel1.Text = "label1";
      // 
      // nomePacienteLabel
      // 
      nomePacienteLabel.AutoSize = true;
      nomePacienteLabel.Location = new System.Drawing.Point(11, 61);
      nomePacienteLabel.Name = "nomePacienteLabel";
      nomePacienteLabel.Size = new System.Drawing.Size(55, 20);
      nomePacienteLabel.TabIndex = 3;
      nomePacienteLabel.Text = "Nome:";
      // 
      // nomePacienteTextBox
      // 
      this.nomePacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "nomePaciente", true));
      this.nomePacienteTextBox.Location = new System.Drawing.Point(114, 58);
      this.nomePacienteTextBox.Name = "nomePacienteTextBox";
      this.nomePacienteTextBox.Size = new System.Drawing.Size(154, 26);
      this.nomePacienteTextBox.TabIndex = 4;
      // 
      // sobrenomePacLabel
      // 
      sobrenomePacLabel.AutoSize = true;
      sobrenomePacLabel.Location = new System.Drawing.Point(11, 93);
      sobrenomePacLabel.Name = "sobrenomePacLabel";
      sobrenomePacLabel.Size = new System.Drawing.Size(96, 20);
      sobrenomePacLabel.TabIndex = 5;
      sobrenomePacLabel.Text = "Sobrenome:";
      // 
      // sobrenomePacTextBox
      // 
      this.sobrenomePacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "sobrenomePac", true));
      this.sobrenomePacTextBox.Location = new System.Drawing.Point(114, 90);
      this.sobrenomePacTextBox.Name = "sobrenomePacTextBox";
      this.sobrenomePacTextBox.Size = new System.Drawing.Size(200, 26);
      this.sobrenomePacTextBox.TabIndex = 6;
      // 
      // telefoneLabel
      // 
      telefoneLabel.AutoSize = true;
      telefoneLabel.Location = new System.Drawing.Point(11, 125);
      telefoneLabel.Name = "telefoneLabel";
      telefoneLabel.Size = new System.Drawing.Size(75, 20);
      telefoneLabel.TabIndex = 7;
      telefoneLabel.Text = "Telefone:";
      // 
      // telefoneTextBox
      // 
      this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "telefone", true));
      this.telefoneTextBox.Location = new System.Drawing.Point(114, 122);
      this.telefoneTextBox.Name = "telefoneTextBox";
      this.telefoneTextBox.Size = new System.Drawing.Size(200, 26);
      this.telefoneTextBox.TabIndex = 8;
      // 
      // nascimentoLabel
      // 
      nascimentoLabel.AutoSize = true;
      nascimentoLabel.Location = new System.Drawing.Point(11, 158);
      nascimentoLabel.Name = "nascimentoLabel";
      nascimentoLabel.Size = new System.Drawing.Size(97, 20);
      nascimentoLabel.TabIndex = 9;
      nascimentoLabel.Text = "Nascimento:";
      // 
      // nascimentoDateTimePicker
      // 
      this.nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacienteBindingSource, "nascimento", true));
      this.nascimentoDateTimePicker.Location = new System.Drawing.Point(114, 154);
      this.nascimentoDateTimePicker.Name = "nascimentoDateTimePicker";
      this.nascimentoDateTimePicker.Size = new System.Drawing.Size(319, 26);
      this.nascimentoDateTimePicker.TabIndex = 10;
      // 
      // pacienteDataGridView
      // 
      this.pacienteDataGridView.AutoGenerateColumns = false;
      this.pacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.pacienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.pacienteDataGridView.DataSource = this.pacienteBindingSource;
      this.pacienteDataGridView.Location = new System.Drawing.Point(14, 188);
      this.pacienteDataGridView.Name = "pacienteDataGridView";
      this.pacienteDataGridView.Size = new System.Drawing.Size(623, 220);
      this.pacienteDataGridView.TabIndex = 11;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "idPaciente";
      this.dataGridViewTextBoxColumn1.HeaderText = "idPaciente";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "nomePaciente";
      this.dataGridViewTextBoxColumn2.HeaderText = "nomePaciente";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "sobrenomePac";
      this.dataGridViewTextBoxColumn3.HeaderText = "sobrenomePac";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "telefone";
      this.dataGridViewTextBoxColumn4.HeaderText = "telefone";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "nascimento";
      this.dataGridViewTextBoxColumn5.HeaderText = "nascimento";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // FrmPacientes
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(649, 428);
      this.Controls.Add(this.pacienteDataGridView);
      this.Controls.Add(idPacienteLabel);
      this.Controls.Add(this.idPacienteLabel1);
      this.Controls.Add(nomePacienteLabel);
      this.Controls.Add(this.nomePacienteTextBox);
      this.Controls.Add(sobrenomePacLabel);
      this.Controls.Add(this.sobrenomePacTextBox);
      this.Controls.Add(telefoneLabel);
      this.Controls.Add(this.telefoneTextBox);
      this.Controls.Add(nascimentoLabel);
      this.Controls.Add(this.nascimentoDateTimePicker);
      this.Controls.Add(this.pacienteBindingNavigator);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmPacientes";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Pacientes";
      this.Load += new System.EventHandler(this.FrmPacientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.consDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
      this.pacienteBindingNavigator.ResumeLayout(false);
      this.pacienteBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private consDataSet consDataSet;
    private System.Windows.Forms.BindingSource pacienteBindingSource;
    private consDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
    private consDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
    private System.Windows.Forms.Label idPacienteLabel1;
    private System.Windows.Forms.TextBox nomePacienteTextBox;
    private System.Windows.Forms.TextBox sobrenomePacTextBox;
    private System.Windows.Forms.TextBox telefoneTextBox;
    private System.Windows.Forms.DateTimePicker nascimentoDateTimePicker;
    private System.Windows.Forms.DataGridView pacienteDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
  }
}