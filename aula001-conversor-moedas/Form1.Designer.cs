namespace aula001_conversor_moedas
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
            this.btn_dolar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_real = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_dolar
            // 
            this.btn_dolar.Location = new System.Drawing.Point(94, 193);
            this.btn_dolar.Name = "btn_dolar";
            this.btn_dolar.Size = new System.Drawing.Size(162, 50);
            this.btn_dolar.TabIndex = 0;
            this.btn_dolar.Text = "Converter para Dólar";
            this.btn_dolar.UseVisualStyleBackColor = true;
            this.btn_dolar.Click += new System.EventHandler(this.btn_dolar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor a ser convertido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taxa de câmbio:";
            // 
            // btn_real
            // 
            this.btn_real.Location = new System.Drawing.Point(94, 249);
            this.btn_real.Name = "btn_real";
            this.btn_real.Size = new System.Drawing.Size(162, 45);
            this.btn_real.TabIndex = 3;
            this.btn_real.Text = "Converter para Real";
            this.btn_real.UseVisualStyleBackColor = true;
            this.btn_real.Click += new System.EventHandler(this.btn_real_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(191, 77);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(87, 22);
            this.txt_valor.TabIndex = 4;
            this.txt_valor.TextChanged += new System.EventHandler(this.valor_real_TextChanged);
            // 
            // txt_cambio
            // 
            this.txt_cambio.Location = new System.Drawing.Point(154, 114);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.Size = new System.Drawing.Size(96, 22);
            this.txt_cambio.TabIndex = 5;
            // 
            // txt_res
            // 
            this.txt_res.Enabled = false;
            this.txt_res.Location = new System.Drawing.Point(94, 329);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(162, 22);
            this.txt_res.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "CONVERSOR DE MOEDAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 417);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_real);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dolar);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_real;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_cambio;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Label label3;
    }
}

