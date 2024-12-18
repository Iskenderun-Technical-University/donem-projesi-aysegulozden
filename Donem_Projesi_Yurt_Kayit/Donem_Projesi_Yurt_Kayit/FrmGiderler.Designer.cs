namespace Donem_Projesi_Yurt_Kayit
{
    partial class FrmGiderler
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtElektirik = new System.Windows.Forms.TextBox();
            this.TxtDogalgaz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDiger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGıda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elektirik";
            // 
            // TxtElektirik
            // 
            this.TxtElektirik.Location = new System.Drawing.Point(138, 25);
            this.TxtElektirik.Name = "TxtElektirik";
            this.TxtElektirik.Size = new System.Drawing.Size(209, 22);
            this.TxtElektirik.TabIndex = 1;
            // 
            // TxtDogalgaz
            // 
            this.TxtDogalgaz.Location = new System.Drawing.Point(138, 66);
            this.TxtDogalgaz.Name = "TxtDogalgaz";
            this.TxtDogalgaz.Size = new System.Drawing.Size(209, 22);
            this.TxtDogalgaz.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğalgaz";
            // 
            // TxtInternet
            // 
            this.TxtInternet.Location = new System.Drawing.Point(138, 107);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(209, 22);
            this.TxtInternet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "İnternet";
            // 
            // TxtDiger
            // 
            this.TxtDiger.Location = new System.Drawing.Point(138, 191);
            this.TxtDiger.Name = "TxtDiger";
            this.TxtDiger.Size = new System.Drawing.Size(209, 22);
            this.TxtDiger.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Diğer";
            // 
            // TxtGıda
            // 
            this.TxtGıda.Location = new System.Drawing.Point(142, 150);
            this.TxtGıda.Name = "TxtGıda";
            this.TxtGıda.Size = new System.Drawing.Size(209, 22);
            this.TxtGıda.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gıda";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(168, 232);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(120, 30);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(491, 366);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtGıda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDiger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtInternet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDogalgaz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtElektirik);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderler";
            this.Text = "Giderler";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtGıda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDiger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDogalgaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtElektirik;
        private System.Windows.Forms.Label label1;
    }
}