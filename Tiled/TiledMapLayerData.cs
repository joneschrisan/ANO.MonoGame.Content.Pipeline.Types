using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANO.MonoGame.Content.Pipeline.Types.Tiled
{
    public class TiledMapLayerData
    {
        public string Encoding { get; set; }
        public List<int> Tiles { get; set; } = new List<int>();
    }
}
