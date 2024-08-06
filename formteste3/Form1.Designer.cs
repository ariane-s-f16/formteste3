namespace formteste3
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
            this.renda = new System.Windows.Forms.Label();
            this.mostrarrenda = new System.Windows.Forms.TextBox();
            this.alimentacao = new System.Windows.Forms.Label();
            this.aparelhoseletronicos = new System.Windows.Forms.Label();
            this.agua = new System.Windows.Forms.Label();
            this.energia = new System.Windows.Forms.Label();
            this.outros = new System.Windows.Forms.Label();
            this.mostraroutros = new System.Windows.Forms.TextBox();
            this.mostraralimentacao = new System.Windows.Forms.TextBox();
            this.mostrargastos = new System.Windows.Forms.TextBox();
            this.mostraragua = new System.Windows.Forms.TextBox();
            this.mostrarenergia = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.saldo = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.mostrartotal = new System.Windows.Forms.TextBox();
            this.mostrarsaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // renda
            // 
            this.renda.Location = new System.Drawing.Point(56, 65);
            this.renda.Name = "renda";
            this.renda.Size = new System.Drawing.Size(82, 30);
            this.renda.TabIndex = 0;
            this.renda.Text = "renda familiar ";
            this.renda.Visible = false;
            // 
            // mostrarrenda
            // 
            this.mostrarrenda.Location = new System.Drawing.Point(144, 62);
            this.mostrarrenda.Name = "mostrarrenda";
            this.mostrarrenda.Size = new System.Drawing.Size(169, 20);
            this.mostrarrenda.TabIndex = 1;
            // 
            // alimentacao
            // 
            this.alimentacao.Location = new System.Drawing.Point(56, 348);
            this.alimentacao.Name = "alimentacao";
            this.alimentacao.Size = new System.Drawing.Size(82, 33);
            this.alimentacao.TabIndex = 2;
            this.alimentacao.Text = "Alimentação";
            this.alimentacao.Visible = false;
            // 
            // aparelhoseletronicos
            // 
            this.aparelhoseletronicos.Location = new System.Drawing.Point(56, 297);
            this.aparelhoseletronicos.Name = "aparelhoseletronicos";
            this.aparelhoseletronicos.Size = new System.Drawing.Size(98, 30);
            this.aparelhoseletronicos.TabIndex = 3;
            this.aparelhoseletronicos.Text = "TV/Fone/internet";
            this.aparelhoseletronicos.Visible = false;
            // 
            // agua
            // 
            this.agua.Location = new System.Drawing.Point(56, 242);
            this.agua.Name = "agua";
            this.agua.Size = new System.Drawing.Size(82, 30);
            this.agua.TabIndex = 4;
            this.agua.Text = "água";
            this.agua.Visible = false;
            // 
            // energia
            // 
            this.energia.Location = new System.Drawing.Point(56, 194);
            this.energia.Name = "energia";
            this.energia.Size = new System.Drawing.Size(82, 30);
            this.energia.TabIndex = 5;
            this.energia.Text = "energia eletrica ";
            this.energia.Visible = false;
            // 
            // outros
            // 
            this.outros.Location = new System.Drawing.Point(56, 397);
            this.outros.Name = "outros";
            this.outros.Size = new System.Drawing.Size(82, 33);
            this.outros.TabIndex = 6;
            this.outros.Text = "Outros gastos";
            this.outros.Visible = false;
            // 
            // mostraroutros
            // 
            this.mostraroutros.Location = new System.Drawing.Point(191, 394);
            this.mostraroutros.Name = "mostraroutros";
            this.mostraroutros.Size = new System.Drawing.Size(169, 20);
            this.mostraroutros.TabIndex = 7;
            // 
            // mostraralimentacao
            // 
            this.mostraralimentacao.Location = new System.Drawing.Point(191, 345);
            this.mostraralimentacao.Name = "mostraralimentacao";
            this.mostraralimentacao.Size = new System.Drawing.Size(169, 20);
            this.mostraralimentacao.TabIndex = 8;
            // 
            // mostrargastos
            // 
            this.mostrargastos.Location = new System.Drawing.Point(191, 294);
            this.mostrargastos.Name = "mostrargastos";
            this.mostrargastos.Size = new System.Drawing.Size(169, 20);
            this.mostrargastos.TabIndex = 9;
            // 
            // mostraragua
            // 
            this.mostraragua.Location = new System.Drawing.Point(191, 239);
            this.mostraragua.Name = "mostraragua";
            this.mostraragua.Size = new System.Drawing.Size(169, 20);
            this.mostraragua.TabIndex = 10;
            // 
            // mostrarenergia
            // 
            this.mostrarenergia.Location = new System.Drawing.Point(191, 191);
            this.mostrarenergia.Name = "mostrarenergia";
            this.mostrarenergia.Size = new System.Drawing.Size(169, 20);
            this.mostrarenergia.TabIndex = 11;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(84, 496);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 12;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(209, 496);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(122, 23);
            this.limpar.TabIndex = 13;
            this.limpar.Text = "Novo calculo";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(373, 496);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 23);
            this.fechar.TabIndex = 14;
            this.fechar.Text = "fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // saldo
            // 
            this.saldo.Location = new System.Drawing.Point(56, 633);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(82, 33);
            this.saldo.TabIndex = 15;
            this.saldo.Text = "Saldo";
            this.saldo.Visible = false;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(56, 581);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(82, 33);
            this.total.TabIndex = 16;
            this.total.Text = "Total";
            this.total.Visible = false;
            // 
            // mostrartotal
            // 
            this.mostrartotal.Location = new System.Drawing.Point(261, 563);
            this.mostrartotal.Name = "mostrartotal";
            this.mostrartotal.Size = new System.Drawing.Size(186, 20);
            this.mostrartotal.TabIndex = 17;
            // 
            // mostrarsaldo
            // 
            this.mostrarsaldo.Location = new System.Drawing.Point(262, 630);
            this.mostrarsaldo.Name = "mostrarsaldo";
            this.mostrarsaldo.Size = new System.Drawing.Size(186, 20);
            this.mostrarsaldo.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 827);
            this.Controls.Add(this.mostrarsaldo);
            this.Controls.Add(this.mostrartotal);
            this.Controls.Add(this.total);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.mostrarenergia);
            this.Controls.Add(this.mostraragua);
            this.Controls.Add(this.mostrargastos);
            this.Controls.Add(this.mostraralimentacao);
            this.Controls.Add(this.mostraroutros);
            this.Controls.Add(this.outros);
            this.Controls.Add(this.energia);
            this.Controls.Add(this.agua);
            this.Controls.Add(this.aparelhoseletronicos);
            this.Controls.Add(this.alimentacao);
            this.Controls.Add(this.mostrarrenda);
            this.Controls.Add(this.renda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label renda;
        private System.Windows.Forms.TextBox mostrarrenda;
        private System.Windows.Forms.Label alimentacao;
        private System.Windows.Forms.Label aparelhoseletronicos;
        private System.Windows.Forms.Label agua;
        private System.Windows.Forms.Label energia;
        private System.Windows.Forms.Label outros;
        private System.Windows.Forms.TextBox mostraroutros;
        private System.Windows.Forms.TextBox mostraralimentacao;
        private System.Windows.Forms.TextBox mostrargastos;
        private System.Windows.Forms.TextBox mostraragua;
        private System.Windows.Forms.TextBox mostrarenergia;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox mostrartotal;
        private System.Windows.Forms.TextBox mostrarsaldo;
    }
}

