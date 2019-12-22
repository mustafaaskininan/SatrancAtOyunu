using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrancV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int boyut = 0;
        private void btnCiz_Click(object sender, EventArgs e)
        {
            btnCiz.BackColor = Color.White;

            if (cmbBoyut.Text == "5x5")
            {
                boyut = 7;
                btnCiz.Enabled = false;
            }
            else if (cmbBoyut.Text == "6x6")
            {
                boyut = 8;
                btnCiz.Enabled = false;
            }
            else if (cmbBoyut.Text == "7x7")
            {
                boyut = 9;
                btnCiz.Enabled = false;
            }
            else if (cmbBoyut.Text == "8x8")
            {
                boyut = 10;
                btnCiz.Enabled = false;
            }
            else if (cmbBoyut.Text == "9x9")
            {
                boyut = 11;
                btnCiz.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen değer seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    string x = Convert.ToString(i);
                    string y = Convert.ToString(j);
                    string z = x + y;
                    string k, l, m, n;
                    k = Convert.ToString(i) + "0";
                    l = "0" + Convert.ToString(j);
                    m = Convert.ToString(i) + Convert.ToString(boyut - 1);
                    n = Convert.ToString(boyut - 1) + Convert.ToString(j);
                    Button b = new Button();
                    b.Top = i * 40;
                    b.Left = j * 40;
                    b.Width = 40;
                    b.Height = 40;
                    b.Name = z;
                    b.BackColor = Color.White;
                    b.Click += btnClick;
                    this.Controls.Add(b);
                    if (b.Name == k || b.Name == l || b.Name == m || b.Name == n)
                    {
                        b.BackColor = Color.Black;
                        b.Enabled = false;
                    }
                }
            }
        }
        private void btnClick(object sender, EventArgs e)
        {
            Button b = ((Button)(sender));

            b.Enabled = false;
            b.BackColor = Color.DarkBlue;
            int aktarıcı = Convert.ToInt32(b.Name) - 19;
            string hamle1, hamle2, hamle3, hamle4, hamle5, hamle6, hamle7, hamle8;
            hamle1 = Convert.ToString(aktarıcı);
            aktarıcı = aktarıcı - 2;
            hamle2 = Convert.ToString(aktarıcı);
            aktarıcı = aktarıcı + 9;
            hamle3 = Convert.ToString(aktarıcı);
            aktarıcı = aktarıcı + 4;
            hamle4 = Convert.ToString(aktarıcı);
            aktarıcı = aktarıcı + 16;
            hamle5 = Convert.ToString(aktarıcı);
            aktarıcı = aktarıcı + 4;
            hamle6 = Convert.ToString(aktarıcı);
            aktarıcı = aktarıcı + 7;
            hamle7 = Convert.ToString(aktarıcı);
            aktarıcı = aktarıcı + 2;
            hamle8 = Convert.ToString(aktarıcı);

            Form1 frm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form1")
                {
                    frm = (Form1)f;
                }
            }

            if (frm != null)
            {
                foreach (Control c in frm.Controls)
                {
                    if (c is Button)
                    {
                        if (c.BackColor == Color.White)
                        {
                            c.Enabled = false;
                        }
                        if (c.BackColor == Color.DeepSkyBlue)
                        {
                            c.BackColor = Color.White;
                            c.Enabled = false;
                        }
                        if (c.Name == hamle2 || c.Name == hamle1 || c.Name == hamle3 || c.Name == hamle4 || c.Name == hamle5 || c.Name == hamle6 || c.Name == hamle7 || c.Name == hamle8 )
                        {

                            if (c.BackColor == Color.DarkBlue || c.BackColor == Color.Black)
                            { continue; }
                            
                            c.BackColor = Color.DeepSkyBlue;
                            c.Enabled = true;

                            
                        }
                    }
                }
            }

            if (frm != null)
            {
                int sayac = 0;
                int sayac2 = 0;
                foreach (Control c in frm.Controls)
                {

                    if (c is Button)
                    {
                        if (c.Enabled == false)
                        {
                            sayac++;
                        }
                        if (c.BackColor == Color.DarkBlue)
                        {
                            sayac2++;
                        }
                    }
                }
                if (sayac2 == (boyut - 2) * (boyut - 2))
                {
                    MessageBox.Show("Kazandınız!");
                }
                else if (sayac == boyut * boyut + 1)
                { MessageBox.Show("Oyunu bitti.Skorunuz:" + sayac2); }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    string z = Convert.ToString(i) + Convert.ToString(j);
                    Button b = new Button();
                    Form1 frm = null;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == "Form1")
                        {
                            frm = (Form1)f;
                        }
                    }

                    if (frm != null)
                    {
                        foreach (Control c in frm.Controls)
                        {
                            if (c is Button)
                            {
                                if (c.Name == z)
                                {
                                    frm.Controls.Remove(c);
                                }
                            }
                        }
                    }
                }
            }
            btnCiz.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
