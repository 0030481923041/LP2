namespace INSS_IRPF
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedNome = new System.Windows.Forms.MaskedTextBox();
            this.maskedSalB = new System.Windows.Forms.MaskedTextBox();
            this.maskedFilho = new System.Windows.Forms.MaskedTextBox();
            this.maskedINSS = new System.Windows.Forms.MaskedTextBox();
            this.maskedIRPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedSalFam = new System.Windows.Forms.MaskedTextBox();
            this.maskedSLiq = new System.Windows.Forms.MaskedTextBox();
            this.maskedDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.maskedDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFem = new System.Windows.Forms.RadioButton();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LblDados = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de filhos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aliquota INSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aliquota IRPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salario Familia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salario Liquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Desconto INSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Desconto IRPF";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Verificar Desconto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedNome
            // 
            this.maskedNome.Location = new System.Drawing.Point(117, 23);
            this.maskedNome.Name = "maskedNome";
            this.maskedNome.Size = new System.Drawing.Size(138, 20);
            this.maskedNome.TabIndex = 11;
            // 
            // maskedSalB
            // 
            this.maskedSalB.Location = new System.Drawing.Point(118, 49);
            this.maskedSalB.Mask = "000000.00";
            this.maskedSalB.Name = "maskedSalB";
            this.maskedSalB.Size = new System.Drawing.Size(61, 20);
            this.maskedSalB.SkipLiterals = false;
            this.maskedSalB.TabIndex = 12;
            this.maskedSalB.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedSalB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedSalB_MaskInputRejected);
            // 
            // maskedFilho
            // 
            this.maskedFilho.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedFilho.Location = new System.Drawing.Point(118, 77);
            this.maskedFilho.Mask = "99";
            this.maskedFilho.Name = "maskedFilho";
            this.maskedFilho.Size = new System.Drawing.Size(21, 20);
            this.maskedFilho.TabIndex = 13;
            // 
            // maskedINSS
            // 
            this.maskedINSS.Enabled = false;
            this.maskedINSS.Location = new System.Drawing.Point(118, 235);
            this.maskedINSS.Name = "maskedINSS";
            this.maskedINSS.Size = new System.Drawing.Size(100, 20);
            this.maskedINSS.TabIndex = 14;
            // 
            // maskedIRPF
            // 
            this.maskedIRPF.Enabled = false;
            this.maskedIRPF.Location = new System.Drawing.Point(118, 263);
            this.maskedIRPF.Name = "maskedIRPF";
            this.maskedIRPF.Size = new System.Drawing.Size(100, 20);
            this.maskedIRPF.TabIndex = 15;
            // 
            // maskedSalFam
            // 
            this.maskedSalFam.Enabled = false;
            this.maskedSalFam.Location = new System.Drawing.Point(118, 293);
            this.maskedSalFam.Name = "maskedSalFam";
            this.maskedSalFam.Size = new System.Drawing.Size(100, 20);
            this.maskedSalFam.TabIndex = 16;
            this.maskedSalFam.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // maskedSLiq
            // 
            this.maskedSLiq.Enabled = false;
            this.maskedSLiq.Location = new System.Drawing.Point(118, 319);
            this.maskedSLiq.Name = "maskedSLiq";
            this.maskedSLiq.Size = new System.Drawing.Size(100, 20);
            this.maskedSLiq.TabIndex = 17;
            this.maskedSLiq.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedSLiq_MaskInputRejected);
            // 
            // maskedDescINSS
            // 
            this.maskedDescINSS.Enabled = false;
            this.maskedDescINSS.Location = new System.Drawing.Point(326, 235);
            this.maskedDescINSS.Name = "maskedDescINSS";
            this.maskedDescINSS.Size = new System.Drawing.Size(100, 20);
            this.maskedDescINSS.TabIndex = 18;
            // 
            // maskedDescIRPF
            // 
            this.maskedDescIRPF.Enabled = false;
            this.maskedDescIRPF.Location = new System.Drawing.Point(326, 263);
            this.maskedDescIRPF.Name = "maskedDescIRPF";
            this.maskedDescIRPF.Size = new System.Drawing.Size(100, 20);
            this.maskedDescIRPF.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFem);
            this.groupBox1.Controls.Add(this.radioMasc);
            this.groupBox1.Location = new System.Drawing.Point(319, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 67);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioFem
            // 
            this.radioFem.AutoSize = true;
            this.radioFem.Checked = true;
            this.radioFem.Location = new System.Drawing.Point(7, 19);
            this.radioFem.Name = "radioFem";
            this.radioFem.Size = new System.Drawing.Size(67, 17);
            this.radioFem.TabIndex = 1;
            this.radioFem.TabStop = true;
            this.radioFem.Text = "Feminino";
            this.radioFem.UseVisualStyleBackColor = true;
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Location = new System.Drawing.Point(7, 42);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(73, 17);
            this.radioMasc.TabIndex = 0;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(319, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 51);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Casado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LblDados
            // 
            this.LblDados.Location = new System.Drawing.Point(24, 151);
            this.LblDados.Name = "LblDados";
            this.LblDados.Size = new System.Drawing.Size(231, 63);
            this.LblDados.TabIndex = 23;
            this.LblDados.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblDados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedDescIRPF);
            this.Controls.Add(this.maskedDescINSS);
            this.Controls.Add(this.maskedSLiq);
            this.Controls.Add(this.maskedSalFam);
            this.Controls.Add(this.maskedIRPF);
            this.Controls.Add(this.maskedINSS);
            this.Controls.Add(this.maskedFilho);
            this.Controls.Add(this.maskedSalB);
            this.Controls.Add(this.maskedNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedNome;
        private System.Windows.Forms.MaskedTextBox maskedSalB;
        private System.Windows.Forms.MaskedTextBox maskedFilho;
        private System.Windows.Forms.MaskedTextBox maskedINSS;
        private System.Windows.Forms.MaskedTextBox maskedIRPF;
        private System.Windows.Forms.MaskedTextBox maskedSalFam;
        private System.Windows.Forms.MaskedTextBox maskedSLiq;
        private System.Windows.Forms.MaskedTextBox maskedDescINSS;
        private System.Windows.Forms.MaskedTextBox maskedDescIRPF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFem;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox LblDados;
        private System.Windows.Forms.Button button2;
    }
}

