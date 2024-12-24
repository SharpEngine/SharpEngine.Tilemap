namespace SharpEngine.Tilemap.Data;

/// <summary>
/// Class with represents Map information
/// </summary>
public class Map
{
    /// <summary>
    /// Format of Map (currently : 1)
    /// </summary>
    public required int Format { get; set; }
    
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