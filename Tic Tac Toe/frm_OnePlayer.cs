﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class frm_OnePlayer : Form
    {
        public frm_OnePlayer()
        {
            InitializeComponent();
        }
        List<Guna.UI2.WinForms.Guna2Button> buttons;
        Random rand=new Random();
        int player1 = 0;
        int player2 = 0;
        void loadbuttons()
        {
            buttons = new List<Guna.UI2.WinForms.Guna2Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
        }
        void wineffect(Guna.UI2.WinForms.Guna2Button b1 ,Guna.UI2.WinForms.Guna2Button b2 , Guna.UI2.WinForms.Guna2Button b3)
        {
            b1.ForeColor = Color.FromArgb(84, 180, 53);
            b2.ForeColor = Color.FromArgb(84, 180, 53);
            b2.ForeColor = Color.FromArgb(84, 180, 53);
            if (b1.Text== "X")
            {
                player1++;
                lbl1.Text = player1.ToString();
            }
            else
            {
                player2++;
                lbl2.Text = player2.ToString();
            }
        }
        bool win = false;
        void getthewinner()
        {
            if(btn1.Text != ""&& btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                wineffect(btn1, btn2, btn3 );
                win = true;
            }
            else if(btn4.Text != "" && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                wineffect(btn4, btn5, btn6 );
                win = true;
            }
            else if(btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                wineffect(btn7, btn8, btn9);
                win = true;
            }
        }

        private void frm_OnePlayer_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain frm = new FrmMain();
            frm.Show();
        }
    }
}
