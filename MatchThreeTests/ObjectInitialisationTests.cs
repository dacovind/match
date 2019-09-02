using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatchThree;
using Microsoft.Xna.Framework;

namespace MatchThree
{
    [TestClass]
    public class ObjectInitialisationTests
    {
        [TestMethod]
        public void InitialiseTile()
        {

            Tile tile = new Tile();

            Assert.AreEqual("Tiles/TestTile", tile._Path);
            Assert.AreEqual(Color.White, tile.Tint);
            Assert.AreEqual(Vector2.Zero, tile.Position);
            Assert.AreEqual(Vector2.One, tile.Scale);
            Assert.AreEqual(0F, tile.Layer);

        }
    }
}
