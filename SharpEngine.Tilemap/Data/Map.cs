namespace SharpEngine.Tilemap.Data;

/// <summary>
/// Class with represents Map information
/// </summary>
public class Map
{
    /// <summary>
    /// Name of Map
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Width of Map in Tiles
    /// </summary>
    public required int Width { get; set; }
    
    /// <summary>
    /// Height of Map in Tiles
    /// </summary>
    public required int Height { get; set; }
    
    /// <summary>
    /// Width of Tile in Pixels
    /// </summary>
    public required int TileWidth { get; set; }
    
    /// <summary>
    /// Height of Tile in Pixels
    /// </summary>
    public required int TileHeight { get; set; }
}