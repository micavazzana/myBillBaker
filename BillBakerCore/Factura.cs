using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillBakerCore
{
    public class Factura
    {
        //Pantalla 1 : Dropdowns
        private string puntoDeVenta;
        private string tipoFactura;

        //Pantalla 2 : Dropdowns
        private string fecha;
        private string conceptoAIncluir; //si es servicios o productos
        private string periodoDesde;
        private string periodoHasta;

        //Pantalla 3
        private string condicionIvaCliente;
        private string cuitCliente;
        private string condicionDeVenta; //check box "contado" u otro

        //Pantalla 4
        private string descripcion;
        private int cantidad;
        private decimal monto;

        public Factura(string puntoDeVenta, string tipoFactura, string fecha, string conceptoAIncluir, string periodoDesde, string periodoHasta, string condicionIvaCliente, string cuitCliente, string condicionDeVenta, string descripcion, int cantidad, decimal monto)
        {
            this.PuntoDeVenta = puntoDeVenta;
            this.TipoFactura = tipoFactura;
            this.fecha = fecha;
            this.conceptoAIncluir = conceptoAIncluir;
            this.periodoDesde = periodoDesde;
            this.periodoHasta = periodoHasta;
            this.condicionIvaCliente = condicionIvaCliente;
            this.cuitCliente = cuitCliente;
            this.condicionDeVenta = condicionDeVenta;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.monto = monto;
        }

        //Getters and Setters
        public string PuntoDeVenta
        {
            get => puntoDeVenta;
            set { if (puntoDeVenta != null) puntoDeVenta = value; }
        }
        public string TipoFactura { get => tipoFactura; set { if (tipoFactura != null) tipoFactura = value; } }
        public string Fecha { get => fecha; set => fecha = value; }
        public string ConceptoAIncluir { get => conceptoAIncluir; set => conceptoAIncluir = value; }
        public string PeriodoDesde { get => periodoDesde; set => periodoDesde = value; }
        public string PeriodoHasta { get => periodoHasta; set => periodoHasta = value; }
        public string CondicionIvaCliente { get => condicionIvaCliente; set => condicionIvaCliente = value; }
        public string CuitCliente { get => cuitCliente; set => cuitCliente = value; }
        public string CondicionDeVenta { get => condicionDeVenta; set => condicionDeVenta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Monto { get => monto; set => monto = value; }

    }
}
