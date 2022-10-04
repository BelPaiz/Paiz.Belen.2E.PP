using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PP_clases
{
    public class Cursada
    {
        public string materia;
        private int estado;
        Dictionary<E_instanciasExamen, int> notaExamen;
        private int aprobada;
        private int presentes;

        public Cursada()
        {

        }
        public Cursada(string nombreMateria):this ()
        {
            Random r = new Random();
            int buffer;
            materia = nombreMateria;
            buffer = r.Next(0, 100);
            if(buffer > 50)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
            aprobada = 0;
            presentes = 0;
            notaExamen = new Dictionary<E_instanciasExamen, int>();
        }
        public int Estado 
        {
            get {return estado; }
            set {estado = value; } 
        }

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public int Aprobada
        {
            get { return aprobada; }
            set { aprobada = value; }
        }
        public int Presente
        {
            get { return presentes; }
        }

        public void AnadirExamen(E_instanciasExamen examen)
        {
            notaExamen.Add(examen, -1);
        }
        public void ModificarNotaExamen(E_instanciasExamen examen, int nota)
        {
            if(notaExamen.ContainsKey(examen))
            {
                notaExamen[examen] = nota;
            }
        }
        public string MostrarMateriaEnCurso()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Materia: {materia}      ");
            sb.Append($"Estado: {estado}");
            return sb.ToString();
        }
        public int EncontrarNotaExamen(E_instanciasExamen examen)
        {
            foreach(var item in notaExamen)
            {
                if (item.Key == examen)
                {
                    return item.Value;
                }
            }
            return -1;
        }
        
        public void DarPresente()
        {
            presentes++;
        }

    }
}
