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
        private List<Vacuna> _vacunas;

        public EsquemaVacunacion()
        {

        }

        public EsquemaVacunacion (DateTime fecha, List<Vacuna> vacunas)
        {
            _fechaAplicacion=fecha;
            _vacunas = vacunas;
        }

        //Vacunas basicas para caninos
        public void VacunasCaninas()
        {
            Vacuna v1 = new Vacuna("Parvovirus", "Canina");
            Vacuna v2 = new Vacuna("Rabia", "Canina");
            Vacuna v3 = new Vacuna("Moquillo", "Canina");
            _vacunas.Add(v1);
            _vacunas.Add(v2);
            _vacunas.Add(v3);

        }



            public EsquemaVacunacion AgregarEsquema()
        {
            VacunasCaninas();
            EsquemaVacunacion e = new EsquemaVacunacion(DateTime.Now, _vacunas);
            return e;
        }

        //Quisiera que este metodo cambiara el estado de el atributo _nroDosis
        //(no se si es correcto que  lo modifique segun el valor que tenga otro atributo)
        public void cantidadDosis(Vacuna nombre)
        {
            foreach (var item in _vacunas)
            {
                if (!item.Equals(nombre))
                {
                    Console.WriteLine("No existe una vacuna con ese nombre");

                }if (nombre.Equals ("Parvovirus")|| nombre.Equals("Rabia")|| nombre.Equals("Moquillo"))
                {
                    
                }
                

            }

        }


        
        
    }
}
