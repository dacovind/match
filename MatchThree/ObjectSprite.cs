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
    public class ObjectSprite
    {
        public Texture2D Texture { get; private set; }

        public string _Path { get; private set; }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public Color Tint { get; private set; }

        public ObjectSprite()
        {
            _Path = "Tests/SpriteTestOne";
            Tint = Color.White;

            Width = 100;
            Height = 100;
        }

        public ObjectSprite(string path, int width, int height)
        {
            _Path = path;

            Width = width;
            Height = height;

            Tint = Color.White;
        }

        public ObjectSprite(string path, int width, int height, Color tint)
        {
            _Path = path;

            Width = width;
            Height = height;

            Tint = tint;
        }

        public void SetTexture(ContentManager aContentManager)
        {
            Texture = aContentManager.Load<Texture2D>(_Path);
        }
    }
}
