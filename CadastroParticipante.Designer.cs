
namespace UnusualEvents
{
    partial class CadastroParticipante
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelRg = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.maskedTextBoxWhatsApp = new System.Windows.Forms.MaskedTextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(26, 29);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(96, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome Completo";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(26, 83);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(28, 15);
            this.labelCpf.TabIndex = 1;
            this.labelCpf.Text = "CPF";
            // 
            // labelRg
            // 
            this.labelRg.AutoSize = true;
            this.labelRg.Location = new System.Drawing.Point(26, 142);
            this.labelRg.Name = "labelRg";
            this.labelRg.Size = new System.Drawing.Size(22, 15);
            this.labelRg.TabIndex = 2;
            this.labelRg.Text = "RG";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(26, 201);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(36, 15);
            this.labelIdade.TabIndex = 3;
            this.labelIdade.Text = "Idade";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Location = new System.Drawing.Point(124, 201);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(44, 15);
            this.labelCelular.TabIndex = 4;
            this.labelCelular.Text = "Celular";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(26, 48);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(201, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(26, 101);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(201, 23);
            this.maskedTextBoxCpf.TabIndex = 6;
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Location = new System.Drawing.Point(26, 161);
            this.maskedTextBoxRg.Mask = "0.000.000";
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(201, 23);
            this.maskedTextBoxRg.TabIndex = 7;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(26, 220);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(77, 23);
            this.textBoxIdade.TabIndex = 8;
            // 
            // maskedTextBoxWhatsApp
            // 
            this.maskedTextBoxWhatsApp.Location = new System.Drawing.Point(124, 220);
            this.maskedTextBoxWhatsApp.Mask = "(00)0 0000-0000";
            this.maskedTextBoxWhatsApp.Name = "maskedTextBoxWhatsApp";
            this.maskedTextBoxWhatsApp.Size = new System.Drawing.Size(103, 23);
            this.maskedTextBoxWhatsApp.TabIndex = 9;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(59, 282);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(139, 37);
            this.buttonCadastrar.TabIndex = 10;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // CadastroParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 331);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.maskedTextBoxWhatsApp);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.maskedTextBoxRg);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelCelular);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelRg);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelNome);
            this.Name = "CadastroParticipante";
            this.Text = "Cadastro Participante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelRg;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRg;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWhatsApp;
        private System.Windows.Forms.Button buttonCadastrar;
    }
}