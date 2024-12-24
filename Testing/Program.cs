using SharpEngine.Core;
using SharpEngine.Core.Manager;
using SharpEngine.Core.Utils;
using SharpEngine.Tilemap;

namespace Testing;

internal static class Program
{
    private static void Main()
    {
        SETilemap.AddVersions();

        var window = new Window(1280, 920, "SE Tilemap", Color.CornflowerBlue, null, true, true, true);
        
        window.AddScene(new MyScene());
        
        window.Run();
    }
}