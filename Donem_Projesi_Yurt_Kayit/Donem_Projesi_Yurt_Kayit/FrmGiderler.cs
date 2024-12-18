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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler (Elektrik,Dogalgaz,Internet,Gıda,DigerGiderler) Values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtElektirik.Text);
                komut.Parameters.AddWithValue("@p2", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p3", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p4", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p5", TxtDiger.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıtlar eklendi");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
        }
    }
}
