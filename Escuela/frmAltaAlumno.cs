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
    public partial class frmAltaAlumno : Form
    {
        BL BL = new BL();
        public frmAltaAlumno()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string nombre, telefono, direccion;
            int edad;

            nombre = txtName.Text.ToString();
            telefono = txtTel.Text.ToString();
            direccion = txtDir.Text.ToString();
            edad = Int16.Parse(txtEdad.Text.ToString());
            BL.InsertaAlumno(nombre, edad ,direccion , telefono);
        }
    }
}
