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
        
        public  Shot(Graphics g)    //1回のみ呼ぶ　static使いたいがエラーでる
        {
            ShotImg = new Bitmap(@"image\shot.png");//要確認
            //copygの生成
            //タイマー作成
            
        }

        public void S()
        {
            //y++
            g.DrawImage(ShotImg, x, y, ShotImg.Width, ShotImg.Height);
            //タイマー使用
            //ifでメモリ解放条件はyの座標
        }

    }
}
