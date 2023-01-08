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
using stokEkstresi.Entity;

namespace stokEkstresi
{
    public partial class FormStok : Form
    {
        public FormStok()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        SqlDataAdapter adapter;
        SqlCommand command;
        DataTable dt = new DataTable();
        
        void listele() //tabloyu parametresiz listelemek için
        {
            dt.Clear();
            adapter = new SqlDataAdapter("Goster", bgl.baglanti());
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FormStok_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //tabloyu parametre değerleriyle birlikte listelemek için
            dt.Clear();
            command = new SqlCommand("Search", bgl.baglanti());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@malKodu", MalKodu.Text));
            command.Parameters.Add(new SqlParameter("@baslangic", BaslangicTarihi.Text));
            command.Parameters.Add(new SqlParameter("@bitis", BitisTarihi.Text));

            command.ExecuteNonQuery();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
