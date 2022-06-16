namespace VertexTeachingGame.Rendering.Models;

public readonly struct Triangle
{
    public readonly int A;
    public readonly int B;
    public readonly int C;

    public Triangle(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }
}
