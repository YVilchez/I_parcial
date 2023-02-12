
namespace _1_Ejempo_repo
{
    partial class Ejercicio4
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
            this.Fechac = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dia = new System.Windows.Forms.TextBox();
            this.Semana = new System.Windows.Forms.TextBox();
            this.mes = new System.Windows.Forms.TextBox();
            this.anio = new System.Windows.Forms.TextBox();
            this.Ejecutar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Cita = new System.Windows.Forms.TextBox();
            this.Cita2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Fechac
            // 
            this.Fechac.Location = new System.Drawing.Point(12, 12);
            this.Fechac.Name = "Fechac";
            this.Fechac.Size = new System.Drawing.Size(200, 20);
            this.Fechac.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Anio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dia
            // 
            this.dia.Location = new System.Drawing.Point(64, 56);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(100, 20);
            this.dia.TabIndex = 5;
            // 
            // Semana
            // 
            this.Semana.Location = new System.Drawing.Point(64, 102);
            this.Semana.Name = "Semana";
            this.Semana.Size = new System.Drawing.Size(100, 20);
            this.Semana.TabIndex = 6;
            // 
            // mes
            // 
            this.mes.Location = new System.Drawing.Point(64, 149);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(100, 20);
            this.mes.TabIndex = 7;
            // 
            // anio
            // 
            this.anio.Location = new System.Drawing.Point(64, 197);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(100, 20);
            this.anio.TabIndex = 8;
            // 
            // Ejecutar
            // 
            this.Ejecutar.Location = new System.Drawing.Point(235, 9);
            this.Ejecutar.Name = "Ejecutar";
            this.Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.Ejecutar.TabIndex = 9;
            this.Ejecutar.Text = "Ejecutar";
            this.Ejecutar.UseVisualStyleBackColor = true;
            this.Ejecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cita";
            // 
            // Cita
            // 
            this.Cita.Location = new System.Drawing.Point(64, 248);
            this.Cita.Name = "Cita";
            this.Cita.Size = new System.Drawing.Size(100, 20);
            this.Cita.TabIndex = 11;
            // 
            // Cita2
            // 
            this.Cita2.Location = new System.Drawing.Point(210, 248);
            this.Cita2.Name = "Cita2";
            this.Cita2.Size = new System.Drawing.Size(100, 20);
            this.Cita2.TabIndex = 12;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 283);
            this.Controls.Add(this.Cita2);
            this.Controls.Add(this.Cita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ejecutar);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.Semana);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fechac);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Fechac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dia;
        private System.Windows.Forms.TextBox Semana;
        private System.Windows.Forms.TextBox mes;
        private System.Windows.Forms.TextBox anio;
        private System.Windows.Forms.Button Ejecutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cita;
        private System.Windows.Forms.TextBox Cita2;
    }
}