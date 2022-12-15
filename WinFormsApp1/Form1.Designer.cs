namespace WinFormsApp1
{
    partial class Form_principal
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
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtListaNomes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(26, 13);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(96, 15);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(141, 5);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(396, 23);
            this.txtNomeCompleto.TabIndex = 1;
            this.txtNomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCompleto_KeyPress);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(141, 50);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnInserir_MouseClick);
            // 
            // txtListaNomes
            // 
            this.txtListaNomes.Location = new System.Drawing.Point(141, 94);
            this.txtListaNomes.Multiline = true;
            this.txtListaNomes.Name = "txtListaNomes";
            this.txtListaNomes.ReadOnly = true;
            this.txtListaNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaNomes.Size = new System.Drawing.Size(396, 344);
            this.txtListaNomes.TabIndex = 3;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtListaNomes);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Name = "Form_principal";
            this.Text = "Título do fomulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnInserir;
        private TextBox txtListaNomes;
    }
}