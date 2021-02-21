using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kochanek_TileSet
{
    class TileWater : Tile
    {
        public TileWater()
        {
            fileName = "water";
            bmp = new Bitmap($"Tiles\\{fileName}.png");
        }
    }
}
