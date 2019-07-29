using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MatchThree
{
    public static class XmlUtilities
    {
        public static Board GetBoardFromID(int anID)
        {
            XElement boardTypes = XElement.Load("XML/BoardTypes.xml");

            XElement boardInfo = boardTypes.Elements().First(i => int.Parse(i.Element("id").Value) == anID);

            ObjectSprite boardSprite = new ObjectSprite(boardInfo.Element("path").Value,
                                                        int.Parse(boardInfo.Element("width").Value),
                                                        int.Parse(boardInfo.Element("height").Value));

            Board board = new Board(boardSprite,
                                    new Vector2(32),
                                    1F,
                                    int.Parse(boardInfo.Element("rows").Value),
                                    int.Parse(boardInfo.Element("columns").Value));

            return board;
        }

        public static ObjectSprite GetTileSpriteFromID(int id)
        {
            XElement tileTypes = XElement.Load("XML/TileTypes.xml");

            XElement tileInfo = tileTypes.Elements().First(i => int.Parse(i.Element("id").Value) == id);

            ObjectSprite tileSprite = new ObjectSprite(tileInfo.Element("path").Value,
                                                       int.Parse(tileInfo.Element("width").Value),
                                                       int.Parse(tileInfo.Element("height").Value));

            return tileSprite;
        }

        public static string GetTileTypeFromID(int id)
        {
            XElement tileTypes = XElement.Load("XML/TileTypes.xml");
            XElement tileInfo = tileTypes.Elements().First(i => int.Parse(i.Element("id").Value) == id);

            string tileType = tileInfo.Element("type").Value;

            return tileType;
        }

        internal static ObjectSprite GetTileSpriteFromType(string type)
        {
            XElement tileTypes = XElement.Load("XML/TileTypes.xml");

            XElement tileInfo = tileTypes.Elements().First(i => i.Element("type").Value == type);

            ObjectSprite tileSprite = new ObjectSprite(tileInfo.Element("path").Value,
                                                       int.Parse(tileInfo.Element("width").Value),
                                                       int.Parse(tileInfo.Element("height").Value));

            return tileSprite;
        }
    }
}
