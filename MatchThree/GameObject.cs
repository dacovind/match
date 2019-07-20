using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchThree
{
    public abstract class GameObject
    {
        private Vector2 position;


        public Vector2 Position
        {
            get
            {
                return position;
            }
            set
            {
                position.X = value.X;
                position.Y = value.Y;
            }
        }
        public float Layer { get; set; }

        public virtual Vector2 Scale { get => Vector2.One; }
        public virtual Vector2 Size { get => Scale; }
        public virtual Vector2 Origin { get => Vector2.Zero; }
        public virtual Vector2 TruePosition { get => new Vector2(Position.X - Origin.X, Position.Y - Origin.Y); }

        public virtual void LoadContent(ContentManager aContentManager) { }
        public virtual void Draw(GameTime aGameTime) { }
        public virtual void Update(GameTime aGameTime) { }

    }
}
