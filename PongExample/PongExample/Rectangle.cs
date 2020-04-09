using Microsoft.Graphics.Canvas;
using Windows.UI;

namespace PongExample
{
    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

        public void Draw(CanvasDrawingSession drawingSession)
        {
            drawingSession.DrawRectangle(X, Y, Width, Height, Color);
        }
    }
}