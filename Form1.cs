using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UItest
{
    public partial class Form1 : Form
    {
        int Topvisiblevalue = 0;
        int Secondvisiblevalue = 0;
        int Thirdvisiblevalue = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(260, 100);      //Form1を起動したときにこのフォームの位置を固定する
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            pnlNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Topvisiblevalue++;
            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            pnlNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);
            Form2 f2 = new Form2();
            f2.Location = new Point(460, 244);
            f2.Show();

            if (Topvisiblevalue == 2)
            {
                f2.Visible = false;
                Topvisiblevalue -= 2;
            }
            else if (Topvisiblevalue == 1)
            {
                f2.Visible = true;
            }
            else if (Topvisiblevalue <= 0)
            {
                Topvisiblevalue = 1;
                f2.Visible = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Topvisiblevalue--;
            Secondvisiblevalue++;
            Thirdvisiblevalue--;
            pnlNav.Height = btn1.Height;
            pnlNav.Top = btn1.Top;
            pnlNav.Left = btn1.Left;
            btn1.BackColor = Color.FromArgb(46, 51, 73);
            Form3 f3 = new Form3();
            f3.Location = new Point(460, 286);
            f3.Show();

            if (Secondvisiblevalue == 2)
            {
                f3.Visible = false;
                Secondvisiblevalue -= 2;
            }
            else if (Secondvisiblevalue == 1)
            {
                f3.Visible = true;
            }
            else if (Secondvisiblevalue <= 0)
            {
                Secondvisiblevalue = 1;
                f3.Visible = true;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Topvisiblevalue--;
            Secondvisiblevalue--;
            Thirdvisiblevalue++;
            pnlNav.Height = btn2.Height;
            pnlNav.Top = btn2.Top;
            pnlNav.Left = btn2.Left;
            btn2.BackColor = Color.FromArgb(46, 51, 73);
            Form4 f4 = new Form4();
            f4.Location = new Point(460, 327);
            f4.Show();

            if (Thirdvisiblevalue == 2)
            {
                f4.Visible = false;
                Thirdvisiblevalue -= 2;
            }
            else if (Thirdvisiblevalue == 1)
            {
                f4.Visible = true;
            }
            else if (Thirdvisiblevalue <= 0)
            {
                Thirdvisiblevalue = 1;
                f4.Visible = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn3.Height;
            pnlNav.Top = btn3.Top;
            pnlNav.Left = btn3.Left;
            btn3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Leave(object sender, EventArgs e)
        {
            btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn1_Leave(object sender, EventArgs e)
        {
            btn1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn2_Leave(object sender, EventArgs e)
        {
            btn2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn3_Leave(object sender, EventArgs e)
        {
            btn3.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Exitbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
