using Bombones2025.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025.Windows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnPaises_Click(object sender, EventArgs e)
        {
            PaisServicio servicio = new PaisServicio("Paises.Txt");
            FrmPaises frm = new FrmPaises(servicio) { Text = "Listado de Paises" };
            frm.ShowDialog(this);
        }

        private void btnFrutoSeco_Click(object sender, EventArgs e)
        {

            FrutoSecoServicio servicio = new FrutoSecoServicio("FrutosSecos.Txt");
            FrmFrutosSecos frm = new FrmFrutosSecos(servicio) { Text = "Listado de Frutos Secos" };
            frm.ShowDialog(this);
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            ChocolateServicio servicio = new ChocolateServicio("Chocolate.Txt");
            FrmChocolate frm = new FrmChocolate(servicio) { Text = "Listado de Chocolate" };
            frm.ShowDialog(this);
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {

            RellenoServicio servicio = new RellenoServicio("Rellenos.Txt");
            FrmRelleno frm = new FrmRelleno(servicio) { Text = "Listado de Relleno" };
            frm.ShowDialog(this);
        }
    }
}
