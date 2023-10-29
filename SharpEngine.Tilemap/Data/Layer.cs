using System.Collections.Generic;

namespace SharpEngine.Tilemap.Data;

/// <summary>
/// Class with represents Layer of Map
/// </summary>
public class Layer
{
    /// <summary>
    /// List of Tiles ID in the layer
    /// </summary>
    public required List<int> Tiles { get; set; }
}