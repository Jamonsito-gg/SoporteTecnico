using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SoporteTecnico.Modelo;

namespace SoporteTecnico.Controlador
{
    class ESTicket
    {
        private string Nombre;
        private string Apellido;
        private string Correo;
        private int NumTicket;
        private string Estado;
        private string Dispositivo;
        private string Descripción;

        public ESTicket(string nombre, string apellido, string correo, int numTicket, string estado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            NumTicket = numTicket;
            Estado = estado;

        }
        public ESTicket(string nombre, string apellido, string correo, string estado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;

            Estado = estado;

        }
        public ESTicket(string nombre, string apellido, string correo, string estado, string dispositivo, string descripción)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Estado = estado;
            Dispositivo = dispositivo;
            Descripción = descripción;
        }
        public ESTicket(string nombre, string apellido, string correo, string dispositivo, string descripción)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;

            Dispositivo = dispositivo;
            Descripción = descripción;
        }


        public ESTicket()
        {

        }

        public void insertarticket()
        {
            BDTicket nuevo = new BDTicket();
            nuevo.insertar(this);
        }

        public void eliminarticket(int NumTicket)
        {
            BDTicket eliminar = new BDTicket();
            eliminar.eliminar(NumTicket);
        }
        public void modificarticket()
        {
            BDTicket modificar = new BDTicket();
            modificar.modificar(this);
        }


        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Correo1{ get => Correo; set => Correo = value; }
        public int NumTicket1 { get => NumTicket; set => NumTicket = value; }
        public string Estado1  { get => Estado; set => Estado = value; }
        public string Dispositivo1 { get => Dispositivo; set => Dispositivo = value; }
        public string Descripción1 { get => Descripción; set => Descripción = value; }
    }

}
