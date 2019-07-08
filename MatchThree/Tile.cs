﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MatchThree
{
    public class Tile : GameObject
    {
        public Board PlayingBoard { get; }

        public ObjectSprite Sprite { get; private set; }

        public override Vector2 Size { get => new Vector2(Sprite.TextureSize.X * Scale.X, Sprite.TextureSize.Y * Scale.Y); }
        public override Vector2 Origin { get => new Vector2(Size.X / 2, Size.Y / 2); }

        public bool IsMoving { get; private set; }


        public Tile()
        {
            PlayingBoard = new Board();

            Sprite = new ObjectSprite();

            Position = Vector2.Zero;
            Layer = 0F;
        }

        public Tile(Board aBoard, ObjectSprite aSprite, Vector2 aPosition, float aLayer)
        {
            PlayingBoard = aBoard;
            Sprite = aSprite;
            Position = aPosition;
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

        public override void LoadContent(ContentManager aContentManager)
        {
            Sprite.SetTexture(aContentManager);
        }

        public override void Update(GameTime gameTime)
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