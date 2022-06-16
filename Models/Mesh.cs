using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace VertexTeachingGame.Rendering.Models;

public class Mesh
{
    public VertexPositionColor[] Vertices;
    public Triangle[] Triangles;
    public MeshData Data { get; }

    public void GenerateMeshData()
    {
        Data.Update(Vertices, Triangles);
    }

    public Mesh(GraphicsDevice graphicsDevice, VertexPositionColor[] vertices, Triangle[] triangles)
    {
        Vertices = vertices;
        Triangles = triangles;
        Data = new MeshData(graphicsDevice);
    }
}
