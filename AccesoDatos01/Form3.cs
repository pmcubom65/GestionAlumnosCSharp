using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alumnosnotasmidataset.talumnosnotas' Puede moverla o quitarla según sea necesario.
            this.talumnosnotasTableAdapter.Fill(this.alumnosnotasmidataset.talumnosnotas);

            this.reportViewer1.RefreshReport();
        }
    }
}
