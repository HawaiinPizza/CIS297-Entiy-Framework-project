using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.UI.Xaml;
using System;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PongExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        Pong pong;
        CanvasBitmap ballImage;
        public GamePage()
        {
            this.InitializeComponent();
            pong = new Pong();

            Window.Current.CoreWindow.KeyDown += Canvas_KeyDown;
            Window.Current.CoreWindow.KeyUp += Canvas_KeyUp;
        }

        private void Canvas_KeyUp(CoreWindow sender, KeyEventArgs args)
        {
            if (args.VirtualKey == Windows.System.VirtualKey.Left)
            {
                pong.setUserPaddleMovingLeftward(false);
            }
            if (args.VirtualKey == Windows.System.VirtualKey.Right)
            {
                pong.setUserPaddleMovingRightward(false);
            }
            if (pong.gameOver && args.VirtualKey == Windows.System.VirtualKey.Y)
            {
                pong = new Pong();
            }
        }

        private void Canvas_KeyDown(CoreWindow sender, KeyEventArgs args)
        {
            if (args.VirtualKey == Windows.System.VirtualKey.Left)
            {
                pong.setUserPaddleMovingLeftward(true);
            }
            if (args.VirtualKey == Windows.System.VirtualKey.Right)
            {
                pong.setUserPaddleMovingRightward(true);
            }
        }

        private void Canvas_Draw(ICanvasAnimatedControl sender, CanvasAnimatedDrawEventArgs args)
        {
            if (!pong.gameOver)
            {
                pong.DrawPong(args.DrawingSession);
            }
            else
            {
                var fontFormat = new Microsoft.Graphics.Canvas.Text.CanvasTextFormat 
                { 
                    FontSize = 48 
                };
                
                args.DrawingSession.DrawText("Game over! Do you want to play again? ( Y/N )", 400, 400, Colors.Azure,fontFormat);
            }
        }

        private void Canvas_CreateResources(CanvasAnimatedControl sender, Microsoft.Graphics.Canvas.UI.CanvasCreateResourcesEventArgs args)
        {
            args.TrackAsyncAction(CreateResources(sender).AsAsyncAction());
        }

        async Task CreateResources(Microsoft.Graphics.Canvas.UI.Xaml.CanvasAnimatedControl sender)
        {
            ballImage = await CanvasBitmap.LoadAsync(sender, "Assets/ball.png");
            pong.setBallImage(ballImage);
        }

        private void Canvas_Update(ICanvasAnimatedControl sender, CanvasAnimatedUpdateEventArgs args)
        {
            pong.Update();
        }
    }
}
