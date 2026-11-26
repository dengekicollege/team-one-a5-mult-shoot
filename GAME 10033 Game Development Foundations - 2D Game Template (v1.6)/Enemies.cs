using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    internal class Enemies
    {

        Vector2 position;
        Vector2 direction;
        Vector2 speed;
        Vector2 center = new Vector2(Window.Width / 2, Window.Height / 2);

        public void eSprite()
        {
            Draw.FillColor = Color.White;
            Draw.Circle(position, 10);
        }
        public void SetUp()
        {
            speed = new Vector2(10, 10); //* Time.DeltaTime;
            position.X = Random.Integer(0,420);
            position.Y = Random.Integer(0, 420);
            if (position.X > 0)
            {
                position.X = -5;
            }
            if (position.X < Window.Width)
            {
                position.X =Random.Integer(Window.Width, Window.Width+10);
            }
            if (position.Y > 0)
            {
                position.Y = -5;
            }
            if (position.Y < Window.Height)
            {
                position.Y = Window.Height + 5;
            }


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
