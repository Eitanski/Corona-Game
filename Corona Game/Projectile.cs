using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Corona_Game
{
    class Projectile
    {
        public PictureBox pic;
        public int t;
        public int v0x;
        public int v0y;

        public Projectile(PictureBox p)
        {
            pic = p;
            t = 0;
        }
    }
}
