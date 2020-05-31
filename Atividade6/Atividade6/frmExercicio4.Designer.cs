namespace Atividade6
{
    partial class frmExercicio4
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtGratific = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(107, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(125, 347);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 34);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular salário bruto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(107, 84);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(172, 20);
            this.txtCargo.TabIndex = 2;
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(107, 141);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(172, 20);
            this.txtInscricao.TabIndex = 3;
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(107, 193);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(172, 20);
            this.txtProducao.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(107, 293);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(172, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // txtGratific
            // 
            this.txtGratific.Location = new System.Drawing.Point(107, 244);
            this.txtGratific.Name = "txtGratific";
            this.txtGratific.Size = new System.Drawing.Size(172, 20);
            this.txtGratific.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nº  inscrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Produção";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salário bruto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gratificação";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGratific);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNome);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtGratific;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}