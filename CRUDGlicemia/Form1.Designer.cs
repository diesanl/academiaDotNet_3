namespace CRUDGlicemia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.listViewMedidasGlicemia = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dateTimePickerDataMedicao = new System.Windows.Forms.DateTimePicker();
            this.textBoxIdPaciente = new System.Windows.Forms.TextBox();
            this.textBoxValorGlicemia = new System.Windows.Forms.TextBox();
            this.textBoxIdGlicemia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(12, 177);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(75, 23);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(93, 177);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(174, 177);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 2;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(255, 177);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(18, 168);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // listViewMedidasGlicemia
            // 
            this.listViewMedidasGlicemia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewMedidasGlicemia.Location = new System.Drawing.Point(12, 12);
            this.listViewMedidasGlicemia.Name = "listViewMedidasGlicemia";
            this.listViewMedidasGlicemia.Size = new System.Drawing.Size(705, 159);
            this.listViewMedidasGlicemia.TabIndex = 5;
            this.listViewMedidasGlicemia.UseCompatibleStateImageBehavior = false;
            this.listViewMedidasGlicemia.View = System.Windows.Forms.View.Details;
            this.listViewMedidasGlicemia.SelectedIndexChanged += new System.EventHandler(this.listViewMedidasGlicemia_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IdMedida";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicêmico";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Medição";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "idPaciente";
            this.columnHeader5.Width = 200;
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.buttonCancelar);
            this.panelCampos.Controls.Add(this.dateTimePickerDataMedicao);
            this.panelCampos.Controls.Add(this.textBoxIdPaciente);
            this.panelCampos.Controls.Add(this.buttonSalvar);
            this.panelCampos.Controls.Add(this.textBoxValorGlicemia);
            this.panelCampos.Controls.Add(this.textBoxIdGlicemia);
            this.panelCampos.Controls.Add(this.label4);
            this.panelCampos.Controls.Add(this.label3);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.label1);
            this.panelCampos.Enabled = false;
            this.panelCampos.Location = new System.Drawing.Point(12, 226);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(318, 212);
            this.panelCampos.TabIndex = 6;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(99, 168);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dateTimePickerDataMedicao
            // 
            this.dateTimePickerDataMedicao.Location = new System.Drawing.Point(99, 79);
            this.dateTimePickerDataMedicao.Name = "dateTimePickerDataMedicao";
            this.dateTimePickerDataMedicao.Size = new System.Drawing.Size(75, 23);
            this.dateTimePickerDataMedicao.TabIndex = 7;
            // 
            // textBoxIdPaciente
            // 
            this.textBoxIdPaciente.Location = new System.Drawing.Point(99, 114);
            this.textBoxIdPaciente.Name = "textBoxIdPaciente";
            this.textBoxIdPaciente.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdPaciente.TabIndex = 6;
            // 
            // textBoxValorGlicemia
            // 
            this.textBoxValorGlicemia.Location = new System.Drawing.Point(99, 43);
            this.textBoxValorGlicemia.Name = "textBoxValorGlicemia";
            this.textBoxValorGlicemia.Size = new System.Drawing.Size(100, 23);
            this.textBoxValorGlicemia.TabIndex = 5;
            // 
            // textBoxIdGlicemia
            // 
            this.textBoxIdGlicemia.Location = new System.Drawing.Point(99, 11);
            this.textBoxIdGlicemia.Name = "textBoxIdGlicemia";
            this.textBoxIdGlicemia.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdGlicemia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "idPaciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Medição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Glicemia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "idGlicemia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 451);
            this.Controls.Add(this.panelCampos);
            this.Controls.Add(this.listViewMedidasGlicemia);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonConectar;
        private Button buttonCadastrar;
        private Button buttonDeletar;
        private Button buttonEditar;
        private Button buttonSalvar;
        private ListView listViewMedidasGlicemia;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Panel panelCampos;
        private DateTimePicker dateTimePickerDataMedicao;
        private TextBox textBoxIdPaciente;
        private TextBox textBoxValorGlicemia;
        private TextBox textBoxIdGlicemia;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCancelar;
    }
}