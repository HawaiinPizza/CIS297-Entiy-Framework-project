using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace PongExample
{
    public class Pong
    {
        private Ball ball;
        private Rectangle leftWall;
        private Rectangle rightWall;
        private Rectangle userPaddle;
        private Rectangle computerPaddle;
        public bool gameOver { get; private set; }

        // TODO - clean up this mess - put it in a class where it belongs
        private bool isUserPaddleMovingLeftward;
        private bool isUserPaddleMovingRightward;

        public Pong()
        {
            gameOver = false;
            ball = new Ball
            {
                X = 400,
                Y = 400,
                Radius = 10,
                Color = Colors.SkyBlue,
                movingLeftward = Convert.ToBoolean(new Random().Next(2)),
                movingDownward = Convert.ToBoolean(new Random().Next(2)),
                BallSpeed = 2
            };
            isUserPaddleMovingLeftward = false;
            isUserPaddleMovingRightward = false;
            leftWall = new Rectangle
            {
                X = 10,
                Y = 50,
                Width = 10,
                Height = 700,
                Color = Colors.Green
            };
            rightWall = new Rectangle
            {
                X = 790,
                Y = 50,
                Width = 10,
                Height = 700,
                Color = Colors.Green
            };

            computerPaddle = new Rectangle
            {
                X = 400,
                Y = 40,
                Width = 50,
                Height = 10,
                Color = Colors.Fuchsia
            };

            userPaddle = new Rectangle
            {
                X = 400,
                Y = 750,
                Width = 50,
                Height = 10,
                Color = Colors.Turquoise
            };
        }

        public void DrawPong(CanvasDrawingSession drawingSession)
        {
            leftWall.Draw(drawingSession);
            rightWall.Draw(drawingSession);
            userPaddle.Draw(drawingSession);
            computerPaddle.Draw(drawingSession);
            ball.Draw(drawingSession);
        }

        public void setUserPaddleMovingLeftward(bool movingLeftward)
        {
            isUserPaddleMovingLeftward = movingLeftward;
        }

        public void Update()
        {
            if (!gameOver)
            {
                if (isUserPaddleMovingLeftward)
                {
                    if (userPaddle.X > leftWall.X + leftWall.Width)
                    {
                        moveUserPaddle(-5);
                    }
                }
                if (isUserPaddleMovingRightward)
                {
                    if (userPaddle.X + userPaddle.Width < rightWall.X)
                    {
                        moveUserPaddle(5);
                    }
                }

                if (ball.X - ball.Radius <= leftWall.X + leftWall.Width &&
                    ball.Y + ball.Radius >= leftWall.Y && ball.Y + ball.Radius <= leftWall.Y + leftWall.Height)
                {
                    ball.movingLeftward = false;
                    ball.ChangeColor();
                }
                else if (ball.X + ball.Radius >= rightWall.X &&
                    ball.Y + ball.Radius >= rightWall.Y && ball.Y + ball.Radius <= rightWall.Y + leftWall.Height)
                {
                    ball.movingLeftward = true;
                    ball.ChangeColor();
                }

                if (ball.Y - ball.Radius <= computerPaddle.Y + computerPaddle.Height
                    && ball.X - ball.Radius >= computerPaddle.X
                    && ball.X + ball.Radius <= computerPaddle.X + computerPaddle.Width)
                {
                    ball.movingDownward = true;
                    ball.ChangeColor();
                }
                else if (ball.Y + ball.Radius >= userPaddle.Y
                    && ball.X - ball.Radius >= userPaddle.X
                    && ball.X + ball.Radius <= userPaddle.X + userPaddle.Width)
                {
                    ball.movingDownward = false;
                    ball.ChangeColor();
                }

                computerPaddle.X = ball.X - computerPaddle.Width / 2;


                ball.updatePosition();

                if ( ball.Y < computerPaddle.Y || ball.Y > userPaddle.Y)
                {
                    gameOver = true;
                }
            }
        }

        public void setUserPaddleMovingRightward(bool movingRightward)
        {
            isUserPaddleMovingRightward = movingRightward;
        }

        public void moveUserPaddle(int changeInX)
        {
            userPaddle.X += changeInX;
        }
    }
}
