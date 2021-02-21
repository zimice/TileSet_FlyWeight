using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kochanek_TileSet
{
    public class TileFactory
    {
        private Dictionary<string, Tile> tiles = new Dictionary<string, Tile>();

        public Tile getTile(string key)
        {
            key = key.ToLower();
            Tile tile = null;

            if (tiles.ContainsKey(key))
                return tiles[key];

            switch (key)
            {

                case "grass":
                    {
                        tile = new TileGrass();
                        break;
                    }
                case "rock":
                    {
                        tile = new TileRock();
                        break;
                    }
                case "sand":
                    {
                        tile = new TileSand();
                        break;
                    }
                case "water": {
                        tile = new TileWater();
                        break;
                    }
            }
            tiles.Add(key, tile);
            return tile;
        }

    }
}
