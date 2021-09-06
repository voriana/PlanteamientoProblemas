using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.BibliotecaClases.Entidades
{
    public class Cliente
    {
        private int _clienteId;
        private string _nombre;
        private string _apellido;
        private string _email;
        private int _telefono;


        public Cliente()
        {

        }

        //constructor con parametros
        public Cliente (int cId, string nombre, string apellido, string mail, int telf)
        {
            _clienteId = cId;
            _nombre = nombre;
            _apellido = apellido;
            _email = mail;
            _telefono = telf;
        }

        public void IncrementarRegistros()
        {
            _clienteId++;
        }

        public Cliente AgregarCliente()

        {
            IncrementarRegistros();

            Console.WriteLine("Ingrese nombre de cliente");
            String nombre = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Ingrese apellido de cliente");
            String apellido = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Ingrese mail de cliente");
            String mail = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Ingrese telefono del cliente");
            int telefono = Convert.ToInt32(Console.ReadLine());

            Cliente c = new Cliente(_clienteId, nombre, apellido, mail, telefono);

            return c;

        }

        public void ActualizarDatosCliente(int idcliente)
        {

        }

        public bool BuscarCliente()
        {
            bool flag = false;
            return flag;
        }
    }
}
