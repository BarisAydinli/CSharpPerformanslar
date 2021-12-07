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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBir = new System.Windows.Forms.Button();
            this.btnIki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBir
            // 
            this.btnBir.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.btnBir, "btnBir");
            this.btnBir.Name = "btnBir";
            this.btnBir.UseVisualStyleBackColor = false;
            this.btnBir.Click += new System.EventHandler(this.btnBir_Click);
            // 
            // btnIki
            // 
            this.btnIki.BackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.btnIki, "btnIki");
            this.btnIki.Name = "btnIki";
            this.btnIki.UseVisualStyleBackColor = false;
            this.btnIki.Click += new System.EventHandler(this.btnİki_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.btnIki);
            this.Controls.Add(this.btnBir);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBir;
        private System.Windows.Forms.Button btnIki;
    }
}

