using System;
using MatchThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;

namespace MatchThreeTests
{
    [TestClass]
    public class ObjectInitialisationTests
    {
        Tile tile;

        string tileTexturePath;
        Point tileTextureSize;
        Vector2 tilePosition;
        Vector2 tileScale;
        Color tileColor;
        float tileLayer;

        [TestInitialize]
        public void Initialise()
        {

        }

        /// <summary>
        /// Initialise a Tile object with no parameters, and check if the drawing properties are set up properly.
        /// </summary>
        [TestMethod]
        public void InitialiseTile_NoParameters_CheckDrawProperties()
        {
            tileTexturePath = "Tiles/tileTest";
            tileTextureSize = new Point(100);
            tilePosition = Vector2.Zero;
            tileScale = Vector2.One;
            tileColor = Color.White;
            tileLayer = 1F;

            tile = new Tile();

            Assert.AreEqual(tileTexturePath, tile._TexturePath);
            Assert.AreEqual(tileTextureSize, tile.TextureSize);
            Assert.AreEqual(tilePosition, tile.Position);
            Assert.AreEqual(tileScale, tile.Scale);
            Assert.AreEqual(tileColor, tile.Color);
            Assert.AreEqual(tileLayer, tile.Layer);
        }

    }
}
