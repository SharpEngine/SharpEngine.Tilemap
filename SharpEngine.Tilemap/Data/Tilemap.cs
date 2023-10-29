using System.Collections.Generic;

namespace SharpEngine.Tilemap.Data;

/// <summary>
/// Class which represents a Tile Map
/// </summary>
public class Tilemap
{
    /// <summary>
    /// Map Informations of TileMap
    /// </summary>
    public required Map Map { get; set; }
    
    /// <summary>
    /// Tileset of TileMap
    /// </summary>
    public required List<Tile> Tileset { get; set; }
    
    /// <summary>
    /// Layers of TileMap
    /// </summary>
    public required List<Layer> Layers { get; set; }
}