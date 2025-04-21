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
    public partial class FrmRelleno : Form
    {
        private readonly RellenoServicio _rellenoServicio;

        private List<Relleno> _rellenos = new();
        public FrmRelleno(RellenoServicio rellenoServicio)
        {
            InitializeComponent();
            _rellenoServicio = rellenoServicio;
        }

        private void FrmRelleno_Load(object sender, EventArgs e)
        {
            _rellenos = _rellenoServicio.GetRelleno();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatosRelleno.Rows.Clear();
            foreach (Relleno relleno in _rellenos)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatosRelleno);
                SetearFila(r, relleno);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatosRelleno.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Relleno relleno)
        {
            r.Cells[0].Value = relleno.RellenoId;
            r.Cells[1].Value = relleno.NombreRelleno;

            r.Tag = relleno;
        }

        private void TsbNuevoRelleno_Click(object sender, EventArgs e)
        {
            FrmRellenoAE frm = new FrmRellenoAE() { Text = "Nuevo Relleno" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Relleno? relleno = frm.GetRellenos();
            if (relleno == null) return;

            if (!_rellenoServicio.Existe(relleno))
            {
                _rellenoServicio.Guardar(relleno);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatosRelleno);
                SetearFila(r, relleno);
                AgregarFila(r);
                MessageBox.Show("Relleno agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Relleno existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TsbBorrarRelleno_Click(object sender, EventArgs e)
        {
            if (dgvDatosRelleno.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatosRelleno.SelectedRows[0];
            Relleno rellenoBorrar = (Relleno)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el Relleno {rellenoBorrar}",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            _rellenoServicio.Borrar(rellenoBorrar);
            dgvDatosRelleno.Rows.Remove(r);
            MessageBox.Show("Relleno eliminado");
        }

        private void TsbEditarRelleno_Click(object sender, EventArgs e)
        {
            if (dgvDatosRelleno.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatosRelleno.SelectedRows[0];
            Relleno? relleno = (Relleno)r.Tag!;
            FrmRellenoAE frm = new FrmRellenoAE() { Text = "Editar Relleno" };
            frm.SetRelleno(relleno);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            relleno = frm.GetRellenos();
            if (relleno == null) return;

            if (!_rellenoServicio.Existe(relleno))
            {
                _rellenoServicio.Guardar(relleno);
                SetearFila(r, relleno);

                MessageBox.Show("Relleno editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Relleno existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TsbCerrarRelleno_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
