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
    public partial class frmConsultaalumno : Form
    {
        BL bl = new BL();
        public frmConsultaalumno()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBuscar.Text.ToString();
                DataTable dt = new DataTable();
                dt = bl.BuscarAlumno(nombre);
                if (dt.Rows.Count > 0)
                {
                    dgvAlumnos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nombre no valido", "Advertencia", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error, intentelo mas tarde", "Advertencia", MessageBoxButtons.OK);
            }
            
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAlumnos.Rows.Count <= 0 || dgvAlumnos.DataSource == null)
            {
                MessageBox.Show("Primero debes realizar una busqueda", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                int id_alumno = Convert.ToInt32(dgvAlumnos.Rows[e.RowIndex].Cells["id_alumno"].Value);
                bl.eliminaAlumno(id_alumno);
                MessageBox.Show("El alumno fue dado de baja", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
