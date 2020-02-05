using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunicadoProfesor.Cls
{
    class ClsComunicados
    {
        //ATRIBUTOS
        private int ID;
        private String Autor;
        private String Mensaje;
        private DateTime Fecha;
        //GETTERS Y SETTERS
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public int GetID()
        {
            return ID;
        }
        public void SetAutor(String Autor)
        {
            this.Autor = Autor;
        }
        public String GetAutor()
        {
            return Autor;
        }
        public void SetMensaje(String Mensaje)
        {
            this.Mensaje = Mensaje;
        }
        public String GetMensaje()
        {
            return Mensaje;
        }
        public void SetFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }
        public DateTime GetFecha()
        {
            return Fecha;
        }
        //CONSTRUCTORES
        public ClsComunicados(String Autor, String Mensaje, DateTime Fecha) {
            this.Autor = Autor;
            this.Mensaje = Mensaje;
            this.Fecha = Fecha;
        }
        public ClsComunicados() {

        }
    }
}
