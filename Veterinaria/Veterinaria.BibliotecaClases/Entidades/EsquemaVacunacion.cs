using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.BibliotecaClases.Entidades
{
    public class EsquemaVacunacion
    {
        //atributos de clase
        private DateTime _fechaAplicacion;
        private string _nombreVacuna;
        private int _nroDosis;

        public EsquemaVacunacion (DateTime fecha, string nombreVacuna)
        {
            _fechaAplicacion=fecha;
            _nombreVacuna=nombreVacuna;
        }

        //Quisiera que este metodo cambiara el estado de el atributo _nroDosis
        //(no se si es correcto que  lo modifique segun el valor que tenga otro atributo)
        public void cantidadDosis()
        {
            if (_nombreVacuna.Equals("parvovirus"))
            {
                _nroDosis=4;

            }else if (_nombreVacuna.Equals("rabia"))
            {
                nroDosis=3;
            }
          

        }


        //Metodo que su comportamiento se ve modificado por el valor de un atributo
        public void EstadoEsquema()
        {
            if(_nombreVacuna.Equals("Pavovirus"))
            {
                
                if (_nroDosis < 4)
                {
                    Console.WriteLine("Cantidad de dosis restantes de Pavovirus"+ (4 - _nroDosis));
                }else
                {
                    Console.WriteLine("Esquema Terminado");
                }
            }else if (_nombreVacuna.Equals("Rabia"))
            {
                if (_nroDosis < 3)
                {
                    Console.WriteLine("Cantidad de dosis restantes de Pavovirus"+ (3 - _nroDosis));
                }else
                {
                    Console.WriteLine("Esquema Terminado");
                }
            }
        }
    }
}
