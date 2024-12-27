using SharpEngine.Core;
using SharpEngine.Core.Component;
using SharpEngine.Core.Entity;
using SharpEngine.Core.Math;
using SharpEngine.Core.Renderer;
using SharpEngine.Core.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text.Json;

namespace SharpEngine.Tilemap;

/// <summary>
/// Component which represents a Tilemap
/// </summary>
public class TilemapComponent: Component
{
    /// <summary>
    /// Tilemap of the component
    /// </summary>
    public Data.Tilemap Tilemap { get; }

    /// <summary>
    /// Displayed property of Tilemap
    /// </summary>
    public bool Displayed { get; set; } = true;

    private TransformComponent? _transform;

    /// <summary>
    /// Constructor of TilemapComponent
    /// </summary>
    /// <param name="file">Tilemap json file</param>
    public TilemapComponent(string file)
    {
        Tilemap = JsonSerializer.Deserialize<Data.Tilemap>(File.ReadAllText(file))!;
    }

    /// <inheritdoc />
    public override void Load()
    {
        base.Load();

        _transform = Entity?.GetComponentAs<TransformComponent>();

        foreach (var image in Tilemap.Images)
            Entity?.Scene?.Window?.TextureManager.AddTexture(image.Name, image.Path);

        foreach (var entity in Tilemap.Entities ?? [])
        {
            Type? type = null;
            
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var typeTemp = assembly.GetType(entity.Class);
                if (typeTemp != null)
                {
                    type = typeTemp;
                    break;
                }
            }

            if (Activator.CreateInstance(type ?? throw new Exception($"Entity Class {entity.Class} not found")) is not Entity e)
                throw new Exception($"Entity Class {entity.Class} is not an SharpEngine Entity");

            if (e.GetComponentAs<TransformComponent>() is TransformComponent transform && _transform != null)
            {
                transform.LocalPosition = new Vec2(
                    entity.XTile * Tilemap.Map.TileWidth * _transform.Scale.X,
                    entity.YTile * Tilemap.Map.TileHeight * _transform.Scale.Y
                );

                transform.LocalZLayer = 1;
            }

            Entity?.AddChild(e).Load();
        }

    }

    /// <inheritdoc />
    public override void Draw()
    {
        base.Draw();

        if (_transform == null || !Displayed)
            return;

        var index = 0;

        foreach(var layer in Tilemap.Layers)
        {
            for (var i = 0; i < layer.Tiles.Count; i++)
            {
                if(layer.Tiles[i] == null)
                    continue;

                var tile = Tilemap.Tiles.FirstOrDefault(x => x.Id == layer.Tiles[i]!.Value);

                if (tile == null)
                    continue;

                var x = i % Tilemap.Map.Width;
                var y = i / Tilemap.Map.Width;

                var position = new Vec2(
                    x * Tilemap.Map.TileWidth * _transform.Scale.X + _transform.Position.X, 
                    y * Tilemap.Map.TileHeight * _transform.Scale.Y + _transform.Position.Y
                );
                var texture = Entity?.Scene?.Window?.TextureManager.GetTexture(tile.Image);

                if(texture == null)
                    continue;

                var destination = new Rect(
                    (int)position.X, 
                    (int)position.Y,
                    Tilemap.Map.TileWidth * _transform.Scale.X, 
                    Tilemap.Map.TileHeight * _transform.Scale.Y
                );

                if (tile.XPos.HasValue && tile.YPos.HasValue && tile.Width.HasValue && tile.Height.HasValue)
                {
                    var source = new Rect(tile.XPos.Value, tile.YPos.Value, tile.Width.Value, tile.Height.Value);

                    SERender.DrawTexture(
                        texture.Value,
                        source,
                        destination,
                        new Vec2(Tilemap.Map.TileWidth / 2f, Tilemap.Map.TileHeight / 2f),
                        0,
                        Color.White,
                        InstructionSource.Entity,
                        _transform.ZLayer + index * 0.01f
                    );
                }
                else
                {
                    SERender.DrawTexture(
                        texture.Value,
                        new Rect(0, 0, texture.Value.Width, texture.Value.Height),
                        destination,
                        new Vec2(Tilemap.Map.TileWidth / 2f, Tilemap.Map.TileHeight / 2f),
                        0,
                        Color.White,
                        InstructionSource.Entity,
                        _transform.ZLayer + index * 0.01f
                    );
                }

                index++;
            }
        }
    }
}