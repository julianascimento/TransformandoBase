namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.opcDecimal = new System.Windows.Forms.RadioButton();
            this.opcOctal = new System.Windows.Forms.RadioButton();
            this.opcHexa = new System.Windows.Forms.RadioButton();
            this.opcBinario = new System.Windows.Forms.RadioButton();
            this.caixaValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insira o valor: ";
            // 
            // opcDecimal
            // 
            this.opcDecimal.AutoSize = true;
            this.opcDecimal.Location = new System.Drawing.Point(175, 115);
            this.opcDecimal.Name = "opcDecimal";
            this.opcDecimal.Size = new System.Drawing.Size(63, 17);
            this.opcDecimal.TabIndex = 5;
            this.opcDecimal.TabStop = true;
            this.opcDecimal.Text = "Decimal";
            this.opcDecimal.UseVisualStyleBackColor = true;
            this.opcDecimal.CheckedChanged += new System.EventHandler(this.opcDecimal_CheckedChanged);
            // 
            // opcOctal
            // 
            this.opcOctal.AutoSize = true;
            this.opcOctal.Location = new System.Drawing.Point(175, 184);
            this.opcOctal.Name = "opcOctal";
            this.opcOctal.Size = new System.Drawing.Size(50, 17);
            this.opcOctal.TabIndex = 6;
            this.opcOctal.TabStop = true;
            this.opcOctal.Text = "Octal";
            this.opcOctal.UseVisualStyleBackColor = true;
            this.opcOctal.CheckedChanged += new System.EventHandler(this.opcOctal_CheckedChanged);
            // 
            // opcHexa
            // 
            this.opcHexa.AutoSize = true;
            this.opcHexa.Location = new System.Drawing.Point(175, 161);
            this.opcHexa.Name = "opcHexa";
            this.opcHexa.Size = new System.Drawing.Size(86, 17);
            this.opcHexa.TabIndex = 7;
            this.opcHexa.TabStop = true;
            this.opcHexa.Text = "Hexadecimal";
            this.opcHexa.UseVisualStyleBackColor = true;
            this.opcHexa.CheckedChanged += new System.EventHandler(this.opcHexa_CheckedChanged);
            // 
            // opcBinario
            // 
            this.opcBinario.AutoSize = true;
            this.opcBinario.Location = new System.Drawing.Point(175, 138);
            this.opcBinario.Name = "opcBinario";
            this.opcBinario.Size = new System.Drawing.Size(57, 17);
            this.opcBinario.TabIndex = 8;
            this.opcBinario.TabStop = true;
            this.opcBinario.Text = "Binário";
            this.opcBinario.UseVisualStyleBackColor = true;
            this.opcBinario.CheckedChanged += new System.EventHandler(this.opcBinario_CheckedChanged);
            // 
            // caixaValor
            // 
            this.caixaValor.Location = new System.Drawing.Point(121, 45);
            this.caixaValor.Name = "caixaValor";
            this.caixaValor.Size = new System.Drawing.Size(140, 20);
            this.caixaValor.TabIndex = 9;
            this.caixaValor.TextChanged += new System.EventHandler(this.caixaValor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleciona o tipo de base:";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(109, 226);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 11;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caixaValor);
            this.Controls.Add(this.opcBinario);
            this.Controls.Add(this.opcHexa);
            this.Controls.Add(this.opcOctal);
            this.Controls.Add(this.opcDecimal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Transformando Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton opcDecimal;
        private System.Windows.Forms.RadioButton opcOctal;
        private System.Windows.Forms.RadioButton opcHexa;
        private System.Windows.Forms.RadioButton opcBinario;
        private System.Windows.Forms.TextBox caixaValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProximo;
    }
}

