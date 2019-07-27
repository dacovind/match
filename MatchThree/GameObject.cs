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
        public Vector2 Position { get; set; }
        public float Layer { get; set; }

        public virtual Vector2 Scale { get => Vector2.One; }
        public virtual Vector2 Origin { get => Vector2.Zero; }
        public virtual Vector2 TruePosition { get => new Vector2(Position.X - Origin.X, Position.Y - Origin.Y); }

        public virtual float Width { get => 1F * Scale.X; }
        public virtual float Height { get => 1F * Scale.Y; }

        public virtual void LoadContent(ContentManager aContentManager) { }
        public virtual void Draw(GameTime aGameTime) { }
        public virtual void Update(GameTime aGameTime) { }

    }
}
