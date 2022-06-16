namespace VertexTeachingGame.Rendering.Models;

public readonly struct Triangle
{
    public readonly short A;
    public readonly short B;
    public readonly short C;

    public Triangle(short a, short b, short c)
    {
        A = a;
        B = b;
        C = c;
    }
}
