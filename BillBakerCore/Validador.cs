﻿using OpenQA.Selenium;

namespace BillBakerCore
{
    /// <summary>
    /// Clase que validará que los datos ingresados sean correctos
    /// </summary>
    public static class Validador
    {
        /// <summary>
        /// Chequea que los datos de login no estén vacíos antes del envío al sitio
        /// </summary>
        /// <param name="cuit"> cuit del usuario</param>
        /// <param name="clave"> clave fiscal del usuario</param>
        /// <returns>True si los campos estan completos, False caso contrario</returns>
        public static bool LoginCamposCompletos(string cuit, string clave)
        {
            return !string.IsNullOrWhiteSpace(cuit) && !string.IsNullOrWhiteSpace(clave);
        }

        /// <summary>
        /// Chequea si el sitio devolvió error en el ingreso de los datos
        /// </summary>
        /// <param name="driver"> instancia del navegador que el bot está controlando, 
        /// se usará para inspeccionar el contenido actual de la página </param>
        /// <returns></returns>
        public static bool LoginValidoDesdeWeb(IWebDriver driver)
        {
            try
            {
                IWebElement mensaje = driver.FindElement(By.Id("F1:msg"));
                return !mensaje.Text.Contains("Número de CUIL/CUIT incorrecto")
                        && !mensaje.Text.Contains("Clave o usuario incorrecto");
            }
            catch (NoSuchElementException)
            {
                return true; // No hay mensaje → no falló el login
            }
        }

        /// <summary>
        /// Chequea si el valor que recibe es null o vacío
        /// Arroja una ArgumentException de ser asi, sino devuelve el valor.
        /// </summary>
        /// <param name="valor">El valor a validar</param>
        /// <param name="campo">El nombre de la propiedad cuyo valor es nulo o vacío</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string ValidarObligatorio(string valor, string campo)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException($"{campo} no puede estar vacío.");
            return valor;
        }

        /// <summary>
        /// Chequea si la fecha que recibe está vacía o es inválida en formato.
        /// Arroja una Exception de ser asi, sino devuelve el valor
        /// </summary>
        /// <param name="fecha">La fecha a validar</param>
        /// <param name="campo">El nombre de la propiedad cuyo valor es nulo o vacío</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DateTime ValidarFecha(DateTime fecha, string campo)
        {
            if (fecha == default)
                throw new Exception($"{campo} no puede estar vacío o tener una fecha inválida.");

            return fecha;
        }            

        /// <summary>
        /// Verifica si el navegador sigue activo para chequear que el usuario no lo haya cerrado
        /// </summary>
        /// <param name="driver">Instancia del navegaor</param>
        /// <returns>True si sigue activo, false caso contrario</returns>
        public static bool NavegadorActivo(IWebDriver driver)
        {
            try
            {
                //Pido titulo para chequear si el navegador existe
                var _ = driver.Title;
                return true;
            }
            catch (WebDriverException)
            {
                return false;
            }
        }

        // public static bool ExcelCargadoCorrectamente
        // public static bool FacturaValida

        /// <summary>
        /// 
        /// </summary>
        /// <param name="f">La factura a validar</param>
        /// <returns></returns>
        public static List<string> ValidarFactura(Factura f)
        {
            List<string> errores = new List<string>();

            if (f.PeriodoDesde > f.PeriodoHasta)
                errores.Add("El período 'Desde' no puede ser mayor que el período 'Hasta'.");

            if (string.IsNullOrWhiteSpace(f.CondicionIvaCliente))
                errores.Add("Debe especificar la condición IVA del cliente.");

            return errores;
        }
    }
}
