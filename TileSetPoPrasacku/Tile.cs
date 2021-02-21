using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kochanek_TileSet
{
    public abstract class Tile
    {
        protected String fileName;
        protected Bitmap bmp;
        public Bitmap getBMP()
        {
            return bmp;
        }
    }
    
}
