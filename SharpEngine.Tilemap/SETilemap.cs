using SharpEngine.Core.Manager;

namespace SharpEngine.Tilemap;

/// <summary>
/// Static class with extensions and add version functions
/// </summary>
public static class SETilemap
{
    /// <summary>
    /// Add versions to DebugManager
    /// </summary>
    public static void AddVersions()
    {
        DebugManager.Versions.Add("SharpEngine.Tilemap", "1.0.0");
    }
}