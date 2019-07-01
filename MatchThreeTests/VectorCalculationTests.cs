using MatchThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MatchThreeTests
{
    [TestClass]
    public class VectorCalculationTests
    {
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
