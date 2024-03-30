namespace CadastroProdutos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMercearia = new System.Windows.Forms.RadioButton();
            this.radioHigiene = new System.Windows.Forms.RadioButton();
            this.radioProdutosLimpeza = new System.Windows.Forms.RadioButton();
            this.radioBebidas = new System.Windows.Forms.RadioButton();
            this.radioAlimentosPereciveis = new System.Windows.Forms.RadioButton();
            this.radioAlimentosNaoPereciveis = new System.Windows.Forms.RadioButton();
            this.txtDataFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.txtDataValidade = new System.Windows.Forms.MaskedTextBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Produto";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(35, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 24);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fonecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de Fabricação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data de Validade";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(538, 309);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(232, 24);
            this.txtFornecedor.TabIndex = 10;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(538, 49);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(111, 24);
            this.txtPeso.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMercearia);
            this.groupBox1.Controls.Add(this.radioHigiene);
            this.groupBox1.Controls.Add(this.radioProdutosLimpeza);
            this.groupBox1.Controls.Add(this.radioBebidas);
            this.groupBox1.Controls.Add(this.radioAlimentosPereciveis);
            this.groupBox1.Controls.Add(this.radioAlimentosNaoPereciveis);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 285);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // radioMercearia
            // 
            this.radioMercearia.AutoSize = true;
            this.radioMercearia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMercearia.Location = new System.Drawing.Point(7, 257);
            this.radioMercearia.Name = "radioMercearia";
            this.radioMercearia.Size = new System.Drawing.Size(180, 22);
            this.radioMercearia.TabIndex = 5;
            this.radioMercearia.TabStop = true;
            this.radioMercearia.Text = "Produtos de mercearia";
            this.radioMercearia.UseVisualStyleBackColor = true;
            // 
            // radioHigiene
            // 
            this.radioHigiene.AutoSize = true;
            this.radioHigiene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHigiene.Location = new System.Drawing.Point(7, 215);
            this.radioHigiene.Name = "radioHigiene";
            this.radioHigiene.Size = new System.Drawing.Size(216, 22);
            this.radioHigiene.TabIndex = 4;
            this.radioHigiene.TabStop = true;
            this.radioHigiene.Text = "Produtos de higiene pessoal";
            this.radioHigiene.UseVisualStyleBackColor = true;
            // 
            // radioProdutosLimpeza
            // 
            this.radioProdutosLimpeza.AutoSize = true;
            this.radioProdutosLimpeza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioProdutosLimpeza.Location = new System.Drawing.Point(7, 173);
            this.radioProdutosLimpeza.Name = "radioProdutosLimpeza";
            this.radioProdutosLimpeza.Size = new System.Drawing.Size(165, 22);
            this.radioProdutosLimpeza.TabIndex = 3;
            this.radioProdutosLimpeza.TabStop = true;
            this.radioProdutosLimpeza.Text = "Produtos de limpeza";
            this.radioProdutosLimpeza.UseVisualStyleBackColor = true;
            // 
            // radioBebidas
            // 
            this.radioBebidas.AutoSize = true;
            this.radioBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBebidas.Location = new System.Drawing.Point(7, 131);
            this.radioBebidas.Name = "radioBebidas";
            this.radioBebidas.Size = new System.Drawing.Size(82, 22);
            this.radioBebidas.TabIndex = 2;
            this.radioBebidas.TabStop = true;
            this.radioBebidas.Text = "Bebidas";
            this.radioBebidas.UseVisualStyleBackColor = true;
            // 
            // radioAlimentosPereciveis
            // 
            this.radioAlimentosPereciveis.AutoSize = true;
            this.radioAlimentosPereciveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAlimentosPereciveis.Location = new System.Drawing.Point(7, 89);
            this.radioAlimentosPereciveis.Name = "radioAlimentosPereciveis";
            this.radioAlimentosPereciveis.Size = new System.Drawing.Size(164, 22);
            this.radioAlimentosPereciveis.TabIndex = 1;
            this.radioAlimentosPereciveis.TabStop = true;
            this.radioAlimentosPereciveis.Text = "Alimentos perecíveis";
            this.radioAlimentosPereciveis.UseVisualStyleBackColor = true;
            // 
            // radioAlimentosNaoPereciveis
            // 
            this.radioAlimentosNaoPereciveis.AutoSize = true;
            this.radioAlimentosNaoPereciveis.Checked = true;
            this.radioAlimentosNaoPereciveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAlimentosNaoPereciveis.Location = new System.Drawing.Point(7, 47);
            this.radioAlimentosNaoPereciveis.Name = "radioAlimentosNaoPereciveis";
            this.radioAlimentosNaoPereciveis.Size = new System.Drawing.Size(193, 22);
            this.radioAlimentosNaoPereciveis.TabIndex = 0;
            this.radioAlimentosNaoPereciveis.TabStop = true;
            this.radioAlimentosNaoPereciveis.Text = "Alimentos não perecíveis";
            this.radioAlimentosNaoPereciveis.UseVisualStyleBackColor = true;
            // 
            // txtDataFabricacao
            // 
            this.txtDataFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFabricacao.Location = new System.Drawing.Point(538, 136);
            this.txtDataFabricacao.Mask = "00/00/0000";
            this.txtDataFabricacao.Name = "txtDataFabricacao";
            this.txtDataFabricacao.Size = new System.Drawing.Size(163, 24);
            this.txtDataFabricacao.TabIndex = 13;
            // 
            // txtDataValidade
            // 
            this.txtDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataValidade.Location = new System.Drawing.Point(538, 225);
            this.txtDataValidade.Mask = "00/00/0000";
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(163, 24);
            this.txtDataValidade.TabIndex = 14;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 18;
            this.lista.Location = new System.Drawing.Point(42, 491);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(728, 184);
            this.lista.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(538, 387);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 44);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 701);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.txtDataValidade);
            this.Controls.Add(this.txtDataFabricacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE PRODUTOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioProdutosLimpeza;
        private System.Windows.Forms.RadioButton radioBebidas;
        private System.Windows.Forms.RadioButton radioAlimentosPereciveis;
        private System.Windows.Forms.RadioButton radioAlimentosNaoPereciveis;
        private System.Windows.Forms.RadioButton radioHigiene;
        private System.Windows.Forms.RadioButton radioMercearia;
        private System.Windows.Forms.MaskedTextBox txtDataFabricacao;
        private System.Windows.Forms.MaskedTextBox txtDataValidade;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

