namespace desafio_aula_003_2_dataGrid_alunos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.TextBox();
            this.serie = new System.Windows.Forms.TextBox();
            this.nota = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cabecalhoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabecalhoIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabecalhoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabecalhoNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.Label();
            this.textbox_idade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cabecalhoNome,
            this.cabecalhoIdade,
            this.cabecalhoSerie,
            this.cabecalhoNota});
            this.dataGridView1.Location = new System.Drawing.Point(136, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(13, 49);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 22);
            this.nome.TabIndex = 1;
            // 
            // serie
            // 
            this.serie.Location = new System.Drawing.Point(13, 150);
            this.serie.Name = "serie";
            this.serie.Size = new System.Drawing.Size(100, 22);
            this.serie.TabIndex = 2;
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(13, 206);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(100, 22);
            this.nota.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 243);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 45);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota";
            // 
            // cabecalhoNome
            // 
            this.cabecalhoNome.HeaderText = "Nome";
            this.cabecalhoNome.MinimumWidth = 6;
            this.cabecalhoNome.Name = "cabecalhoNome";
            this.cabecalhoNome.Width = 125;
            // 
            // cabecalhoIdade
            // 
            this.cabecalhoIdade.HeaderText = "Idade";
            this.cabecalhoIdade.MinimumWidth = 6;
            this.cabecalhoIdade.Name = "cabecalhoIdade";
            this.cabecalhoIdade.Width = 125;
            // 
            // cabecalhoSerie
            // 
            this.cabecalhoSerie.HeaderText = "Serie";
            this.cabecalhoSerie.MinimumWidth = 6;
            this.cabecalhoSerie.Name = "cabecalhoSerie";
            this.cabecalhoSerie.Width = 125;
            // 
            // cabecalhoNota
            // 
            this.cabecalhoNota.HeaderText = "Nota";
            this.cabecalhoNota.MinimumWidth = 6;
            this.cabecalhoNota.Name = "cabecalhoNota";
            this.cabecalhoNota.Width = 125;
            // 
            // idade
            // 
            this.idade.AutoSize = true;
            this.idade.Location = new System.Drawing.Point(13, 78);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(43, 17);
            this.idade.TabIndex = 9;
            this.idade.Text = "idade";
            // 
            // textbox_idade
            // 
            this.textbox_idade.Location = new System.Drawing.Point(13, 98);
            this.textbox_idade.Name = "textbox_idade";
            this.textbox_idade.Size = new System.Drawing.Size(100, 22);
            this.textbox_idade.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 336);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.textbox_idade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.serie);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Boletim Escolar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox serie;
        private System.Windows.Forms.TextBox nota;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabecalhoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabecalhoIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabecalhoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabecalhoNota;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.TextBox textbox_idade;
    }
}

