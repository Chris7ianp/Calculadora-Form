namespace Calculadora
{
    partial class frmTelaPrincipal
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btmMultiplicar = new System.Windows.Forms.Button();
            this.btmSubtrair = new System.Windows.Forms.Button();
            this.btmSomar = new System.Windows.Forms.Button();
            this.btmDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(23, 121);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(164, 24);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Digite o numero 1:";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(23, 197);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(164, 24);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Digite o numero 2:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(189, 300);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(88, 24);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Resposta";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(294, 300);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 24);
            this.lblResposta.TabIndex = 3;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(193, 121);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 29);
            this.txtNumero1.TabIndex = 4;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(193, 194);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 29);
            this.txtNumero2.TabIndex = 5;
            // 
            // btmMultiplicar
            // 
            this.btmMultiplicar.Location = new System.Drawing.Point(425, 198);
            this.btmMultiplicar.Name = "btmMultiplicar";
            this.btmMultiplicar.Size = new System.Drawing.Size(75, 35);
            this.btmMultiplicar.TabIndex = 6;
            this.btmMultiplicar.Text = "*";
            this.btmMultiplicar.UseVisualStyleBackColor = true;
            this.btmMultiplicar.Click += new System.EventHandler(this.btmMultiplicar_Click);
            // 
            // btmSubtrair
            // 
            this.btmSubtrair.Location = new System.Drawing.Point(425, 121);
            this.btmSubtrair.Name = "btmSubtrair";
            this.btmSubtrair.Size = new System.Drawing.Size(75, 43);
            this.btmSubtrair.TabIndex = 7;
            this.btmSubtrair.Text = "-";
            this.btmSubtrair.UseVisualStyleBackColor = true;
            this.btmSubtrair.Click += new System.EventHandler(this.btmSubtrair_Click);
            // 
            // btmSomar
            // 
            this.btmSomar.Location = new System.Drawing.Point(314, 121);
            this.btmSomar.Name = "btmSomar";
            this.btmSomar.Size = new System.Drawing.Size(75, 43);
            this.btmSomar.TabIndex = 8;
            this.btmSomar.Text = "+";
            this.btmSomar.UseVisualStyleBackColor = true;
            this.btmSomar.Click += new System.EventHandler(this.btmSomar_Click);
            // 
            // btmDividir
            // 
            this.btmDividir.Location = new System.Drawing.Point(314, 197);
            this.btmDividir.Name = "btmDividir";
            this.btmDividir.Size = new System.Drawing.Size(75, 36);
            this.btmDividir.TabIndex = 9;
            this.btmDividir.Text = "/";
            this.btmDividir.UseVisualStyleBackColor = true;
            this.btmDividir.Click += new System.EventHandler(this.btmDividir_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(543, 403);
            this.Controls.Add(this.btmDividir);
            this.Controls.Add(this.btmSomar);
            this.Controls.Add(this.btmSubtrair);
            this.Controls.Add(this.btmMultiplicar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmTelaPrincipal";
            this.Text = "Exemplo 03 - Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btmMultiplicar;
        private System.Windows.Forms.Button btmSubtrair;
        private System.Windows.Forms.Button btmSomar;
        private System.Windows.Forms.Button btmDividir;
    }
}

