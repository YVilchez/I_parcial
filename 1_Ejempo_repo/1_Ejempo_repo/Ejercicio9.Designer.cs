
namespace _1_Ejempo_repo
{
    partial class Ejercicio9
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKilo = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.dataCoches = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoches)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(138, 31);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(180, 26);
            this.tbMarca.TabIndex = 1;
            this.tbMarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kilometros";
            // 
            // tbKilo
            // 
            this.tbKilo.Location = new System.Drawing.Point(132, 244);
            this.tbKilo.Name = "tbKilo";
            this.tbKilo.Size = new System.Drawing.Size(180, 26);
            this.tbKilo.TabIndex = 9;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(138, 169);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(180, 26);
            this.tbPrecio.TabIndex = 10;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(138, 98);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(180, 26);
            this.tbModelo.TabIndex = 11;
            // 
            // dataCoches
            // 
            this.dataCoches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCoches.Location = new System.Drawing.Point(12, 304);
            this.dataCoches.Name = "dataCoches";
            this.dataCoches.RowHeadersWidth = 62;
            this.dataCoches.RowTemplate.Height = 28;
            this.dataCoches.Size = new System.Drawing.Size(776, 265);
            this.dataCoches.TabIndex = 12;
            // 
            // Ejercicio9
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.dataCoches);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbKilo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio9";
            this.Text = "Ejercicio9";
            ((System.ComponentModel.ISupportInitialize)(this.dataCoches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKilo;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.DataGridView dataCoches;
    }
}