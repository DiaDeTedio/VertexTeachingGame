using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace VertexTeachingGame.Rendering.Models;

public class Mesh
{
    public VertexPosition[] Vertices;
    public int[] Indices;
    public MeshData Data { get; }

    public void GenerateMeshData()
    {
        Data.Update(Vertices, Indices);
    }

    public Mesh(GraphicsDevice graphicsDevice, VertexPosition[] vertices, int[] indices)
    {
        Vertices = vertices;
        Indices = indices;
        Data = new MeshData(graphicsDevice);
    }
}
