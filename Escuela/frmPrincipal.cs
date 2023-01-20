using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escuela.Layers;

namespace Escuela
{
    public partial class FrmPrincipal : Form
    {
        public frmAltaAlumno frmAltaAlumno;
        public frmConsultaalumno frmConsultaalumno;
        public frmAltaMateria frmAltaMateria;
        public frmModAlumno FrmModAlumno;
        public FrmConsultaAluMat FrmConsultaAluMat;
        public frmModAluMat FrmModAluMat;

        dbConn conn = new dbConn();
        public FrmPrincipal()
        {
            conn.dbConnect();
            InitializeComponent();
        }

        private void msAltaAlumno_Click(object sender, EventArgs e)
        {
            if(frmAltaAlumno == null || frmAltaAlumno.IsDisposed)
            {
                frmAltaAlumno = new frmAltaAlumno();
                frmAltaAlumno.Show();
                frmAltaAlumno.MdiParent = this;
            }
            else
            {
                MessageBox.Show("Ya existe una ventana abierta","Alerta",MessageBoxButtons.OK);
            }
        }

        private void msConsultaAlumno_Click(object sender, EventArgs e)
        {
            if (frmConsultaalumno == null || frmConsultaalumno.IsDisposed)
            {
                frmConsultaalumno = new frmConsultaalumno();
                frmConsultaalumno.Show();
                frmConsultaalumno.MdiParent = this;
            }
            else
            {
                MessageBox.Show("Ya existe una ventana abierta", "Alerta", MessageBoxButtons.OK);
            }
        }

        private void msMateriaAlta_Click(object sender, EventArgs e)
        {
            if (frmAltaMateria == null || frmAltaMateria.IsDisposed)
            {
                frmAltaMateria = new frmAltaMateria();
                frmAltaMateria.Show();
                frmAltaMateria.MdiParent = this;
            }
            else
            {
                MessageBox.Show("Ya existe una ventana abierta", "Alerta", MessageBoxButtons.OK);
            }
        }


        private void msModAlumno_Click(object sender, EventArgs e)
        {
            if (FrmModAlumno == null || FrmModAlumno.IsDisposed)
            {
                FrmModAlumno = new frmModAlumno();
                FrmModAlumno.Show();
                FrmModAlumno.MdiParent = this;
            }
            else
            {
                MessageBox.Show("Ya existe una ventana abierta", "Alerta", MessageBoxButtons.OK);
            }
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FrmConsultaAluMat == null || FrmConsultaAluMat.IsDisposed)
            {
                FrmConsultaAluMat = new FrmConsultaAluMat();
                FrmConsultaAluMat.Show();
                FrmConsultaAluMat.MdiParent = this;
            }
            else
            {
                MessageBox.Show("Ya existe una ventana abierta", "Alerta", MessageBoxButtons.OK);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmModAluMat == null || FrmModAluMat.IsDisposed)
            {
                FrmModAluMat = new frmModAluMat();
                FrmModAluMat.Show();
                FrmModAluMat.MdiParent = this;
            }
            else
            {
                MessageBox.Show("Ya existe una ventana abierta", "Alerta", MessageBoxButtons.OK);
            }
        }
    }
}
