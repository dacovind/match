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

        public string _TexturePath { get; private set; }
        public Point TextureSize { get; private set; }
        public Color TextureColor { get; private set; }


        public ObjectSprite()
        {
            _TexturePath = "Tests/SpriteTestOne";
            TextureSize = new Point(100);
            TextureColor = Color.White;
        }

        public ObjectSprite(string aTexturePath, Point aTextureSize)
        {
            _TexturePath = aTexturePath;
            TextureSize = aTextureSize;
            TextureColor = Color.White;
        }

        public ObjectSprite(string aTexturePath, Point aTextureSize, Color aTextureColor)
        {
            _TexturePath = aTexturePath;
            TextureSize = aTextureSize;
            TextureColor = aTextureColor;
        }

        public void SetTexture(ContentManager aContentManager)
        {
            Texture = aContentManager.Load<Texture2D>(_TexturePath);
        }
    }
}
