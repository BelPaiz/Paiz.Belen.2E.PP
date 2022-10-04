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

        public string MostrarExamenNombre()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_nombre}   ");
            return sb.ToString();
        }
        public string MostrarExamenFecha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_fecha.Day}/{_fecha.Month}/{_fecha.Year}");
            return sb.ToString();
        }
    }
}
