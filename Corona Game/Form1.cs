using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
        List<PictureBox> viruses = new List<PictureBox>();
        List<PictureBox> splashes = new List<PictureBox>();

        int v0x = 30, v0y = 0, y0 = 288;

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            PictureBox temp;

            if (v0y == 0)
            {
                picBoxCannon.Image = Properties.Resources.cannonSi;
            }

            if (e.KeyCode == Keys.Space)
            {
                temp = new PictureBox();
                temp.Location = picBoxCannon.Location;
                temp.Image = Properties.Resources.injection;
                temp.Height = 55;
                temp.Width = 65;
                temp.SizeMode = PictureBoxSizeMode.StretchImage;
                injections.Add(new Projectile(temp));
                Controls.Add(temp);
                injections.Last().v0x = v0x;
                injections.Last().v0y = v0y;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (v0x != 5)
                {
                    v0x -= 5;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (v0x != 100)
                {
                    v0x += 5;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (v0y != 100)
                {
                    v0y += 5;
                    picBoxCannon.Image = RotateImage(picBoxCannon.Image, -5);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (v0y != -100)
                {
                    v0y -= 5;
                    picBoxCannon.Image = RotateImage(picBoxCannon.Image, 5);
                }
            }

        }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            //gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private bool IsTouching(PictureBox p1, PictureBox p2)
        {
            if (p1.Location.X + p1.Width / 2 < p2.Location.X)
                return false;
            if (p2.Location.X + p2.Width / 2 < p1.Location.X)
                return false;
            if (p1.Location.Y + p1.Height < p2.Location.Y)
                return false;
            if (p2.Location.Y + p2.Height < p1.Location.Y)
                return false;
            return true;
        }

        private void tmrCorona_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            PictureBox temp = new PictureBox();
            temp.Location = new Point(rnd.Next(100,Width - 100), rnd.Next(100, Height - 100));
            temp.Width = 120;
            temp.Height = 100;
            temp.SizeMode = PictureBoxSizeMode.StretchImage;
            temp.Image = Properties.Resources.corona;
            temp.BackColor = Color.Transparent;
            viruses.Add(temp);
            Controls.Add(temp);
        }

        private void tmrSplashes_Tick(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < splashes.Count; i++)
            {
                splashes[i].Tag = (int.Parse(splashes[i].Tag.ToString()) + 1).ToString();
                if (splashes[i].Tag.Equals("1"))
                {
                    Controls.Remove(splashes[i]);
                    splashes.RemoveAt(i);
                }
            }
        }

        private void tmrFire_Tick(object sender, EventArgs e)
        {
            int i, j, x, y;
            PictureBox temp;
            for (i = 0; i < injections.Count; i++)
            {
                x = injections[i].pic.Location.X + injections[i].v0x;
                y = y0 - injections[i].t * injections[i].v0y + (int)Math.Pow(injections[i].t, 2);
                injections[i].pic.Location = new Point(x, y);
                injections[i].t++;
                if (injections[i].pic.Location.X > Width | injections[i].pic.Location.Y > Height )
                {
                    Controls.Remove(injections[i].pic);
                    injections.Remove(injections[i]);
                }
                else
                {
                    for (j = 0; j < viruses.Count; j++)
                    {
                        if (IsTouching(injections[i].pic, viruses[j]))
                        {

                            Controls.Remove(injections[i].pic);
                            injections.Remove(injections[i]);
                            lblScore.Text = (int.Parse(lblScore.Text) + 1).ToString();

                            temp = new PictureBox();
                            temp.Location = viruses[j].Location;
                            Controls.Remove(viruses[j]);
                            viruses.Remove(viruses[j]);
                            temp.Width = 100;
                            temp.Height = 100;
                            temp.SizeMode = PictureBoxSizeMode.StretchImage;
                            temp.Image = Properties.Resources.splash;
                            temp.Tag = "0";
                            Controls.Add(temp);
                            splashes.Add(temp);
                            break;
                        }
                    }
                }
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
