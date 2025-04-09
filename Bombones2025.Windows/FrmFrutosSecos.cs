using Bombones2025.Entidades;
using Bombones2025.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025.Windows
{
    public partial class FrmFrutosSecos : Form
    {
        private readonly FrutoSecoServicio _frutoServicio;

        private List<FrutoSeco> _fruto = new();
        public FrmFrutosSecos(FrutoSecoServicio frutosSecosServicio)
        {
            InitializeComponent();
            _frutoServicio = frutosSecosServicio;
        }
        private void FrmFrutoSecos_Load(object sender, EventArgs e)
        {
            _fruto = _frutoServicio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void TsbNuevoFrutosSecos_Click(object sender, EventArgs e)
        {
            FrmFrutosSecosAE frm = new FrmFrutosSecosAE() { Text = "Nuevo Fruto Seco" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            FrutoSeco? frutoSeco = frm.GetFrutosSecos();
            if (frutoSeco == null) return;

            if (!_frutoServicio.Existe(frutoSeco))
            {
                _frutoServicio.Guardar(frutoSeco);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(DgvFrutosSecos);
                SetearFila(r, frutoSeco);
                AgregarFila(r);
                MessageBox.Show("Fruto Seco agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fruto Seco existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SetearFila(DataGridViewRow r, FrutoSeco frutoSeco)
        {
            r.Cells[0].Value = frutoSeco.FrutoSecoId;
            r.Cells[1].Value = frutoSeco.NombreFrutosSecos;

            r.Tag = frutoSeco;
        }

        private void MostrarDatosEnGrilla()
        {
            DgvFrutosSecos.Rows.Clear();
            foreach (FrutoSeco frutoSeco in _fruto)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(DgvFrutosSecos);
                SetearFila(r, frutoSeco);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvFrutosSecos.Rows.Add(r);
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TsbBorrarFrutosSecos_Click(object sender, EventArgs e)
        {
            if (DgvFrutosSecos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvFrutosSecos.SelectedRows[0];
            FrutoSeco frutosSecosBorrar = (FrutoSeco)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el Fruto Seco {frutosSecosBorrar}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            _frutoServicio.Borrar(frutosSecosBorrar);
            DgvFrutosSecos.Rows.Remove(r);
            MessageBox.Show("Fruto Seco eliminado");
        }

        private void tsvEditarFrutoSeco_Click(object sender, EventArgs e)
        {
            if (DgvFrutosSecos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvFrutosSecos.SelectedRows[0];
            FrutoSeco? frutoSeco = (FrutoSeco)r.Tag!;
            FrmFrutosSecosAE frm = new FrmFrutosSecosAE() { Text = "Editar Fruto Seco" };
            frm.SetFrutosSecos(frutoSeco);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            frutoSeco = frm.GetFrutosSecos();
            if (frutoSeco == null) return;

            if (!_frutoServicio.Existe(frutoSeco))
            {
                _frutoServicio.Guardar(frutoSeco);
                SetearFila(r, frutoSeco);

                MessageBox.Show("Fruto Seco editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fruto Seco existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        
        }
    }
}
