namespace PesoIdeal
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
            this.Genero = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.MaskedTextBox();
            this.Peso = new System.Windows.Forms.MaskedTextBox();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.Calcular = new System.Windows.Forms.Button();
            this.Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // Genero
            // 
            this.Genero.Controls.Add(this.Feminino);
            this.Genero.Controls.Add(this.Masculino);
            this.Genero.Location = new System.Drawing.Point(205, 41);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(125, 68);
            this.Genero.TabIndex = 3;
            this.Genero.TabStop = false;
            this.Genero.Text = "Gênero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(81, 50);
            this.Altura.Mask = "0.00";
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(100, 20);
            this.Altura.TabIndex = 2;
            this.Altura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Altura_MaskInputRejected);
            // 
            // Peso
            // 
            this.Peso.Location = new System.Drawing.Point(81, 79);
            this.Peso.Mask = "00.00";
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(100, 20);
            this.Peso.TabIndex = 3;
            this.Peso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Peso_MaskInputRejected);
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(20, 19);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(73, 17);
            this.Masculino.TabIndex = 4;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            this.Masculino.CheckedChanged += new System.EventHandler(this.Masculino_CheckedChanged);
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Location = new System.Drawing.Point(20, 42);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(67, 17);
            this.Feminino.TabIndex = 5;
            this.Feminino.TabStop = true;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = true;
            this.Feminino.CheckedChanged += new System.EventHandler(this.Feminino_CheckedChanged);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(95, 125);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 185);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Genero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Genero.ResumeLayout(false);
            this.Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Genero;
        private System.Windows.Forms.RadioButton Feminino;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Altura;
        private System.Windows.Forms.MaskedTextBox Peso;
        private System.Windows.Forms.Button Calcular;
    }
}

