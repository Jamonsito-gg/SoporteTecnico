using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoporteTecnico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }



        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                if (ActiveMdiChild.GetType().Name != "Ingreso")
                {
                    ActiveMdiChild.Close();
                    Form formIngreso = new Ingreso();
                    formIngreso.MdiParent = this;
                    formIngreso.Show();
                }
                else
                {
                    MessageBox.Show("El formulario ya está abierto");
                }

            }
            else
            {
                Form formIngreso = new Ingreso();
                formIngreso.MdiParent = this;
                formIngreso.Show();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formTicket = new Ticket();
            formTicket.MdiParent = this;
            formTicket.Show();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



    }
}
