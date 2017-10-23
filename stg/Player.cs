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
    class Player
    { 

        public int x;
        public int y;               //自機の座標


        private Image CharImg;

        public Player(int x1,int y1)
        {
            CharImg = new Bitmap(@"C:\Users\hosomi\Desktop\SP\char.JPEG");
            x =x1;
            y =y1;     
        }

        


        public void P(Graphics g)
        {
          
                
            

                if ((Keyboard.GetKeyStates(Key.Right) & KeyStates.Down) > 0)
                {
                    x += 2;

                }


                if ((Keyboard.GetKeyStates(Key.Left) & KeyStates.Down) > 0)
                {
                    x -= 2;

                }

                if ((Keyboard.GetKeyStates(Key.Up) & KeyStates.Down) > 0)
                {
                    y -= 2;

                }

                if ((Keyboard.GetKeyStates(Key.Down) & KeyStates.Down) > 0)
                {
                    y += 2;

                }

                

            g.DrawImage(CharImg, x, y, CharImg.Width, CharImg.Height);

        }
    }
}
