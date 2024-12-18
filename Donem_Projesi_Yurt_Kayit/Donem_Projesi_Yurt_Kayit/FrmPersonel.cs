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

namespace Donem_Projesi_Yurt_Kayit
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_KayitDataSet13.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurt_KayitDataSet13.Personel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAd,PersonelSoyad,PersonelDepertman) values (@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtPersonelGorev.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
            this.personelTableAdapter.Fill(this.yurt_KayitDataSet13.Personel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where PersonelID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi yapıldı");
            this.personelTableAdapter.Fill(this.yurt_KayitDataSet13.Personel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutgun = new SqlCommand("update Personel set PersonelAd=@p1,PersonelSoyad=@p2,PersonelDepertman=@p3 where PersonelID=@p4 ", bgl.baglanti());
            komutgun.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komutgun.Parameters.AddWithValue("@p2", TxtPersonelSoyad.Text);
            komutgun.Parameters.AddWithValue("@p3", TxtPersonelGorev.Text);
            komutgun.Parameters.AddWithValue("@p4", TxtPersonelID.Text);
            komutgun.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi");
            this.personelTableAdapter.Fill(this.yurt_KayitDataSet13.Personel);

        }
    }
}
