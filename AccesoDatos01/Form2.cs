using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using AccesoDatos01.Modelo;

namespace AccesoDatos01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try //Capturar la excepción por si diera error.
            {
                ModeloDatos accederDatos = new ModeloDatos();
                accederDatos.datosAlumnos();
                //Guardar los datos en un Adaptador.
                DataSet ds = new DataSet();
                accederDatos.m_datos.Fill(ds);
                List<Alumno> Agregar = new List<Alumno>();
                foreach (DataRow Lista in ds.Tables[0].Rows)
                {
                    Agregar.Add(new Alumno
                    {
                        Codigo = Lista[0].ToString(),
                        Nombre = Lista[1].ToString(),
                        Apellidos = Lista[2].ToString(),
                        Dni = Lista[3].ToString(),
                        Direccion = Lista[4].ToString()
                    });


                    this.reportViewer1.RefreshReport();
                }
                reportViewer1.LocalReport.DataSources.Clear();
                LocalReport localReport = reportViewer1.LocalReport;
                localReport.EnableExternalImages = true; //Para visualizar gráficos.
                ReportDataSource rds1 = new ReportDataSource("Alumnos", Agregar);
                localReport.DataSources.Add(rds1);
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mostrar cualquier excepción.
            }


        }



            private void Button1_Click(object sender, EventArgs e)
        {
            //Llamar al Form2 para visualizar el informe.
            Form2 frm = new Form2();
            frm.Show();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
