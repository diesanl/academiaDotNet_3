namespace WinFormsExercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnListarEmail = new System.Windows.Forms.Button();
            this.btnListarDominio = new System.Windows.Forms.Button();
            this.txtListaPessoas = new System.Windows.Forms.TextBox();
            this.txtListaEmails = new System.Windows.Forms.TextBox();
            this.txtListaDominios = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(32, 129);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            this.btnInserir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnInserir_KeyPress);
            // 
            // btnListarEmail
            // 
            this.btnListarEmail.Location = new System.Drawing.Point(186, 129);
            this.btnListarEmail.Name = "btnListarEmail";
            this.btnListarEmail.Size = new System.Drawing.Size(87, 23);
            this.btnListarEmail.TabIndex = 4;
            this.btnListarEmail.Text = "Listar Emails";
            this.btnListarEmail.UseVisualStyleBackColor = true;
            this.btnListarEmail.Click += new System.EventHandler(this.btnListarEmail_Click);
            this.btnListarEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnListarEmail_KeyPress);
            // 
            // btnListarDominio
            // 
            this.btnListarDominio.Location = new System.Drawing.Point(344, 129);
            this.btnListarDominio.Name = "btnListarDominio";
            this.btnListarDominio.Size = new System.Drawing.Size(100, 23);
            this.btnListarDominio.TabIndex = 5;
            this.btnListarDominio.Text = "Listar Domínios";
            this.btnListarDominio.UseVisualStyleBackColor = true;
            // 
            // txtListaPessoas
            // 
            this.txtListaPessoas.Location = new System.Drawing.Point(32, 158);
            this.txtListaPessoas.Multiline = true;
            this.txtListaPessoas.Name = "txtListaPessoas";
            this.txtListaPessoas.ReadOnly = true;
            this.txtListaPessoas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaPessoas.Size = new System.Drawing.Size(100, 280);
            this.txtListaPessoas.TabIndex = 7;
            this.txtListaPessoas.TabStop = false;
            // 
            // txtListaEmails
            // 
            this.txtListaEmails.Location = new System.Drawing.Point(186, 158);
            this.txtListaEmails.Multiline = true;
            this.txtListaEmails.Name = "txtListaEmails";
            this.txtListaEmails.ReadOnly = true;
            this.txtListaEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaEmails.Size = new System.Drawing.Size(100, 280);
            this.txtListaEmails.TabIndex = 8;
            this.txtListaEmails.TabStop = false;
            // 
            // txtListaDominios
            // 
            this.txtListaDominios.Location = new System.Drawing.Point(344, 158);
            this.txtListaDominios.Multiline = true;
            this.txtListaDominios.Name = "txtListaDominios";
            this.txtListaDominios.ReadOnly = true;
            this.txtListaDominios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaDominios.Size = new System.Drawing.Size(100, 280);
            this.txtListaDominios.TabIndex = 9;
            this.txtListaDominios.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(466, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLimpar_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtListaDominios);
            this.Controls.Add(this.txtListaEmails);
            this.Controls.Add(this.txtListaPessoas);
            this.Controls.Add(this.btnListarDominio);
            this.Controls.Add(this.btnListarEmail);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Button btnInserir;
        private Button btnListarEmail;
        private Button btnListarDominio;
        private TextBox txtListaPessoas;
        private TextBox txtListaEmails;
        private TextBox txtListaDominios;
        private Button btnLimpar;
    }
}