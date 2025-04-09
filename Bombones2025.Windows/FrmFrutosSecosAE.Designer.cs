namespace Bombones2025.Windows
{
    partial class FrmFrutosSecosAE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrutosSecosAE));
            label1 = new Label();
            TxtFrutoSeco = new ComboBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 49);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Fruto Seco: ";
            // 
            // TxtFrutoSeco
            // 
            TxtFrutoSeco.FormattingEnabled = true;
            TxtFrutoSeco.Location = new Point(131, 49);
            TxtFrutoSeco.Name = "TxtFrutoSeco";
            TxtFrutoSeco.Size = new Size(451, 28);
            TxtFrutoSeco.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Image = Properties.Resources.Aceptar;
            btnConfirmar.Location = new Point(131, 157);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(91, 76);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(481, 157);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.RightToLeft = RightToLeft.No;
            btnCancelar.Size = new Size(91, 76);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmFrutosSecosAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 303);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(TxtFrutoSeco);
            Controls.Add(label1);
            Name = "FrmFrutosSecosAE";
            Text = "FrmFrutosSecosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox TxtFrutoSeco;
        private Button btnConfirmar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}