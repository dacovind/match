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
    public class Board : GameObject
    {
        public ObjectSprite Sprite { get; private set; }
        public override Vector2 Size { get => new Vector2(Sprite.TextureSize.X * Scale.X, Sprite.TextureSize.Y * Scale.Y); }

        public Point SquarePer { get; private set; }

        public Vector2 SquareSize { get => new Vector2(Size.X / SquarePer.X, Size.Y / SquarePer.Y); }

        public Board()
        {
            Sprite = new ObjectSprite();

            Position = Vector2.Zero;
            Layer = 0F;
            SquarePer = new Point(10);
        }

        public Board(ObjectSprite aSprite, Vector2 aPosition, float aLayer, Point aSquarePer)
        {
            Sprite = aSprite;

            Position = aPosition;
            Layer = aLayer;
            SquarePer = aSquarePer;
        }

        public override void LoadContent(ContentManager aContentManager)
        {
            Sprite.SetTexture(aContentManager);
        }
    }
}
