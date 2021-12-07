namespace Soru8
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
            this.lstSonuclar = new System.Windows.Forms.ListBox();
            this.txtSayiBir = new System.Windows.Forms.TextBox();
            this.txtSayiIki = new System.Windows.Forms.TextBox();
            this.txtSayiUc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayıları Giriniz(3): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uygulama Enter İle Çalışıyor.";
            // 
            // lstSonuclar
            // 
            this.lstSonuclar.FormattingEnabled = true;
            this.lstSonuclar.ItemHeight = 19;
            this.lstSonuclar.Location = new System.Drawing.Point(225, 9);
            this.lstSonuclar.Name = "lstSonuclar";
            this.lstSonuclar.Size = new System.Drawing.Size(238, 175);
            this.lstSonuclar.TabIndex = 10;
            // 
            // txtSayiBir
            // 
            this.txtSayiBir.Location = new System.Drawing.Point(17, 73);
            this.txtSayiBir.Name = "txtSayiBir";
            this.txtSayiBir.Size = new System.Drawing.Size(129, 27);
            this.txtSayiBir.TabIndex = 11;
            // 
            // txtSayiIki
            // 
            this.txtSayiIki.Location = new System.Drawing.Point(17, 106);
            this.txtSayiIki.Name = "txtSayiIki";
            this.txtSayiIki.Size = new System.Drawing.Size(129, 27);
            this.txtSayiIki.TabIndex = 12;
            // 
            // txtSayiUc
            // 
            this.txtSayiUc.Location = new System.Drawing.Point(17, 139);
            this.txtSayiUc.Name = "txtSayiUc";
            this.txtSayiUc.Size = new System.Drawing.Size(129, 27);
            this.txtSayiUc.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(475, 189);
            this.Controls.Add(this.txtSayiUc);
            this.Controls.Add(this.txtSayiIki);
            this.Controls.Add(this.txtSayiBir);
            this.Controls.Add(this.lstSonuclar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSonuclar;
        private System.Windows.Forms.TextBox txtSayiBir;
        private System.Windows.Forms.TextBox txtSayiIki;
        private System.Windows.Forms.TextBox txtSayiUc;
    }
}

