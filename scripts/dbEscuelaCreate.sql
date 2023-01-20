create database Escuela;
use Escuela;

Create table Alumno (
id_alumno int primary key auto_increment,
nombre varchar(60),
edad int,
telefono varchar(20),
direccion varchar(200),
activo bit default 1);

Create table Materia(
id_materia int primary key auto_increment,
nombre varchar(60),
activo bit default 1
);

Create table rel_Alumno(
alumno int not null, 
materia int not null,
calificacion double,
activio bit default 1,

constraint FK_relAlumno foreign key (alumno) references Alumno (id_alumno),
 constraint FK_relMateria foreign key (materia) references Materia (id_materia)
);
