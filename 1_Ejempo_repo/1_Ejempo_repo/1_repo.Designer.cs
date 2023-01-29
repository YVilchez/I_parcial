
namespace _1_Ejempo_repo
{
    partial class valo2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.rsuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(183, 62);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(124, 20);
            this.valor1.TabIndex = 2;
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(183, 133);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(124, 20);
            this.valor2.TabIndex = 3;
            // 
            // rsuma
            // 
            this.rsuma.Location = new System.Drawing.Point(208, 198);
            this.rsuma.Name = "rsuma";
            this.rsuma.Size = new System.Drawing.Size(75, 23);
            this.rsuma.TabIndex = 4;
            this.rsuma.Text = "suma";
            this.rsuma.UseVisualStyleBackColor = true;
            this.rsuma.Click += new System.EventHandler(this.rsuma_Click);
            // 
            // valo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rsuma);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "valo2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.Button rsuma;
    }
}

