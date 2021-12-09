using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoporteTecnico
{
    public partial class AgregarDispositivo : Form 
    {

        public delegate void pasar(string dato);
        public event pasar pasado;

        public AgregarDispositivo()
        {
            InitializeComponent();
        }

        private void btnAgregarDispositivo_Click(object sender, EventArgs e)
        {
            pasado(txtAgregarDispositivo.Text);
        }
    }
}
