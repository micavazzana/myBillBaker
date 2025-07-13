namespace InterfazBot
{
    partial class FrmCargaDeFc
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
            btnRCEL = new Button();
            btnCargarExcel = new Button();
            btnGenerarFC = new Button();
            dgvFacturas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            SuspendLayout();
            // 
            // btnRCEL
            // 
            btnRCEL.Location = new Point(62, 54);
            btnRCEL.Name = "btnRCEL";
            btnRCEL.Size = new Size(136, 44);
            btnRCEL.TabIndex = 0;
            btnRCEL.Text = "Estoy en RCEL";
            btnRCEL.UseVisualStyleBackColor = true;
            btnRCEL.Click += btnRCEL_Click;
            // 
            // btnCargarExcel
            // 
            btnCargarExcel.Location = new Point(204, 54);
            btnCargarExcel.Name = "btnCargarExcel";
            btnCargarExcel.Size = new Size(136, 44);
            btnCargarExcel.TabIndex = 1;
            btnCargarExcel.Text = "Cargar Excel";
            btnCargarExcel.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFC
            // 
            btnGenerarFC.Location = new Point(626, 54);
            btnGenerarFC.Name = "btnGenerarFC";
            btnGenerarFC.Size = new Size(136, 44);
            btnGenerarFC.TabIndex = 2;
            btnGenerarFC.Text = "Generar Facturas";
            btnGenerarFC.UseVisualStyleBackColor = true;
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(62, 104);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.Size = new Size(700, 292);
            dgvFacturas.TabIndex = 3;
            // 
            // FrmCargaDeFc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvFacturas);
            Controls.Add(btnGenerarFC);
            Controls.Add(btnCargarExcel);
            Controls.Add(btnRCEL);
            Name = "FrmCargaDeFc";
            Text = "FrmCargaDeFc";
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRCEL;
        private Button btnCargarExcel;
        private Button btnGenerarFC;
        private DataGridView dgvFacturas;
    }
}