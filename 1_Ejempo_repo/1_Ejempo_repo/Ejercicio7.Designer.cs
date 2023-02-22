
namespace _1_Ejempo_repo
{
    partial class Ejercicio7
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_matriz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_fila = new System.Windows.Forms.TextBox();
            this.tb_columna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 18);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 444);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bt_matriz
            // 
            this.bt_matriz.Location = new System.Drawing.Point(379, 161);
            this.bt_matriz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_matriz.Name = "bt_matriz";
            this.bt_matriz.Size = new System.Drawing.Size(148, 58);
            this.bt_matriz.TabIndex = 1;
            this.bt_matriz.Text = "Mostrar Matriz";
            this.bt_matriz.UseVisualStyleBackColor = true;
            this.bt_matriz.Click += new System.EventHandler(this.bt_matriz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tama_matriz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(404, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // tb_fila
            // 
            this.tb_fila.Location = new System.Drawing.Point(404, 18);
            this.tb_fila.Name = "tb_fila";
            this.tb_fila.Size = new System.Drawing.Size(100, 26);
            this.tb_fila.TabIndex = 4;
            // 
            // tb_columna
            // 
            this.tb_columna.Location = new System.Drawing.Point(404, 94);
            this.tb_columna.Name = "tb_columna";
            this.tb_columna.Size = new System.Drawing.Size(100, 26);
            this.tb_columna.TabIndex = 5;
            // 
            // Ejercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 475);
            this.Controls.Add(this.tb_columna);
            this.Controls.Add(this.tb_fila);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_matriz);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio7";
            this.Text = "Ejercicio7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_matriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_fila;
        private System.Windows.Forms.TextBox tb_columna;
    }
}