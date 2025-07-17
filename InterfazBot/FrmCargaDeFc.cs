using BillBakerCore;
using System.Collections.ObjectModel;
using System.Windows.Forms;


namespace InterfazBot
{
    public partial class FrmCargaDeFc : Form
    {
        private Baker facturador;
        private List<Factura> listaFacturas;

        /// <summary>
        /// Constructor
        /// Inicializa el facturador con el que recibe del formulario anterior.
        /// Deshabilita todos los botones que se habilitaran solo si estamos en la pestaña correcta.
        /// </summary>
        /// <param name="miFacturador"></param>
        public FrmCargaDeFc(Baker miFacturador)
        {
            InitializeComponent();
            this.facturador = miFacturador;
            btnCargarExcel.Enabled = false;
            btnGenerarFC.Enabled = false;
            listaFacturas = new List<Factura>();
        }

        /// <summary>
        /// Chequea que haya más de una pestaña ya que RCEL abre en una nueva,
        /// de ser el caso switchea a la primer ventana abierta y chequea si esta es la de RCEL.
        /// De ser que estamos en RCEL entonces habilitamos los botones que permiten empezar a crear FC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRCEL_Click(object sender, EventArgs e)
        {
            ReadOnlyCollection<string> ventanas = facturador.ControladorChrome.WindowHandles;

            if (ventanas.Count > 1)
            {
                facturador.ControladorChrome.SwitchTo().Window(ventanas[1]);

                if (facturador.ControladorChrome.Url.Contains("rcel"))
                {
                    btnCargarExcel.Enabled = true;
                    btnGenerarFC.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Asegurate de estar en la página de RCEL antes de continuar.");
                }
            }
            else
            {
                MessageBox.Show("no hay otras ventanas abiertas");
            }
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Archivos de Excel (*.xlsx;*.xls)|*.xlsx;*.xls";
                openFileDialog.Title = "Seleccionar archivo de Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = openFileDialog.FileName;

                    try
                    {
                        // Acá podrías validar el archivo si querés
                        List<Factura> facturas = GestorData.ExcelReader(rutaArchivo);

                        // Mostrás en tu DataGridView
                        dgvFacturas.DataSource = facturas;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al leer el archivo Excel:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGenerarFC_Click(object sender, EventArgs e)
        {
            foreach (Factura f in listaFacturas)
            {
                var errores = Validador.ValidarFactura(f);
                if (errores.Any())
                {
                    MessageBox.Show($"Errores en una factura:\n\n{string.Join("\n", errores)}", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detenés la ejecución hasta que el usuario corrija
                }
            }

        }
    }
}
