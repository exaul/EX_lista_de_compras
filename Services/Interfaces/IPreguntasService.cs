using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial2.Services.Interfaces
{
    public interface IPreguntasService
    {
        public Task<bool> LoginAsync(int res1,double res2, int res3);
    }
}
