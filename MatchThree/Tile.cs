using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MatchThree
{
    public class Tile
    {
        public Texture2D Texture { get; private set; }

        public string _TexturePath { get; private set; }
        public Point TextureSize { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Origin { get; set; }
        public Vector2 Scale { get; set; }
        public Color Color { get; set; }
        public float Layer { get; set; }

        public Vector2 Size => new Vector2(TextureSize.X * Scale.X, TextureSize.Y * Scale.Y); 

        public Tile()
        {
            _TexturePath = "Tiles/tileTest";
            TextureSize = new Point(100);
            Position = Vector2.Zero;
            Origin = Vector2.Zero;
            Scale = Vector2.One;
            Color = Color.White;
            Layer = 1F;
        }

        public bool IsLeftClicked(Point aMousePosition, ButtonState aMouseLeftButtonState)
        {
            return (aMouseLeftButtonState == ButtonState.Pressed) &&
                   (aMousePosition.X >= Position.X && aMousePosition.X < Position.X + Size.X) &&
                   (aMousePosition.Y >= Position.Y && aMousePosition.Y < Position.Y + Size.Y);
        }

        public void LoadContent(ContentManager aContentManager)
        {
            Texture = aContentManager.Load<Texture2D>(_TexturePath);
        }

        public void Update(GameTime gameTime)
        {
            MouseState state = Mouse.GetState();

            if(IsLeftClicked(state.Position, state.LeftButton))
            {
                Debug.WriteLine("SELECT " + gameTime.TotalGameTime);
            }
        }
    }
}