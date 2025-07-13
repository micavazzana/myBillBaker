namespace InterfazBot
{
    partial class FrmLogin
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
            txtCuit = new TextBox();
            txtClaveFiscal = new TextBox();
            lblCuit = new Label();
            lblClaveFiscal = new Label();
            btnIniciarSesion = new Button();
            picBoxLogo = new PictureBox();
            picBoxClave = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxClave).BeginInit();
            SuspendLayout();
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(119, 152);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(125, 27);
            txtCuit.TabIndex = 0;
            txtCuit.KeyPress += txtCuit_KeyPress;
            // 
            // txtClaveFiscal
            // 
            txtClaveFiscal.Location = new Point(119, 245);
            txtClaveFiscal.Name = "txtClaveFiscal";
            txtClaveFiscal.Size = new Size(125, 27);
            txtClaveFiscal.TabIndex = 1;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(161, 109);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(40, 20);
            lblCuit.TabIndex = 2;
            lblCuit.Text = "CUIT";
            // 
            // lblClaveFiscal
            // 
            lblClaveFiscal.AutoSize = true;
            lblClaveFiscal.Location = new Point(139, 202);
            lblClaveFiscal.Name = "lblClaveFiscal";
            lblClaveFiscal.Size = new Size(85, 20);
            lblClaveFiscal.TabIndex = 3;
            lblClaveFiscal.Text = "Clave Fiscal";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(119, 295);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(125, 44);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "INICIAR SESIÓN";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click_1;
            // 
            // picBoxLogo
            // 
            picBoxLogo.Location = new Point(119, 24);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(125, 62);
            picBoxLogo.TabIndex = 5;
            picBoxLogo.TabStop = false;
            // 
            // picBoxClave
            // 
            picBoxClave.Image = Properties.Resources.hide;
            picBoxClave.Location = new Point(250, 245);
            picBoxClave.Name = "picBoxClave";
            picBoxClave.Size = new Size(28, 27);
            picBoxClave.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxClave.TabIndex = 6;
            picBoxClave.TabStop = false;
            picBoxClave.Click += picBoxClave_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 373);
            Controls.Add(picBoxClave);
            Controls.Add(picBoxLogo);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lblClaveFiscal);
            Controls.Add(lblCuit);
            Controls.Add(txtClaveFiscal);
            Controls.Add(txtCuit);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxClave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCuit;
        private TextBox txtClaveFiscal;
        private Label lblCuit;
        private Label lblClaveFiscal;
        private Button btnIniciarSesion;
        private PictureBox picBoxLogo;
        private PictureBox picBoxClave;
    }
}