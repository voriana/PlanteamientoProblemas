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
        private DateTime _edad;

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
    }
}
