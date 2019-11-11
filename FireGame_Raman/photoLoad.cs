using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_Raman
{
    public class photoLoad
    {
        //user define method to load the bullet with the help of argument of the picture box working as parameter
        public void start(PictureBox pb) {
            pb.Image = FireGame_Raman.Properties.Resources.emprt;
        }
        // method to load the bullet and also with the working of the argument 
        public void fill(PictureBox pb) {
            pb.Image = FireGame_Raman.Properties.Resources.Loading_Bullet;
        }
        // spin the gun to start for shot or get ready to shoot
        public void revolve(PictureBox pb) {
            pb.Image = FireGame_Raman.Properties.Resources.startshoot;

        }
        public void fire(PictureBox pb) {
            pb.Image = FireGame_Raman.Properties.Resources.shootImage;
        }
    }
}
