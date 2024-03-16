namespace PIMC
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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalculoIMC = new System.Windows.Forms.Button();
            this.txtResultIMC = new System.Windows.Forms.TextBox();
            this.lblResutIMC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(226, 89);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(122, 26);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.Validated += new System.EventHandler(this.txtPeso_Validated);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(226, 166);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(122, 26);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.Validated += new System.EventHandler(this.txtAltura_Validated);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(110, 89);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(76, 20);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso (kg)";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(110, 166);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(78, 20);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura (m)";
            // 
            // btnCalculoIMC
            // 
            this.btnCalculoIMC.Location = new System.Drawing.Point(218, 307);
            this.btnCalculoIMC.Name = "btnCalculoIMC";
            this.btnCalculoIMC.Size = new System.Drawing.Size(130, 67);
            this.btnCalculoIMC.TabIndex = 4;
            this.btnCalculoIMC.Text = "Calcular IMC";
            this.btnCalculoIMC.UseVisualStyleBackColor = true;
            this.btnCalculoIMC.Click += new System.EventHandler(this.btnCalculoIMC_Click);
            // 
            // txtResultIMC
            // 
            this.txtResultIMC.Enabled = false;
            this.txtResultIMC.Location = new System.Drawing.Point(226, 229);
            this.txtResultIMC.Name = "txtResultIMC";
            this.txtResultIMC.Size = new System.Drawing.Size(122, 26);
            this.txtResultIMC.TabIndex = 5;
            // 
            // lblResutIMC
            // 
            this.lblResutIMC.AutoSize = true;
            this.lblResutIMC.Location = new System.Drawing.Point(110, 229);
            this.lblResutIMC.Name = "lblResutIMC";
            this.lblResutIMC.Size = new System.Drawing.Size(38, 20);
            this.lblResutIMC.TabIndex = 6;
            this.lblResutIMC.Text = "IMC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 420);
            this.Controls.Add(this.lblResutIMC);
            this.Controls.Add(this.txtResultIMC);
            this.Controls.Add(this.btnCalculoIMC);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnCalculoIMC;
        private System.Windows.Forms.TextBox txtResultIMC;
        private System.Windows.Forms.Label lblResutIMC;
    }
}

