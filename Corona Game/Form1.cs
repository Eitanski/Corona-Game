using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corona_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        List<Projectile> injections = new List<Projectile>();
        List<PictureBox> Viruses = new List<PictureBox>();
        int v0x, v0y;

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //int x = picBoxCannon.Location.X;
            //int y = picBoxCannon.Location.Y;

            PictureBox temp;

            if (e.KeyCode == Keys.Space)
            {
                temp = new PictureBox();
                temp.Location = picBoxCannon.Location;
                temp.Image = Properties.Resources.injection;
                temp.Height = 85;
                temp.Width = 95;
                temp.SizeMode = PictureBoxSizeMode.StretchImage;
                injections.Add(new Projectile(temp));
                Controls.Add(temp);
            }
            //else if (e.KeyCode == Keys.Left)
            //{
            //    x -= 30;
            //}
            //else if (e.KeyCode == Keys.Space)
            //{
            //    fireballs.Add(new PictureBox());    // adding a new fire ball to fire
            //    fireballs.Last().Image = Properties.Resources.fireball;
            //    fireballs.Last().Location = picBoxCannon.Location;
            //    fireballs.Last().Size = picBoxCannon.Size;
            //    fireballs.Last().SizeMode = PictureBoxSizeMode.StretchImage;
            //    Controls.Add(fireballs.Last());
            //}

            //picBoxCannon.Location = new Point(x, y);
        }

        private bool IsTouching(PictureBox p1, PictureBox p2)
        {
            if (p1.Location.X + p1.Width / 2 < p2.Location.X)
                return false;
            if (p2.Location.X + p2.Width / 2 < p1.Location.X)
                return false;
            if (p1.Location.Y + p1.Height - 50 < p2.Location.Y)
                return false;
            if (p2.Location.Y + p2.Height - 50 < p1.Location.Y)
                return false;
            return true;
        }

        private void tmrCorona_Tick(object sender, EventArgs e)
        {

        }

        private void tmrFire_Tick(object sender, EventArgs e)
        {
            int i, j, x, y;
            for (i = 0; i < injections.Count; i++)
            {
                x = injections[i].pic.Location.X;
                y = injections[i].pic.Location.Y;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
