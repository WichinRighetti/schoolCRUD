using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escuela.Layers;
using System.Windows.Forms;
using System.Data;

namespace Escuela.Layers
{
    public class BL
    {
        DAL dal = new DAL();
        public void InsertaAlumno(string nombre, int edad, string direccion, string telefono)
        {

            if (nombre == null || nombre.Length < 3)
            {
                MessageBox.Show("Nombre no valido", "Advertencia", MessageBoxButtons.OK);
            }else if(direccion==null || direccion.Length < 3){
                MessageBox.Show("Direccion no valida", "Advertencia", MessageBoxButtons.OK);
            }else if(telefono == null || telefono.Length < 10){
                MessageBox.Show("Telefono no valido", "Advertencia", MessageBoxButtons.OK);
            }else if(edad <= 0){
                MessageBox.Show("Ingresa una edad valida", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    dal.insertarAlumno(nombre, edad, direccion, telefono);
                    MessageBox.Show("Alumno dado de alta", "SUCCESS", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
            }
        }

        public DataTable BuscarAlumno(string nombre)
        {
                DataTable dt = new DataTable();
                dt = dal.consultaAlumno(nombre);
                return dt;
        }

        public void eliminaAlumno(int id_alumno)
        {
            if(id_alumno <= 0)
            {
                MessageBox.Show("ID no valida", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                dal.eliminaAlumno(id_alumno);
            }
        }
        
        public DataTable BuscarIdAlumno(int id_alumno)
        {
            if (id_alumno <= 0)
            {
                MessageBox.Show("No hay alumnos que el ID ingresada", "Advertencia", MessageBoxButtons.OK);
                return null;
            
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dal.BuscarIdAlumno(id_alumno);
                return dt;
            }
        }

        public void ModificaAlumno(int id_alumno, string nombre, int edad, string telefono, string direccion)
        {
            if (nombre == null || nombre.Length < 3)
            {
                MessageBox.Show("Nombre no valido", "Advertencia", MessageBoxButtons.OK);
            }
            else if (direccion == null || direccion.Length < 3)
            {
                MessageBox.Show("Direccion no valida", "Advertencia", MessageBoxButtons.OK);
            }
            else if (telefono == null || telefono.Length < 10)
            {
                MessageBox.Show("Telefono no valido", "Advertencia", MessageBoxButtons.OK);
            }
            else if (edad <= 0)
            {
                MessageBox.Show("Ingresa una edad valida", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    dal.modificaAlumno(id_alumno, nombre, edad, telefono, direccion);
                    MessageBox.Show("Alumno fue modificado", "SUCCESS", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
            }
        }


        public void insetarMateria(string nombre)
        {
            if (nombre == null || nombre.Length < 3)
            {
                MessageBox.Show("Nombre no valido", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    dal.instertaMateria(nombre);
                    MessageBox.Show("Materia dada de alta", "SUCCESS", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
            }
        }

        public void eliminaMat(int id_materia)
        {
            if (id_materia <= 0)
            {
                MessageBox.Show("ID no valida", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                dal.eliminaMateria(id_materia);
            }
        }

        public DataTable BuscaAluMat (string filtro, string valor)
        {
            try{
                DataTable dt = new DataTable();
                if (filtro == null && filtro.Length < 3)
                {
                    MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
                else if (filtro == null && valor.Length < 3)
                {
                    MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
                else
                {
                    dt = dal.BuscarAluMat(filtro, valor);
                }
                return dt;
            }
            catch
            {
                MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                return null;
            }
        }

        public void InsertaAluMat (int id_alumno, int id_materia, double calificacion)
        {
            try {
                if (id_alumno == 0)
                {
                    MessageBox.Show("Ocurrio un error con el alumno, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
                else if (id_materia == 0)
                {
                    MessageBox.Show("Ocurrio un error con la materia, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
                else if (calificacion < 0)
                {
                    MessageBox.Show("Ocurrio un error con la calificacion, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
                else {
                    dal.insertarAluMat(id_alumno, id_materia, calificacion);
                    MessageBox.Show("La calificacion fue ingresada correctamente", "Exito", MessageBoxButtons.OK);
                }
            }
            catch {
                MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
            }
        }

        public void EliminaAluMat(int id_relAlu)
        {
            try
            {
                if (id_relAlu == 0)
                {
                    MessageBox.Show("Ocurrio un error con el alumno, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
                else
                {
                    dal.EliminaAluMat(id_relAlu);
                    MessageBox.Show("Se elimino la relacion alumno-materia", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
            }
        }

        public DataTable consultaAluMat(int alumno, int materia)
        {
            DataTable dt = new DataTable();
            dt = dal.consultaAluMat(alumno, materia);
            return dt;
        }
        public void ModificaAluMat(double calificacion, int alumno, double materia)
        {
            try
            {
                if (calificacion < 0)
                {
                    MessageBox.Show("Ocurrio un error con la calificacion, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
                }
                else
                {
                    dal.modificaAluMat(calificacion,alumno,materia);
                    MessageBox.Show("La calificacion fue modificada correctamente", "Exito", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error, vuelve a intentar", "Advertencia", MessageBoxButtons.OK);
            }
        }
        public DataTable ComboAlumno()
        {
            DataTable dt = new DataTable();
            dt = dal.ComboAlumno();
            return dt;
        }
        public DataTable ComboMateria()
        {
            DataTable dt = new DataTable();
            dt = dal.ComboMateria();
            return dt;
        }
    }
}
