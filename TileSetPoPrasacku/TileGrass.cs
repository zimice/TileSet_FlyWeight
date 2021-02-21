using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kochanek_TileSet
{
    class TileGrass : Tile
    {
        public TileGrass() {
            fileName = "grass";
            bmp = new Bitmap($"Tiles\\{fileName}.png");
    }
    }
}
