using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Size = new Size(650, 650);
            textbox_NhapSo1.TextChanged += textbox_NhapSo1_TextChanged;
            btn_nhap.Click += btn_nhap_Click;
            btn_xoa.Click += btn_xoa_Click;
        }
        int click = 0;

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is PictureBox)
                {
                    this.Controls.RemoveAt(i);
                    i--;
                }
            }
            click = 0;
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textbox_NhapSo1.Text);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    PictureBox p = new PictureBox();
                    p.Name = "p1";
                    p.Size = new Size(50, 50);
                    p.Left = 50 + 50 * j;
                    p.Top = 50 * i + 50;
                    p.BackColor = Color.Silver;
                    p.BorderStyle = BorderStyle.Fixed3D;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(p);
                    p.Click += p_Click;
                }
            }
        }

        private void p_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (click % 2 != 0)
            {
                if (p.Tag == null)
                {
                    p.Image = WindowsFormsApplication1.Properties.Resources.Delete;
                    p.Tag = 1;
                    click++;
                }
            }
            else
            {
                if (p.Tag == null)
                {
                    p.Image = WindowsFormsApplication1.Properties.Resources.o_150;
                    p.Tag = 0;
                    click++;
                }
                
            }
        }

        private void textbox_NhapSo1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(textbox_NhapSo1.Text);
                if (x <= 0 || x > 10)
                {
                    MessageBox.Show("chi dc nhap tu 1 den 10", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_NhapSo1.Clear();
                }
            }
            catch { }
        }
    }
}
