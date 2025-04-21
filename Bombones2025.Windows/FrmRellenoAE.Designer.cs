namespace Bombones2025.Windows
{
    partial class FrmRellenoAE
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
            BtnCancelarRelleno = new Button();
            BtnOKRelleno = new Button();
            TxtRelleno = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // BtnCancelarRelleno
            // 
            BtnCancelarRelleno.Location = new Point(435, 167);
            BtnCancelarRelleno.Margin = new Padding(3, 4, 3, 4);
            BtnCancelarRelleno.Name = "BtnCancelarRelleno";
            BtnCancelarRelleno.Size = new Size(86, 69);
            BtnCancelarRelleno.TabIndex = 5;
            BtnCancelarRelleno.Text = "Cancelar";
            BtnCancelarRelleno.UseVisualStyleBackColor = true;
            BtnCancelarRelleno.Click += BtnCancelarRelleno_Click;
            // 
            // BtnOKRelleno
            // 
            BtnOKRelleno.Location = new Point(67, 167);
            BtnOKRelleno.Margin = new Padding(3, 4, 3, 4);
            BtnOKRelleno.Name = "BtnOKRelleno";
            BtnOKRelleno.Size = new Size(86, 69);
            BtnOKRelleno.TabIndex = 6;
            BtnOKRelleno.Text = "OK";
            BtnOKRelleno.UseVisualStyleBackColor = true;
            BtnOKRelleno.Click += BtnOKRelleno_Click;
            // 
            // TxtRelleno
            // 
            TxtRelleno.Location = new Point(116, 44);
            TxtRelleno.Margin = new Padding(3, 4, 3, 4);
            TxtRelleno.MaxLength = 200;
            TxtRelleno.Name = "TxtRelleno";
            TxtRelleno.Size = new Size(430, 27);
            TxtRelleno.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 44);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Relleno:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmRellenoAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 308);
            Controls.Add(BtnCancelarRelleno);
            Controls.Add(BtnOKRelleno);
            Controls.Add(TxtRelleno);
            Controls.Add(label1);
            Name = "FrmRellenoAE";
            Text = "FrmRellenoAE";
            Load += FrmRellenoAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelarRelleno;
        private Button BtnOKRelleno;
        private TextBox TxtRelleno;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}