using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace my_archive1
{
    public partial class main : DevExpress.XtraEditors.XtraForm
    {
        public main()
        {
            InitializeComponent();
        }


        //load home page
        private void btn_home_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            LoadHomePage();
        }

        private void LoadHomePage()
        {
            pages.homePage page = new pages.homePage();
            LoadPage(page);
        }


        //load page method
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try
            {
                pn_contaier.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                pn_contaier.Controls.Add(Page);
            }
            catch { }
        }

        private void pn_contaier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_sec_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            pages.DepPage page = new pages.DepPage();
            LoadPage(page);
        }
    }
}
