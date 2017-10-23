using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace stg
{
    class Shot
    {
        private Image ShotImg;

        public Shot()
        {
            ShotImg = new Bitmap(@"C:\Users\hosomi\Desktop\SP\shot.png");
            
        }

        public void S(Graphics g)
        {
            if ((Keyboard.GetKeyStates(Key.Z) & KeyStates.Down) > 0)
            {
                g.DrawImage(ShotImg, x, y, ShotImg.Width, ShotImg.Height);

            }

        }

    }
}
