using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MatchThree
{
    class Board
    {
        public Texture2D Texture { get; private set; }

        public string _TexturePath { get; private set; }
        public Point TextureSize { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Scale { get; set; }
        public Color Color { get; set; }
        public float Layer { get; set; }

        public Vector2 Origin { get => Vector2.Zero; }

        public Board()
        {
            _TexturePath = "Boards/boardTest";
            TextureSize = new Point(100);
            Position = Vector2.Zero;
            Scale = Vector2.One;
            Color = Color.White;
            Layer = 1F;
        }

        public void LoadContent(ContentManager aContentManager)
        {
            Texture = aContentManager.Load<Texture2D>(_TexturePath);
        }
    }
}
