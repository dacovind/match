using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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

        public MouseState CurrentMouseState { get; private set; }
        public MouseState PreviousMouseState { get; private set; }

        public Vector2 Position { get; private set; }
        public Vector2 Origin
        {
            get => new Vector2(
                Width  / 2,
                Height / 2);
        }
        public Vector2 Scale { get; private set; }
        public Vector2 TruePosition
        {
            get => new Vector2(
                Position.X - Origin.X, 
                Position.Y - Origin.Y);
        }
        public Vector2 CurrentMousePosition
        {
            get => new Vector2(
                CurrentMouseState.X, 
                CurrentMouseState.Y);
        }

        public Vector2 PreviousMousePosition
        {
            get => new Vector2(
                PreviousMouseState.X, 
                PreviousMouseState.Y);
        }

        public float Width
        {
            get => Texture.Width * Scale.X;
        }
        public float Height
        {
            get => Texture.Height * Scale.Y;
        }
        public float Layer { get; private set; }

        public bool IsDragging { get; protected set; }
        public bool IsLeftMouseButtonJustPressed
        {
            get => 
                PreviousMouseState.LeftButton == ButtonState.Released &&
                CurrentMouseState.LeftButton == ButtonState.Pressed;
        }

        public bool IsLeftMouseButtonHeld
        {
            get => 
                PreviousMouseState.LeftButton == ButtonState.Pressed &&
                CurrentMouseState.LeftButton == ButtonState.Pressed;
        }

        public bool IsLeftMouseButtonJustReleased
        {
            get => 
                PreviousMouseState.LeftButton == ButtonState.Pressed &&
                CurrentMouseState.LeftButton == ButtonState.Released;
        }

        public bool IsMouseOver
        {
            get => 
                (CurrentMouseState.Position.X >= TruePosition.X && 
                 CurrentMouseState.Position.X < TruePosition.X + Width) && 
                (CurrentMouseState.Position.Y >= TruePosition.Y && 
                 CurrentMouseState.Position.Y < TruePosition.Y + Height);
        }

        /* CONSTRUCTORS */

        public Tile()
        {
            _Path = "Tiles/TestTile";

            Tint = Color.White;

            Position = Vector2.Zero;
            Scale = Vector2.One;

            Layer = 0F;
        }

        /* METHODS */
        
        public void LoadTile(ContentManager aContentManager)
        {
            Texture = aContentManager.Load<Texture2D>(_Path);
        }

        public void Update(GameTime aGameTime)
        {
            CurrentMouseState = Mouse.GetState();

            if (IsMouseOver && IsLeftMouseButtonJustPressed)
                IsDragging = true;
            if (IsLeftMouseButtonJustReleased)
                IsDragging = false;

            if (IsDragging)
                Position = CurrentMousePosition;


            PreviousMouseState = CurrentMouseState;
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
