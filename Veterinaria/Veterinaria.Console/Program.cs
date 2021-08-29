using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.BibliotecaClases.Entidades;

namespace Veterinaria.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //FichaMascota ficha1 = new BibliotecaClases.Entidades.FichaMascota();
            FichaMascota ficha1 = new FichaMascota();
            ficha1.nombre = "Rufus";
        }
    }
}
