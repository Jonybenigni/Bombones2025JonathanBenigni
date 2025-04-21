namespace Bombones2025.Windows
{
    partial class FrmChocolate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChocolate));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbImprimir = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            DgvDatosChocolate = new DataGridView();
            ColIdChocolate = new DataGridViewTextBoxColumn();
            ColChocolate = new DataGridViewTextBoxColumn();
            BtnUltimo = new Button();
            BtnSiguiente = new Button();
            BtnAnterior = new Button();
            BtnPrimero = new Button();
            label2 = new Label();
            TxtCantidadPaginas = new TextBox();
            label1 = new Label();
            CboPaginas = new ComboBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatosChocolate).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbImprimir, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(56, 44);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextAlign = ContentAlignment.BottomCenter;
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.RightToLeft = RightToLeft.No;
            tsbBorrar.Size = new Size(54, 44);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 44);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(51, 44);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(79, 44);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 47);
            // 
            // tsbImprimir
            // 
            tsbImprimir.Image = (Image)resources.GetObject("tsbImprimir.Image");
            tsbImprimir.ImageTransparentColor = Color.Magenta;
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(70, 44);
            tsbImprimir.Text = "Imprimir";
            tsbImprimir.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 47);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(42, 44);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 47);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(DgvDatosChocolate);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(BtnUltimo);
            splitContainer1.Panel2.Controls.Add(BtnSiguiente);
            splitContainer1.Panel2.Controls.Add(BtnAnterior);
            splitContainer1.Panel2.Controls.Add(BtnPrimero);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(TxtCantidadPaginas);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(CboPaginas);
            splitContainer1.Size = new Size(800, 403);
            splitContainer1.SplitterDistance = 253;
            splitContainer1.TabIndex = 1;
            // 
            // DgvDatosChocolate
            // 
            DgvDatosChocolate.AllowUserToAddRows = false;
            DgvDatosChocolate.AllowUserToDeleteRows = false;
            DgvDatosChocolate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatosChocolate.Columns.AddRange(new DataGridViewColumn[] { ColIdChocolate, ColChocolate });
            DgvDatosChocolate.Dock = DockStyle.Fill;
            DgvDatosChocolate.Location = new Point(0, 0);
            DgvDatosChocolate.Name = "DgvDatosChocolate";
            DgvDatosChocolate.ReadOnly = true;
            DgvDatosChocolate.RowHeadersWidth = 51;
            DgvDatosChocolate.Size = new Size(800, 253);
            DgvDatosChocolate.TabIndex = 0;
            // 
            // ColIdChocolate
            // 
            ColIdChocolate.HeaderText = "ID";
            ColIdChocolate.MinimumWidth = 6;
            ColIdChocolate.Name = "ColIdChocolate";
            ColIdChocolate.ReadOnly = true;
            ColIdChocolate.Visible = false;
            ColIdChocolate.Width = 125;
            // 
            // ColChocolate
            // 
            ColChocolate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColChocolate.HeaderText = "Chocolate";
            ColChocolate.MinimumWidth = 6;
            ColChocolate.Name = "ColChocolate";
            ColChocolate.ReadOnly = true;
            // 
            // BtnUltimo
            // 
            BtnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUltimo.Image = Properties.Resources.last_24px;
            BtnUltimo.Location = new Point(669, 46);
            BtnUltimo.Margin = new Padding(3, 4, 3, 4);
            BtnUltimo.Name = "BtnUltimo";
            BtnUltimo.Size = new Size(86, 55);
            BtnUltimo.TabIndex = 31;
            BtnUltimo.UseVisualStyleBackColor = true;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSiguiente.Image = Properties.Resources.next_24px;
            BtnSiguiente.Location = new Point(576, 46);
            BtnSiguiente.Margin = new Padding(3, 4, 3, 4);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(86, 55);
            BtnSiguiente.TabIndex = 32;
            BtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAnterior.Image = Properties.Resources.previous_24px;
            BtnAnterior.Location = new Point(484, 46);
            BtnAnterior.Margin = new Padding(3, 4, 3, 4);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(86, 55);
            BtnAnterior.TabIndex = 33;
            BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnPrimero
            // 
            BtnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPrimero.Image = Properties.Resources.first_24px;
            BtnPrimero.Location = new Point(391, 46);
            BtnPrimero.Margin = new Padding(3, 4, 3, 4);
            BtnPrimero.Name = "BtnPrimero";
            BtnPrimero.Size = new Size(86, 55);
            BtnPrimero.TabIndex = 34;
            BtnPrimero.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 92);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 30;
            label2.Text = "de:";
            // 
            // TxtCantidadPaginas
            // 
            TxtCantidadPaginas.Location = new Point(90, 89);
            TxtCantidadPaginas.Margin = new Padding(3, 4, 3, 4);
            TxtCantidadPaginas.Name = "TxtCantidadPaginas";
            TxtCantidadPaginas.ReadOnly = true;
            TxtCantidadPaginas.Size = new Size(97, 27);
            TxtCantidadPaginas.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 28;
            label1.Text = "Pág.:";
            // 
            // CboPaginas
            // 
            CboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            CboPaginas.FormattingEnabled = true;
            CboPaginas.Location = new Point(90, 31);
            CboPaginas.Margin = new Padding(3, 4, 3, 4);
            CboPaginas.Name = "CboPaginas";
            CboPaginas.Size = new Size(77, 28);
            CboPaginas.TabIndex = 27;
            // 
            // FrmChocolate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "FrmChocolate";
            Text = "FrmChocolate";
            Load += FrmChocolate_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDatosChocolate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbImprimir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private SplitContainer splitContainer1;
        private DataGridView DgvDatosChocolate;
        private Button BtnUltimo;
        private Button BtnSiguiente;
        private Button BtnAnterior;
        private Button BtnPrimero;
        private Label label2;
        private TextBox TxtCantidadPaginas;
        private Label label1;
        private ComboBox CboPaginas;
        private DataGridViewTextBoxColumn ColIdChocolate;
        private DataGridViewTextBoxColumn ColChocolate;
    }
}