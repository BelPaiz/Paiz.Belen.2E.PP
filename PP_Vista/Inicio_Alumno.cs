﻿using PP_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Vista
{
    public partial class frm_Inicio_Alumno : Form
    {
        private string _user;
        private Alumno usuario;
        private List<Cursada> cursadas;
        public Cursada cursada = new Cursada();
        private int cuatriCursada1;
        private int correlativaCursada1;
        private string cursadaAprobada = "no";
        private string estadoCursada = "Libre";
        private List<Materia> materias = new List<Materia>();
        private string materiaSeleccion = null;
        private Materia materiaInscripcion;
        public frm_Inicio_Alumno()
        {
            InitializeComponent();
        }
        public frm_Inicio_Alumno(string user, Alumno alumno, List<Materia> maters) :this()
        {
            _user = user;
            usuario = alumno;
            materias = maters;
            cursadas = alumno.Cursada;  
        }

        private void frm_Inicio_Alumno_Load(object sender, EventArgs e)
        {
            this.lbl_bienvenida.Text = "Bienvenid@ " + _user;

            RecargarCursadas(cursadas);
        }

        private void frm_Inicio_Alumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void RecargarCursadas(List<Cursada>curs)
        {
            foreach(Cursada c in curs)
            {
                BuscarInfoMateria(c);
                int j = dtg_cursadas.Rows.Add();
                dtg_cursadas.Rows[j].Cells[0].Value = c.Materia;
                dtg_cursadas.Rows[j].Cells[1].Value = cuatriCursada1;
                dtg_cursadas.Rows[j].Cells[2].Value = NombreCorrelativa(correlativaCursada1);
                if(c.Estado == 1)
                {
                    estadoCursada = "Regular";
                }
                dtg_cursadas.Rows[j].Cells[3].Value = estadoCursada;
                if (c.Aprobada == 1)
                {
                    cursadaAprobada = "si";
                }
                dtg_cursadas.Rows[j].Cells[4].Value = cursadaAprobada;
                dtg_cursadas.Rows[j].Cells[5].Value = c.Presente;
            }
            
        }
        private void BuscarInfoMateria(Cursada c)
        {
            foreach(Materia m in materias)
            {
                if(m.Nombre == c.Materia)
                {
                    cuatriCursada1 = m.Cuatrim;
                    correlativaCursada1 = m.Correlativa;
                    break;
                }
            }
        }
        private string NombreCorrelativa(int correlat)
        {
            foreach(Materia m in materias)
            {
                if(m.Id == correlat)
                {
                    return m.Nombre;
                }
            }
            return "no tiene";
        }

        private void dtg_cursadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string value = (string)dtg_cursadas.Rows[n].Cells[0].Value;
                materiaSeleccion = value;
            }
        }

        private void btn_presente_Click(object sender, EventArgs e)
        {
            if(materiaSeleccion != null)
            {
                foreach (Cursada c in cursadas)
                {
                    if (materiaSeleccion == c.Materia)
                    {
                        c.DarPresente();
                        break;
                    }
                }
                lbl_info.Text = "Presente registrado";
                dtg_cursadas.Rows.Clear();
                RecargarCursadas(cursadas);
            }
            else
            {
                lbl_info.Text = "Seleccione nombre de materia";
            }
            
        }

        private void inscripcionAMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionMaterias frm_inscripcionMaterias = new InscripcionMaterias(materias, usuario);
            DialogResult resultado = frm_inscripcionMaterias.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                materiaInscripcion = frm_inscripcionMaterias.GetMateria();
                if(cursadas.Count < 2)
                {
                    usuario.AnadirCursada(materiaInscripcion.Nombre);
                    //cursadas.Clear();
                    cursadas = usuario.Cursada;
                    lbl_info.Text = "Incripcion exitosa!";
                    dtg_cursadas.Rows.Clear();
                    RecargarCursadas(cursadas);
                }
                else
                {
                    lbl_info.Text = "Solo puede cursar 2 materias simultaneamente";
                }
                
            }
            else
            {
                lbl_info.Text = "Incripcion cancelada por el usuario";
            }
        }
    }
}
