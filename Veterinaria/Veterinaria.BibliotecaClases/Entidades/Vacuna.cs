using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.BibliotecaClases.Utilidades;

namespace Veterinaria.BibliotecaClases.Entidades
{
    public class Vacuna
    {
        string _nombre;
        string _tipoVacuna;
        

        public Vacuna()
        {

        }

        public Vacuna (string nombre, string tipo)
        {
            _nombre = nombre;
            _tipoVacuna = tipo;
            
        }


        public string ObtenerVacunas
        {
            get
            {
                return "Nombre de la vacuna:"+_nombre + Environment.NewLine+"Tipo Vacuna: "+_tipoVacuna ;
            }
         
        }

        public void AgregarVacuna()
        {
            Nombre=Utilidades.SolicitudDatos.ValidarCadena("Ingrese el nombre de la vacuna:");
            Tipo= Utilidades.SolicitudDatos.ValidarCadena("Ingrese el tipo de vacuna:");
            
            

        }
        public string Nombre
        {
            set
            {
                _nombre = value;
                


            }
        }
        public string Tipo
        {
            set
            {
                _tipoVacuna= value;
            }
        }


        public string DetallarVacuna()
        {
            return $" Nombre de la vacuna: {_nombre}\n" +
                $" Observaciones:{_tipoVacuna}\n";
              
        }

    }
}
