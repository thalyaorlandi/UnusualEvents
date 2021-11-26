
namespace UnusualEvents
{
    partial class DetalhesEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesEvento));
            this.labelNomeEvento = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelDataHora = new System.Windows.Forms.Label();
            this.labelRequisitos = new System.Windows.Forms.Label();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.buttonIncrever = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeEvento
            // 
            this.labelNomeEvento.AutoSize = true;
            this.labelNomeEvento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomeEvento.Location = new System.Drawing.Point(22, 9);
            this.labelNomeEvento.Name = "labelNomeEvento";
            this.labelNomeEvento.Size = new System.Drawing.Size(138, 21);
            this.labelNomeEvento.TabIndex = 0;
            this.labelNomeEvento.Text = "Nome do Evento";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(22, 47);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(64, 15);
            this.labelCategoria.TabIndex = 1;
            this.labelCategoria.Text = "Categoria: ";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(22, 72);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(62, 15);
            this.labelEndereco.TabIndex = 2;
            this.labelEndereco.Text = "Endereco: ";
            // 
            // labelDataHora
            // 
            this.labelDataHora.AutoSize = true;
            this.labelDataHora.Location = new System.Drawing.Point(22, 98);
            this.labelDataHora.Name = "labelDataHora";
            this.labelDataHora.Size = new System.Drawing.Size(68, 15);
            this.labelDataHora.TabIndex = 3;
            this.labelDataHora.Text = "Date/Hora: ";
            // 
            // labelRequisitos
            // 
            this.labelRequisitos.AutoSize = true;
            this.labelRequisitos.Location = new System.Drawing.Point(22, 154);
            this.labelRequisitos.Name = "labelRequisitos";
            this.labelRequisitos.Size = new System.Drawing.Size(67, 15);
            this.labelRequisitos.TabIndex = 5;
            this.labelRequisitos.Text = "Requisitos: ";
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(22, 218);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.ReadOnly = true;
            this.richTextBoxDescricao.Size = new System.Drawing.Size(535, 119);
            this.richTextBoxDescricao.TabIndex = 6;
            this.richTextBoxDescricao.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(361, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 114);
            this.panel1.TabIndex = 7;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(22, 188);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(73, 15);
            this.labelDescricao.TabIndex = 8;
            this.labelDescricao.Text = "Descricação:";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(22, 126);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(43, 15);
            this.labelPreco.TabIndex = 9;
            this.labelPreco.Text = "Preco: ";
            // 
            // buttonIncrever
            // 
            this.buttonIncrever.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonIncrever.Location = new System.Drawing.Point(169, 343);
            this.buttonIncrever.Name = "buttonIncrever";
            this.buttonIncrever.Size = new System.Drawing.Size(211, 32);
            this.buttonIncrever.TabIndex = 10;
            this.buttonIncrever.Text = "Inscrever-se";
            this.buttonIncrever.UseVisualStyleBackColor = false;
            this.buttonIncrever.Click += new System.EventHandler(this.buttonIncrever_Click);
            // 
            // DetalhesEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 377);
            this.Controls.Add(this.buttonIncrever);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.labelRequisitos);
            this.Controls.Add(this.labelDataHora);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelNomeEvento);
            this.Name = "DetalhesEvento";
            this.Text = "DetalhesEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeEvento;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelDataHora;
        private System.Windows.Forms.Label labelRequisitos;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Button buttonIncrever;
    }
}