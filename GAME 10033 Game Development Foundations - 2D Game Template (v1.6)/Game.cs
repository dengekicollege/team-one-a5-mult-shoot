// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        public int player1Score = 0;

        public int player2Score = 0;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

        }

        void P1ScoreChangeByInt(int amount)
        {
            player1Score += amount;
        }

        void P1ScoreChangeByPercentage(int amount)
        {
            player1Score += player1Score * (amount / 100);
        }

        void P2ScoreChangeByInt(int amount)
        {
            player2Score += amount;
        }

        void P2ScoreChangeByPercentage(int amount)
        {
            player2Score += player2Score * (amount / 100); 
        }
    }

}
