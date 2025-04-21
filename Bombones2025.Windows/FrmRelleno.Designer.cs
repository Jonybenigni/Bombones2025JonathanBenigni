namespace Bombones2025.Windows
{
    partial class FrmRelleno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip2 = new ToolStrip();
            TsbNuevoRelleno = new ToolStripButton();
            TsbBorrarRelleno = new ToolStripButton();
            TsbEditarRelleno = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbFiltrarRelleno = new ToolStripButton();
            TsbActualizarRelleno = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsbImprimirRelleno = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            TsbCerrarRelleno = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            dgvDatosRelleno = new DataGridView();
            idRelleno = new DataGridViewTextBoxColumn();
            colRelleno = new DataGridViewTextBoxColumn();
            TxtCantidadPaginas = new TextBox();
            CboPaginas = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            BtnUltimo = new Button();
            BtnSiguiente = new Button();
            BtnAnterior = new Button();
            BtnPrimero = new Button();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosRelleno).BeginInit();
            SuspendLayout();
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { TsbNuevoRelleno, TsbBorrarRelleno, TsbEditarRelleno, toolStripSeparator1, TsbFiltrarRelleno, TsbActualizarRelleno, toolStripSeparator2, TsbImprimirRelleno, toolStripSeparator3, TsbCerrarRelleno });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(800, 67);
            toolStrip2.TabIndex = 5;
            toolStrip2.Text = "toolStrip2";
            // 
            // TsbNuevoRelleno
            // 
            TsbNuevoRelleno.Image = Properties.Resources.Nuevo;
            TsbNuevoRelleno.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevoRelleno.ImageTransparentColor = Color.Magenta;
            TsbNuevoRelleno.Name = "TsbNuevoRelleno";
            TsbNuevoRelleno.Size = new Size(56, 64);
            TsbNuevoRelleno.Text = "Nuevo";
            TsbNuevoRelleno.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevoRelleno.Click += TsbNuevoRelleno_Click;
            // 
            // TsbBorrarRelleno
            // 
            TsbBorrarRelleno.Image = Properties.Resources.Delete;
            TsbBorrarRelleno.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrarRelleno.ImageTransparentColor = Color.Magenta;
            TsbBorrarRelleno.Name = "TsbBorrarRelleno";
            TsbBorrarRelleno.Size = new Size(54, 64);
            TsbBorrarRelleno.Text = "Borrar";
            TsbBorrarRelleno.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbBorrarRelleno.Click += TsbBorrarRelleno_Click;
            // 
            // TsbEditarRelleno
            // 
            TsbEditarRelleno.Image = Properties.Resources.Edit;
            TsbEditarRelleno.ImageScaling = ToolStripItemImageScaling.None;
            TsbEditarRelleno.ImageTransparentColor = Color.Magenta;
            TsbEditarRelleno.Name = "TsbEditarRelleno";
            TsbEditarRelleno.Size = new Size(52, 64);
            TsbEditarRelleno.Text = "Editar";
            TsbEditarRelleno.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbEditarRelleno.Click += TsbEditarRelleno_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 67);
            // 
            // TsbFiltrarRelleno
            // 
            TsbFiltrarRelleno.Image = Properties.Resources.filter_40px;
            TsbFiltrarRelleno.ImageScaling = ToolStripItemImageScaling.None;
            TsbFiltrarRelleno.ImageTransparentColor = Color.Magenta;
            TsbFiltrarRelleno.Name = "TsbFiltrarRelleno";
            TsbFiltrarRelleno.Size = new Size(51, 64);
            TsbFiltrarRelleno.Text = "Filtrar";
            TsbFiltrarRelleno.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TsbActualizarRelleno
            // 
            TsbActualizarRelleno.Image = Properties.Resources.Update;
            TsbActualizarRelleno.ImageScaling = ToolStripItemImageScaling.None;
            TsbActualizarRelleno.ImageTransparentColor = Color.Magenta;
            TsbActualizarRelleno.Name = "TsbActualizarRelleno";
            TsbActualizarRelleno.Size = new Size(79, 64);
            TsbActualizarRelleno.Text = "Actualizar";
            TsbActualizarRelleno.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 67);
            // 
            // TsbImprimirRelleno
            // 
            TsbImprimirRelleno.Image = Properties.Resources.Print;
            TsbImprimirRelleno.ImageScaling = ToolStripItemImageScaling.None;
            TsbImprimirRelleno.ImageTransparentColor = Color.Magenta;
            TsbImprimirRelleno.Name = "TsbImprimirRelleno";
            TsbImprimirRelleno.Size = new Size(70, 64);
            TsbImprimirRelleno.Text = "Imprimir";
            TsbImprimirRelleno.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 67);
            // 
            // TsbCerrarRelleno
            // 
            TsbCerrarRelleno.Image = Properties.Resources.Close;
            TsbCerrarRelleno.ImageScaling = ToolStripItemImageScaling.None;
            TsbCerrarRelleno.ImageTransparentColor = Color.Magenta;
            TsbCerrarRelleno.Name = "TsbCerrarRelleno";
            TsbCerrarRelleno.Size = new Size(53, 64);
            TsbCerrarRelleno.Text = "Cerrar";
            TsbCerrarRelleno.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbCerrarRelleno.Click += TsbCerrarRelleno_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 67);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatosRelleno);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtCantidadPaginas);
            splitContainer1.Panel2.Controls.Add(CboPaginas);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(BtnUltimo);
            splitContainer1.Panel2.Controls.Add(BtnSiguiente);
            splitContainer1.Panel2.Controls.Add(BtnAnterior);
            splitContainer1.Panel2.Controls.Add(BtnPrimero);
            splitContainer1.Size = new Size(800, 383);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 6;
            // 
            // dgvDatosRelleno
            // 
            dgvDatosRelleno.AllowUserToAddRows = false;
            dgvDatosRelleno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatosRelleno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosRelleno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosRelleno.Columns.AddRange(new DataGridViewColumn[] { idRelleno, colRelleno });
            dgvDatosRelleno.Dock = DockStyle.Fill;
            dgvDatosRelleno.Location = new Point(0, 0);
            dgvDatosRelleno.Margin = new Padding(3, 4, 3, 4);
            dgvDatosRelleno.Name = "dgvDatosRelleno";
            dgvDatosRelleno.ReadOnly = true;
            dgvDatosRelleno.RowHeadersVisible = false;
            dgvDatosRelleno.RowHeadersWidth = 51;
            dgvDatosRelleno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosRelleno.Size = new Size(800, 266);
            dgvDatosRelleno.TabIndex = 3;
            // 
            // idRelleno
            // 
            idRelleno.HeaderText = "Id";
            idRelleno.MinimumWidth = 6;
            idRelleno.Name = "idRelleno";
            idRelleno.ReadOnly = true;
            idRelleno.Visible = false;
            idRelleno.Width = 125;
            // 
            // colRelleno
            // 
            colRelleno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRelleno.HeaderText = "Relleno";
            colRelleno.MinimumWidth = 6;
            colRelleno.Name = "colRelleno";
            colRelleno.ReadOnly = true;
            // 
            // TxtCantidadPaginas
            // 
            TxtCantidadPaginas.Location = new Point(221, 33);
            TxtCantidadPaginas.Margin = new Padding(3, 4, 3, 4);
            TxtCantidadPaginas.Name = "TxtCantidadPaginas";
            TxtCantidadPaginas.ReadOnly = true;
            TxtCantidadPaginas.Size = new Size(97, 27);
            TxtCantidadPaginas.TabIndex = 27;
            // 
            // CboPaginas
            // 
            CboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            CboPaginas.FormattingEnabled = true;
            CboPaginas.Location = new Point(94, 32);
            CboPaginas.Margin = new Padding(3, 4, 3, 4);
            CboPaginas.Name = "CboPaginas";
            CboPaginas.Size = new Size(77, 28);
            CboPaginas.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 36);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 24;
            label2.Text = "de:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 25;
            label1.Text = "Pág.:";
            // 
            // BtnUltimo
            // 
            BtnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUltimo.Image = Properties.Resources.last_24px;
            BtnUltimo.Location = new Point(690, 29);
            BtnUltimo.Margin = new Padding(3, 4, 3, 4);
            BtnUltimo.Name = "BtnUltimo";
            BtnUltimo.Size = new Size(86, 55);
            BtnUltimo.TabIndex = 20;
            BtnUltimo.UseVisualStyleBackColor = true;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSiguiente.Image = Properties.Resources.next_24px;
            BtnSiguiente.Location = new Point(598, 29);
            BtnSiguiente.Margin = new Padding(3, 4, 3, 4);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(86, 55);
            BtnSiguiente.TabIndex = 21;
            BtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAnterior.Image = Properties.Resources.previous_24px;
            BtnAnterior.Location = new Point(506, 29);
            BtnAnterior.Margin = new Padding(3, 4, 3, 4);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(86, 55);
            BtnAnterior.TabIndex = 22;
            BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnPrimero
            // 
            BtnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPrimero.Image = Properties.Resources.first_24px;
            BtnPrimero.Location = new Point(414, 29);
            BtnPrimero.Margin = new Padding(3, 4, 3, 4);
            BtnPrimero.Name = "BtnPrimero";
            BtnPrimero.Size = new Size(86, 55);
            BtnPrimero.TabIndex = 23;
            BtnPrimero.UseVisualStyleBackColor = true;
            // 
            // FrmRelleno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip2);
            Name = "FrmRelleno";
            Text = "FrmRelleno";
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatosRelleno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip2;
        private ToolStripButton TsbNuevoRelleno;
        private ToolStripButton TsbBorrarRelleno;
        private ToolStripButton TsbEditarRelleno;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbFiltrarRelleno;
        private ToolStripButton TsbActualizarRelleno;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbImprimirRelleno;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton TsbCerrarRelleno;
        private SplitContainer splitContainer1;
        private DataGridView dgvDatosRelleno;
        private TextBox TxtCantidadPaginas;
        private ComboBox CboPaginas;
        private Label label2;
        private Label label1;
        private Button BtnUltimo;
        private Button BtnSiguiente;
        private Button BtnAnterior;
        private Button BtnPrimero;
        private DataGridViewTextBoxColumn idRelleno;
        private DataGridViewTextBoxColumn colRelleno;
    }
}