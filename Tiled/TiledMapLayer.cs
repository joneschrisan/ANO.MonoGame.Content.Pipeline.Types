using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANO.MonoGame.Content.Pipeline.Types.Tiled
{
    public class TiledMapLayer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Width {  get; set; }
        public int Height { get; set; }
        public List<TiledMapLayerData> Data { get; set; } = new List<TiledMapLayerData>();
    }
}
