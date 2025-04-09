using Bombones2025.Entidades;
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
    public partial class FrmChocolate : Form
    {
        private readonly ChocolateServicio _chocolateServicio;

        private List<Chocolate> _Chocolates = new();
        public FrmChocolate(ChocolateServicio chocolateServicio)
        {
            InitializeComponent();
            _chocolateServicio = chocolateServicio;
        }

        private void SetearFila(DataGridViewRow r, Chocolate chocolate)
        {
            r.Cells[0].Value = chocolate.ChocolateId;
            r.Cells[1].Value = chocolate.NombreChocolate;

            r.Tag = chocolate;
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DgvDatosChocolate.Rows.Add(r);
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmChocolateAE frm = new FrmChocolateAE() { Text = "Nuevo Chocolate" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            Chocolate? chocolate = frm.GetChocolate();
            if (chocolate == null) return;

            if (!_chocolateServicio.Existe(chocolate))
            {
                _chocolateServicio.Guardar(chocolate);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(DgvDatosChocolate);
                SetearFila(r, chocolate);
                AgregarFila(r);
                MessageBox.Show("Chocolate agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Chocolate existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (DgvDatosChocolate.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatosChocolate.SelectedRows[0];

            Chocolate chocolateBorrar = (Chocolate)r.Tag!;

            DialogResult dr = MessageBox.Show($"¿Desea borrar el Chocolate {chocolateBorrar}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            _chocolateServicio.Borrar(chocolateBorrar);
            DgvDatosChocolate.Rows.Remove(r);
            MessageBox.Show("Chocolate eliminado");
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatosChocolate.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DgvDatosChocolate.SelectedRows[0];
            Chocolate? chocolate = (Chocolate)r.Tag!;
            FrmChocolateAE frm = new FrmChocolateAE() { Text = "Editar Chocolate" };
            frm.SetChocolate(chocolate);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            chocolate = frm.GetChocolate();
            if (chocolate == null) return;

            if (!_chocolateServicio.Existe(chocolate))
            {
                _chocolateServicio.Guardar(chocolate);
                SetearFila(r, chocolate);

                MessageBox.Show("Chocolate editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Chocolate existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
