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
    public partial class frmAltaMateria : Form
    {
        BL BL = new BL();
        public frmAltaMateria()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txtNombre.Text.ToString();
            BL.insetarMateria(nombre);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaMateria_Load(object sender, EventArgs e)
        {
            DataTable dtM = new DataTable();
            dtM = BL.ComboMateria();
            dgvMateria.DataSource = dtM;
        }

        private void dgvMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMateria.Rows.Count <= 0 || dgvMateria.DataSource == null)
            {
                MessageBox.Show("Primero debes realizar una busqueda", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                int id_materia = Convert.ToInt32(dgvMateria.Rows[e.RowIndex].Cells["id_materia"].Value);
                BL.eliminaMat(id_materia);
                MessageBox.Show("La materia fue dada de baja", "Advertencia", MessageBoxButtons.OK);
            }
        }
    }
}
