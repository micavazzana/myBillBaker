using BillBakerCore;
using System.Collections.ObjectModel;

namespace InterfazBot
{
    public partial class FrmCargaDeFc : Form
    {
        private Baker facturador;

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRCEL_Click(object sender, EventArgs e)
        {
            ReadOnlyCollection<string> ventanas = facturador.ControladorChrome.WindowHandles;

            //Me fijo si hay más de una pestaña, ya que RCEL abre en una nueva
            if (ventanas.Count > 1)
            {
                //Cambio a la siguiente ventana
                facturador.ControladorChrome.SwitchTo().Window(ventanas[1]);
                //Si encuentra que la ventana en que esta en RCEL estamos ok para hacer nuestras facturas
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
