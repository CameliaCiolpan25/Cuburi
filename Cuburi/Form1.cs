using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuburi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //=======================================================
        List<Cub> cuburi;//lista in care pastram cuburile
        Image img;
        Graphics g;
        bool apasat;
        int tempX, tempY;
        int cub_curent;

        void adauga_cub()
        {
            Random r = new Random();
            Color c1 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));//GENERAM ALEATORIU CULORILE
            Color c2 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            Color c3 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            int dim = Convert.ToInt32(dimensiune.Text);
            cuburi.Add(new Cub(20, p.Height - 100, 10* dim, 5 * dim, 4 * dim, eticheta.Text, c1, c2, c3));
            deseneaza(g);
        }
        void deseneaza(Graphics g)
        {
            g.Clear(p.BackColor);
            for (int i = 0; i < cuburi.Count; i++)//desenam toate cuburile, in ordinrea din lista cuburi
                cuburi[i].deseneaza(g);
            p.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dimensiune.SelectedIndex = 0;
            cuburi = new List<Cub>();
            img = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(img);
            deseneaza(g);
        }

        private void p_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = cuburi.Count - 1; i >= 0; i--)
                if (cuburi[i].esteDeasupra(e.X, e.Y))
                {
                    tempX = e.X - cuburi[i].X;
                    tempY = e.Y - cuburi[i].Y;
                    apasat = true;
                    if (inFata.Checked)
                    {//pentru a aduce un cub in prim plan il trecem ultimul in vectorul cuburi
                        Cub tempC = cuburi[i];
                        for (int j = i + 1; j < cuburi.Count; j++)
                            cuburi[j - 1] = cuburi[j];
                        cuburi[cuburi.Count - 1] = tempC;
                        cub_curent = cuburi.Count - 1;
                    }
                    else if (inSpate.Checked)
                    {//pentru a pune un cub in spate il trecem primul in vectorul cuburi
                        Cub tempC = cuburi[i];
                        for (int j = i - 1; j >= 0; j--)
                            cuburi[j + 1] = cuburi[j];
                        cuburi[0] = tempC;
                        cub_curent = 0;
                    }
                    else
                    {
                        cub_curent = i;
                    }
                    p.Cursor = Cursors.Hand;
                    break;
                }
        }

        private void p_MouseUp(object sender, MouseEventArgs e)
        {
            apasat = false;
            p.Cursor = Cursors.Default;
        }

        private void p_MouseMove(object sender, MouseEventArgs e)
        {
            if (apasat)
            {
                cuburi[cub_curent].X = e.X - tempX;
                cuburi[cub_curent].Y = e.Y - tempY;
                deseneaza(g);
            }    
        }

        private void inSpate_Click(object sender, EventArgs e)
        {
            inSpate.Checked = true;
            inFata.Checked = false;
        }

        private void inFata_Click(object sender, EventArgs e)
        {
            inFata.Checked = true;
            inSpate.Checked = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            adauga_cub();
        }

        private void p_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0, p.Width, p.Height);
        }

    }
}
