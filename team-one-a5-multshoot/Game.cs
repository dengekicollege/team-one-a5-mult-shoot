using System;
using System.Numerics;
using System.IO;
// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>

        Player player1 = new Player();
        Player player2 = new Player();
        public void Setup()
        {
            Window.SetSize(1024, 1024);

            Window.SetTitle("Mult Shoot");

            player1.Setup(KeyboardKey.S, KeyboardKey.W, KeyboardKey.D, KeyboardKey.A, Color.Red);

            player2.Setup(KeyboardKey.Down, KeyboardKey.Up, KeyboardKey.Right, KeyboardKey.Left, Color.Blue);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Green);

            player1.Update();

            player2.Update();
        }
    }

}
