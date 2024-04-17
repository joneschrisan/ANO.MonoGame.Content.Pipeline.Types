using System.Collections.Generic;

namespace ANO.MonoGame.Content.Pipeline.Types.Tiled
{
    public class TiledMapModel
    {
        public string Version { get; set; }
        public string TiledVersion {  get; set; }
        public string Orientation { get; set; }
        public string RenderOrder { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int TileWidth { get; set; }
        public int TileHeight { get; set; }
        public int Infinite { get; set; }
        public int NextLayerID { get; set; }
        public int NextObjectID { get; set; }
        public List<TiledMapTileset> TileSets { get; set; } = new List<TiledMapTileset>();
        public List<TiledMapLayer> Layers { get; set; } = new List<TiledMapLayer>();
        public TiledMapObjectGroup ObjectGroup { get; set; }
    }
}
