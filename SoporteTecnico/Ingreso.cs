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
            

               try
                {
                    //string i = 0;
                    //i = i++;
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = txtNombre.Text;
                    dataGridView1.Rows[n].Cells[1].Value = txtApellido.Text;
                    dataGridView1.Rows[n].Cells[2].Value = txtCorreo.Text;
                    dataGridView1.Rows[n].Cells[3].Value = numericUpDown1.Text;
                    dataGridView1.Rows[n].Cells[6].Value = comboBoxDispositivo.SelectedItem;
                    dataGridView1.Rows[n].Cells[7].Value = txtDescripcion.Text;


                    //dataGridView1.Rows[n].Cells[3].Value = colTicket;


                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtCorreo.Text = "";
                    txtDescripcion.Text = "";

                    
                    _ = numericUpDown1.Value = numericUpDown1.Value + 1;

                    

                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede agregar con valores vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            
    
                     


        }

        private void selectedRowsButton_Click(object sender, EventArgs e)
        {
            string message = "¿Seguro que quieres borrar el ticket?";
            string title = "Advertencia";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            
            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                        //MessageBox.Show("Se eliminó el ticket",
                        //"Ticket",
                        //MessageBoxButtons.OK);

                    }
                }
                catch
                {
                    MessageBox.Show("No has seleccionado una fila o no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                    MessageBox.Show("No se eliminó el ticket",
                    "Ticket",
                    MessageBoxButtons.OK);
            }
            

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n!= -1) 
            {
                infoNombre.Text = (string)dataGridView1.Rows[n].Cells[0].Value;
                infoApellido.Text = (string)dataGridView1.Rows[n].Cells[1].Value;
                infoCorreo.Text = (string)dataGridView1.Rows[n].Cells[2].Value;
                infoTicket.Text = (string)dataGridView1.Rows[n].Cells[3].Value;
                infoDispositivo.Text = (string)dataGridView1.Rows[n].Cells[6].Value;
                infoDescripcion.Text = (string)dataGridView1.Rows[n].Cells[7].Value;
            }
        }

        private void infoNombre_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
