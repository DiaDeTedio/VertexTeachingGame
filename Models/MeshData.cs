using Microsoft.Xna.Framework.Graphics;

namespace VertexTeachingGame.Rendering.Models;

public class MeshData
{
    public VertexBuffer VertexBuffer { get; private set; }
    public IndexBuffer IndexBuffer { get; private set; }

    private readonly GraphicsDevice _graphicsDevice;

    void CreateIfNeeded(int vertexCount, int indexCount)
    {
        if (VertexBuffer is null || VertexBuffer.VertexCount != vertexCount)
            VertexBuffer = new VertexBuffer(_graphicsDevice, VertexPositionColor.VertexDeclaration, vertexCount, BufferUsage.WriteOnly);
        if (IndexBuffer is null || IndexBuffer.IndexCount != indexCount)
            IndexBuffer = new IndexBuffer(_graphicsDevice, IndexElementSize.SixteenBits, indexCount, BufferUsage.WriteOnly);
    }

    public void Update(VertexPositionColor[] vertices, Triangle[] triangles)
    {
        CreateIfNeeded(vertices.Length, triangles.Length * 3);
        VertexBuffer.SetData(vertices);
        IndexBuffer.SetData(triangles);
    }

    public MeshData(GraphicsDevice graphicsDevice)
    {
        _graphicsDevice = graphicsDevice;
    }
}