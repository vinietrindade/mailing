namespace WindowsFormsApp1
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinarario = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 42);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(131, 50);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAnexar
            // 
            this.btnAnexar.Location = new System.Drawing.Point(12, 125);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(131, 53);
            this.btnAnexar.TabIndex = 1;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = true;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para :";
            // 
            // txtDestinarario
            // 
            this.txtDestinarario.Location = new System.Drawing.Point(238, 39);
            this.txtDestinarario.Name = "txtDestinarario";
            this.txtDestinarario.Size = new System.Drawing.Size(187, 20);
            this.txtDestinarario.TabIndex = 3;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(238, 65);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(187, 20);
            this.txtAssunto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assunto :";
            // 
            // txtAnexo
            // 
            this.txtAnexo.Location = new System.Drawing.Point(238, 142);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(187, 20);
            this.txtAnexo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Anexo :";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 246);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(413, 108);
            this.txtMensagem.TabIndex = 8;
            this.txtMensagem.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mensagem :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 388);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtAnexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestinarario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnexar);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinarario;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtMensagem;
        private System.Windows.Forms.Label label4;
    }
}

