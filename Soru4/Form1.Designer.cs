namespace Soru4ButonHareketEttirmeProgrami
{
    partial class Form1
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
            this.btnBir = new System.Windows.Forms.Button();
            this.btnIki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBir
            // 
            this.btnBir.BackColor = System.Drawing.Color.Coral;
            this.btnBir.Location = new System.Drawing.Point(50, 50);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(50, 50);
            this.btnBir.TabIndex = 1;
            this.btnBir.UseVisualStyleBackColor = false;
            this.btnBir.Click += new System.EventHandler(this.btnBir_Click);
            // 
            // btnIki
            // 
            this.btnIki.BackColor = System.Drawing.Color.RosyBrown;
            this.btnIki.Location = new System.Drawing.Point(50, 150);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(50, 50);
            this.btnIki.TabIndex = 0;
            this.btnIki.UseVisualStyleBackColor = false;
            this.btnIki.Click += new System.EventHandler(this.btnİki_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Düğmeler Tıkla.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(153, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIki);
            this.Controls.Add(this.btnBir);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBir;
        private System.Windows.Forms.Button btnIki;
        private System.Windows.Forms.Label label1;
    }
}

