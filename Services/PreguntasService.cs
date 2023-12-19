using ExamenParcial2.Models;
using ExamenParcial2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial2.Services
{
    public class PreguntasService : IPreguntasService
    {
        public async Task<bool> LoginAsync(int res1, double res2, int res3)
        {
            var result = false;

            await Task.Delay(250);

            var storedRespuestas = new List<Tuple<int, double, int>>
    {
        new Tuple<int, double, int>(Settings.RespuestaPregunta1, Settings.RespuestaPregunta2, Settings.RespuestaPregunta3)
        // Puedes agregar más respuestas almacenadas según sea necesario
    };

            var inputRespuestas = new Tuple<int, double, int>(res1, res2, res3);

            if (storedRespuestas.Any(r => r.Equals(inputRespuestas)))
            {
                result = true;
            }

            return result;

        }
    }
}

