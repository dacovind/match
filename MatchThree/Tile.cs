using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchThree
{
    public class Tile
    {

        /* PROPERTIES */

        public Texture2D Texture { get; private set; }
        public string _Path { get; private set; }

        public Color Tint { get; private set; }

        public Vector2 Position { get; private set; }
        public Vector2 Origin { get; private set; }
        public Vector2 Scale { get; private set; }

        public float Layer { get; private set; }

        /* CONSTRUCTORS */

        public Tile()
        {
            _Path = "Tiles/TestTile";

            Tint = Color.White;

            Position = Vector2.Zero;
            Origin = Vector2.Zero;
            Scale = Vector2.One;

            Layer = 0F;
        }

        /* METHODS */

        public void LoadTile(ContentManager aContentManager)
        {
            Texture = aContentManager.Load<Texture2D>(_Path);
        }

        public void DrawTile(SpriteBatch aSpriteBatch)
        {
            aSpriteBatch.Draw(
                Texture,
                Position,
                null,
                Tint,
                0F,
                Origin,
                Scale,
                SpriteEffects.None,
                Layer);
        }
    }
}
