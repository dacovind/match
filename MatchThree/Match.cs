using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MatchThree
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Match : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Board board;

        Dictionary<string, int> tileWeights;

        public Match()
        {
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1280,
                PreferredBackBufferHeight = 720
            };

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            IsMouseVisible = true;

            // TODO: Add your initialization logic here

            tileWeights = new Dictionary<string, int>();
            for (int i = 1; i <= 6; i++)
                tileWeights.Add(XmlUtilities.GetTileTypeFromID(i), 30);

            board = XmlUtilities.GetBoardFromID(1);

            board.FillBoard(tileWeights);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            board.LoadContent(Content);

            foreach(Tile tile in board.Tiles)
            {
                tile.LoadContent(Content);
            }

           // tile.LoadContent(Content);     
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            foreach (Tile tile in board.Tiles)
            {
                tile.Update(gameTime);
            }



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            spriteBatch.Draw(board.Sprite.Texture, board.Position, null, board.Sprite.Tint, 0, board.Origin, board.Scale, SpriteEffects.None, board.Layer);
            //spriteBatch.Draw(tile.Sprite.Texture, tile.Position, null, tile.Sprite.TextureColor, 0, tile.Origin, tile.Scale, SpriteEffects.None, tile.Layer);

            foreach (Tile tile in board.Tiles)
            {
                spriteBatch.Draw(tile.Sprite.Texture, tile.Position, null, tile.Sprite.Tint, 0, tile.Origin, tile.Scale, SpriteEffects.None, tile.Layer);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
