using System;
using MatchThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;

namespace MatchThreeTests
{
    [TestClass]
    public class ObjectInitialisationTests
    {
        ObjectSprite sprite;
        Board board;
        Tile tile;

        string expectedTexturePath;
        Point expectedTextureSize;
        Color expectedTextureColor;

        Vector2 expectedPosition;
        float expectedLayer;

        Point expectedSquarePer;

        /// <summary>
        /// Initialise a sprite object with no parameters, then check if the default values are 
        /// set properly.
        /// </summary>
        [TestMethod]
        public void InitialiseSprite_NoParameters()
        {
            //expectedTexturePath = "Tests/SpriteTestOne";
            //expectedTextureSize = new Point(100);
            //expectedTextureColor = Color.White;

            //sprite = new ObjectSprite();

            //Assert.AreEqual(expectedTexturePath, sprite._TexturePath);
            //Assert.AreEqual(expectedTextureSize, sprite.TextureSize);
            //Assert.AreEqual(expectedTextureColor, sprite.TextureColor);
        }

        /// <summary>
        /// Initialise a sprite object with texture path and texture size parameters, then check if 
        /// the given and default values are set properly.
        /// </summary>
        [TestMethod]
        public void InitialiseSprite_PathAndSizeParameters()
        {
            //expectedTexturePath = "Tests/SpriteTestTwo";
            //expectedTextureSize = new Point(50);
            //expectedTextureColor = Color.White;

            //sprite = new ObjectSprite("Tests/SpriteTestTwo",
            //                          new Point(50));

            //Assert.AreEqual(expectedTexturePath, sprite._TexturePath);
            //Assert.AreEqual(expectedTextureSize, sprite.TextureSize);
            //Assert.AreEqual(expectedTextureColor, sprite.TextureColor);
        }

        /// <summary>
        /// Initialise a sprite object with all parameters, then check if the given values are 
        /// set properly.
        /// </summary>
        [TestMethod]
        public void InitialiseSprite_AllParameters()
        {
            //expectedTexturePath = "Tests/SpriteTestThree";
            //expectedTextureSize = new Point(20);
            //expectedTextureColor = new Color(255,255,255,127);

            //sprite = new ObjectSprite("Tests/SpriteTestThree",
            //                          new Point(20), 
            //                          new Color(255,255,255,127));

            //Assert.AreEqual(expectedTexturePath, sprite._TexturePath);
            //Assert.AreEqual(expectedTextureSize, sprite.TextureSize);
            //Assert.AreEqual(expectedTextureColor, sprite.TextureColor);
        }

        [TestMethod]
        public void InitialiseBoard_NoParameters()
        {
            //expectedTexturePath = "Tests/SpriteTestOne";
            //expectedTextureSize = new Point(100);
            //expectedTextureColor = Color.White;

            //expectedPosition = Vector2.Zero;
            //expectedLayer = 0F;
            //expectedSquarePer = new Point(10);

            //board = new Board();

            //Assert.AreEqual(expectedTexturePath, board.Sprite._TexturePath);
            //Assert.AreEqual(expectedTextureSize, board.Sprite.TextureSize);
            //Assert.AreEqual(expectedTextureColor, board.Sprite.TextureColor);

            //Assert.AreEqual(expectedPosition, board.Position);
            //Assert.AreEqual(expectedLayer, board.Layer);
            //Assert.AreEqual(expectedSquarePer, board.Squares);
        }

        [TestMethod]
        public void InitialiseBoard_AllParameters()
        {
            //expectedTexturePath = "Boards/BoardTest";
            //expectedTextureSize = new Point(300);
            //expectedTextureColor = Color.White;

            //expectedPosition = new Vector2 (50);
            //expectedLayer = 1F;
            //expectedSquarePer = new Point(6);

            //sprite = new ObjectSprite("Boards/BoardTest", new Point(300));
            //board = new Board(sprite, new Vector2(50), 1F, new Point(6));

            //Assert.AreEqual(expectedTexturePath, board.Sprite._TexturePath);
            //Assert.AreEqual(expectedTextureSize, board.Sprite.TextureSize);
            //Assert.AreEqual(expectedTextureColor, board.Sprite.TextureColor);

            //Assert.AreEqual(expectedPosition, board.Position);
            //Assert.AreEqual(expectedLayer, board.Layer);
            //Assert.AreEqual(expectedSquarePer, board.Squares);
        }

        /// <summary>
        /// Initialise a Tile object with no parameters, and check if the drawing properties are set up properly.
        /// </summary>
        //[TestMethod]
        //public void InitialiseTile_NoParameters_CheckDrawProperties()
        //{
        //    tileTexturePath = "Tiles/tileTest";
        //    tileTextureSize = new Point(100);
        //    tilePosition = Vector2.Zero;
        //    tileScale = Vector2.One;
        //    tileColor = Color.White;
        //    tileLayer = 1F;

        //    tile = new Tile();

        //    Assert.AreEqual(tileTexturePath, tile._TexturePath);
        //    Assert.AreEqual(tileTextureSize, tile.TextureSize);
        //    Assert.AreEqual(tilePosition, tile.Position);
        //    Assert.AreEqual(tileScale, tile.Scale);
        //    Assert.AreEqual(tileColor, tile.Color);
        //    Assert.AreEqual(tileLayer, tile.Layer);
        //}

    }
}
