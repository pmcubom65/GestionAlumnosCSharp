using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos01.Controlador
{
    
    class MiControlador
    {

        DataGridViewRow row;

        public Boolean comprobarDatosFila(DataGridViewRow row)
        {
             
            if (row == null)
            {
                return false;
            }else
            {
                return true;
            }
        }


        public Boolean comprobarValores(string s1, string s2, string s3, string s4)
        {
            if (s1.Length == 0 || s2.Length == 0 || s3.Length == 0 || s4.Length == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }


    }
}
