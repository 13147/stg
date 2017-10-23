using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stg
{
    public partial class Form1 : Form
    {
        private Player player1 = new Player(0,0);
        private Player player2 = new Player(50,50);

        private Shot shot = new Shot();

        public  Graphics g;

        

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            //グラフィック用オブジェクトを生成
            g = pictureBox1.CreateGraphics();


            //画像読み込み
           
            

            //タイマー
            Timer1.Interval = 20;
            Timer1.Enabled = true;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            

            

            g.Clear(Color.White);

            player1.P(g);
            player2.P(g);


        }

    }
}
