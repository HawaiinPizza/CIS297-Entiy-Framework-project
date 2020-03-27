using Microsoft.Graphics.Canvas;
using System;
using Windows.UI;

namespace PongExample
{
    public class Ball
    {
        public bool movingLeftward { get; set; }
        public bool movingDownward { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }

        public int BallSpeed { get; set; }
        public void Draw(CanvasDrawingSession drawingSession)
        {
            drawingSession.DrawEllipse(X, Y, Radius, Radius, Color);
        }

        public void updatePosition()
        {
            if ( movingLeftward )
            {
                X -= BallSpeed;
            }
            else
            {
                X += BallSpeed;
            }
            if ( movingDownward )
            {
                Y += BallSpeed;
            }
            else
            {
                Y -= BallSpeed;
            }
        }

        public void ChangeColor()
        {
            Random random = new Random();
            Color = Color.FromArgb(255, (byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
        }
    }
}