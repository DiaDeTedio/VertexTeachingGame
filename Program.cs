using System;
using System.IO;

namespace VertexTeachingGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                using var game = new MainGame();
                game.Run();
            }
            catch (Exception ex)
            {
                File.WriteAllText($"dump_{DateTime.Now.ToOADate()}.txt", ex.ToString());
            }
        }
    }
}
