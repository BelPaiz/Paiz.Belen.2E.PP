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
        /// <summary>
        /// Se utiliza para buscar un usuario dentro de una lista de usuarios
        /// compara id y contraseña
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pass"></param> contraseña
        /// <param name="usuarios"></param>
        /// <returns></returns> el tipo del usuario si lo encuentra o una cadena que indica que no se encontro
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
        /// <summary>
        /// Retorna el valor del id en un string
        /// </summary>
        /// <returns></returns>
        public string MostrarId()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_id}");
            return sb.ToString();
        }
        /// <summary>
        /// Concatena nombre y apellido, con la primer letra de ambos en mayuscula.
        /// </summary>
        /// <returns></returns> El nombre completo en un string
        public string MostrarNombreCompleto()
        {
            StringBuilder sb = new StringBuilder();
            string nombre = UpperPrimerCaracter(Nombre);
            string apellido = UpperPrimerCaracter(Apellido);
            sb.AppendLine(nombre + " " + apellido);
            return sb.ToString();
        }
        /// <summary>
        /// Comprueba que el texto del parametro no se null ni en blanco y coloca en mayuscula la primera letra
        /// y el resto en minuscula
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns> retorna un string del nombre modificado.
        public static string UpperPrimerCaracter(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return null;
            }
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }
        /// <summary>
        /// compara el int del parametro con el id del usuario
        /// </summary>
        /// <param name="id"></param> int del id a comparar
        /// <param name="user"></param> usuario del tipo Usuario
        /// <returns></returns> true si son iguales
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
        /// <summary>
        /// compara el string del parametro con la contraseña del usuario
        /// </summary>
        /// <param name="pass"></param> contraseña
        /// <param name="user"></param> usuario del tipo usuario
        /// <returns></returns> true si son iguales
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
        /// <summary>
        /// devuelve un string con un mensaje de bienvenida para el usuario
        /// </summary>
        /// <returns></returns> mensaje  + nombre completo
        public abstract string Saludar();
     
    }
}