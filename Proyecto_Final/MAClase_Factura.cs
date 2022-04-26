using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class MAClase_Factura
    {
        private int MANumeroFactura;

        public int Manumerfactura
        {
            get
            {
                return MANumeroFactura;
            }
            set
            {
                MANumeroFactura = value;
            }
           
        }
        private char MAMONEDA;
        
        public char MAmoneda
        {
            get
            {
                return MAMONEDA;
            }
            set
            {
                MAMONEDA = value;
            }
        }
        private double MACAMBIO;

        public double MAcambio
        {
            get
            {
                return MACAMBIO;
            }
            set
            {
                MACAMBIO = value;
            }
        }
        private string MATIPOFACTURA;

        public string MAtipofactura
        {
            get
            {
                return MATIPOFACTURA;
            }
            set
            {
                MATIPOFACTURA = value;
            }
        }
        private DateTime MAFECHAFACTURA;
        public DateTime mafechafactura
        {
            get
            {
                return MAFECHAFACTURA;
            }
            set
            {
                MAFECHAFACTURA = value;
            }
        }
        private DateTime MAFECHAVENCIMIENTO;
        public DateTime mafechavencimiento
        {
            get
            {
                return MAFECHAVENCIMIENTO;
            }
            set
            {
                MAFECHAVENCIMIENTO = value;
            }
        }
        private double MASUBTOTAL;
        public double masubtotal
        {
            get
            {
                return MASUBTOTAL;
            }
            set
            {
                MASUBTOTAL = value;
            }

        }
        private double MADESCUENTO;
        public double madescuento
        {
            get
            {
                return MADESCUENTO;
            }
            set
            {
                MADESCUENTO = value;
            }
        }
        private double MATOTALDESCUENTO;
        public double matotaldescuento
        {
            get
            {
                return MATOTALDESCUENTO;
            }
            set
            {
                MATOTALDESCUENTO = value;
            }
        }
        private double MATotalImpuesto;
        public double matotalimpuesto
        {
            get
            {
                return MATotalImpuesto;
            }
            set
            {
                MATotalImpuesto = value;
            }
        }
        private double MATotalFactura;
        public double matotal
        {
            get
            {
                return MATotalFactura;
            }
            set
            {
                MATotalFactura = value;
            }
        }
        private int MACANTIDADPRODUCTO;
        private int MANumeroProducto;
        private string MANombreProducto;
        private double MAPrecioProducto;
        private string MAAplicaDescuento;
        private double MADIAS;
        private string MAAplicaImpuesto;
        private double MAIMPUESTOPAGAR;
        public double MAIMPUESTOPAGAR1
        {
            get { return MAIMPUESTOPAGAR; }
            set { MAIMPUESTOPAGAR = value; }
        }
        public string MAAplicaImpuesto1
        {
            get { return MAAplicaImpuesto; }
            set { MAAplicaImpuesto = value; }
        }
        public double MADIAS1
        {
            get { return MADIAS; }
            set { MADIAS = value; }
        }
        public string MAAplicaDescuento1
        {
            get { return MAAplicaDescuento; }
            set { MAAplicaDescuento = value; }
        }
        public double maprecioproducto1
        {
            get { return MAPrecioProducto; }
            set { MAPrecioProducto = value; }
        }
        public string manombreprodu
        {
            get { return MANombreProducto; }
            set { MANombreProducto = value; }
        }
        public int manumeroproducto
        {
            get { return MANumeroProducto; }
            set { MANumeroProducto = value; }
        }
        public int macantidadproducto1
        {
            get { return MACANTIDADPRODUCTO; }
            set { MACANTIDADPRODUCTO = value; }
        }
        //VARIABLE LOCAL
        char Seguir, ImprimirFactura;
        public int NoCliente, MAOpcion;
        public double MASuma, MADescuento;
        //DECLARAR LA LISTA PARA ALMACENAR DATOS DE LA FACTURA..
        List<MAClase_Factura> MAFacturas = new List<MAClase_Factura>();
        public void IngresoFactura()
        {
            try
            {   //SE LLAMAN A CADA UNO DE LOS METODOS PARA LA GENERACIÓN DE FACTURA
                TipodeFactura();
                
                if (Console.ReadLine() == "S")
                {
                    MAProducto ObjProducto = new MAProducto();
                    ObjProducto.MAListaProducto();

                    Seguir = 'S';
                    while (Seguir.Equals('S'))
                    {
                        Console.Write("Ingrese el Código de Producto de la Lista: ");
                        ObjProducto.SelectUsuario(int.Parse(Console.ReadLine()));
                        Console.Write("Ingrese la Cantidad del Producto: ");
                        macantidadproducto1 = int.Parse(Console.ReadLine());
                        MAFacturas.Add(new MAClase_Factura {manumeroproducto = ObjProducto.manumproducto, manombreprodu = ObjProducto.manombreproducto, maprecioproducto1 = ObjProducto.mapreciounitario1, macantidadproducto1 = macantidadproducto1, MAAplicaDescuento1 = ObjProducto.MAAplicaDescuento1, MAAplicaImpuesto1 = ObjProducto.maaplicaisv, MAIMPUESTOPAGAR1 = ObjProducto.maisv });

                        Console.Write("Desea Agregar mas Prodcutos S/N: ");
                        Seguir = char.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("===============================================================================================");

                    foreach (MAClase_Factura RegDatoFactura in MAFacturas)
                    {
                        Console.WriteLine("=== Prodcuto  " + RegDatoFactura.manumeroproducto + " - " + RegDatoFactura.manombreprodu + " Precio : " + MAmoneda + RegDatoFactura.maprecioproducto1 + " Cantidad: " + RegDatoFactura.macantidadproducto1 + " Aplica Descuento: " + MAAplicaDescuento1 + " Aplica Impuesto: " + RegDatoFactura.MAAplicaImpuesto1 + RegDatoFactura.MAIMPUESTOPAGAR1 + " || ===");
                    }

                }
                else
                {   //SE LIMPIA LA PANTALLA Y SE EJECUTA NUEVAMENTE EL METODO INGRESO FACTURA
                    Console.Clear();
                    IngresoFactura();
                }
                Console.Write("¿Desea Imprimir la Factura? S/N: ");
                ImprimirFactura = char.Parse(Console.ReadLine());
                if (ImprimirFactura == 'S')
                {
                    Console.Clear();
                    MAEMPRESA ObjEmpresa = new MAEMPRESA();
                    ObjEmpresa.ImprimirEmpresa();
                    Console.WriteLine("Fecha de Factura: " + mafechafactura);
                    Console.WriteLine("Fecha de Vencimiento: " + MAFecha());
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    ImprimirCliente();
                    Console.WriteLine("========================================================================================");
                    foreach (MAClase_Factura RegDatoFactura in MAFacturas)
                    {
                       Console.WriteLine("=== Prodcuto  " + RegDatoFactura.manumeroproducto + " - " + RegDatoFactura.manombreprodu + " Precio : " + MAmoneda + RegDatoFactura.maprecioproducto1 + " Cantidad: " + RegDatoFactura.macantidadproducto1 + " SubTotal : " + MAmoneda + (RegDatoFactura.macantidadproducto1 * RegDatoFactura.maprecioproducto1) + " Aplica Descuento " + RegDatoFactura.MAAplicaDescuento1 + " Aplica Impuesto: " + RegDatoFactura.MAAplicaImpuesto1 + " Descuento a Pagar: " + RegDatoFactura.MAIMPUESTOPAGAR1 + "%" + " || ===");
                        masubtotal += (RegDatoFactura.macantidadproducto1 * RegDatoFactura.maprecioproducto1);
                        if (RegDatoFactura.MAAplicaDescuento1 == "S")
                        {
                            MADescuento = (RegDatoFactura.macantidadproducto1 * RegDatoFactura.maprecioproducto1) * 0.20;

                        }
                        else if (RegDatoFactura.MAAplicaDescuento1 == "N")
                        {

                            MADescuento = 0;
                        }
                       MASuma += MADescuento;
                    }
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("SubTotal: " + MAmoneda + CalculoaPagar());
                    Console.WriteLine("Impuesto: " + MAmoneda + CalculoImpuesto());
                    Console.WriteLine("Descuento: " + MAmoneda + MASuma);
                    Console.WriteLine("Total a Pagar: " + MAmoneda + (CalculoTotal() - MASuma));
                }
                else
                {    //RETORNAR AL PROGRAMA MAIN...
                    Program.Iniciar();
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error, Formato Incorrecto");
                TipodeFactura();
            }

        }
        //METODO PARA SELECCIONAR EL TIPO DE FACTURA.
        private void TipodeFactura()
        {
            Console.WriteLine("1. Contado");
            Console.WriteLine("2. Credito");
            Console.Write("Ingrese el Tipo de Factura: ");
            MAOpcion = int.Parse(Console.ReadLine());
            if (MAOpcion == 1)
            {
                MAtipofactura = "Contado";
                Console.Write("Ingrese la Fecha de Factura: ");
                mafechafactura = DateTime.Parse(Console.ReadLine());
                MonedadeFactura();
                ClienteFactura();
                Console.Write("¿El Cliente es el correcto? S/N :");
            }
            else if (MAOpcion == 2)
            {
                MAtipofactura = "Crédito";
                Console.Write("Ingrese la Fecha de Factura: ");
                mafechafactura = DateTime.Parse(Console.ReadLine());
                MonedadeFactura();
                ClienteFactura();
                Console.Write("Ingrese los dias Credito del Cliente: ");//Estos dias deben ser los mismos ue aparecen en la descripcion del cliente en pantalla.
                MADIAS1 = double.Parse(Console.ReadLine());
                Console.Write("¿El Cliente es el correcto? S/N :");
            }
        }
        //METODO PARA DEFINIR LA MONEDA DE LA FACTURA
        private void MonedadeFactura()
        {
            Console.WriteLine("1. Lempiras");
            Console.WriteLine("2. Dólares");
            Console.Write("Ingrese el Tipo de Factura: ");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                MAmoneda = 'L';
            }
            else
            {
                MAmoneda = '$';
            }
        }
        //METODO PARA INSTANCIAR Y DISPARAR LOS PROCESOS DE LA CLASE CLIENTE.
        private void ClienteFactura()
        {
            Cliente ObjCliente = new Cliente();
            ObjCliente.ListaCliente();
            Console.Write("Ingrese el Número de Cliente: ");
            NoCliente = int.Parse(Console.ReadLine());
            ObjCliente.SelectCliente(NoCliente);
        }
        //METODO PARA IMPRIRMI LOS DATOS DEL CLIENTE.
        private void ImprimirCliente()
        {
            Cliente ObjCliente = new Cliente();
            ObjCliente.SelectCliente(NoCliente);
     
        }
        private double CalculoaPagar()
        {
            double MATotalPagar;
            return MATotalPagar = masubtotal;
        }
        private double CalculoImpuesto()
        {
            
            return matotalimpuesto = masubtotal * 0.15;
        }
        private double CalculoTotal()
        {
            
            return matotal = masubtotal + matotalimpuesto;
        }
        private DateTime MAFecha()
        {
            return mafechavencimiento = mafechafactura.AddDays(MADIAS1);
            if (MAOpcion == 1)
            {
                mafechavencimiento = mafechafactura;
            }
            else if (MAOpcion == 2)
            {
                mafechavencimiento = mafechafactura.AddDays(MADIAS1);
            }

        }
    }
}
