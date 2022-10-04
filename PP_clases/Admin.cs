
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_clases
{
    public class Admin : Usuario
    {
        private static int ultimoId;

        static Admin()
        {
            ultimoId = 1;
        }

        public Admin(string nombre, string apellido, int dni, string contrasenia) : base(nombre, apellido, dni, contrasenia, "admin")
        {
            Id = ultimoId;
            
            ultimoId++;
        }

        

       
    }
}
