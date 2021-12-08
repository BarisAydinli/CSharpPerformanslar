namespace Soru9SayiHesaplamaProgrami
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
            this.txtGirdi = new System.Windows.Forms.TextBox();
            this.lstSonuclar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbSayiDahil = new System.Windows.Forms.RadioButton();
            this.rdbSayiDahilDegil = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Giriniz:";
            // 
            // txtGirdi
            // 
            this.txtGirdi.Location = new System.Drawing.Point(109, 73);
            this.txtGirdi.Name = "txtGirdi";
            this.txtGirdi.Size = new System.Drawing.Size(129, 27);
            this.txtGirdi.TabIndex = 1;
            // 
            // lstSonuclar
            // 
            this.lstSonuclar.FormattingEnabled = true;
            this.lstSonuclar.ItemHeight = 19;
            this.lstSonuclar.Location = new System.Drawing.Point(265, 12);
            this.lstSonuclar.Name = "lstSonuclar";
            this.lstSonuclar.Size = new System.Drawing.Size(413, 99);
            this.lstSonuclar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Uygulama Enter İle Çalışıyor.";
            // 
            // rdbSayiDahil
            // 
            this.rdbSayiDahil.AutoSize = true;
            this.rdbSayiDahil.Location = new System.Drawing.Point(12, 41);
            this.rdbSayiDahil.Name = "rdbSayiDahil";
            this.rdbSayiDahil.Size = new System.Drawing.Size(95, 23);
            this.rdbSayiDahil.TabIndex = 13;
            this.rdbSayiDahil.TabStop = true;
            this.rdbSayiDahil.Text = "Sayı Dahil";
            this.rdbSayiDahil.UseVisualStyleBackColor = true;
            // 
            // rdbSayiDahilDegil
            // 
            this.rdbSayiDahilDegil.AutoSize = true;
            this.rdbSayiDahilDegil.Location = new System.Drawing.Point(109, 41);
            this.rdbSayiDahilDegil.Name = "rdbSayiDahilDegil";
            this.rdbSayiDahilDegil.Size = new System.Drawing.Size(134, 23);
            this.rdbSayiDahilDegil.TabIndex = 14;
            this.rdbSayiDahilDegil.TabStop = true;
            this.rdbSayiDahilDegil.Text = "Sayı Dahil Değil";
            this.rdbSayiDahilDegil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(705, 131);
            this.Controls.Add(this.rdbSayiDahilDegil);
            this.Controls.Add(this.rdbSayiDahil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSonuclar);
            this.Controls.Add(this.txtGirdi);
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
        private System.Windows.Forms.TextBox txtGirdi;
        private System.Windows.Forms.ListBox lstSonuclar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbSayiDahil;
        private System.Windows.Forms.RadioButton rdbSayiDahilDegil;
    }
}

