using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Donem_Projesi_Yurt_Kayit
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-SJJ7N21\SQLEXPRESS;Initial Catalog=Yurt_Kayit;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
