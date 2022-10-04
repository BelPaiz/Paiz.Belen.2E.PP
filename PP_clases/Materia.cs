using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PP_clases
{
    public class Materia
    {
        private static int ultimoId;

        private int _id;
        private string _nombre;
        private int _cuatrimestre;
        public List <Alumno> alumnos;
        private int _idPorfesor;
        private int correlativa;
        public List<Examen> examenes;
        

        static Materia()
        {
            ultimoId = 1;
        }

        public Materia(string nombre, int cuatrimestre, int idPorfesor, int correlativa)
        {
            _id = ultimoId;
            _nombre = nombre;
            _cuatrimestre = cuatrimestre;
            _idPorfesor = idPorfesor;
            this.correlativa = correlativa;
            alumnos = new List <Alumno>();
            examenes = new List <Examen>();

            ultimoId++;
        }
        public int Id 
        {
            get { return _id; } 
        }
        public int Id_ProfesorACargo 
        {
            get {return _idPorfesor; }
            set {_idPorfesor = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public List<Alumno> Alumnos
        {
            get { return alumnos; }
        }
        public List<Examen> Examenes
        {
            get { return examenes; }
        }
        public int Correlativa
        {
            get { return correlativa; }
        }
        public int Cuatrim
        {
            get { return _cuatrimestre; }
        }
        public Alumno BuscarAlumno(int id)
        {
            foreach(Alumno a in alumnos)
            {
                if(a.Id == id)
                {
                    return a;
                }
            }
            return null;
        }
        public void AgregarAlumno(Alumno alum)
        {
            alumnos.Add(alum);
        }
        public void AgregarExamen(Examen exam)
        {
            examenes.Add(exam);
            foreach(Alumno a in alumnos)
            {
                foreach(Cursada c in a.Cursada)
                {
                    if(_nombre == c.Materia)
                    {
                        c.AnadirExamen(exam.Nombre);
                    }
                }
                
            }
        }

        public string MostrarId()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_id}");
            return sb.ToString();
        }
        public string MostrarNombre()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_nombre}");
            return sb.ToString();
        }
        public string MostrarCuatri()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_cuatrimestre}");
            return sb.ToString();
        }
    }
}
