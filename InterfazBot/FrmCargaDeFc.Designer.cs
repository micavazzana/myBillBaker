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
            btnRCEL.Location = new Point(54, 40);
            btnRCEL.Margin = new Padding(3, 2, 3, 2);
            btnRCEL.Name = "btnRCEL";
            btnRCEL.Size = new Size(119, 33);
            btnRCEL.TabIndex = 0;
            btnRCEL.Text = "Estoy en RCEL";
            btnRCEL.UseVisualStyleBackColor = true;
            btnRCEL.Click += btnRCEL_Click;
            // 
            // btnCargarExcel
            // 
            btnCargarExcel.Location = new Point(178, 40);
            btnCargarExcel.Margin = new Padding(3, 2, 3, 2);
            btnCargarExcel.Name = "btnCargarExcel";
            btnCargarExcel.Size = new Size(119, 33);
            btnCargarExcel.TabIndex = 1;
            btnCargarExcel.Text = "Cargar Excel";
            btnCargarExcel.UseVisualStyleBackColor = true;
            btnCargarExcel.Click += btnCargarExcel_Click;
            // 
            // btnGenerarFC
            // 
            btnGenerarFC.Location = new Point(548, 40);
            btnGenerarFC.Margin = new Padding(3, 2, 3, 2);
            btnGenerarFC.Name = "btnGenerarFC";
            btnGenerarFC.Size = new Size(119, 33);
            btnGenerarFC.TabIndex = 2;
            btnGenerarFC.Text = "Generar Facturas";
            btnGenerarFC.UseVisualStyleBackColor = true;
            btnGenerarFC.Click += btnGenerarFC_Click;
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(54, 78);
            dgvFacturas.Margin = new Padding(3, 2, 3, 2);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.Size = new Size(612, 219);
            dgvFacturas.TabIndex = 3;
            // 
            // FrmCargaDeFc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dgvFacturas);
            Controls.Add(btnGenerarFC);
            Controls.Add(btnCargarExcel);
            Controls.Add(btnRCEL);
            Margin = new Padding(3, 2, 3, 2);
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