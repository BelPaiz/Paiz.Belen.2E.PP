using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PP_clases
{
    public class Alumno : Usuario
    {
        private static int ultimoId;
        private List<Cursada> cursada;
        

        static Alumno()
        {
            ultimoId = 1000;
        }
        public Alumno(string nombre, string apellido, int dni, string contrasenia) : base(nombre, apellido, dni, contrasenia, "alumno")
        {
            Id = ultimoId;
            cursada = new List<Cursada>();

            ultimoId++;
        }
        public Alumno(string nombre, string apellido, int dni, string contrasenia, string nombreMateria) : this(nombre, apellido, dni, contrasenia)
        {
            Cursada curs = new Cursada(nombreMateria);
            cursada.Add(curs);  
        }
        public List<Cursada> Cursada
        {
            get { return cursada; }
        }
        
        /// <summary>
        /// Crea una cursada para la materia con el nombre ingresado por parametro 
        /// y la añade a la lista  de cursadas
        /// </summary>
        /// <param name="nombreMateria"></param>
        public void AnadirCursada(string nombreMateria)
        {
            Cursada curs = new Cursada(nombreMateria);
            cursada.Add(curs);
        }
        /// <summary>
        /// Busca en la lista de cursadas la que tenga el nombre de la materia pasada por parametro
        /// </summary>
        /// <param name="nombreMateria"></param>
        /// <returns></returns> la cursada
        public Cursada EncontrarCursada(string nombreMateria)
        {
            foreach(Cursada c in Cursada)
            {
                if(c.Materia == nombreMateria)
                {
                    return c;
                }
            }
            return null;
        }
        public override string Saludar()
        {
            return "Bienvenido/a Estudiante: " + MostrarNombreCompleto();
        }


    }
}
