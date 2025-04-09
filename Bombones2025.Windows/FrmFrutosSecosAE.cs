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
    public partial class FrmFrutosSecosAE : Form
    {

        private FrutoSeco? frutoSeco;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (frutoSeco is not null)
            {
                TxtFrutoSeco.Text = frutoSeco.NombreFrutosSecos;
            }
        }
        public FrutoSeco? GetFrutosSecos()
        {
            return frutoSeco;
        }

        public void SetFrutosSecos(FrutoSeco frutoSeco)
        {
            this.frutoSeco = frutoSeco;
        }
        public FrmFrutosSecosAE()
        {
            InitializeComponent();
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtFrutoSeco.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtFrutoSeco, "El nombre es requerido");

            }
            return valido;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (frutoSeco is null)
                {
                    frutoSeco = new FrutoSeco();

                }
                frutoSeco.NombreFrutosSecos = TxtFrutoSeco.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
