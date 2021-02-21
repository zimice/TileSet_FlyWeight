using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileSetPoPrasacku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] tileNames =
            {
                 {"rock","sand", "grass",  "sand","sand","grass","sand","sand","grass","rock"}
                ,{"sand","grass", "sand",  "sand","rock","sand","sand","sand","sand","sand"}
                ,{"sand","grass", "sand",  "sand","sand","sand","sand","sand","sand","sand"}
                ,{"sand","grass", "sand",  "sand","sand","sand","sand","grass","sand","sand"}
                ,{"sand","rock", "water",  "sand","grass","rock","sand","sand","rock","sand"}
                ,{"sand","sand", "sand",  "sand","sand","sand","grass","sand","sand","sand"}
                ,{"sand","grass", "rock",  "sand","grass","sand","sand","sand","sand","sand"}
                ,{"sand","sand", "sand",  "sand","sand","sand","sand","sand","sand","sand"}
                ,{"rock","sand", "sand",  "sand","sand","rock","grass","sand","sand","sand"}
                ,{"sand","grass", "sand",  "sand","sand","rock","sand","sand","rock","grass"}
            };
            
            mapa = new Mapa(tileNames);
            this.trackBar1.Maximum = tileNames.GetLength(0) - tilesOnScreenX;
            this.trackBar2.Maximum = tileNames.GetLength(1) - tilesOnScreenY;
            DrawMap();
        }
        private enum tiles {grass,sand,rock,water}
        private String[,] randomizeMap(int x, int y) {
            String[,] tileNames = new String[x,y];
            Array values = Enum.GetValues(typeof(tiles));
            Random random = new Random();
            for(int i=0;i<x;i++)
                for(int d=0;d<y;d++)
                    tileNames[x,y] = ((tiles)values.GetValue(random.Next(values.Length))).ToString();


            return tileNames;
        }
        private void DrawMap()
        {
            this.pictureBox1.Image = mapa.GetMap(trackBar1.Value, trackBar2.Value, tilesOnScreenX, tilesOnScreenY);
        }

        int tilesOnScreenX = 5;
        int tilesOnScreenY = 5;
        Mapa mapa;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DrawMap();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            DrawMap();
        }
    }
}
