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
    }
}
