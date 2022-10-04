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
        /// <summary>
        /// Añade el examen pasado por parametro al directorio de examenes
        /// </summary>
        /// <param name="examen"></param>
        public void AnadirExamen(E_instanciasExamen examen)
        {
            notaExamen.Add(examen, -1);
        }
        /// <summary>
        /// Permite ingresar una nota y modificar la nota del examen pasado por parametro
        /// </summary>
        /// <param name="examen"></param>
        /// <param name="nota"></param>
        public void ModificarNotaExamen(E_instanciasExamen examen, int nota)
        {
            if(notaExamen.ContainsKey(examen))
            {
                notaExamen[examen] = nota;
            }
        }
        /// <summary>
        /// permite mostrar una materia cursada y su estado
        /// </summary>
        /// <returns></returns> un string con la informacion de la materia
        public string MostrarMateriaEnCurso()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Materia: {materia}      ");
            sb.Append($"Estado: {estado}");
            return sb.ToString();
        }
        /// <summary>
        /// Busca un examen dentro del directorio de examenes de la cursada
        /// </summary>
        /// <param name="examen"></param>
        /// <returns></returns> el value del examen
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
        /// <summary>
        /// modifica el valor del campo de presentes, incrementandolo en 1 unidad
        /// </summary>
        public void DarPresente()
        {
            presentes++;
        }
        /// <summary>
        /// Permite mostrar la informacion de la cursada (estado, examenes y notas)
        /// </summary>
        /// <returns></returns> un string con la informacion 
        public string MostrarInfoCursada()
        {
            StringBuilder sb = new StringBuilder();
            if(Estado == 0)
            {
                sb.AppendLine($"Estado de cursada: Libre");
            }
            else
            {
                sb.AppendLine($"Estado de cursada: Regular");
            }
            sb.AppendLine($"Examenes: ");
            if(notaExamen.Count > 0)
            {
                foreach (var item in notaExamen)
                {
                    sb.AppendLine($"Instancia de examen: {item.Key}");
                    sb.AppendLine($"Instancia de examen: {item.Value}");
                }
            }
            else
            {
                sb.AppendLine($"No hay examenes creados en esta materia.");
            }
            
            return sb.ToString();
        }
        /// <summary>
        /// Permite realizar una comprobacion para saber si se cumplen las condiciones para probar la cursada
        /// en caso de aporbacion se modifica el campo aprobada.
        /// </summary>
        /// <returns></returns> false si no esta aprobada, true caso contrario
        public bool ConfirmarCondicionDeAprobacion()
        {
            int contadorExamenesAprobados = 0;
            if(notaExamen.Count > 0)
            {
                foreach(var item in notaExamen)
                {
                    if(item.Value > 6)
                    {
                        contadorExamenesAprobados++;
                    }
                }
                if(contadorExamenesAprobados >= 2)
                {
                    if(Estado == 1)
                    {
                        aprobada = 1;
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
