using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MatchThree
{
    public class Tile : GameObject
    {
        public ObjectSprite Sprite { get; private set; }

        public override float Width { get => Sprite.Width * Scale.X; }
        public override float Height { get => Sprite.Height * Scale.Y; }
        public override Vector2 Origin { get => new Vector2(Width / 2, Height / 2); }

        public Point CasePosition { get; private set; }

        public Board ActiveBoard { get; }

        public bool IsMoving { get; private set; }

        public string Type { get; private set; }


        public Tile()
        {
            Sprite = new ObjectSprite();

            Position = Vector2.Zero;
            Layer = 0F;

            CasePosition = Point.Zero;

            ActiveBoard = new Board();
        }

        public Tile(ObjectSprite sprite, Vector2 position, float layer, Point casePosition, Board board)
        {
            Sprite = sprite;

            Position = position;
            Layer = layer;

            CasePosition = casePosition;

            ActiveBoard = board;
        }

        public Tile(ObjectSprite sprite, float layer, Point casePosition, string type, Board board)
        {
            Sprite = sprite;

            Layer = layer;

            CasePosition = casePosition;
            Type = type;

            ActiveBoard = board;

            Position = new Vector2(ActiveBoard.Position.X + (ActiveBoard.CaseWidth * CasePosition.X) + Origin.X,
                                   ActiveBoard.Position.Y + (ActiveBoard.CaseHeight * CasePosition.Y) + Origin.Y);
        }


        public bool IsLeftClicked(Point mousePosition, ButtonState mouseLeftButtonState)
        {
            return (mouseLeftButtonState == ButtonState.Pressed) &&
                   (mousePosition.X >= TruePosition.X && mousePosition.X < TruePosition.X + Width) &&
                   (mousePosition.Y >= TruePosition.Y && mousePosition.Y < TruePosition.Y + Height);
        }

        public void MoveToPosition(Vector2 position)
        {
            Vector2 newPosition = position;

            if (position.X < ActiveBoard.Position.X)
            {
                newPosition.X = ActiveBoard.Position.X;
            }
            else if (position.X >= ActiveBoard.Position.X + ActiveBoard.Width)
            {
                newPosition.X = ActiveBoard.Position.X + ActiveBoard.Width - 1;
            }
            else
            {
                newPosition.X = position.X;
            }

            if (position.Y < ActiveBoard.Position.Y)
            {
                newPosition.Y = ActiveBoard.Position.Y;
            }
            else if (position.Y >= ActiveBoard.Position.Y + ActiveBoard.Height)
            {
                newPosition.Y = ActiveBoard.Position.Y + ActiveBoard.Height - 1;
            }
            else
            {
                newPosition.Y = position.Y;
            }

            Position = newPosition;
        }





        public override void LoadContent(ContentManager aContentManager)
        {
            Sprite.SetTexture(aContentManager);
        }

        public override void Update(GameTime gameTime)
        {
            // Update the current mouse state.
            CurrentMouseState = Mouse.GetState();

            if (IsHovered && IsLeftMouseButtonPressed)
                IsMoving = true;
            if (IsLeftMouseButtonReleased)
                IsMoving = false;

            if ((IsLeftMouseButtonPressed || IsLeftMouseButtonHeld) && IsMoving)
                MoveToPosition(CurrentMousePosition);

            // The current mouse state becomes the previous mouse state for the next tick.
            PreviousMouseState = CurrentMouseState;

            //if(IsLeftClicked(state.Position, state.LeftButton) && IsMoving == false)
            //{
            //    IsMoving = true;
            //}
            //else if (state.LeftButton == ButtonState.Released && IsMoving)
            //{
            //    IsMoving = false;
            //}

            //if (IsLeftClicked(state.Position, state.LeftButton) || IsMoving)
            //{
            //    MoveToPosition(new Vector2(state.Position.X, state.Position.Y));
            //}
        }


        //---------

        public MouseState PreviousMouseState { get; private set; }
        public MouseState CurrentMouseState { get; private set; }

        public bool IsLeftMouseButtonPressed
        {
            get => PreviousMouseState.LeftButton == ButtonState.Released &&
                   CurrentMouseState.LeftButton == ButtonState.Pressed;
        }

        public bool IsLeftMouseButtonHeld
        {
            get => PreviousMouseState.LeftButton == ButtonState.Pressed &&
                   CurrentMouseState.LeftButton == ButtonState.Pressed;
        }

        public bool IsLeftMouseButtonReleased
        {
            get => PreviousMouseState.LeftButton == ButtonState.Pressed &&
                   CurrentMouseState.LeftButton == ButtonState.Released;
        }

        public Vector2 PreviousMousePosition
        {
            get => new Vector2(PreviousMouseState.X, PreviousMouseState.Y);
        }

        public Vector2 CurrentMousePosition
        {
            get => new Vector2(CurrentMouseState.X, CurrentMouseState.Y);
        }

        public Vector2 MouseMovement
        {
            get => CurrentMousePosition - PreviousMousePosition;
        }


        public bool IsHovered
        {
            get => (CurrentMousePosition.X >= TruePosition.X && CurrentMousePosition.X < TruePosition.X + Width) &&
                   (CurrentMousePosition.Y >= TruePosition.Y && CurrentMousePosition.Y < TruePosition.Y + Height);
        }
    }
}