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
        Vector2 tilePosition;
        Vector2 tileOrigin;
        Vector2 tileScale;
        Color tileColor;
        float tileLayer;


        /// <summary>
        /// Initialise a Tile object with no parameters.
        /// </summary>
        [TestMethod]
        public void InitialiseTile_NoParameters()
        {
            tileTexturePath = "Tiles/tileTest";
            tilePosition = Vector2.Zero;
            tileOrigin = Vector2.Zero;
            tileScale = Vector2.One;
            tileColor = Color.White;
            tileLayer = 1F;

            tile = new Tile();

            Assert.AreEqual(tileTexturePath, tile._TexturePath);
            Assert.AreEqual(tilePosition, tile.Position);
            Assert.AreEqual(tileOrigin, tile.Origin);
            Assert.AreEqual(tileScale, tile.Scale);
            Assert.AreEqual(tileColor, tile.Color);
            Assert.AreEqual(tileLayer, tile.Layer);
        }
    }
}
