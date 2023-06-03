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

namespace Tic_Tac_Toe
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            frm_OnePlayer frm = new frm_OnePlayer();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            frm_TwoPlayer frm = new frm_TwoPlayer();
            frm.Show();
            this.Hide();
        }
    }
}
