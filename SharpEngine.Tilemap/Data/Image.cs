using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEngine.Tilemap.Data;

/// <summary>
/// Image Texture of TileMap
/// </summary>
public class Image
{
    /// <summary>
    /// Name of the Image
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Path of the Image
    /// </summary>
    public required string Path { get; set; }
}
