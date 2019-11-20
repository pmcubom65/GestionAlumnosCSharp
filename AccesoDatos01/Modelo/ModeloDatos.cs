using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos01.Controlador;


namespace AccesoDatos01
{

    class ModeloDatos
    {
        public MySqlConnection Conexion; 
        public MySqlDataAdapter m_datos; 
        

        public ModeloDatos()
        {
               Conexion = new MySqlConnection("server=localhost; database=educacion; Uid=root; pwd=");
        //    Conexion = new MySqlConnection("server=db4free.net; port=3306; database=educacion; Uid=alumnojcps; pwd=alumno1#; old guids=true");

        }
        public void datosAlumnos()
        {
            try 
            {
                Conexion.Open(); 
                                 
                MySqlCommand mostrar = new MySqlCommand("select * from talumnos", Conexion);
                m_datos = new MySqlDataAdapter(mostrar);
                Conexion.Close(); 
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void datosAlumnosNotas()
        {
            try
            {
                Conexion.Open();

                MySqlCommand mostrar = new MySqlCommand("SELECT * FROM `talumnosnotas` join `talumnos` on codigoenlacealumnonota=codigoalumno;", Conexion);
                m_datos = new MySqlDataAdapter(mostrar);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
          
        }







        public void alumnosNotas()
        {
            try
            {
                Conexion.Open();

                MySqlCommand mostrar = new MySqlCommand("select * from talumnosnotas", Conexion);
                m_datos = new MySqlDataAdapter(mostrar);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        public void ingresarDatosAlumnos(string nombre, string apellido, string dni, string direccion)

        {
            try 
            {
                    Conexion.Open(); 
                                     
                    string sentencia = string.Format("insert into talumnos (apellidosalumno, direccionalumno, dnialumno, nombrealumno) values ('{0}', '{1}', '{2}', '{3}');", apellido, direccion, dni, nombre);

                    MySqlCommand comm = Conexion.CreateCommand();

                    comm.CommandText = sentencia;

                    comm.ExecuteNonQuery();

                    Conexion.Close(); 
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message); 
                }
            }
        


        public void borrarDatosAlumnos(string codigo)

        {

                try 
                {
                    Conexion.Open(); 
                                     

                int salida;
                Int32.TryParse(codigo, out salida);

                    string sentencia = "delete from talumnos where codigoalumno="+salida+";";



                    MySqlCommand comm = Conexion.CreateCommand();

                    comm.CommandText = sentencia;

                    comm.ExecuteNonQuery();

                    Conexion.Close(); 
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message); 
                }
            
        }


        public void buscarAlumno(string texto)
        {
            string sentencia = String.Format("SELECT *  FROM  talumnos WHERE nombrealumno like '{0}%' or apellidosalumno like '{1}%';", texto, texto) ;
           

           try
            {
                Conexion.Open();

                MySqlCommand mostrar = new MySqlCommand(sentencia, Conexion);
                m_datos = new MySqlDataAdapter(mostrar);


                MySqlCommand comm = Conexion.CreateCommand();

                comm.CommandText = sentencia;

                comm.ExecuteNonQuery();

                Conexion.Close(); 
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message); 
            }
        }

        public void actualizarDatosAlumnos(string codigo, string texto, int indice)

        {

            try 
            {
                Conexion.Open(); 
                                 

                int salida;
                Int32.TryParse(codigo, out salida);
                string campo="";
                switch (indice)
                {
                    case 1: campo = "nombrealumno";break;
                    case 2: campo = "apellidosalumno"; break;
                    case 3: campo = "dnialumno"; break;
                    case 4: campo = "direccionalumno"; break;
                }


                string primeraparte = String.Format("update talumnos set {0}='{1}' where codigoalumno=", campo, texto);
                string sentencia = primeraparte + salida + ";";

                MySqlCommand comm = Conexion.CreateCommand();

                comm.CommandText = sentencia;

                comm.ExecuteNonQuery();

                Conexion.Close(); 
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message); 
            }

        }


    }

   


}
