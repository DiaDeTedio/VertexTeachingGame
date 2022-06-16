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
            VertexBuffer = new VertexBuffer(_graphicsDevice, VertexPosition.VertexDeclaration, vertexCount, BufferUsage.WriteOnly);
        if (IndexBuffer is null || IndexBuffer.IndexCount != indexCount)
            IndexBuffer = new IndexBuffer(_graphicsDevice, IndexElementSize.SixteenBits, indexCount, BufferUsage.WriteOnly);
    }

    public void Update(VertexPosition[] vertices, int[] indices)
    {
        CreateIfNeeded(vertices.Length, indices.Length);
        VertexBuffer.SetData(vertices);
        IndexBuffer.SetData(indices);
    }

    public MeshData(GraphicsDevice graphicsDevice)
    {
        _graphicsDevice = graphicsDevice;
    }
}