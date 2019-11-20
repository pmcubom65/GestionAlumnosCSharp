using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos01.Modelo
{
    public class Alumno
    {
        //Propiedades get y set
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        //Asignar el constructor por defecto para que no genere error de argumentos.
        public Alumno()
        {
        }
        //Constructor que recibe parámetro de la misma clase.
        public Alumno(Alumno Add)
        {
            Codigo = Add.Codigo;
            Nombre = Add.Nombre;
            Apellidos = Add.Apellidos;
            Dni = Add.Dni;
            Direccion = Add.Direccion;
        }
    }
}
