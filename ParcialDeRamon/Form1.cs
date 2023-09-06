using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialDeRamon
{
    public partial class Conversores : Form
    {
        public Conversores()
        {
            InitializeComponent();
        }

        // Ramon Josue Rivera Arias USSS018523
        // Parcial 1 

        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            {
                int de, a;
                double cantidad, respuesta;

                de = cboDeConversor.SelectedIndex;
                a = cboAConversor.SelectedIndex;




                cantidad = double.Parse(txtCantidadConversor.Text);
                double[] medida = { 0.09290304, 0.698896, 0.836127, 1, 438, 7000, 10000, };




                respuesta = medida[de] / medida[a] * cantidad;
                lblRespuesta.Text = " Respuesta " + Math.Round(respuesta, 3);
            }
        }
    }
}
