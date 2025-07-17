using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillBakerCore
{
    public class GestorData
    {

        /// <summary>
        /// Lee un archivo Excel y genera una lista de objetos Factura
        /// </summary>
        /// <returns></returns>
        public static List<Factura> ExcelReader(string ruta)
        {            
            List<Factura> facturas = new List<Factura>();

            try
            {
                using (var workbook = new XLWorkbook(ruta))
                {
                    var hoja = workbook.Worksheet(1);
                    var filas = hoja.RangeUsed().RowsUsed().Skip(1);

                    foreach (var fila in filas)
                    {
                        Factura fc = new Factura
                        (
                            fila.Cell("A").GetValue<string>(),// Periodo desde
                            fila.Cell("B").GetValue<string>(),// Periodo hasta
                            fila.Cell("C").GetValue<string>(),// Condicion Iva 
                            fila.Cell("D").GetValue<string>(),// Cuit cliente
                            fila.Cell("E").GetValue<string>(), //Condicion de venta
                            fila.Cell("F").GetValue<string>(), // Descripción fc
                            fila.Cell("G").GetValue<int>(), // Cant.
                            fila.Cell("H").GetValue<decimal>() // Monto
                        );
                        facturas.Add(fc);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar excel {ex.Message}");
            }

            return facturas;
        }
    }
}
