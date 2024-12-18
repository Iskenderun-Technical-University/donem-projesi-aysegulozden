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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl= new SqlBaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_KayitDataSet11.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurt_KayitDataSet11.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtOgrAd.Text = ad;
            TxtOgrID.Text = id;
            TxtKalan.Text = kalan;

        }

        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            int odenen, kalan,yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);

            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();

            SqlCommand komut = new SqlCommand("update Borclar set  OgrKalanBorc=@b1 where OgrID=@b2", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtKalan.Text);
            komut.Parameters.AddWithValue("@b2", TxtOgrID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç ödendi");
            this.borclarTableAdapter.Fill(this.yurt_KayitDataSet11.Borclar);

            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy , OdemeMiktar) values (@k1,@k2)", bgl.baglanti());

            komut2.Parameters.AddWithValue("@k1", TxtKalan.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}
