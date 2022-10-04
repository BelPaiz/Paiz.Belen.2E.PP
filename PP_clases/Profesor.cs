using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_clases
{
    public class Profesor : Usuario
    {
        private static int ultimoId;
        public List<Materia> _materias;

        static Profesor()
        {
            ultimoId = 100;
        }
        public Profesor(string nombre, string apellido, int dni, string contrasenia) : base(nombre, apellido, dni, contrasenia, "profe")
        {
            Id = ultimoId;
            _materias = new List<Materia>();

            ultimoId++;
        }
        
        public List<Materia> Materias
        {
            get { return _materias; }
        }
        /// <summary>
        /// se añade la materia con el nombre pasado por parametro a la lista de materias del profesor
        /// </summary>
        /// <param name="idMateria"></param> 
        /// <param name="maters"></param> lista de materias
        public void AnadirMateriaProfe(int idMateria, List<Materia> maters)
        {
            foreach(Materia materia in maters)
            {
                if(idMateria == materia.Id)
                {
                    _materias.Add(materia);
                    break;
                }
            }
        }
        /// <summary>
        /// busca las materias que tiene en su lista el profesor y las muestra
        /// </summary>
        /// <returns></returns> un string con la informacion de las materias o 
        /// un string que indique que no tiene materias en su lista
        public string MostrarListaMaterias()
        {
            StringBuilder sb = new StringBuilder();
            if(_materias.Count > 0)
            {
                foreach (Materia materia in _materias)
                {
                    sb.AppendLine($"Materia: {materia.MostrarNombre()}");
                    sb.AppendLine($"Cuatrimestre: {materia.MostrarCuatri()}");
                }
            }
            else
            {
                sb.Append($"No hay materias a cargo.\n");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Compara el id pasado por parametro con los id de las materias que tiene el profesor en la lista
        /// 
        /// </summary>
        /// <param name="idMateria"></param>
        /// <returns></returns> la materia si la encuentra, caso contrario null
        public Materia GetMateria(int idMateria)
        {
            foreach(Materia m in _materias)
            {
                if(m.Id == idMateria)
                {
                    return m;
                }
            }
            return null;
        }
        public override string Saludar()
        {
            return "Bienvenido/a Profe: " + MostrarNombreCompleto();
        }
    }
}
