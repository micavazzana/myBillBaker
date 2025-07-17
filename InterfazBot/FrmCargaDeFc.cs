using BillBakerCore;
using System.Collections.ObjectModel;

namespace InterfazBot
{
    public partial class FrmCargaDeFc : Form
    {
        private Baker facturador;

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
    }
}
