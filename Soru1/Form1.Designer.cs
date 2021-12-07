namespace GirilenSayiyiHarflerleYazdırmaProgramı
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
            this.nudSayiGirdisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSayiCiktisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayiGirdisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayıyı Giriniz: ";
            // 
            // nudSayiGirdisi
            // 
            this.nudSayiGirdisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSayiGirdisi.Location = new System.Drawing.Point(123, 65);
            this.nudSayiGirdisi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nudSayiGirdisi.Name = "nudSayiGirdisi";
            this.nudSayiGirdisi.Size = new System.Drawing.Size(48, 23);
            this.nudSayiGirdisi.TabIndex = 2;
            this.nudSayiGirdisi.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayının Harf İle Yazılışı:";
            // 
            // lblSayiCiktisi
            // 
            this.lblSayiCiktisi.AutoSize = true;
            this.lblSayiCiktisi.Location = new System.Drawing.Point(183, 102);
            this.lblSayiCiktisi.Name = "lblSayiCiktisi";
            this.lblSayiCiktisi.Size = new System.Drawing.Size(54, 19);
            this.lblSayiCiktisi.TabIndex = 4;
            this.lblSayiCiktisi.Text = "<Sayi>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uygulama Enter İle Çalışıyor.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(338, 151);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSayiCiktisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSayiGirdisi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudSayiGirdisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSayiGirdisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSayiCiktisi;
        private System.Windows.Forms.Label label3;
    }
}

