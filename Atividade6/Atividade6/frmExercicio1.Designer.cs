namespace Atividade6
{
    partial class frmExercicio1
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
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnRepetR = new System.Windows.Forms.Button();
            this.btnRepetPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTexto
            // 
            this.rchTexto.Location = new System.Drawing.Point(90, 35);
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(468, 136);
            this.rchTexto.TabIndex = 0;
            this.rchTexto.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(90, 252);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(130, 23);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Espaços em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnRepetR
            // 
            this.btnRepetR.Location = new System.Drawing.Point(250, 252);
            this.btnRepetR.Name = "btnRepetR";
            this.btnRepetR.Size = new System.Drawing.Size(120, 23);
            this.btnRepetR.TabIndex = 2;
            this.btnRepetR.Text = "Repetição de \"R\"";
            this.btnRepetR.UseVisualStyleBackColor = true;
            this.btnRepetR.Click += new System.EventHandler(this.btnRepetR_Click);
            // 
            // btnRepetPar
            // 
            this.btnRepetPar.Location = new System.Drawing.Point(418, 252);
            this.btnRepetPar.Name = "btnRepetPar";
            this.btnRepetPar.Size = new System.Drawing.Size(140, 23);
            this.btnRepetPar.TabIndex = 3;
            this.btnRepetPar.Text = "Repetição de par de letras";
            this.btnRepetPar.UseVisualStyleBackColor = true;
            this.btnRepetPar.Click += new System.EventHandler(this.btnRepetPar_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRepetPar);
            this.Controls.Add(this.btnRepetR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rchTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTexto;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnRepetR;
        private System.Windows.Forms.Button btnRepetPar;
    }
}