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
    public partial class frmModAluMat : Form
    {
        BL bl = new BL();
        int id_alumno = 0, id_materia = 0;
        double calificacion = 0;

        public frmModAluMat()
        {
            InitializeComponent();
        }
        private void frmModAluMat_Load(object sender, EventArgs e)
        {
            DataTable dtA = new DataTable();
            dtA = bl.ComboAlumno();
            cmbAlu.DataSource = dtA;
            cmbAlu.ValueMember = "id_alumno";
            cmbAlu.DisplayMember = "nombre";

            DataTable dtM = new DataTable();
            dtM = bl.ComboMateria();
            cmbMat.DataSource = dtM;
            cmbMat.ValueMember = "id_materia";
            cmbMat.DisplayMember = "nombre";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                id_alumno = Convert.ToInt32(cmbAlu.SelectedValue.ToString());
                id_materia = Convert.ToInt32(cmbMat.SelectedValue.ToString());
                dt = bl.consultaAluMat(id_alumno, id_materia);
                txtCalif.Text = dt.Rows[0]["calificacion"].ToString();
            }
            catch
            {
                MessageBox.Show("Busqueda no arrojo datos", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                calificacion = Convert.ToDouble(txtCalif.Text.ToString());
                id_alumno = Convert.ToInt32(cmbAlu.SelectedValue.ToString());
                id_materia = Convert.ToInt32(cmbMat.SelectedValue.ToString());
                bl.InsertaAluMat(id_alumno, id_materia, calificacion);
            }
            catch
            {
                MessageBox.Show("Por favor digite una calificaion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                id_alumno = Convert.ToInt32(cmbAlu.SelectedValue.ToString());
                id_materia = Convert.ToInt32(cmbMat.SelectedValue.ToString());
                calificacion = Convert.ToDouble(txtCalif.Text);
                bl.ModificaAluMat(calificacion, id_alumno, id_materia);
            }
            catch
            {
                MessageBox.Show("Por favor realice busqueda primero", "Advertencia", MessageBoxButtons.OK);
            }
        }

    }
}
