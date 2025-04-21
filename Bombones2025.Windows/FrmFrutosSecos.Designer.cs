namespace Bombones2025.Windows
{
    partial class FrmFrutosSecos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrutosSecos));
            toolStrip1 = new ToolStrip();
            TsbNuevoFrutosSecos = new ToolStripButton();
            TsbBorrarFrutosSecos = new ToolStripButton();
            tsvEditarFrutoSeco = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            DgvFrutosSecos = new DataGridView();
            IdFrutosSecos = new DataGridViewTextBoxColumn();
            ColFrutosSecos = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)DgvFrutosSecos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevoFrutosSecos, TsbBorrarFrutosSecos, tsvEditarFrutoSeco, toolStripSeparator1, toolStripButton4, toolStripButton5, toolStripSeparator2, toolStripButton6, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // TsbNuevoFrutosSecos
            // 
            TsbNuevoFrutosSecos.BackColor = SystemColors.Control;
            TsbNuevoFrutosSecos.ForeColor = SystemColors.ControlText;
            TsbNuevoFrutosSecos.Image = (Image)resources.GetObject("TsbNuevoFrutosSecos.Image");
            TsbNuevoFrutosSecos.ImageTransparentColor = Color.Magenta;
            TsbNuevoFrutosSecos.Name = "TsbNuevoFrutosSecos";
            TsbNuevoFrutosSecos.Size = new Size(56, 44);
            TsbNuevoFrutosSecos.Text = "Nuevo";
            TsbNuevoFrutosSecos.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevoFrutosSecos.Click += TsbNuevoFrutosSecos_Click;
            // 
            // TsbBorrarFrutosSecos
            // 
            TsbBorrarFrutosSecos.Image = (Image)resources.GetObject("TsbBorrarFrutosSecos.Image");
            TsbBorrarFrutosSecos.ImageTransparentColor = Color.Magenta;
            TsbBorrarFrutosSecos.Name = "TsbBorrarFrutosSecos";
            TsbBorrarFrutosSecos.Size = new Size(54, 44);
            TsbBorrarFrutosSecos.Text = "Borrar";
            TsbBorrarFrutosSecos.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbBorrarFrutosSecos.Click += TsbBorrarFrutosSecos_Click;
            // 
            // tsvEditarFrutoSeco
            // 
            tsvEditarFrutoSeco.Image = (Image)resources.GetObject("tsvEditarFrutoSeco.Image");
            tsvEditarFrutoSeco.ImageTransparentColor = Color.Magenta;
            tsvEditarFrutoSeco.Name = "tsvEditarFrutoSeco";
            tsvEditarFrutoSeco.Size = new Size(52, 44);
            tsvEditarFrutoSeco.Text = "Editar";
            tsvEditarFrutoSeco.TextImageRelation = TextImageRelation.ImageAboveText;
            tsvEditarFrutoSeco.Click += tsvEditarFrutoSeco_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(51, 44);
            toolStripButton4.Text = "Filtrar";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(79, 44);
            toolStripButton5.Text = "Actualizar";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 47);
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(70, 44);
            toolStripButton6.Text = "Imprimir";
            toolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
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
            splitContainer1.Panel1.Controls.Add(DgvFrutosSecos);
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
            splitContainer1.SplitterDistance = 251;
            splitContainer1.TabIndex = 1;
            // 
            // DgvFrutosSecos
            // 
            DgvFrutosSecos.AllowUserToAddRows = false;
            DgvFrutosSecos.AllowUserToDeleteRows = false;
            DgvFrutosSecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvFrutosSecos.Columns.AddRange(new DataGridViewColumn[] { IdFrutosSecos, ColFrutosSecos });
            DgvFrutosSecos.Dock = DockStyle.Fill;
            DgvFrutosSecos.Location = new Point(0, 0);
            DgvFrutosSecos.Name = "DgvFrutosSecos";
            DgvFrutosSecos.ReadOnly = true;
            DgvFrutosSecos.RowHeadersWidth = 51;
            DgvFrutosSecos.Size = new Size(800, 251);
            DgvFrutosSecos.TabIndex = 0;
            // 
            // IdFrutosSecos
            // 
            IdFrutosSecos.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IdFrutosSecos.HeaderText = "IdFrutosSecos";
            IdFrutosSecos.MinimumWidth = 6;
            IdFrutosSecos.Name = "IdFrutosSecos";
            IdFrutosSecos.ReadOnly = true;
            IdFrutosSecos.Resizable = DataGridViewTriState.True;
            IdFrutosSecos.Visible = false;
            IdFrutosSecos.Width = 129;
            // 
            // ColFrutosSecos
            // 
            ColFrutosSecos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFrutosSecos.HeaderText = "FrutosSecos";
            ColFrutosSecos.MinimumWidth = 6;
            ColFrutosSecos.Name = "ColFrutosSecos";
            ColFrutosSecos.ReadOnly = true;
            ColFrutosSecos.Resizable = DataGridViewTriState.True;
            // 
            // BtnUltimo
            // 
            BtnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUltimo.Image = Properties.Resources.last_24px;
            BtnUltimo.Location = new Point(648, 48);
            BtnUltimo.Margin = new Padding(3, 4, 3, 4);
            BtnUltimo.Name = "BtnUltimo";
            BtnUltimo.Size = new Size(86, 55);
            BtnUltimo.TabIndex = 23;
            BtnUltimo.UseVisualStyleBackColor = true;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSiguiente.Image = Properties.Resources.next_24px;
            BtnSiguiente.Location = new Point(555, 48);
            BtnSiguiente.Margin = new Padding(3, 4, 3, 4);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(86, 55);
            BtnSiguiente.TabIndex = 24;
            BtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAnterior.Image = Properties.Resources.previous_24px;
            BtnAnterior.Location = new Point(463, 48);
            BtnAnterior.Margin = new Padding(3, 4, 3, 4);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(86, 55);
            BtnAnterior.TabIndex = 25;
            BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnPrimero
            // 
            BtnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPrimero.Image = Properties.Resources.first_24px;
            BtnPrimero.Location = new Point(370, 48);
            BtnPrimero.Margin = new Padding(3, 4, 3, 4);
            BtnPrimero.Name = "BtnPrimero";
            BtnPrimero.Size = new Size(86, 55);
            BtnPrimero.TabIndex = 26;
            BtnPrimero.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 94);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 22;
            label2.Text = "de:";
            // 
            // TxtCantidadPaginas
            // 
            TxtCantidadPaginas.Location = new Point(69, 91);
            TxtCantidadPaginas.Margin = new Padding(3, 4, 3, 4);
            TxtCantidadPaginas.Name = "TxtCantidadPaginas";
            TxtCantidadPaginas.ReadOnly = true;
            TxtCantidadPaginas.Size = new Size(97, 27);
            TxtCantidadPaginas.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 20;
            label1.Text = "Pág.:";
            // 
            // CboPaginas
            // 
            CboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            CboPaginas.FormattingEnabled = true;
            CboPaginas.Location = new Point(69, 33);
            CboPaginas.Margin = new Padding(3, 4, 3, 4);
            CboPaginas.Name = "CboPaginas";
            CboPaginas.Size = new Size(77, 28);
            CboPaginas.TabIndex = 19;
            // 
            // FrmFrutosSecos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "FrmFrutosSecos";
            Text = "FrmFrutosSecos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvFrutosSecos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TsbNuevoFrutosSecos;
        private ToolStripButton TsbBorrarFrutosSecos;
        private ToolStripButton tsvEditarFrutoSeco;
        private SplitContainer splitContainer1;
        private DataGridView DgvFrutosSecos;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private ComboBox CboPaginas;
        private Label label1;
        private TextBox TxtCantidadPaginas;
        private Label label2;
        private Button BtnUltimo;
        private Button BtnSiguiente;
        private Button BtnAnterior;
        private Button BtnPrimero;
        private DataGridViewTextBoxColumn IdFrutosSecos;
        private DataGridViewTextBoxColumn ColFrutosSecos;
    }
}