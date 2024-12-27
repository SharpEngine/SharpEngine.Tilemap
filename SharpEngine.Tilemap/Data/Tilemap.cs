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
    /// Images of TileMap
    /// </summary>
    public required List<Image> Images { get; set; }

    /// <summary>
    /// Tiles of TileMap
    /// </summary>
    public required List<Tile> Tiles { get; set; }
    
    /// <summary>
    /// Layers of TileMap
    /// </summary>
    public required List<Layer> Layers { get; set; }

    /// <summary>
    /// Entities of TileMap
    /// </summary>
    public List<Entity>? Entities { get; set; }
}