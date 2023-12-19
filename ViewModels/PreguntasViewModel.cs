using ExamenParcial2.Services.Interfaces;
using System.ComponentModel;

namespace ExamenParcial2.ViewModels
{
    public class PreguntasViewModel : INotifyPropertyChanged
    {
        private readonly IPreguntasService preguntasService;

        public event PropertyChangedEventHandler PropertyChanged;

        public int RespuestaPregunta1 { get; set; }
        public double RespuestaPregunta2 { get; set; }
        public int RespuestaPregunta3 { get; set; }

        public Command ValidarRespuestasCommand { get; set; }

        public PreguntasViewModel(IPreguntasService preguntasService)
        {
            this.preguntasService = preguntasService;

            ValidarRespuestasCommand = new Command(ValidarRespuestas);
        }

        private void ValidarRespuestas()
        {
            char respuestaPregunta1Char;
            if (char.TryParse(RespuestaPregunta1.ToString(), out respuestaPregunta1Char))
            {
                if (respuestaPregunta1Char == '4')
                {
                    ShowToast("Respuesta correcta para la Pregunta 1");
                }
                else
                {
                    ShowToast("Respuesta incorrecta para la Pregunta 1");
                }
            }
            else
            {
                ShowToast("La respuesta para la Pregunta 1 no es un carácter válido");
            }
            double respuestaPregunta2;
            if (double.TryParse(RespuestaPregunta2.ToString(), out respuestaPregunta2))
            {
                if (Math.Abs(respuestaPregunta2 - 3.1416) < 0.0001) // Ajusta la tolerancia según sea necesario
                {
                    ShowToast("Respuesta correcta para la Pregunta 2");
                }
                else
                {
                    ShowToast("Respuesta incorrecta para la Pregunta 2");
                }
            }
            else
            {
                ShowToast("La respuesta para la Pregunta 2 no es un número válido");
            }

            int respuestaPregunta3;
            if (int.TryParse(RespuestaPregunta3.ToString(), out respuestaPregunta3))
            {
                if (respuestaPregunta3 == 5)
                {
                    ShowToast("Respuesta correcta para la Pregunta 3");
                }
                else
                {
                    ShowToast("Respuesta incorrecta para la Pregunta 3");
                }
            }
            else
            {
                ShowToast("La respuesta para la Pregunta 3 no es un número válido");
            }

        }

        private void ShowToast(string message)
        {
        
        }

        
    }

}
