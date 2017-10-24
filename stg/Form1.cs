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
        private Player player2 = new Player(50,50);　//newはコンストラクタの中に移動したいがtimer1_tickでエラー

       

        public  Graphics g;

        

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           
            g = pictureBox1.CreateGraphics();    //グラフィック用オブジェクトを生成

            Timer1.Interval = 20;    //タイマー
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
