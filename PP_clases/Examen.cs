using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_clases
{
    public class Examen
    {
        private E_instanciasExamen _nombre;

        private DateTime _fecha;

        public Examen(E_instanciasExamen nombre, DateTime fecha)
        {
            _nombre = nombre;
            _fecha = fecha;
        }

        public E_instanciasExamen Nombre
        {
            get { return _nombre; }
        }
        /// <summary>
        /// Permite mostrar el nombre del examen
        /// </summary>
        /// <returns></returns> un string con el nombre
        public string MostrarExamenNombre()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_nombre}   ");
            return sb.ToString();
        }
        /// <summary>
        /// Permite mostrar la nota  del examen
        /// </summary>
        /// <returns></returns> un string con la nota
        public string MostrarExamenFecha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_fecha.Day}/{_fecha.Month}/{_fecha.Year}");
            return sb.ToString();
        }
    }
}
