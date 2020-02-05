using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunicadoProfesor.Cls
{
    class ClsFaltaDeHoy
    {
        //ATTRIBUTOS
        private int ID;
        private String Profesor;
        private String Curso;
        //GETTERS Y SETTERS
        public void SetID(int ID) {
            this.ID = ID;
        }
        public int GetID() {
            return ID;
        }
        public void SetProfesor(String Profesor)
        {
            this.Profesor = Profesor;
        }
        public String GetProfesor()
        {
            return Profesor;
        }
        public void SetCurso(String Curso)
        {
            this.Curso = Curso;
        }
        public String GetCurso()
        {
            return Curso;
        }
        //CONSTRUCTORES
        public ClsFaltaDeHoy(String Profesor, String Curso) {
            this.Profesor = Profesor;
            this.Curso = Curso;
        }
        public ClsFaltaDeHoy() {

        }
    }
}
