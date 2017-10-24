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
        private Image shotImg;
        private Graphics copyg;
        private int shotx, shoty;

        public  Shot()    //1回のみ呼ぶ　static使いたいがエラーでる
        {
            shotImg = new Bitmap(@"image\shot.png");//要確認
            copyg = g;
            //タイマー作成
           

        }

        public void S()
        {
            shoty++;
            copyg.DrawImage(shotImg, shotx, shoty, shotImg.Width, shotImg.Height);
            //タイマー使用
            //ifでメモリ解放条件はyの座標
        }

    }
}
