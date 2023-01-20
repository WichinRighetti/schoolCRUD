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
    public partial class frmModAlumno : Form
    {
        BL bl = new BL();
        int id_alumno = 0;
        public frmModAlumno()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = cmbBuscar.SelectedItem.ToString();
            DataTable dt = new DataTable();
            if (filtro == "Nombre")
            {
                try
                {
                    string valor = txBusqueda.Text.ToString();
                    dt = bl.BuscarAlumno(valor);
                    txtName.Text = dt.Rows[0]["Nombre"].ToString();
                    txtEdad.Text = dt.Rows[0]["edad"].ToString();
                    txtTel.Text = dt.Rows[0]["telefono"].ToString();
                    txtDir.Text = dt.Rows[0]["direccion"].ToString();
                    id_alumno = Convert.ToInt32(dt.Rows[0]["id_alumno"].ToString());
                }
                catch
                {
                    MessageBox.Show("Nombre no valido", "Advertencia", MessageBoxButtons.OK);
                }
            }
            else
            {
                int valor = Convert.ToInt32(txBusqueda.Text.ToString());
                dt = bl.BuscarIdAlumno(valor);
                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["Nombre"].ToString();
                    txtEdad.Text = dt.Rows[0]["edad"].ToString();
                    txtTel.Text = dt.Rows[0]["telefono"].ToString();
                    txtDir.Text = dt.Rows[0]["direccion"].ToString();
                    id_alumno = valor;
                }
                else
                {
                    MessageBox.Show("No hay alumnos que el ID ingresada", "Advertencia", MessageBoxButtons.OK);
                }
            }
        }

        public void limpiarContenido()
        {
            txtName.Text = "";
            txtEdad.Text = "";
            txtTel.Text = "";
            txtDir.Text = "";
            cmbBuscar.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFGuardar_Click(object sender, EventArgs e)
        {
            string nombre, direccion, telefono;
            int edad;

            nombre = txtName.Text;
            edad = Convert.ToInt32(txtEdad.Text);
            telefono = txtTel.Text;
            direccion = txtDir.Text;
            bl.ModificaAlumno(id_alumno, nombre, edad, telefono, direccion);
        }
    }
}
