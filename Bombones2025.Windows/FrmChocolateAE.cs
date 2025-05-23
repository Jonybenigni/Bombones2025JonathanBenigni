﻿using Bombones2025.Entidades;
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
    public partial class FrmChocolateAE : Form
    {
        private Chocolate? chocolate;
        public FrmChocolateAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (chocolate is not null)
            {
                TxtChocolate.Text = chocolate.NombreChocolate;
            }
        }
        public Chocolate? GetChocolate()
        {
            return chocolate;
        }
        public void SetChocolate(Chocolate chocolate)
        {
            this.chocolate = chocolate;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtChocolate.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtChocolate, "El nombre es requerido");

            }
            return valido;
        }


        private void FrmChocolateAE_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (chocolate is null)
                {
                    chocolate = new Chocolate();

                }
                chocolate.NombreChocolate = TxtChocolate.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
