using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SoporteTecnico.Controlador;
using SoporteTecnico.Modelo;

namespace SoporteTecnico
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void btnCerrarModi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
                    

            try
            {
                ESTicket EST = new ESTicket(
                    modiNombre.Text,
                    modiApellido.Text,
                    modiCorreo.Text,
                    comboBoxModiEstado.Text,
                    modiDescripción.Text

                    );
                EST.modificarticket();

                    MessageBox.Show("Modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No se pudo modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
