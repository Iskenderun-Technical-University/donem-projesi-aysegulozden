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
    public partial class FrmAdminGiriş : Form
    {
        public FrmAdminGiriş()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin where YoneticiAd=@y1 and YoneticiSifre=@y2", bgl.baglanti());
            komut.Parameters.AddWithValue("@y1", TxtKullanıcıAdı.Text);
            komut.Parameters.AddWithValue("@y2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                FrmAnaMenu fr = new FrmAnaMenu();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE");
                TxtKullanıcıAdı.Clear();
                TxtSifre.Clear();
                TxtKullanıcıAdı.Focus();

            }
            bgl.baglanti().Close();
        }
    }
}
