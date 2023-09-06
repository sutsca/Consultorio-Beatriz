namespace apConsultorio
{
  partial class FrmConsultas
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
      System.Windows.Forms.Label idConsultaLabel;
      System.Windows.Forms.Label idMedicoLabel;
      System.Windows.Forms.Label idPacienteLabel;
      System.Windows.Forms.Label dataConsultaLabel;
      System.Windows.Forms.Label horaInicioLabel;
      System.Windows.Forms.Label horaFimLabel;
      System.Windows.Forms.Label observacoesLabel;
      this.consDataSet = new apConsultorio.consDataSet();
      this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.consultaTableAdapter = new apConsultorio.consDataSetTableAdapters.ConsultaTableAdapter();
      this.tableAdapterManager = new apConsultorio.consDataSetTableAdapters.TableAdapterManager();
      this.consultaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.consultaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.idConsultaLabel1 = new System.Windows.Forms.Label();
      this.idMedicoComboBox = new System.Windows.Forms.ComboBox();
      this.idPacienteComboBox = new System.Windows.Forms.ComboBox();
      this.dataConsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.horaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.horaFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.observacoesTextBox = new System.Windows.Forms.TextBox();
      this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.medicoTableAdapter = new apConsultorio.consDataSetTableAdapters.MedicoTableAdapter();
      this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.pacienteTableAdapter = new apConsultorio.consDataSetTableAdapters.PacienteTableAdapter();
      idConsultaLabel = new System.Windows.Forms.Label();
      idMedicoLabel = new System.Windows.Forms.Label();
      idPacienteLabel = new System.Windows.Forms.Label();
      dataConsultaLabel = new System.Windows.Forms.Label();
      horaInicioLabel = new System.Windows.Forms.Label();
      horaFimLabel = new System.Windows.Forms.Label();
      observacoesLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.consDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).BeginInit();
      this.consultaBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // consDataSet
      // 
      this.consDataSet.DataSetName = "consDataSet";
      this.consDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // consultaBindingSource
      // 
      this.consultaBindingSource.DataMember = "Consulta";
      this.consultaBindingSource.DataSource = this.consDataSet;
      // 
      // consultaTableAdapter
      // 
      this.consultaTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.ConsultaTableAdapter = this.consultaTableAdapter;
      this.tableAdapterManager.MedicoTableAdapter = this.medicoTableAdapter;
      this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
      this.tableAdapterManager.UpdateOrder = apConsultorio.consDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // consultaBindingNavigator
      // 
      this.consultaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.consultaBindingNavigator.BindingSource = this.consultaBindingSource;
      this.consultaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.consultaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.consultaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultaBindingNavigatorSaveItem});
      this.consultaBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.consultaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.consultaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.consultaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.consultaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.consultaBindingNavigator.Name = "consultaBindingNavigator";
      this.consultaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.consultaBindingNavigator.Size = new System.Drawing.Size(570, 25);
      this.consultaBindingNavigator.TabIndex = 0;
      this.consultaBindingNavigator.Text = "bindingNavigator1";
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
      // consultaBindingNavigatorSaveItem
      // 
      this.consultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.consultaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaBindingNavigatorSaveItem.Image")));
      this.consultaBindingNavigatorSaveItem.Name = "consultaBindingNavigatorSaveItem";
      this.consultaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
      this.consultaBindingNavigatorSaveItem.Text = "Salvar Dados";
      this.consultaBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultaBindingNavigatorSaveItem_Click);
      // 
      // idConsultaLabel
      // 
      idConsultaLabel.AutoSize = true;
      idConsultaLabel.Location = new System.Drawing.Point(12, 25);
      idConsultaLabel.Name = "idConsultaLabel";
      idConsultaLabel.Size = new System.Drawing.Size(92, 20);
      idConsultaLabel.TabIndex = 1;
      idConsultaLabel.Text = "id Consulta:";
      // 
      // idConsultaLabel1
      // 
      this.idConsultaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "idConsulta", true));
      this.idConsultaLabel1.Location = new System.Drawing.Point(130, 25);
      this.idConsultaLabel1.Name = "idConsultaLabel1";
      this.idConsultaLabel1.Size = new System.Drawing.Size(200, 23);
      this.idConsultaLabel1.TabIndex = 2;
      this.idConsultaLabel1.Text = "label1";
      // 
      // idMedicoLabel
      // 
      idMedicoLabel.AutoSize = true;
      idMedicoLabel.Location = new System.Drawing.Point(12, 54);
      idMedicoLabel.Name = "idMedicoLabel";
      idMedicoLabel.Size = new System.Drawing.Size(80, 20);
      idMedicoLabel.TabIndex = 3;
      idMedicoLabel.Text = "id Medico:";
      // 
      // idMedicoComboBox
      // 
      this.idMedicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultaBindingSource, "idMedico", true));
      this.idMedicoComboBox.DataSource = this.medicoBindingSource;
      this.idMedicoComboBox.DisplayMember = "nomeCompleto";
      this.idMedicoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.idMedicoComboBox.FormattingEnabled = true;
      this.idMedicoComboBox.Location = new System.Drawing.Point(130, 51);
      this.idMedicoComboBox.Name = "idMedicoComboBox";
      this.idMedicoComboBox.Size = new System.Drawing.Size(200, 28);
      this.idMedicoComboBox.TabIndex = 4;
      this.idMedicoComboBox.ValueMember = "idMedico";
      // 
      // idPacienteLabel
      // 
      idPacienteLabel.AutoSize = true;
      idPacienteLabel.Location = new System.Drawing.Point(12, 88);
      idPacienteLabel.Name = "idPacienteLabel";
      idPacienteLabel.Size = new System.Drawing.Size(91, 20);
      idPacienteLabel.TabIndex = 5;
      idPacienteLabel.Text = "id Paciente:";
      // 
      // idPacienteComboBox
      // 
      this.idPacienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultaBindingSource, "idPaciente", true));
      this.idPacienteComboBox.DataSource = this.pacienteBindingSource;
      this.idPacienteComboBox.DisplayMember = "nomeCompleto";
      this.idPacienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.idPacienteComboBox.FormattingEnabled = true;
      this.idPacienteComboBox.Location = new System.Drawing.Point(130, 85);
      this.idPacienteComboBox.Name = "idPacienteComboBox";
      this.idPacienteComboBox.Size = new System.Drawing.Size(200, 28);
      this.idPacienteComboBox.TabIndex = 6;
      this.idPacienteComboBox.ValueMember = "idPaciente";
      // 
      // dataConsultaLabel
      // 
      dataConsultaLabel.AutoSize = true;
      dataConsultaLabel.Location = new System.Drawing.Point(12, 123);
      dataConsultaLabel.Name = "dataConsultaLabel";
      dataConsultaLabel.Size = new System.Drawing.Size(112, 20);
      dataConsultaLabel.TabIndex = 7;
      dataConsultaLabel.Text = "data Consulta:";
      // 
      // dataConsultaDateTimePicker
      // 
      this.dataConsultaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "dataConsulta", true));
      this.dataConsultaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dataConsultaDateTimePicker.Location = new System.Drawing.Point(130, 119);
      this.dataConsultaDateTimePicker.Name = "dataConsultaDateTimePicker";
      this.dataConsultaDateTimePicker.Size = new System.Drawing.Size(200, 26);
      this.dataConsultaDateTimePicker.TabIndex = 8;
      // 
      // horaInicioLabel
      // 
      horaInicioLabel.AutoSize = true;
      horaInicioLabel.Location = new System.Drawing.Point(12, 155);
      horaInicioLabel.Name = "horaInicioLabel";
      horaInicioLabel.Size = new System.Drawing.Size(86, 20);
      horaInicioLabel.TabIndex = 9;
      horaInicioLabel.Text = "hora Inicio:";
      // 
      // horaInicioDateTimePicker
      // 
      this.horaInicioDateTimePicker.CustomFormat = "HH:mm";
      this.horaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "horaInicio", true));
      this.horaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.horaInicioDateTimePicker.Location = new System.Drawing.Point(130, 151);
      this.horaInicioDateTimePicker.Name = "horaInicioDateTimePicker";
      this.horaInicioDateTimePicker.Size = new System.Drawing.Size(100, 26);
      this.horaInicioDateTimePicker.TabIndex = 10;
      // 
      // horaFimLabel
      // 
      horaFimLabel.AutoSize = true;
      horaFimLabel.Location = new System.Drawing.Point(12, 187);
      horaFimLabel.Name = "horaFimLabel";
      horaFimLabel.Size = new System.Drawing.Size(75, 20);
      horaFimLabel.TabIndex = 11;
      horaFimLabel.Text = "hora Fim:";
      // 
      // horaFimDateTimePicker
      // 
      this.horaFimDateTimePicker.CustomFormat = "HH:mm";
      this.horaFimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "horaFim", true));
      this.horaFimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.horaFimDateTimePicker.Location = new System.Drawing.Point(130, 183);
      this.horaFimDateTimePicker.Name = "horaFimDateTimePicker";
      this.horaFimDateTimePicker.Size = new System.Drawing.Size(100, 26);
      this.horaFimDateTimePicker.TabIndex = 12;
      // 
      // observacoesLabel
      // 
      observacoesLabel.AutoSize = true;
      observacoesLabel.Location = new System.Drawing.Point(12, 218);
      observacoesLabel.Name = "observacoesLabel";
      observacoesLabel.Size = new System.Drawing.Size(103, 20);
      observacoesLabel.TabIndex = 13;
      observacoesLabel.Text = "observacoes:";
      // 
      // observacoesTextBox
      // 
      this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "observacoes", true));
      this.observacoesTextBox.Location = new System.Drawing.Point(130, 215);
      this.observacoesTextBox.Multiline = true;
      this.observacoesTextBox.Name = "observacoesTextBox";
      this.observacoesTextBox.Size = new System.Drawing.Size(337, 92);
      this.observacoesTextBox.TabIndex = 14;
      // 
      // medicoBindingSource
      // 
      this.medicoBindingSource.DataMember = "Medico";
      this.medicoBindingSource.DataSource = this.consDataSet;
      // 
      // medicoTableAdapter
      // 
      this.medicoTableAdapter.ClearBeforeFill = true;
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
      // FrmConsultas
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(570, 319);
      this.Controls.Add(idConsultaLabel);
      this.Controls.Add(this.idConsultaLabel1);
      this.Controls.Add(idMedicoLabel);
      this.Controls.Add(this.idMedicoComboBox);
      this.Controls.Add(idPacienteLabel);
      this.Controls.Add(this.idPacienteComboBox);
      this.Controls.Add(dataConsultaLabel);
      this.Controls.Add(this.dataConsultaDateTimePicker);
      this.Controls.Add(horaInicioLabel);
      this.Controls.Add(this.horaInicioDateTimePicker);
      this.Controls.Add(horaFimLabel);
      this.Controls.Add(this.horaFimDateTimePicker);
      this.Controls.Add(observacoesLabel);
      this.Controls.Add(this.observacoesTextBox);
      this.Controls.Add(this.consultaBindingNavigator);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmConsultas";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Registro de Consultas";
      this.Load += new System.EventHandler(this.FrmConsultas_Load);
      ((System.ComponentModel.ISupportInitialize)(this.consDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).EndInit();
      this.consultaBindingNavigator.ResumeLayout(false);
      this.consultaBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private consDataSet consDataSet;
    private System.Windows.Forms.BindingSource consultaBindingSource;
    private consDataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter;
    private consDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator consultaBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton consultaBindingNavigatorSaveItem;
    private consDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
    private System.Windows.Forms.Label idConsultaLabel1;
    private System.Windows.Forms.ComboBox idMedicoComboBox;
    private System.Windows.Forms.ComboBox idPacienteComboBox;
    private System.Windows.Forms.DateTimePicker dataConsultaDateTimePicker;
    private System.Windows.Forms.DateTimePicker horaInicioDateTimePicker;
    private System.Windows.Forms.DateTimePicker horaFimDateTimePicker;
    private System.Windows.Forms.TextBox observacoesTextBox;
    private System.Windows.Forms.BindingSource medicoBindingSource;
    private consDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
    private System.Windows.Forms.BindingSource pacienteBindingSource;
  }
}