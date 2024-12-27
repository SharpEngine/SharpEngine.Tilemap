using SharpEngine.Core;
using SharpEngine.Core.Component;
using SharpEngine.Core.Entity;
using SharpEngine.Tilemap;

namespace Testing;

public class MyScene: Scene
{
    public MyScene()
    {
        var m1 = new Movable();
        AddEntity(m1);

        var entity = new Entity();
        entity.AddComponent(new TransformComponent(new SharpEngine.Core.Math.Vec2(200), new SharpEngine.Core.Math.Vec2(4)));
        entity.AddComponent(new TilemapComponent("Resource/tilemap.json"));
        AddEntity(entity);
    }
}