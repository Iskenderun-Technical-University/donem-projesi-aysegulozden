namespace Donem_Projesi_Yurt_Kayit
{
    partial class FrmBolumler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcbEkle = new System.Windows.Forms.PictureBox();
            this.PcbSil = new System.Windows.Forms.PictureBox();
            this.PcbGuncelle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumID = new System.Windows.Forms.TextBox();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_KayitDataSet = new Donem_Projesi_Yurt_Kayit.Yurt_KayitDataSet();
            this.bolumlerTableAdapter = new Donem_Projesi_Yurt_Kayit.Yurt_KayitDataSetTableAdapters.BolumlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PcbEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_KayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbEkle
            // 
            this.PcbEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcbEkle.Image")));
            this.PcbEkle.Location = new System.Drawing.Point(2, 89);
            this.PcbEkle.Name = "PcbEkle";
            this.PcbEkle.Size = new System.Drawing.Size(68, 64);
            this.PcbEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbEkle.TabIndex = 0;
            this.PcbEkle.TabStop = false;
            this.PcbEkle.Click += new System.EventHandler(this.PcbEkle_Click);
            // 
            // PcbSil
            // 
            this.PcbSil.Image = ((System.Drawing.Image)(resources.GetObject("PcbSil.Image")));
            this.PcbSil.Location = new System.Drawing.Point(118, 89);
            this.PcbSil.Name = "PcbSil";
            this.PcbSil.Size = new System.Drawing.Size(68, 64);
            this.PcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbSil.TabIndex = 1;
            this.PcbSil.TabStop = false;
            this.PcbSil.Click += new System.EventHandler(this.PcbSil_Click);
            // 
            // PcbGuncelle
            // 
            this.PcbGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("PcbGuncelle.Image")));
            this.PcbGuncelle.Location = new System.Drawing.Point(228, 89);
            this.PcbGuncelle.Name = "PcbGuncelle";
            this.PcbGuncelle.Size = new System.Drawing.Size(68, 64);
            this.PcbGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbGuncelle.TabIndex = 2;
            this.PcbGuncelle.TabStop = false;
            this.PcbGuncelle.Click += new System.EventHandler(this.PcbGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bölüm Adı:";
            // 
            // TxtBolumID
            // 
            this.TxtBolumID.Location = new System.Drawing.Point(105, 16);
            this.TxtBolumID.Name = "TxtBolumID";
            this.TxtBolumID.Size = new System.Drawing.Size(147, 22);
            this.TxtBolumID.TabIndex = 5;
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Location = new System.Drawing.Point(105, 61);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(147, 22);
            this.TxtBolumAd.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 388);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurt_KayitDataSet;
            // 
            // yurt_KayitDataSet
            // 
            this.yurt_KayitDataSet.DataSetName = "Yurt_KayitDataSet";
            this.yurt_KayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(401, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.TxtBolumID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbGuncelle);
            this.Controls.Add(this.PcbSil);
            this.Controls.Add(this.PcbEkle);
            this.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_KayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbEkle;
        private System.Windows.Forms.PictureBox PcbSil;
        private System.Windows.Forms.PictureBox PcbGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumID;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Yurt_KayitDataSet yurt_KayitDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private Yurt_KayitDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
    }
}