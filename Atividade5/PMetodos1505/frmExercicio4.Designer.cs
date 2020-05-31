namespace PMetodos1505
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
            this.btnNumerico = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNumerico
            // 
            this.btnNumerico.Location = new System.Drawing.Point(79, 314);
            this.btnNumerico.Name = "btnNumerico";
            this.btnNumerico.Size = new System.Drawing.Size(114, 60);
            this.btnNumerico.TabIndex = 0;
            this.btnNumerico.Text = "Caracteres numéricos";
            this.btnNumerico.UseVisualStyleBackColor = true;
            this.btnNumerico.Click += new System.EventHandler(this.Numerico_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(244, 314);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(104, 60);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Primeiro Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Location = new System.Drawing.Point(391, 314);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(111, 60);
            this.btnAlfabetico.TabIndex = 2;
            this.btnAlfabetico.Text = "Caracteres Alfabéticos";
            this.btnAlfabetico.UseVisualStyleBackColor = true;
            this.btnAlfabetico.Click += new System.EventHandler(this.btnAlfabetico_Click);
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(79, 52);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(423, 192);
            this.rchtxtTexto.TabIndex = 3;
            this.rchtxtTexto.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchtxtTexto);
            this.Controls.Add(this.btnAlfabetico);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumerico);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumerico;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfabetico;
        private System.Windows.Forms.RichTextBox rchtxtTexto;
    }
}