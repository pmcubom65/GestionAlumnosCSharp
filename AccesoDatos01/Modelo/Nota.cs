using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos01.Modelo
{
    class Nota
    {


        public string codigoalumnonota { get; set; }
        public string codigoenlacealumnonota { get; set; }
        public string evaluacionalumnonota { get; set; }
        public string moduloalumnonota { get; set; }
        public string notaalumno { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }

        public Nota() { }

    public Nota(Nota a)
        {
            codigoalumnonota = a.codigoalumnonota;
            codigoenlacealumnonota = a.codigoenlacealumnonota;
            evaluacionalumnonota = a.evaluacionalumnonota;
            moduloalumnonota = a.moduloalumnonota;
            notaalumno = a.notaalumno;

        }



    }
}
