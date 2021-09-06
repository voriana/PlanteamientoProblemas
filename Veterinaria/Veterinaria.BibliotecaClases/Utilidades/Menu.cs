using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.BibliotecaClases.Utilidades
{
    class Menu
    {
        public void Inicio()
        {
            Console.WriteLine("*****SISTEMA VETERINARIO*****"+Environment.NewLine+
                "ELIJA LA OPCION QUE DESEA REALIZAR:" + Environment.NewLine +
                "1 - BUSCAR FICHA MASCOTA"+Environment.NewLine+
                "2- CREAR FICHA MASCOTA"+Environment.NewLine+
                "3- ACTUALIZAR FICHA MASCOTA");
           
        }
    }
}
