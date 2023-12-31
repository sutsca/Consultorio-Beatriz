﻿namespace apConsultorio
{
  partial class FrmMedico
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
      System.Windows.Forms.Label idMedicoLabel;
      System.Windows.Forms.Label nomeMedicoLabel;
      System.Windows.Forms.Label sobrenomeMedLabel;
      System.Windows.Forms.Label crmLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedico));
      this.consDataSet = new apConsultorio.consDataSet();
      this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.medicoTableAdapter = new apConsultorio.consDataSetTableAdapters.MedicoTableAdapter();
      this.tableAdapterManager = new apConsultorio.consDataSetTableAdapters.TableAdapterManager();
      this.medicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.medicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.idMedicoLabel1 = new System.Windows.Forms.Label();
      this.nomeMedicoTextBox = new System.Windows.Forms.TextBox();
      this.sobrenomeMedTextBox = new System.Windows.Forms.TextBox();
      this.crmTextBox = new System.Windows.Forms.TextBox();
      this.medicoDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      idMedicoLabel = new System.Windows.Forms.Label();
      nomeMedicoLabel = new System.Windows.Forms.Label();
      sobrenomeMedLabel = new System.Windows.Forms.Label();
      crmLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.consDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.medicoBindingNavigator)).BeginInit();
      this.medicoBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.medicoDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // idMedicoLabel
      // 
      idMedicoLabel.AutoSize = true;
      idMedicoLabel.Location = new System.Drawing.Point(17, 43);
      idMedicoLabel.Name = "idMedicoLabel";
      idMedicoLabel.Size = new System.Drawing.Size(146, 20);
      idMedicoLabel.TabIndex = 1;
      idMedicoLabel.Text = "Número do Médico:";
      // 
      // nomeMedicoLabel
      // 
      nomeMedicoLabel.AutoSize = true;
      nomeMedicoLabel.Location = new System.Drawing.Point(17, 72);
      nomeMedicoLabel.Name = "nomeMedicoLabel";
      nomeMedicoLabel.Size = new System.Drawing.Size(77, 20);
      nomeMedicoLabel.TabIndex = 3;
      nomeMedicoLabel.Text = "Prenome:";
      // 
      // sobrenomeMedLabel
      // 
      sobrenomeMedLabel.AutoSize = true;
      sobrenomeMedLabel.Location = new System.Drawing.Point(17, 104);
      sobrenomeMedLabel.Name = "sobrenomeMedLabel";
      sobrenomeMedLabel.Size = new System.Drawing.Size(96, 20);
      sobrenomeMedLabel.TabIndex = 5;
      sobrenomeMedLabel.Text = "Sobrenome:";
      // 
      // crmLabel
      // 
      crmLabel.AutoSize = true;
      crmLabel.Location = new System.Drawing.Point(17, 136);
      crmLabel.Name = "crmLabel";
      crmLabel.Size = new System.Drawing.Size(61, 20);
      crmLabel.TabIndex = 7;
      crmLabel.Text = "C.R.M.:";
      // 
      // consDataSet
      // 
      this.consDataSet.DataSetName = "consDataSet";
      this.consDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.ConsultaTableAdapter = null;
      this.tableAdapterManager.MedicoTableAdapter = this.medicoTableAdapter;
      this.tableAdapterManager.PacienteTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = apConsultorio.consDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // medicoBindingNavigator
      // 
      this.medicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.medicoBindingNavigator.BindingSource = this.medicoBindingSource;
      this.medicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.medicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.medicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medicoBindingNavigatorSaveItem});
      this.medicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.medicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.medicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.medicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.medicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.medicoBindingNavigator.Name = "medicoBindingNavigator";
      this.medicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.medicoBindingNavigator.Size = new System.Drawing.Size(502, 25);
      this.medicoBindingNavigator.TabIndex = 0;
      this.medicoBindingNavigator.Text = "bindingNavigator1";
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
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
      this.bindingNavigatorCountItem.Text = "de {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Excluir";
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
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Mover último";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // medicoBindingNavigatorSaveItem
      // 
      this.medicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.medicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicoBindingNavigatorSaveItem.Image")));
      this.medicoBindingNavigatorSaveItem.Name = "medicoBindingNavigatorSaveItem";
      this.medicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.medicoBindingNavigatorSaveItem.Text = "Salvar Dados";
      this.medicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicoBindingNavigatorSaveItem_Click);
      // 
      // idMedicoLabel1
      // 
      this.idMedicoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "idMedico", true));
      this.idMedicoLabel1.Location = new System.Drawing.Point(169, 43);
      this.idMedicoLabel1.Name = "idMedicoLabel1";
      this.idMedicoLabel1.Size = new System.Drawing.Size(100, 23);
      this.idMedicoLabel1.TabIndex = 2;
      this.idMedicoLabel1.Text = "label1";
      // 
      // nomeMedicoTextBox
      // 
      this.nomeMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "nomeMedico", true));
      this.nomeMedicoTextBox.Location = new System.Drawing.Point(173, 69);
      this.nomeMedicoTextBox.Name = "nomeMedicoTextBox";
      this.nomeMedicoTextBox.Size = new System.Drawing.Size(153, 26);
      this.nomeMedicoTextBox.TabIndex = 4;
      // 
      // sobrenomeMedTextBox
      // 
      this.sobrenomeMedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "sobrenomeMed", true));
      this.sobrenomeMedTextBox.Location = new System.Drawing.Point(173, 101);
      this.sobrenomeMedTextBox.Name = "sobrenomeMedTextBox";
      this.sobrenomeMedTextBox.Size = new System.Drawing.Size(252, 26);
      this.sobrenomeMedTextBox.TabIndex = 6;
      // 
      // crmTextBox
      // 
      this.crmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "crm", true));
      this.crmTextBox.Location = new System.Drawing.Point(173, 133);
      this.crmTextBox.Name = "crmTextBox";
      this.crmTextBox.Size = new System.Drawing.Size(100, 26);
      this.crmTextBox.TabIndex = 8;
      // 
      // medicoDataGridView
      // 
      this.medicoDataGridView.AutoGenerateColumns = false;
      this.medicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.medicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      this.medicoDataGridView.DataSource = this.medicoBindingSource;
      this.medicoDataGridView.Location = new System.Drawing.Point(21, 174);
      this.medicoDataGridView.Name = "medicoDataGridView";
      this.medicoDataGridView.ReadOnly = true;
      this.medicoDataGridView.Size = new System.Drawing.Size(469, 178);
      this.medicoDataGridView.TabIndex = 9;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "idMedico";
      this.dataGridViewTextBoxColumn1.HeaderText = "idMedico";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeMedico";
      this.dataGridViewTextBoxColumn2.HeaderText = "nomeMedico";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "sobrenomeMed";
      this.dataGridViewTextBoxColumn3.HeaderText = "sobrenomeMed";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "crm";
      this.dataGridViewTextBoxColumn4.HeaderText = "crm";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // FrmMedico
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(502, 364);
      this.Controls.Add(this.medicoDataGridView);
      this.Controls.Add(idMedicoLabel);
      this.Controls.Add(this.idMedicoLabel1);
      this.Controls.Add(nomeMedicoLabel);
      this.Controls.Add(this.nomeMedicoTextBox);
      this.Controls.Add(sobrenomeMedLabel);
      this.Controls.Add(this.sobrenomeMedTextBox);
      this.Controls.Add(crmLabel);
      this.Controls.Add(this.crmTextBox);
      this.Controls.Add(this.medicoBindingNavigator);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KeyPreview = true;
      this.Name = "FrmMedico";
      this.Text = "Cadastro de Médicos";
      this.Load += new System.EventHandler(this.FrmMedico_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMedico_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.consDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.medicoBindingNavigator)).EndInit();
      this.medicoBindingNavigator.ResumeLayout(false);
      this.medicoBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.medicoDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private consDataSet consDataSet;
    private System.Windows.Forms.BindingSource medicoBindingSource;
    private consDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
    private consDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator medicoBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton medicoBindingNavigatorSaveItem;
    private System.Windows.Forms.Label idMedicoLabel1;
    private System.Windows.Forms.TextBox nomeMedicoTextBox;
    private System.Windows.Forms.TextBox sobrenomeMedTextBox;
    private System.Windows.Forms.TextBox crmTextBox;
    private System.Windows.Forms.DataGridView medicoDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
  }
}