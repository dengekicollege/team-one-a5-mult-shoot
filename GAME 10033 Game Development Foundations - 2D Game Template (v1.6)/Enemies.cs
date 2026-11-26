using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    internal class Enemies
    {

        Vector2 position = new Vector2(500,500);
        Vector2 direction;
        Vector2 speed = new Vector2(1,1);
        Vector2 center = new Vector2(Window.Width / 2, Window.Height / 2);

        public void eSprite()
        {
            Draw.FillColor = Color.White;
            Draw.Circle(position, 10);
        }
        public void SetUp()
        {

            Vector2 distance = center - position;
            direction = Vector2.Normalize(distance);
        }
        public void movment()
        {

           
            Vector2 velocity = speed*direction;
            position += velocity;
        }




    }
}
