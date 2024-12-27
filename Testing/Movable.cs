using SharpEngine.Core.Component;
using SharpEngine.Core.Entity;
using SharpEngine.Core.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Movable: Entity
    {
        public Movable()
        {
            AddComponent(new TransformComponent(Vec2.Zero));
            AddComponent(new ControlComponent());
            AddComponent(new SpriteComponent("tile1"));
        }
    }
}
