namespace SharpEngine.Tilemap.Data;

/// <summary>
/// Class which represents a Tile Type
/// </summary>
public class Tile
{
    /// <summary>
    /// Id of Tile Type
    /// </summary>
    public required int Id { get; set; }
    
    /// <summary>
    /// Path of Texture
    /// </summary>
    public required string Path { get; set; }
    
    /// <summary>
    /// X Position of Tile (for tilesheet)
    /// </summary>
    public int? XPos { get; set; }
    
    /// <summary>
    /// Y Position of Tile (for tilesheet)
    /// </summary>
    public int? YPos { get; set; }
    
    /// <summary>
    /// Width of Tile (for tilesheet)
    /// </summary>
    public int? Width { get; set; }
    
    /// <summary>
    /// Height of Tile (for tilesheet)
    /// </summary>
    public int? Height { get; set; }
}