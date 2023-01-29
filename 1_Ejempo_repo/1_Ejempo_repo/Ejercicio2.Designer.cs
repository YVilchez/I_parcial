
namespace _1_Ejempo_repo
{
    partial class Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.N1_tb = new System.Windows.Forms.TextBox();
            this.N2_tb2 = new System.Windows.Forms.TextBox();
            this.Operaciones_cb = new System.Windows.Forms.ComboBox();
            this.Ejecutar_B = new System.Windows.Forms.Button();
            this.Resultado_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero_1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero_2";
            // 
            // N1_tb
            // 
            this.N1_tb.Location = new System.Drawing.Point(191, 63);
            this.N1_tb.Name = "N1_tb";
            this.N1_tb.Size = new System.Drawing.Size(198, 29);
            this.N1_tb.TabIndex = 2;
            // 
            // N2_tb2
            // 
            this.N2_tb2.Location = new System.Drawing.Point(191, 130);
            this.N2_tb2.Name = "N2_tb2";
            this.N2_tb2.Size = new System.Drawing.Size(198, 29);
            this.N2_tb2.TabIndex = 3;
            // 
            // Operaciones_cb
            // 
            this.Operaciones_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operaciones_cb.FormattingEnabled = true;
            this.Operaciones_cb.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.Operaciones_cb.Location = new System.Drawing.Point(191, 200);
            this.Operaciones_cb.Name = "Operaciones_cb";
            this.Operaciones_cb.Size = new System.Drawing.Size(198, 32);
            this.Operaciones_cb.TabIndex = 4;
            // 
            // Ejecutar_B
            // 
            this.Ejecutar_B.Location = new System.Drawing.Point(243, 266);
            this.Ejecutar_B.Name = "Ejecutar_B";
            this.Ejecutar_B.Size = new System.Drawing.Size(106, 34);
            this.Ejecutar_B.TabIndex = 5;
            this.Ejecutar_B.Text = "Ejecutar";
            this.Ejecutar_B.UseVisualStyleBackColor = true;
            this.Ejecutar_B.Click += new System.EventHandler(this.Ejecutar_B_Click);
            // 
            // Resultado_lb
            // 
            this.Resultado_lb.AutoSize = true;
            this.Resultado_lb.Location = new System.Drawing.Point(263, 328);
            this.Resultado_lb.Name = "Resultado_lb";
            this.Resultado_lb.Size = new System.Drawing.Size(60, 24);
            this.Resultado_lb.TabIndex = 6;
            this.Resultado_lb.Text = "label3";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Resultado_lb);
            this.Controls.Add(this.Ejecutar_B);
            this.Controls.Add(this.Operaciones_cb);
            this.Controls.Add(this.N2_tb2);
            this.Controls.Add(this.N1_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox N1_tb;
        private System.Windows.Forms.TextBox N2_tb2;
        private System.Windows.Forms.ComboBox Operaciones_cb;
        private System.Windows.Forms.Button Ejecutar_B;
        private System.Windows.Forms.Label Resultado_lb;
    }
}