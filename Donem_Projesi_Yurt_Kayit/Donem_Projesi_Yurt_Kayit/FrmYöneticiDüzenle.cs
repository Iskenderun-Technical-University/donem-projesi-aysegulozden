using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Donem_Projesi_Yurt_Kayit;

namespace Donem_Projesi_Yurt_Kayit
{
    public partial class FrmYöneticiDüzenle : Form
    {
        public FrmYöneticiDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void Frm1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_KayitDataSet12.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurt_KayitDataSet12.Admin);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd,YoneticiSifre) values (@y1,@y2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@y1", TxtKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@y2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Yönetici Eklendi");
            this.adminTableAdapter.Fill(this.yurt_KayitDataSet12.Admin);


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Admin where YoneticiID=@y1", bgl.baglanti());
            komut.Parameters.AddWithValue("@y1", TxtKullaniciID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Silindi");
            this.adminTableAdapter.Fill(this.yurt_KayitDataSet12.Admin);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre,id;
            id = dataGridView1.Rows[0].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[0].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[0].Cells[2].Value.ToString();

            TxtKullaniciID.Text = id;
            TxtKullanıcıAd.Text = ad;
            TxtSifre.Text = sifre;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update admin set YoneticiAd=@y1,YoneticiSifre@y2 ,YoneticiID=@y3 where ", bgl.baglanti());
            komut.Parameters.AddWithValue("@y1", TxtKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@y2", TxtSifre.Text);
            komut.Parameters.AddWithValue("@y3", TxtKullaniciID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Gerçekleşti");
            this.adminTableAdapter.Fill(this.yurt_KayitDataSet12.Admin);
        }
    }
}
