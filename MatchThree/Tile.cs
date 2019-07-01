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
        public Vector2 Scale { get; set; }
        public Color Color { get; set; }
        public float Layer { get; set; }

        public Vector2 Size { get => new Vector2(TextureSize.X * Scale.X, TextureSize.Y * Scale.Y); }
        public Vector2 Origin { get => new Vector2(Size.X / 2, Size.Y / 2); }
        public Vector2 TruePosition { get => new Vector2(Position.X - Origin.X, Position.Y - Origin.Y); }
        public bool IsMoving { get; private set; }

        public Tile()
        {
            _TexturePath = "Tiles/tileTest";
            TextureSize = new Point(100);
            Position = Vector2.Zero;
            Scale = Vector2.One;
            Color = Color.White;
            Layer = 1F;
        }

        public Tile(Vector2 aPosition)
        {
            _TexturePath = "Tiles/tileTest";
            TextureSize = new Point(100);
            Position = aPosition;
            Scale = Vector2.One;
            Color = Color.White;
            Layer = 1F;
        }

        public bool IsLeftClicked(Point aMousePosition, ButtonState aMouseLeftButtonState)
        {
            return (aMouseLeftButtonState == ButtonState.Pressed) &&
                   (aMousePosition.X >= TruePosition.X && aMousePosition.X < TruePosition.X + Size.X) &&
                   (aMousePosition.Y >= TruePosition.Y && aMousePosition.Y < TruePosition.Y + Size.Y);
        }

        public void MoveToPosition(Vector2 aPosition)
        {
            Position = aPosition;
        }

        public void LoadContent(ContentManager aContentManager)
        {
            Texture = aContentManager.Load<Texture2D>(_TexturePath);
        }

        public void Update(GameTime gameTime)
        {
            MouseState state = Mouse.GetState();

            if(IsLeftClicked(state.Position, state.LeftButton) && IsMoving == false)
            {
                IsMoving = true;
            }
            else if (state.LeftButton == ButtonState.Released && IsMoving)
            {
                IsMoving = false;
            }

            if (IsLeftClicked(state.Position, state.LeftButton) || IsMoving)
            {
                MoveToPosition(new Vector2(state.Position.X, state.Position.Y));
            }
        }
    }
}