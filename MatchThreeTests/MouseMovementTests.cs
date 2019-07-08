using MatchThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;

namespace MatchThreeTests
{
    [TestClass]
    public class MouseMovementTests
    {

        [TestMethod]
        public void MouseDragTile()
        {
            Tile tile = new Tile();

            Vector2 expectedPosition = new Vector2(150F);

            tile.MoveToPosition(expectedPosition);

            Assert.AreEqual(expectedPosition, tile.Position);
        }
    }
}
