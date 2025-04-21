using Bombones2025.Entidades;
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
    public partial class FrmRellenoAE : Form
    {

        private Relleno? relleno;
        public FrmRellenoAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (relleno is not null)
            {
                TxtRelleno.Text = relleno.NombreRelleno;
            }
        }
        public Relleno? GetRellenos()
        {
            return relleno;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtRelleno.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtRelleno, "El nombre es requerido");

            }
            return valido;
        }

        public void SetRelleno(Relleno relleno)
        {
            this.relleno = relleno;
        }

        private void BtnOKRelleno_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                if (relleno is null)
                {
                    relleno = new Relleno();

                }
                relleno.NombreRelleno = TxtRelleno.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private void FrmRellenoAE_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelarRelleno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
