using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace stokEkstresi
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-C60BG7AL\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
            baglan.Open();
            return baglan;
        } 
    }
}
