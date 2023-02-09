
namespace _1_Ejempo_repo
{
    partial class Ejercicio_5
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
            this.bt_HornearP = new System.Windows.Forms.Button();
            this.bt_HornearPA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_HornearP
            // 
            this.bt_HornearP.Location = new System.Drawing.Point(114, 65);
            this.bt_HornearP.Name = "bt_HornearP";
            this.bt_HornearP.Size = new System.Drawing.Size(131, 45);
            this.bt_HornearP.TabIndex = 0;
            this.bt_HornearP.Text = "Hornear Pizza";
            this.bt_HornearP.UseVisualStyleBackColor = true;
            this.bt_HornearP.Click += new System.EventHandler(this.bt_HornearP_Click);
            // 
            // bt_HornearPA
            // 
            this.bt_HornearPA.Location = new System.Drawing.Point(251, 65);
            this.bt_HornearPA.Name = "bt_HornearPA";
            this.bt_HornearPA.Size = new System.Drawing.Size(131, 45);
            this.bt_HornearPA.TabIndex = 1;
            this.bt_HornearPA.Text = "Hornear Pizza A";
            this.bt_HornearPA.UseVisualStyleBackColor = true;
            this.bt_HornearPA.Click += new System.EventHandler(this.bt_HornearPA_Click);
            // 
            // Ejercicio_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 423);
            this.Controls.Add(this.bt_HornearPA);
            this.Controls.Add(this.bt_HornearP);
            this.Name = "Ejercicio_5";
            this.Text = "Ejercicio_5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_HornearP;
        private System.Windows.Forms.Button bt_HornearPA;
    }
}