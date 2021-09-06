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
        private List<Vacuna> _vacunasAplicadas;

        //constructor vacio 
        public FichaMascota()
        {
           

        }

        //constructor con parametros
        public FichaMascota(int id, string nombre, string especie, string raza, float peso, DateTime fecha, List<Vacuna> vacuna)
        {
            _idMascota = id;
            _nombre = nombre;
            _especie = especie;
            _raza = raza;
            _peso = peso;
            _fechaNacimiento = fecha;
            _vacunasAplicadas = vacuna;
            

        }

       public void AgregarVacunas(List<Vacuna> v)
       {
            _vacunasAplicadas = v;
       }

        //sub rutina para asignar solicitar datos por consola y asiganarle valor a los atributos
        public void AgregarMascota()
        {
            IdMascota = _idMascota++;
            Nombre = Utilidades.SolicitudDatos.ValidarCadena("Ingrese nombre de la mascota");
            Especie = Utilidades.SolicitudDatos.ValidarCadena("Ingrese especie de la mascota");
            Raza = Utilidades.SolicitudDatos.ValidarCadena("Ingrese raza de la mascota");
            Peso = Utilidades.SolicitudDatos.ValidarNumerico("Ingrese Peso de la mascota");
            FechaNac = Utilidades.SolicitudDatos.ValidarFecha("Ingrese Fecha");

            

        }

       
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
        public string Nombre
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
        public string Especie
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
        public string Raza
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

        public float Peso
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
        public DateTime FechaNac
        {
            get
            {
                return _fechaNacimiento;

            }
            set
            {
                _fechaNacimiento = value;
            }
        }
        public string DatosFicha()
        {
            return "Nombre: " + Nombre + Environment.NewLine + "Especie:" + Especie + Environment.NewLine +
                "Raza: " + Raza + Environment.NewLine + "Fecha de naciemiento:" + FechaNac + Environment.NewLine +
                "Peso: "+Peso+Environment.NewLine+"Vacunas:\n" + ListaVacuna(_vacunasAplicadas) ;
                      
        }

        public string ListaVacuna(List<Vacuna> v)
        {
            string cadena="";
            foreach (var item in v)
            {
                cadena += item.DetallarVacuna()+" -";
            }
            if (string.IsNullOrEmpty(cadena))
            {
                return "No tiene vacunas en su ficha";
            }
            else
            {
                return cadena;
            }
        }
      
        public List<Vacuna> Vacunas
        {
            get
            {
                return _vacunasAplicadas;

                
            }
        }

    }
}
