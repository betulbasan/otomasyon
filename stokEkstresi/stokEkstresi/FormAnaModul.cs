using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokEkstresi
{
    public partial class FormAnaModul : Form
    {
        public FormAnaModul()
        {
            InitializeComponent();
        }
        FormStok form1;
        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (form1==null || form1.IsDisposed) { 
            form1 = new FormStok();
            form1.MdiParent = this;
            form1.Show();
            }
        }
    }
}
