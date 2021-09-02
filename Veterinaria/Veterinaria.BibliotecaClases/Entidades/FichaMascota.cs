using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.BibliotecaClases.Entidades
{
    public class FichaMascota
    {
        //atributos de clase
        private int _idMascota;
        private string _nombre;
        private string _especie;
        private string _raza;
        private float _peso;
        private DateTime _fechaNacimiento;
        private EsquemaVacunacion vacunas;

        //propiedades (getters y setters)
        public int IdMascota
        {
            get
            {
                return _idMascota;
            }
            set
            {

                _idMascota = value;
            }
        }
        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public string especie
        {
            get
            {
                return _especie;
            }

            set
            {
                _especie = value;

            }

        }
        public string raza
        {
            get
            {
                return _raza;
            }
            set
            {
                _raza = value;
            }
        }

        public float peso
        {
            get
            {
                return _peso;
            }
            set
            {
                _peso = value;
            }
        }
        public DateTime edad
        {
            get
            {
                return _edad;

            }
            set
            {
                _edad = value;
            }
        }


        /*
         * /Quiero que este metodo evalue si la mascota tiene 6 semanas 
         * (nose como comparar la fecha actual por meses con la fecha de nacimiento
         * Si la mascota esta edad de vacunarse (1 mes o mas) cree una instacia de esquema de vacunacion
         * sino que devuelva que esta muy pequeño
         * 
         */

        public void CrearVacunas()
        {
            if (_edad == (DateTime.Now.Day - _fechaNacimiento.Day >= 1))
            {
               
                
                EsquemaVacunacion e=new EsquemaVacunacion(DateTime.Now,"Pavovirus");
                e.cantidadDosis();

            }
            else if (DateTime.Now.Month - _fechaNacimiento.Month < 1)
            {
                Console.WriteLine("Aun es muy pequeño para vacunarse");
            }
        }
    }
}
