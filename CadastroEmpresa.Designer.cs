
namespace UnusualEvents
{
    partial class CadastroEmpresa
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxWhatsapp = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelWhatsapp = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(27, 39);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(231, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(27, 216);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(231, 23);
            this.textBoxEmail.TabIndex = 4;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(27, 162);
            this.maskedTextBoxTelefone.Mask = "(00)0000-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(106, 23);
            this.maskedTextBoxTelefone.TabIndex = 5;
            // 
            // maskedTextBoxWhatsapp
            // 
            this.maskedTextBoxWhatsapp.Location = new System.Drawing.Point(152, 162);
            this.maskedTextBoxWhatsapp.Mask = "(00)0 0000-9999";
            this.maskedTextBoxWhatsapp.Name = "maskedTextBoxWhatsapp";
            this.maskedTextBoxWhatsapp.Size = new System.Drawing.Size(106, 23);
            this.maskedTextBoxWhatsapp.TabIndex = 6;
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(27, 102);
            this.maskedTextBoxCnpj.Mask = "00.000.000/0000-00";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(231, 23);
            this.maskedTextBoxCnpj.TabIndex = 7;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(27, 21);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(88, 15);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome Empresa";
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(27, 84);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(34, 15);
            this.labelCnpj.TabIndex = 9;
            this.labelCnpj.Text = "CNPJ";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(27, 144);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(51, 15);
            this.labelTelefone.TabIndex = 10;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelWhatsapp
            // 
            this.labelWhatsapp.AutoSize = true;
            this.labelWhatsapp.Location = new System.Drawing.Point(152, 144);
            this.labelWhatsapp.Name = "labelWhatsapp";
            this.labelWhatsapp.Size = new System.Drawing.Size(62, 15);
            this.labelWhatsapp.TabIndex = 11;
            this.labelWhatsapp.Text = "WhatsApp";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(27, 198);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 15);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(85, 276);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(111, 41);
            this.buttonCadastrar.TabIndex = 13;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 339);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelWhatsapp);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelCnpj);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.maskedTextBoxCnpj);
            this.Controls.Add(this.maskedTextBoxWhatsapp);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Name = "CadastroEmpresa";
            this.Text = "CadastroEmpresa";
            this.Load += new System.EventHandler(this.CadastroEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWhatsapp;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCnpj;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCnpj;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelWhatsapp;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonCadastrar;
    }
}