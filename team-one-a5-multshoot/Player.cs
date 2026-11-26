using System;
using System.Numerics;
using System.IO;

namespace MohawkGame2D
{

    public class Player
    {
        public Vector2 playerPos;

        KeyboardKey down;
        KeyboardKey up;
        KeyboardKey right;
        KeyboardKey left;
        Color playerColor;
        public void Setup(KeyboardKey down, KeyboardKey up, KeyboardKey right, KeyboardKey left, Color color)
        {

            playerPos.X = Window.Width / 3;

            playerPos.Y = Window.Height / 2;

            this.down = down;
            this.up = up;
            this.right = right;
            this.left = left;
            this.playerColor = color;
        }
        int playerSpeed;
        public void Update()
        {
            playerSpeed = 100;
            Draw.FillColor = playerColor;
            Draw.SetLineColor(Color.Black);
            Draw.SetLineSize(10);
            Draw.Circle(playerPos, 50);
            Draw.SetLineColor(Color.Gray);
            Draw.SetLineSize(30);
            // Up Cannon
            


            // movement checks
            if (Input.IsKeyboardKeyDown(down))
            {
                playerPos.Y += playerSpeed * Time.DeltaTime;
            }
            if (Input.IsKeyboardKeyDown(up))
            {
                playerPos.Y -= playerSpeed * Time.DeltaTime;
            }
            if (Input.IsKeyboardKeyDown(left))
            {
                playerPos.X -= playerSpeed * Time.DeltaTime;
            }
            if (Input.IsKeyboardKeyDown(right))
            {
                playerPos.X += playerSpeed * Time.DeltaTime;
            }


        }
    }

}
