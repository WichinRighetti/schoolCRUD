using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Escuela.Layers;

namespace Escuela.Layers
{
    public class DAL
    {
        dbConn conn = new dbConn();
        public DataTable consultaAlumno(string alumno)
        {
            string query;
            DataTable dt = new DataTable();
            query = "Select * From alumno where activo = 1 and nombre like '%" + alumno + "%'";
            dt = conn.EjectutaConsulta(query);
            return dt;
        }
        public void insertarAlumno(string nombre, int edad, string telefono, string direccion)
        {
            string query;
            query = "insert into alumno(nombre,  edad, telefono, direccion) values('" + nombre + "','" + edad + "','" + telefono + "','" + direccion + "')";
            conn.EjecutaConsulta2(query);
        }

        public void eliminaAlumno(int id_alumno)
        {
            string query;
            query = "update alumno set activo = 0 where id_alumno =" + id_alumno;
            conn.EjecutaConsulta2(query);
        }

        public void modificaAlumno(int id_alumno, string nombre, int edad, string telefono, string direccion)
        {
            string query;
            query = "update alumno set nombre = '" + nombre + "', edad = '" + edad + "', telefono = '" + telefono + "', direccion = '" + direccion + "' where id_alumno =" + id_alumno;
            conn.EjecutaConsulta2(query);
        }

        public DataTable BuscarIdAlumno(int id_alumno)
        {
            string query;
            DataTable dt = new DataTable();
            query = "Select * From alumno where activo = 1 and id_alumno = " + id_alumno;
            dt = conn.EjectutaConsulta(query);
            return dt;
        }

        public void instertaMateria (string nombre)
        {
            string query = "INSERT INTO Materia (nombre) values('" + nombre + "')";
            conn.EjecutaConsulta2(query);
        }

        public void eliminaMateria(int id_materia)
        {
            string query;
            query = "update materia set activo = 0 where id_materia =" + id_materia;
            conn.EjecutaConsulta2(query);
        }

        public DataTable BuscarAluMat(string filtro, string valor)
        {
            string query, where;
            DataTable dt = new DataTable();
            if (filtro == "alumno")
            {
                where = " and al.nombre like '%" + valor + "%'";
            }
            else
            {
                where = " and mat.nombre like '%" + valor + "%'";
            }
            query = "SELECT id_relacion 'id', al.nombre 'alumno', mat.nombre 'materia', rma.calificacion 'calificacion' " +
                "from alumno al inner join rel_alumno rma on al.id_alumno = rma.alumno inner join " +
                "materia mat on rma.materia = mat.id_materia where rma.activo = 1 " + where;
            dt = conn.EjectutaConsulta(query);
            return dt;
        }

        public void insertarAluMat(int id_alumno, int id_materia, double calificacion)
        {
            string query = "insert into rel_alumno(alumno, materia, calificacion) values ("+ id_alumno +","+ id_materia +","+ calificacion +")";
            conn.EjecutaConsulta2(query);
        }

        public void EliminaAluMat (int id_relAlu)
        {
            string query = "update rel_alumno set activo = 0 where id_relacion = " + id_relAlu;
            conn.EjecutaConsulta2(query);
        }

        //primero parte para consulta y validcion de realcion aluMat
        public DataTable consultaAluMat(int alumno, int materia)
        {
            DataTable dt = new DataTable();
            string query = "select * from rel_alumno where alumno = " + alumno + " and materia = " + materia + ";";
            dt = conn.EjectutaConsulta(query);
            return dt;
        }

        // srgunda parte para modificacion de calif de aluMat
        public void modificaAluMat( double calificacion, int alumno, double materia)
        {
            string query = "update rel_alumno set calificacion =" + calificacion + " where alumno = " + alumno + " and materia = " + materia;
            conn.EjecutaConsulta2(query);
        }
        public DataTable ComboAlumno()
        {
            string query = "Select id_alumno, nombre from alumno where activo = 1";
            DataTable dt = new DataTable();
            dt = conn.EjectutaConsulta(query);
            return dt;
        }

        public DataTable ComboMateria()
        {
            string query = "Select id_materia, nombre from materia where activo = 1";
            DataTable dt = new DataTable();
            dt = conn.EjectutaConsulta(query);
            return dt;
        }
    }
}
