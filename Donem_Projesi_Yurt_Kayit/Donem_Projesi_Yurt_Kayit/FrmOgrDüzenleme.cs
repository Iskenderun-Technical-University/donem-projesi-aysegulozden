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
    public partial class FrmOgrDüzenleme : Form
    {
        public FrmOgrDüzenleme()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,TC,telefon,dogum,bolum;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where OgrID=@s1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@s1", TxtOgrId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme Başarı ile Gerçekleşti");

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@o1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@o1", CmbOdalar.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
            

        }

        public string mail, odano, veliad, velisoyad, velitel, veliadres;

        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set (OgrID,OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrBolum,OgrDogum,OgrOdaNo,OgrMail,VeliAd,VeliSoyad,VeliTelefon,VeliAdres) values(,@o1,@o2,@o3,@o,@o5,@o6,@7,@o8,@o9,@v1,@v2,@v3,@4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@o1", TxtOgrId);
                komut.Parameters.AddWithValue("@o2", TxtOgAd.Text);
                komut.Parameters.AddWithValue("@o3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@o4", MskTC.Text);
                komut.Parameters.AddWithValue("@o5", MskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@o6", CmbBolum.Text);
                komut.Parameters.AddWithValue("@o7", MskDogumTarihi.Text);
                komut.Parameters.AddWithValue("@o8", CmbOdalar.Text);
                komut.Parameters.AddWithValue("@o9", TxtMail.Text);

                komut.Parameters.AddWithValue("@v1", TxtVeliAd.Text);
                komut.Parameters.AddWithValue("@v2", TxtVeliSoyad.Text);
                komut.Parameters.AddWithValue("@v3", MskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@v4", richTextBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarıyla Gerçekleşti");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız");

            }
        }

        

        private void FrmOgrDüzenleme_Load(object sender, EventArgs e)
        {
            TxtOgrId.Text = id;
            TxtOgAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            MskTC.Text = TC;
            MskOgrTelefon.Text = telefon;
            MskDogumTarihi.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdalar.Text = odano;
            TxtVeliAd.Text = veliad;
            TxtVeliSoyad.Text = velisoyad;
            MskVeliTelefon.Text = velitel;
            richTextBox1.Text = veliadres;
           



        }
    }
}
