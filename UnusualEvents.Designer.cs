
namespace UnusualEvents
{
    partial class UnusualEvents
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
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCadastrarEmpresa = new System.Windows.Forms.Button();
            this.buttonCadastrarEvento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(12, 34);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.PlaceholderText = "Qual evento você procura?";
            this.textBoxPesquisar.Size = new System.Drawing.Size(248, 23);
            this.textBoxPesquisar.TabIndex = 0;
            this.textBoxPesquisar.TabStop = false;
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(12, 13);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(57, 15);
            this.labelPesquisa.TabIndex = 2;
            this.labelPesquisa.Text = "Pesquisar";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(266, 13);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(58, 15);
            this.labelCategoria.TabIndex = 3;
            this.labelCategoria.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(266, 34);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(175, 23);
            this.comboBoxCategoria.TabIndex = 4;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(447, 33);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(82, 23);
            this.buttonPesquisar.TabIndex = 5;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.ButtonPesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Local,
            this.Data});
            this.dataGridView1.Location = new System.Drawing.Point(9, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(518, 340);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Local
            // 
            this.Local.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // buttonCadastrarEmpresa
            // 
            this.buttonCadastrarEmpresa.Location = new System.Drawing.Point(203, 415);
            this.buttonCadastrarEmpresa.Name = "buttonCadastrarEmpresa";
            this.buttonCadastrarEmpresa.Size = new System.Drawing.Size(159, 23);
            this.buttonCadastrarEmpresa.TabIndex = 7;
            this.buttonCadastrarEmpresa.Text = "Cadastrar Empresa";
            this.buttonCadastrarEmpresa.UseVisualStyleBackColor = true;
            this.buttonCadastrarEmpresa.Click += new System.EventHandler(this.buttonCadastrarEmpresa_Click);
            // 
            // buttonCadastrarEvento
            // 
            this.buttonCadastrarEvento.Location = new System.Drawing.Point(368, 415);
            this.buttonCadastrarEvento.Name = "buttonCadastrarEvento";
            this.buttonCadastrarEvento.Size = new System.Drawing.Size(159, 23);
            this.buttonCadastrarEvento.TabIndex = 8;
            this.buttonCadastrarEvento.Text = "Cadastrar Evento";
            this.buttonCadastrarEvento.UseVisualStyleBackColor = true;
            this.buttonCadastrarEvento.Click += new System.EventHandler(this.buttonCadastrarEvento_Click);
            // 
            // UnusualEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.buttonCadastrarEvento);
            this.Controls.Add(this.buttonCadastrarEmpresa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelPesquisa);
            this.Controls.Add(this.textBoxPesquisar);
            this.Name = "UnusualEvents";
            this.Text = "Unusual Events";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Button buttonCadastrarEmpresa;
        private System.Windows.Forms.Button buttonCadastrarEvento;
    }
}

