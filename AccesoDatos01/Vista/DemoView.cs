using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos01.Controlador;

namespace AccesoDatos01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Código_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDatos accederDatos = new ModeloDatos();
                accederDatos.datosAlumnos();

                DataSet ds = new DataSet();
               accederDatos.m_datos.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Visible = true;
             
                dataGridView1.Columns[0].HeaderText = "Código";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Apellidos";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].HeaderText = "DNI";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Dirección";
                dataGridView1.Columns[4].Width = 260;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try 
            {
                
                DataGridViewRow row = dataGridView1.CurrentRow; 
                MiControlador mc = new MiControlador();
                if (!mc.comprobarDatosFila(dataGridView1.CurrentRow))
                {
                    MessageBox.Show("Para cargar datos en las cajas se debe hacer Clic en el botón 'Mostrar Datos de los Alumnos'");
                    return; 
                }
                else
                {
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    textBox4.Text = row.Cells[3].Value.ToString();
                    textBox5.Text = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ModeloDatos md = new ModeloDatos();
            MiControlador mc = new MiControlador();

            if (textBox1.TextLength>0)
            {
                MessageBox.Show("El código del alumno se generará automáticamente");
            } if (!mc.comprobarValores(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text))
            {
                System.Windows.Forms.MessageBox.Show("los campos tienen que rellenarse");
            } else
            {

                md.ingresarDatosAlumnos(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                Button2_Click(sender, e);
            }

           

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void Button5_Click(object sender, EventArgs e)
        {


            MiControlador mc = new MiControlador();
            if (!mc.comprobarValores(textBox2.Text, textBox3.Text, textBox4.Text , textBox5.Text))
            {

                MessageBox.Show("Tiene que rellenar al menos un campo");
            } else {
                

                DataGridViewRow row = dataGridView1.CurrentRow;
              
                if (!mc.comprobarDatosFila(dataGridView1.CurrentRow))
                {
                    MessageBox.Show("Para cargar datos en las cajas se debe hacer Clic en el botón 'Mostrar Datos de los Alumnos'");
                    return; 
                }
                else
                {

                    ModeloDatos md = new ModeloDatos();

                    List<TextBox> listadecajas = new List<TextBox>();
                    listadecajas.Add(textBox1);
                    listadecajas.Add(textBox2);
                    listadecajas.Add(textBox3);
                    listadecajas.Add(textBox4);
                    listadecajas.Add(textBox5);

                    for (int i = 1; i < listadecajas.Count; i++)
                    {
                        if (listadecajas[i].TextLength != 0)
                        {
                            md.actualizarDatosAlumnos(row.Cells[0].Value.ToString(),
                                listadecajas[i].Text.ToString(), i);
                        }
                    }

                    Button2_Click(sender, e);
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try 
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                MiControlador mc = new MiControlador();
                if (!mc.comprobarDatosFila(dataGridView1.CurrentRow))


                {
                    MessageBox.Show("Para borrar un registro se tiene que seleccionar un registro");
                    return; 
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Se necesita confirmación borrar registro", "Se necesita confirmación borrar registro", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ModeloDatos md = new ModeloDatos();


                        md.borrarDatosAlumnos(row.Cells[0].Value.ToString());
                        Button2_Click(sender, e);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mostrar cualquier excepción.
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ModeloDatos accederDatos= new ModeloDatos();
            accederDatos.buscarAlumno(textBox7.Text);

            DataSet ds = new DataSet();
            accederDatos.m_datos.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Visible = true;
            //Cambiar el nombre a las columnas y su ancho.
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Apellidos";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "DNI";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Dirección";
            dataGridView1.Columns[4].Width = 260;

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //Llamar al Form2 para visualizar el informe.
            Form2 frm = new Form2();
            frm.Show();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
