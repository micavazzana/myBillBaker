using BillBakerCore;

namespace InterfazBot
{
    public partial class FrmLogin : Form
    {
        bool verClave;

        /// <summary>
        /// Constructor
        /// Inicializa el textBox de clave fiscal con sistema de contraseñas
        /// Carga la imagen del ojo tachado e inicializa verClave como FALSE
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            txtClaveFiscal.UseSystemPasswordChar = true;
            picBoxClave.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Assets", "hide.png"));
            verClave = false;
        }

        /// <summary>
        /// Boton Iniciar Sesión
        /// Al clickear obtiene lo que hay en los campos de los textBox Cuit y Clave Fiscal-
        /// Ingresa al portal de AFIP pasando los datos necesarios y cargando el nuevo formulario
        /// para poder facturar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            string cuit = txtCuit.Text;
            string clave = txtClaveFiscal.Text;

            if (Validador.LoginCamposCompletos(cuit, clave))
            {
                //Solo si los campos fueron completos creo un nuevo facturador que intentara ingresar al sitio e iniciar sesión
                Baker facturador = new Baker();
                try
                {
                    facturador.IngresarAlPortalAfip(cuit, clave);
                    //Si el ingreso es correcto instanciamos un nuevo form y ocultamos este
                    this.Hide();
                    FrmCargaDeFc frm = new FrmCargaDeFc(facturador);
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Login fallido");
                    facturador.ControladorChrome.Quit();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, completá CUIT y clave fiscal.", "Error");
                return;
            }
        }

        /// <summary>
        /// Impide el ingreso de cualquier caracter que no sea numérico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Alterna entre las imagenes del ojo que permite ver la clave o esconderla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxClave_Click(object sender, EventArgs e)
        {
            verClave = !verClave;
            txtClaveFiscal.UseSystemPasswordChar = verClave;

            string nombreImagen = !verClave ? "view.png" : "hide.png";
            string ruta = Path.Combine(Application.StartupPath, "Assets", nombreImagen);
            picBoxClave.Image = Image.FromFile(ruta);
        }
    }
}