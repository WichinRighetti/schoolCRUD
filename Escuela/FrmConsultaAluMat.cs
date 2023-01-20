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
    public partial class FrmConsultaAluMat : Form
    {
        BL bl = new BL();
        int id_relAlu = 0;
        public FrmConsultaAluMat()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro, valor;
                filtro = cmbFiltro.Text.ToString();
                valor = txtDato.Text.ToString();
                DataTable dt = new DataTable();
                dt = bl.BuscaAluMat(filtro, valor);
                dgvAluMat.DataSource = dt;
                if(dgvAluMat.Rows.Count <= 0)
                {
                    MessageBox.Show("Vuelve a intentar tu busqueda", "Advertencia", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Vuelve a intentar tu busqueda", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void dgvAluMat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAluMat.Rows.Count <=0 || dgvAluMat.DataSource == null) 
            {
                MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
            }
            else 
            {
                id_relAlu = Convert.ToInt32(dgvAluMat.Rows[e.RowIndex].Cells["id"].Value);
                bl.EliminaAluMat(id_relAlu);
                MessageBox.Show("Se dio de baja el alumno de esta materia", "Advertencia", MessageBoxButtons.OK);
            }
        }
    }
}
