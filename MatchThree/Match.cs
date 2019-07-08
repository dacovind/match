using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MatchThree
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Match : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Tile tile;
        Board board;
        ObjectSprite boardSprite;
        ObjectSprite tileSprite;

        public Match()
        {
            graphics = new GraphicsDeviceManager(this);
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

            boardSprite = new ObjectSprite("Boards/BoardTest", new Point(300));
            tileSprite = new ObjectSprite("Tiles/TileTest", new Point(100));

            board = new Board(boardSprite, new Vector2(50), 1F, new Point(6));
            tile = new Tile(board, tileSprite, new Vector2(100), 2F);

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
            tile.LoadContent(Content);     
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

            tile.Update(gameTime);



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
            spriteBatch.Draw(board.Sprite.Texture, board.Position, null, board.Sprite.TextureColor, 0, board.Origin, board.Scale, SpriteEffects.None, board.Layer);
            spriteBatch.Draw(tile.Sprite.Texture, tile.Position, null, tile.Sprite.TextureColor, 0, tile.Origin, tile.Scale, SpriteEffects.None, tile.Layer);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
