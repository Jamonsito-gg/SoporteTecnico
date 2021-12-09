using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Data.SqlClient;
using SoporteTecnico.Modelo;
using SoporteTecnico.Controlador;


namespace SoporteTecnico
{
    public partial class Ingreso : Form
    {
       
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if ((txtNombre.Text != "") && (txtApellido.Text != "") && (txtCorreo.Text != "") && (txtDescripción.Text != "") && (comboBoxDispositivo.Text != "") && (comboBoxEstado.Text != ""))
            {
                try
                {
                    ESTicket EST = new ESTicket(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtCorreo.Text,
                    comboBoxEstado.Text,
                    comboBoxDispositivo.Text,
                    txtDescripción.Text

                    );
                    EST.insertarticket();

                    MessageBox.Show("Ingresado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarTicket();
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MessageBox.Show("No se puede agregar con valores vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtDescripción.Text = "";
            comboBoxDispositivo.Text = "";
            comboBoxEstado.Text = "";
        }

        private void selectedRowsButton_Click(object sender, EventArgs e)
        {

            try
            {
                
                int NumTicket = (int)dataGridView1[3, dataGridView1.CurrentRow.Index].Value;
                ESTicket ticketeliminar = new ESTicket();
                ticketeliminar.eliminarticket(NumTicket);
                MessageBox.Show("Se eliminó el ticket", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarTicket();
            }
            catch
            {
                MessageBox.Show("No se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            
            Close();
        }



        private void Ingreso_Load(object sender, EventArgs e)
        {
            MostrarTicket();
        }


        public void MostrarTicket()
        {
            DataTable DT = new DataTable();
            BDTicket bdt = new BDTicket();
            bdt.mostrar(ref DT);
            dataGridView1.DataSource = DT;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumTicket = (int)dataGridView1[3, dataGridView1.CurrentRow.Index].Value;
            Modificar modificar = new Modificar();
            modificar.modiNombre.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            modificar.modiApellido.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            modificar.modiCorreo.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            modificar.comboBoxModiEstado.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();


            modificar.ShowDialog();
        }
    }
}
