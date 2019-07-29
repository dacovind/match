using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MatchThree
{
    public class Board : GameObject
    {
        public ObjectSprite Sprite { get; private set; }

        public override float Width { get => Sprite.Width * Scale.X; }
        public override float Height { get => Sprite.Height * Scale.Y; }

        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public float CaseWidth { get => Width / Columns; }
        public float CaseHeight { get => Height / Rows; }

        public List<Tile> Tiles { get; }

        public Board()
        {
            Sprite = new ObjectSprite();

            Position = Vector2.Zero;
            Layer = 0F;

            Rows = 10;
            Columns = 10;

            Tiles = new List<Tile>();
        }

        public Board(ObjectSprite sprite, Vector2 position, float layer, int rows, int columns)
        {
            Sprite = sprite;

            Position = position;
            Layer = layer;

            Rows = rows;
            Columns = columns;

            Tiles = new List<Tile>();
        }

        public override void LoadContent(ContentManager aContentManager)
        {
            Sprite.SetTexture(aContentManager);
        }

        public void FillBoard(Dictionary<string, int> tileWeights)
        {
            Random tileFactory = new Random(1);

            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    Dictionary<string, int> sanitisedTileWeights = new Dictionary<string, int>(tileWeights);

                    string chosenType = null;
                    int totalValue = 0;
                    int randomValue = 0;

                    if (Tiles.FirstOrDefault(x => x.CasePosition.X == c - 2 && x.CasePosition.Y == r) != null)
                        RandomiserUtilities.RemoveWeightIfPossibleTileMatch(ref sanitisedTileWeights,
                                                                            Tiles.FirstOrDefault(x => x.CasePosition.X == c - 1 && x.CasePosition.Y == r).Type,
                                                                            Tiles.FirstOrDefault(x => x.CasePosition.X == c - 2 && x.CasePosition.Y == r).Type);

                    if (Tiles.FirstOrDefault(y => y.CasePosition.Y == r - 2 && y.CasePosition.X == c) != null)
                        RandomiserUtilities.RemoveWeightIfPossibleTileMatch(ref sanitisedTileWeights,
                                                                            Tiles.FirstOrDefault(y => y.CasePosition.Y == r - 1 && y.CasePosition.X == c).Type,
                                                                            Tiles.FirstOrDefault(y => y.CasePosition.Y == r - 2 && y.CasePosition.X == c).Type);

                    RandomiserUtilities.RemoveWeightIfBelowOne(ref sanitisedTileWeights);

                    randomValue = tileFactory.Next(1, sanitisedTileWeights.Values.Sum());


                    foreach(var weight in sanitisedTileWeights)
                    {
                        totalValue += weight.Value;

                        if(totalValue >= randomValue && chosenType == null)
                        {
                            chosenType = weight.Key;

                            tileWeights[weight.Key] -= tileWeights.Count - 1;
                        }
                        else
                        {
                            tileWeights[weight.Key]++;
                        }
                    }

                    Tile tile = new Tile(XmlUtilities.GetTileSpriteFromType(chosenType), 0.5F, new Point(c, r), chosenType, this);
                    Tiles.Add(tile);
                }
            }


            //    }
            //}
        }
    }
}
