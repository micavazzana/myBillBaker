namespace BillBakerCore
{
    public class Factura
    {
        //Pantalla 1 : Dropdowns
        // private string puntoDeVenta; Unico select
        // private string tipoFactura;  Factura C
        // private string conceptoAIncluir; si es servicios o productos

        //Pantalla 2 : Dropdowns
        private DateTime periodoDesde;
        private DateTime periodoHasta;

        //Pantalla 3
        private string condicionIvaCliente;
        private string cuitCliente;
        private string condicionDeVenta; //check box "contado" u otro

        //Pantalla 4
        private string descripcion;
        private int cantidad;
        private decimal monto;

        public Factura(DateTime periodoDesde, DateTime periodoHasta, string condicionIvaCliente, string cuitCliente, string condicionDeVenta, string descripcion, int cantidad, decimal monto)
        {
            this.PeriodoDesde = periodoDesde;
            this.PeriodoHasta = periodoHasta;
            this.CondicionIvaCliente = condicionIvaCliente;
            this.CuitCliente = cuitCliente;
            this.CondicionDeVenta = condicionDeVenta;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Monto = monto;
        }

        //Getters and Setters
        public DateTime PeriodoDesde
        {
            get => this.periodoDesde;
            set => this.periodoDesde = Validador.ValidarFecha(value, nameof(PeriodoDesde));
        }
        public DateTime PeriodoHasta
        {
            get => this.periodoHasta;
            set => this.periodoHasta = Validador.ValidarFecha(value, nameof(PeriodoHasta));
        }
        public string CondicionIvaCliente 
        { 
            get => this.condicionIvaCliente; 
            set => this.condicionIvaCliente = Validador.ValidarObligatorio(value, nameof(CondicionIvaCliente));
        }
        public string CuitCliente 
        { 
            get => this.cuitCliente; 
            set => this.cuitCliente = string.IsNullOrWhiteSpace(value) ? string.Empty : value; 
        }
        public string CondicionDeVenta 
        { 
            get => this.condicionDeVenta; 
            set => this.condicionDeVenta = Validador.ValidarObligatorio(value, nameof(CondicionDeVenta)); 
        }
        public string Descripcion 
        { 
            get => this.descripcion; 
            set => this.descripcion = Validador.ValidarObligatorio(value, nameof(Descripcion)); 
        }
        public int Cantidad 
        { 
            get => this.cantidad; 
            set => this.cantidad = value; 
        }
        public decimal Monto 
        { 
            get => monto; 
            set => monto = value; 
        }
    }
}