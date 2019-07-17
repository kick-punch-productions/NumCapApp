using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumCapApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://iterate.com.au");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void NumOn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void NumOff_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void CapOn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void CapOff_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SwapIcons();
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SwapIcons();
        }

        private void SwapIcons()
        {
            if (IsKeyLocked(Keys.CapsLock))
            {
                CapOff.Visible = false;
                CapOn.Visible = true;
            } else
            {
                CapOff.Visible = true;
                CapOn.Visible = false;
            }
            if (IsKeyLocked(Keys.NumLock))
            {
                NumOff.Visible = false;
                NumOn.Visible = true;
            }
            else
            {
                NumOff.Visible = true;
                NumOn.Visible = false;
            }
        }
    }
}
