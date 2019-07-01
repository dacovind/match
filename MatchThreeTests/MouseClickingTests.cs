using System;
using MatchThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace MatchThreeTests
{
    [TestClass]
    public class MouseClickingTests
    {
        Tile tile;

        Point mousePosition;
        ButtonState mouseLeftButtonState;

        [TestInitialize]
        public void Initialise()
        {
        }

        [TestMethod]
        public void ClickTile()
        {
            mousePosition = new Point(50, 50);
            mouseLeftButtonState = ButtonState.Pressed;

            tile = new Tile();

            Assert.IsTrue(tile.IsLeftClicked(mousePosition, mouseLeftButtonState));
        }
    }
}
