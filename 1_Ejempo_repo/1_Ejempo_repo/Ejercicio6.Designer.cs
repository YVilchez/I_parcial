
namespace _1_Ejempo_repo
{
    partial class Ejercicio6
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
            this.bt_arreglo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 121);
            this.listBox1.TabIndex = 0;
            // 
            // bt_arreglo
            // 
            this.bt_arreglo.Location = new System.Drawing.Point(376, 34);
            this.bt_arreglo.Name = "bt_arreglo";
            this.bt_arreglo.Size = new System.Drawing.Size(98, 54);
            this.bt_arreglo.TabIndex = 1;
            this.bt_arreglo.Text = "Arreglo / Vector / Matriz";
            this.bt_arreglo.UseVisualStyleBackColor = true;
            this.bt_arreglo.Click += new System.EventHandler(this.bt_arreglo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 182);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_arreglo);
            this.Controls.Add(this.listBox1);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_arreglo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}