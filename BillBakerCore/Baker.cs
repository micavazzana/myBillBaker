using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BillBakerCore
{
    public class Baker
    {
        private IWebDriver controladorChrome; //IWebDriver es una interfaz que representa una instancia del navegador, el contenido y todas las interacciones con la web
        private WebDriverWait waiter;

        /// <summary>
        /// Constructor
        /// Crea una instancia de configuración para el navegador 
        /// e inicializamos el navegador con esas opciones
        /// Luego creamos un "mesero" que espera a los elementos
        /// </summary>
        public Baker()
        {
            ChromeOptions opciones = new ChromeOptions();
            opciones.AddArgument("--start-maximized");
            // opciones.AddArgument("--headless"); // no abre ventana visible

            this.controladorChrome = new ChromeDriver(opciones);
            this.waiter = new WebDriverWait(controladorChrome, TimeSpan.FromSeconds(10));
        }
        public IWebDriver ControladorChrome { get => controladorChrome; set => controladorChrome = value; }

        /// <summary>
        /// Login: Abre el portal de AFIP directamente en la página del MONOTRIBUTO
        /// Completa los campos Cuit y Clave Fiscal presionando "siguiente" en cada caso
        /// y chequea que el sitio no devuelva una exception en cada espacio a completar
        /// </summary>
        /// <param name="cuit">Cuit del usuario</param>
        /// <param name="clave">Clave Fiscal del usuario</param>
        public void IngresarAlPortalAfip(string cuit, string clave)
        {
            this.controladorChrome.Navigate().GoToUrl("https://auth.afip.gov.ar/contribuyente_/login.xhtml?action=SYSTEM&system=admin_mono");

            this.waiter.Until(driver => driver.FindElement(By.Id("F1:username"))).SendKeys(cuit);//20345037064
            Thread.Sleep(1000); // Pausa para poder ver que lo haga antes de que cliquee "Siguiente":
            this.controladorChrome.FindElement(By.Id("F1:btnSiguiente")).Click();

            if (!Validador.LoginValidoDesdeWeb(this.controladorChrome))
            {
                throw new Exception("CUIT incorrecto");
            }
            else
            {
                //Si el cuit pudo ser completado entonces intentamos completar la clave
                this.waiter.Until(driver => driver.FindElement(By.Id("F1:password"))).SendKeys(clave);//Andalaosa2025
                Thread.Sleep(1000);
                this.controladorChrome.FindElement(By.Id("F1:btnIngresar")).Click();
                if (!Validador.LoginValidoDesdeWeb(this.controladorChrome))
                    throw new Exception("Clave Fiscal incorrecta");
            }
        }


        // A DESARROLLAR
        public void SeleccionarEmpresa()
        {
            this.controladorChrome.FindElement(By.ClassName("btn_empresa")).Click();
        }
        public void Cocinar(List<Factura> facturas)
        {
            foreach (var factura in facturas)
            {
                GenerarFactura(factura);
            }

            controladorChrome.Quit(); // cerramos navegador al final
        }        
        private void GenerarFactura(Factura factura)
        {
            // Completar campos de la pagina paso a paso y guardar factura
        }
        private void EsperarElemento(By selector)
        {
            waiter.Until(driver => driver.FindElement(selector).Displayed);
        }
    }
}
