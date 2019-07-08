using MatchThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MatchThreeTests
{
    [TestClass]
    public class VectorCalculationTests
    {

        Tile tile;


        [TestInitialize]
        public void Initialise()
        {
            tile = new Tile(new Board(), new ObjectSprite(), new Vector2(100F), 0F );
        }

        [TestMethod]
        public void GetSizeOfTile()
        {
            Vector2 expectedSize = new Vector2(100F);

            Assert.AreEqual(expectedSize, tile.Size);
        }


        [TestMethod]
        public void GetMiddleOfTile()
        {
            Tile tile = new Tile();
            Vector2 expectedPosition = new Vector2(50F);
            Vector2 actualPosition = tile.Origin;

            Assert.AreEqual(expectedPosition, actualPosition);
        }
    }
}
