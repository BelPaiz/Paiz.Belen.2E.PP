using PP_clases;
namespace PP_Vista
{
    public partial class frm_login : Form
    {
        List<Usuario> usuarios;
        List<Admin> adminds;
        List<Profesor> profes;
        List<Alumno> alumnos;
        List<Materia> materias;
        public frm_login()
        {
            InitializeComponent();
            adminds = new List<Admin>();
            profes = new List<Profesor>();
            usuarios = new List<Usuario>();
            alumnos = new List<Alumno>();
            materias = new List<Materia>();
            Carga();
            usuarios.AddRange(adminds);
            usuarios.AddRange(profes);
            usuarios.AddRange(alumnos);
        }
        /// <summary>
        /// Harcodea los valores ingresados y crea las distintas listas
        /// </summary>
        private void Carga()
        {
            Admin admin1 = new Admin("Juliana", "Perez", 26358914, "123");
            Admin admin2 = new Admin("Andres", "Juarez", 31562987, "123");
            Admin admin3 = new Admin("Juan", "Martinez", 27896532, "123");
            Admin admin4 = new Admin("Ana", "Paez", 15026985, "123");
            adminds.Add(admin1);
            adminds.Add(admin2);
            adminds.Add(admin3);
            adminds.Add(admin4);
            Profesor profe1 = new Profesor("Cesar", "Gomez", 36897452, "123");
            Profesor profe2 = new Profesor("Marcos", "Conte", 45210369, "123");
            Profesor profe3 = new Profesor("Pedro", "Garcia", 13654789, "123");
            Profesor profe4 = new Profesor("Analia", "Jimenez", 22369852, "123");
            Profesor profe5 = new Profesor("Mabel", "Guaso", 158743, "123");
            profes.Add(profe1);
            profes.Add(profe2);
            profes.Add(profe3);
            profes.Add(profe4);
            profes.Add(profe5);
            Alumno alum1 = new Alumno("German", "Ortiz", 48963258, "123", "Programacion");
            Alumno alum2 = new Alumno("Franco", "Maus", 25147963, "123", "Programacion II");
            Alumno alum3 = new Alumno("Ornela", "Uries", 12365478, "123", "Matematica");
            Alumno alum4 = new Alumno("Florencia", "Ferro", 56412389, "123", "Matematica II");
            Alumno alum5 = new Alumno("Camila", "Kiko", 11456985, "123", "Ingles");
            Alumno alum6 = new Alumno("Jonathan", "Juez", 25369852, "123", "Ingles II");
            Alumno alum7 = new Alumno("Matias", "Lopez", 12635625, "123", "Programacion");
            Alumno alum8 = new Alumno("Mateo", "Meza", 29852147, "123", "Ingles");
            Alumno alum9 = new Alumno("Laura", "Altamira", 33654256, "123", "Matematica");
            Alumno alum10 = new Alumno("Gisel", "Barco", 36521487, "123", "Matematica II");
            alumnos.Add(alum1);
            alumnos.Add(alum2);
            alumnos.Add(alum3);
            alumnos.Add(alum4);
            alumnos.Add(alum5);
            alumnos.Add(alum6);
            alumnos.Add(alum7);
            alumnos.Add(alum8);
            alumnos.Add(alum9);
            alumnos.Add(alum10);
            Materia programacion = new Materia("Programacion", 1, 100, 0);
            Materia programacion2 = new Materia("Programacion II", 2, 101, 1);
            Materia matematica = new Materia("Matematica", 1, 102, 0);
            Materia matematica2 = new Materia("Matematica II", 2, 102, 3);
            Materia Ingles = new Materia("Ingles", 1, 103, 0);
            Materia Ingles2 = new Materia("Ingles II", 2, 104, 5);
            materias.Add(programacion);
            materias.Add(programacion2);
            materias.Add(matematica);
            materias.Add(matematica2);
            materias.Add(Ingles);
            materias.Add(Ingles2);
            ConectarMateriaProfe(materias, profes);
            ConectarMateriaAlumno(materias, alumnos);
        }
        /// <summary>
        /// Al clickear en ingresar se comprueba la informacion de inicio de sesion 
        /// y si el usuario existe se redirige al inicio correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string buffer = txb_user.Text;
            int id;
            bool ok = int.TryParse(buffer, out id); 
            string pass = txb_pass.Text;
            string resultado = Usuario.EncontrarUsuarioTipo(id, pass, usuarios);
            switch (resultado)
            {
                case "admin":
                    foreach (Admin ad in adminds)
                    {
                        if (id == ad.Id)
                        {
                            frm_inicioAdmin frm_InicioAdmin = new frm_inicioAdmin(ad, alumnos, profes, adminds, materias);
                            frm_InicioAdmin.Show();
                            this.Hide();
                            break;
                        }
                    }
                    
                    break;
                case "profe":
                    foreach(Profesor p in profes)
                    {
                        if(id == p.Id)
                        {
                            frm_Inicio_Profe frm_inicioProfe = new frm_Inicio_Profe(p);
                            frm_inicioProfe.Show();
                            this.Hide();
                            break ;
                        }
                    }
                    break;
                case "alumno":
                    foreach(Alumno a in alumnos)
                    {
                        if(id == a.Id)
                        {
                            frm_Inicio_Alumno frm_InicioAlumno = new frm_Inicio_Alumno(a, materias);
                            frm_InicioAlumno.Show();
                            this.Hide();
                            break;
                        }
                    }
                    break;
                default:
                    MessageBox.Show(resultado);
                    break;
            }
        }
        /// <summary>
        /// Añade las materias harcodeadas en la lista del profesor a cargo
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        public void ConectarMateriaProfe(List<Materia> m, List<Profesor>p)
        {
            foreach (Materia materia in m)
            {
                foreach(Profesor profe in p)
                {
                    if(materia.Id_ProfesorACargo == profe.Id)
                    {
                        profe.AnadirMateriaProfe(materia.Id, m);
                    }
                }
            }
        }
        /// <summary>
        /// Añade la materia harcodeada en la lista de cursadas del alumno
        /// </summary>
        /// <param name="m"></param>
        /// <param name="al"></param>
        public void ConectarMateriaAlumno(List<Materia> m, List<Alumno> al)
        {
            foreach(Materia mate in m)
            {
                foreach(Alumno alumno in al)
                {
                    foreach(Cursada c in alumno.Cursada)
                    {
                        if (mate.Nombre == c.Materia)
                        {
                            mate.AgregarAlumno(alumno);
                        }
                    }
                    
                }
            }
        }

        private void btn_rellenarAdmin_Click(object sender, EventArgs e)
        {
            txb_user.Text = "1";
            txb_pass.Text = "123";
        }

        private void btn_rellenarProfe_Click(object sender, EventArgs e)
        {
            txb_user.Text = "100";
            txb_pass.Text = "123";
        }

        private void btn_rellenarAlumno_Click(object sender, EventArgs e)
        {
            txb_user.Text = "1002";
            txb_pass.Text = "123";
        }
    }
}