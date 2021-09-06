using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.BibliotecaClases.Entidades;
using Veterinaria.BibliotecaClases.Utilidades;

namespace Veterinaria.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            FichaMascota ficha2 = new FichaMascota();
            //
            // Con el metodo set de la propieda asigno el valor a cada atributo de la clase
            ficha2.IdMascota = 23;
            ficha2.Nombre = "Freia";
            ficha2.Raza = "Siames";
            ficha2.Especie = "Felino";
            ficha2.Peso = 15.200f;
            ficha2.FechaNac = Convert.ToDateTime("04/07/2021");

            //Creo dos objetos de la clase vacuna con el constructor que recibe parametros
            Vacuna v1 = new Vacuna("Toxoplasmosis","Para felinos");
            Vacuna v2=new Vacuna();
            v2.AgregarVacuna();



            //creo una lista de tipo vacuna y le agrego las dos instancias de vacunas anteriores
            List<Vacuna> lista2 = new List<Vacuna>();
            lista2.Add(v1);
            lista2.Add(v2);

            ficha2.AgregarVacunas(lista2);

            Console.WriteLine("***Datos ficha2****\n ");
            Console.WriteLine(ficha2.DatosFicha());

            
            Vacuna vacuna1 = new Vacuna("Parvovirus", "Para raza canina");
            Vacuna vacuna2 = new Vacuna("Rabia", "Para raza canina");
            List<Vacuna> listaVac = new List<Vacuna>();
            listaVac.Add(vacuna1);
            listaVac.Add(vacuna2);
            listaVac.Add(v1);
            listaVac.Add(v2);

            FichaMascota ficha1 = new FichaMascota(21, "Rufus", "Canina", "Pitbull", (39.50f), Convert.ToDateTime("04/07/2021"), listaVac);

            Console.WriteLine("***Datos ficha1****\n ");
            Console.WriteLine(ficha1.DatosFicha());
            
            

            
           
            Console.ReadKey();
           
        }
    }
}
