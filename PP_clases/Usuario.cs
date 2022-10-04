using System.Text;

namespace PP_clases
{
    public abstract class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _contrasenia;
        private string _tipo;

        public Usuario(string nombre, string apellido, int dni ,string contrasenia, string tipo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _contrasenia = contrasenia;
            _tipo = tipo;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre 
        {
            get {return _nombre; } 
            set {_nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
        }
        public int Dni
        {
            get { return _dni; }
        }

        public static string EncontrarUsuarioTipo(int id, string pass ,List<Usuario> usuarios)
        {
            foreach(var item in usuarios)
            {
                if(id == item && pass == item)
                {
                    return item._tipo;
                }
            }
            return " No se encontro el usuario";
        }
        public static string BuscarNombreConId(int id, List<Usuario> usuarios)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in usuarios)
            {
                if (id == item)
                {
                    string nombre = UpperPrimerCaracter(item._nombre);
                    string apellido = UpperPrimerCaracter(item._apellido);
                    sb.AppendLine(nombre + " " + apellido);
                    return sb.ToString();
                }
            }
            return null;
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
            string nombre = UpperPrimerCaracter(Nombre);
            string apellido = UpperPrimerCaracter(Apellido);
            sb.AppendLine(nombre + " " + apellido);
            return sb.ToString();
        }
        public static string UpperPrimerCaracter(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return null;
            }
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }
        public static bool operator ==(int id, Usuario user)
        {
            if(id == user._id)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(int id, Usuario user)
        {
            return !(id == user._id);
        }
        public static bool operator ==(string pass, Usuario user)
        {
            if (pass == user._contrasenia)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(string pass, Usuario user)
        {
            return !(pass == user._contrasenia);
        }
    }
}