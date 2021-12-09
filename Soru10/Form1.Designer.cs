namespace Soru10MukemmelSayiBulmaProgrami
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGirdi = new System.Windows.Forms.TextBox();
            this.lstMukemmelSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uygulama Enter İle Çalışıyor.";
            // 
            // txtGirdi
            // 
            this.txtGirdi.Location = new System.Drawing.Point(108, 50);
            this.txtGirdi.Name = "txtGirdi";
            this.txtGirdi.Size = new System.Drawing.Size(100, 27);
            this.txtGirdi.TabIndex = 9;
            // 
            // lstMukemmelSayilar
            // 
            this.lstMukemmelSayilar.FormattingEnabled = true;
            this.lstMukemmelSayilar.ItemHeight = 19;
            this.lstMukemmelSayilar.Location = new System.Drawing.Point(243, 19);
            this.lstMukemmelSayilar.Name = "lstMukemmelSayilar";
            this.lstMukemmelSayilar.Size = new System.Drawing.Size(120, 80);
            this.lstMukemmelSayilar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(390, 111);
            this.Controls.Add(this.lstMukemmelSayilar);
            this.Controls.Add(this.txtGirdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGirdi;
        private System.Windows.Forms.ListBox lstMukemmelSayilar;
    }
}

