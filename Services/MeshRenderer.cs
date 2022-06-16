using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using VertexTeachingGame.Rendering.Models;

namespace VertexTeachingGame.Rendering.Services;

public class MeshRenderer
{
    private readonly GraphicsDeviceManager _graphics;
    private BasicEffect effect;

    public MeshRenderer(GraphicsDeviceManager graphics)
    {
        _graphics = graphics;
    }

    public void Setup()
    {
        CreateRenderingEffect();
    }

    void CreateRenderingEffect()
    {
        var device = _graphics.GraphicsDevice;
        
        effect = new BasicEffect(device);

        effect.World = Matrix.Identity;
        effect.View = Matrix.CreateLookAt(new Vector3(0, 0, -5), Vector3.Zero, Vector3.Up);
        effect.Projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45), device.Viewport.AspectRatio, 0.1f, 100);

        effect.VertexColorEnabled = true;
    }

    public void DrawMesh(Mesh mesh)
    {
        var device = _graphics.GraphicsDevice;

        foreach (var pass in effect.CurrentTechnique.Passes)
        {
            pass.Apply();
            device.SetVertexBuffer(mesh.Data.VertexBuffer);
            device.Indices = mesh.Data.IndexBuffer;
            device.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, mesh.Data.IndexBuffer.IndexCount * 3);
        }
    }
}