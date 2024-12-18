using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donem_Projesi_Yurt_Kayit
{
    public partial class FrmGiderGüncelle : Form
    {
        public FrmGiderGüncelle()
        {
            InitializeComponent();
        }

        public string elektirik, dogalgaz, internet, gıda, diger;

        private void FrmGiderGüncelle_Load(object sender, EventArgs e)
        {
            TxtElektirik.Text = elektirik;
            TxtDogalgaz.Text = dogalgaz;
            TxtInternet.Text = internet;
            TxtGıda.Text = gıda;
            TxtDiger.Text = diger;
        }
    }
}
