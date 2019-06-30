using Microsoft.Xna.Framework;

namespace MatchThree
{
    public class Tile
    {
        public string _TexturePath { get; private set; }
        public Vector2 Position { get; set; }
        public Vector2 Origin { get; set; }
        public Vector2 Scale { get; set; }
        public Color Color { get; set; }
        public float Layer { get; set; }

        public Tile()
        {
            _TexturePath = "Tiles/tileTest";
            Position = Vector2.Zero;
            Origin = Vector2.Zero;
            Scale = Vector2.One;
            Color = Color.White;
            Layer = 1F;
        }
    }
}