using Microsoft.Maui.Layouts;

namespace PocCleanMVVM.Presentation.Views
{
    public partial class GamePage : ContentPage
    {
        private double avionX = 0.5;
        private double speed = 0.0075; // Velocidad del movimiento
        private bool movingLeft = false;
        private bool movingRight = false;

        public GamePage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromMilliseconds(16), OnGameUpdate);  // Llamar al método OnGameUpdate cada 16 ms (aproximadamente 60 FPS)
        }

        private bool OnGameUpdate()
        {
            if (movingLeft)
            {
                avionX -= speed;
                if (avionX < 0) avionX = 0;  // Limitar el movimiento a la izquierda
            }
            else if (movingRight)
            {
                avionX += speed;
                if (avionX > 1) avionX = 1;  // Limitar el movimiento a la derecha
            }

            MoveAvion();
            return true;  // Mantener el temporizador activo
        }

        private void OnMoveLeft(object sender, EventArgs e)
        {
            movingLeft = true;
            movingRight = false;  // Detener el movimiento hacia la derecha
        }

        private void OnMoveRight(object sender, EventArgs e)
        {
            movingRight = true;
            movingLeft = false;  // Detener el movimiento hacia la izquierda
        }

        private void OnMoveStop(object sender, EventArgs e)
        {
            movingLeft = false;
            movingRight = false;  // Detener el movimiento al soltar el botón
        }

        private void MoveAvion()
        {
            AbsoluteLayout.SetLayoutBounds(Avion, new Rect(avionX, 0.8, 64, 64));  // Desplazar el avión
            AbsoluteLayout.SetLayoutFlags(Avion, AbsoluteLayoutFlags.PositionProportional);        
        }


    }
}
