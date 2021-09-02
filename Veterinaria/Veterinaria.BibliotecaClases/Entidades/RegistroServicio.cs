using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.BibliotecaClases.Entidades
{
    public class RegistroServicio
    {
        //atributo de clase
        private DateTime _fecha;
        private int _registroNro;
        private string _tipoServicio;
        private float _monto;
        private int _clienteId;
        private int _mascotaId;



        //Metodo que retorna el atributo _registroNro
        public string RegistroNro
        {
            get
            {
                return _registroNro;
            }
        }

        //Metodo que modifica estado de atributo _registroNro
        public void IncrementarRegistro()
        {
            _registroNro++;
        }




    }
}
