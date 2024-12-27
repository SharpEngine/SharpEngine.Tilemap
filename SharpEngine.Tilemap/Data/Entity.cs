using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEngine.Tilemap.Data;

/// <summary>
/// Entity which be spawned on the map
/// </summary>
public class Entity
{
    /// <summary>
    /// C# class name of the entity
    /// </summary>
    public required string Class { get; set; }

    /// <summary>
    /// X Tile position of the entity
    /// </summary>
    public required int XTile { get; set; }

    /// <summary>
    /// Y Tile position of the entity
    /// </summary>
    public required int YTile { get; set; }
}
