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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) from Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                label2.Text = oku[0].ToString()+ "TL";

            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy) from Kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                CmbAylar.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komutkazanc = new SqlCommand("select  OdemeAy, sum(odememiktar) from kasa group by OdemeAy", bgl.baglanti());
            SqlDataReader oku3 = komutkazanc.ExecuteReader();
            while(oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglanti().Close();

        }

        private void CmbAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select sum(OdemeMiktar) From Kasa where OdemeAy=@a1", bgl.baglanti());
            komut.Parameters.AddWithValue("@a1", CmbAylar.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                LblAyKazanç.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
