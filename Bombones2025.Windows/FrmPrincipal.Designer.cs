﻿namespace Bombones2025.Windows
{
    partial class FrmPrincipal
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
            BtnPaises = new Button();
            btnFrutoSeco = new Button();
            btnRelleno = new Button();
            btnChocolate = new Button();
            SuspendLayout();
            // 
            // BtnPaises
            // 
            BtnPaises.Location = new Point(46, 61);
            BtnPaises.Margin = new Padding(3, 4, 3, 4);
            BtnPaises.Name = "BtnPaises";
            BtnPaises.Size = new Size(99, 72);
            BtnPaises.TabIndex = 0;
            BtnPaises.Text = "Países";
            BtnPaises.UseVisualStyleBackColor = true;
            BtnPaises.Click += BtnPaises_Click;
            // 
            // btnFrutoSeco
            // 
            btnFrutoSeco.Location = new Point(151, 61);
            btnFrutoSeco.Margin = new Padding(3, 4, 3, 4);
            btnFrutoSeco.Name = "btnFrutoSeco";
            btnFrutoSeco.Size = new Size(99, 72);
            btnFrutoSeco.TabIndex = 1;
            btnFrutoSeco.Text = "FrutoSeco";
            btnFrutoSeco.UseVisualStyleBackColor = true;
            btnFrutoSeco.Click += btnFrutoSeco_Click;
            // 
            // btnRelleno
            // 
            btnRelleno.Location = new Point(361, 61);
            btnRelleno.Margin = new Padding(3, 4, 3, 4);
            btnRelleno.Name = "btnRelleno";
            btnRelleno.Size = new Size(99, 72);
            btnRelleno.TabIndex = 2;
            btnRelleno.Text = "Relleno";
            btnRelleno.UseVisualStyleBackColor = true;
            btnRelleno.Click += btnRelleno_Click;
            // 
            // btnChocolate
            // 
            btnChocolate.Location = new Point(256, 61);
            btnChocolate.Margin = new Padding(3, 4, 3, 4);
            btnChocolate.Name = "btnChocolate";
            btnChocolate.Size = new Size(99, 72);
            btnChocolate.TabIndex = 3;
            btnChocolate.Text = "Chocolate";
            btnChocolate.UseVisualStyleBackColor = true;
            btnChocolate.Click += btnChocolate_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnChocolate);
            Controls.Add(btnRelleno);
            Controls.Add(btnFrutoSeco);
            Controls.Add(BtnPaises);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPaises;
        private Button btnFrutoSeco;
        private Button btnRelleno;
        private Button btnChocolate;
    }
}