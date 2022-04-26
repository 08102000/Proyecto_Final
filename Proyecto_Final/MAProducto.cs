using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class MAProducto
    {
        private int MANUMEROPRODUCTO;
        public int manumproducto
        {
            get { return MANUMEROPRODUCTO; }
            set { MANUMEROPRODUCTO = value; }
        }
        private string MANOMBREPRODUCTO;
        public string manombreproducto
        {
            get { return MANOMBREPRODUCTO; }
            set { MANOMBREPRODUCTO = value; }
        }
        private double MAPRECIOUNITARIO;
        public double mapreciounitario1
        {
            get { return MAPRECIOUNITARIO; }
            set { MAPRECIOUNITARIO = value; }
        }
        private string MAAPLICAISV;
        public string maaplicaisv
        {
            get { return MAAPLICAISV; }
            set { MAAPLICAISV = value; }
        }
        private double MAISV;
        public double maisv
        {
            get { return MAISV; }   
            set { MAISV = value; }
        }
        private int MACANTIDADMAX;
        public int macantidad
        {
            get { return MACANTIDADMAX; }
            set { MACANTIDADMAX = value; }
        }
        private double MACOSTO;
        public double macosto
        {
            get { return MACOSTO; }
            set { MACOSTO = value; }
        }
        private string MATIPOUNIDAD;
        public string matipounidad
        {
            get { return MATIPOUNIDAD; }
            set { MATIPOUNIDAD = value; }
        }
        private int MAUNIDADESCAJA;
        public int maunidadescaja
        {
            get { return MAUNIDADESCAJA; }
            set { MAUNIDADESCAJA = value; }
        }
        private string MATIPOVENTA;
        public string matipoventa
        {
            get { return MATIPOVENTA; }
            set { MATIPOVENTA = value; }
        }
        private string MAAplicaDescuento;
        public string MAAplicaDescuento1
        {
            get { return MAAplicaDescuento; }
            set { MAAplicaDescuento = value; }
        }
        public void MAListaProducto()
        {
            List<MAProducto> Producto = new List<MAProducto>
            {
               new MAProducto { manumproducto= 0000, manombreproducto = "----------------------------", mapreciounitario1 = 0,maaplicaisv="",maisv=0,MAAplicaDescuento1 = ""},
                new MAProducto { manumproducto = 5512, manombreproducto = "Motocicleta Yamaha YBR 125G", mapreciounitario1 = 42000,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 7689, manombreproducto = "Motocicleta Yamaha XTZ 125", mapreciounitario1 = 52000,maaplicaisv="S", MAAplicaDescuento1 = "N"},
                new MAProducto { manumproducto = 9865, manombreproducto = "Motocicleta Yamaha DT175", mapreciounitario1 = 55000,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 7812, manombreproducto = "Motocicleta Yamaha XT225", mapreciounitario1 = 60000,maaplicaisv="S",maisv=15,MAAplicaDescuento1 = "N"},
                new MAProducto { manumproducto = 1508, manombreproducto = "Motocicleta Yamha XT250", mapreciounitario1 = 70000,maaplicaisv="S" , maisv = 15 , MAAplicaDescuento1="S"},
                new MAProducto { manumproducto = 1092, manombreproducto = "Motocicleta Yamaha XT350", mapreciounitario1 = 80000,maaplicaisv="S", maisv = 15, MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 2145, manombreproducto = "Motocicleta Honda 125", mapreciounitario1 = 22500,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "N"},
                new MAProducto { manumproducto = 0101, manombreproducto = "Motocicleta Honda 150", mapreciounitario1 = 28700,maaplicaisv="S",maisv = 15, MAAplicaDescuento = "S"},
                new MAProducto { manumproducto = 1002, manombreproducto = "Motocicleta Honda Tornado", mapreciounitario1 = 35000,maaplicaisv="S", maisv = 15 , MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Suzuki 115", mapreciounitario1 = 17500,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S" },
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Suzuki 125", mapreciounitario1 = 21200,maaplicaisv="S", maisv = 15, MAAplicaDescuento1 = "N"},
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Suzuki AG 150", mapreciounitario1 = 28500,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S" },
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Genesis 125", mapreciounitario1 = 20000,maaplicaisv="S", maisv = 15, MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Genesis GXT250", mapreciounitario1 = 30000,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "N" },
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta KMF 250", mapreciounitario1 = 27500,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S" }
            };
           

            for (int RegProducto = 1; RegProducto < Producto.Count; RegProducto++)
            {
                Console.WriteLine("Producto: " + RegProducto + " ." + Producto[RegProducto].manombreproducto);
            }
        }
        public void SelectUsuario(int MAOpcion)
        {
            List<MAProducto> Producto = new List<MAProducto>
            {
              new MAProducto { manumproducto= 0000, manombreproducto = "----------------------------", mapreciounitario1 = 0,maaplicaisv="",maisv=0,MAAplicaDescuento1 = ""},
                new MAProducto { manumproducto = 5512, manombreproducto = "Motocicleta Yamaha YBR 125G", mapreciounitario1 = 42000,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 7689, manombreproducto = "Motocicleta Yamaha XTZ 125", mapreciounitario1 = 52000,maaplicaisv="S", MAAplicaDescuento1 = "N"},
                new MAProducto { manumproducto = 9865, manombreproducto = "Motocicleta Yamaha DT175", mapreciounitario1 = 55000,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 7812, manombreproducto = "Motocicleta Yamaha XT225", mapreciounitario1 = 60000,maaplicaisv="S",maisv=15,MAAplicaDescuento1 = "N"},
                new MAProducto { manumproducto = 1508, manombreproducto = "Motocicleta Yamha XT250", mapreciounitario1 = 70000,maaplicaisv="S" , maisv = 15 , MAAplicaDescuento1="S"},
                new MAProducto { manumproducto = 1092, manombreproducto = "Motocicleta Yamaha XT350", mapreciounitario1 = 80000,maaplicaisv="S", maisv = 15, MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 2145, manombreproducto = "Motocicleta Honda 125", mapreciounitario1 = 22500,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "N"},
                new MAProducto { manumproducto = 0101, manombreproducto = "Motocicleta Honda 150", mapreciounitario1 = 28700,maaplicaisv="S",maisv = 15, MAAplicaDescuento = "S"},
                new MAProducto { manumproducto = 1002, manombreproducto = "Motocicleta Honda Tornado", mapreciounitario1 = 35000,maaplicaisv="S", maisv = 15 , MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Suzuki 115", mapreciounitario1 = 17500,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S" },
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Suzuki 125", mapreciounitario1 = 21200,maaplicaisv="S", maisv = 15, MAAplicaDescuento1 = "N"},
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Suzuki AG 150", mapreciounitario1 = 28500,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S" },
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Genesis 125", mapreciounitario1 = 20000,maaplicaisv="S", maisv = 15, MAAplicaDescuento1 = "S"},
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta Genesis GXT250", mapreciounitario1 = 30000,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "N" },
                new MAProducto { manumproducto = 9088, manombreproducto = "Motocicleta KMF 250", mapreciounitario1 = 27500,maaplicaisv="S",maisv=15, MAAplicaDescuento1 = "S" }
            };
            //Console.Clear();
            //Console.WriteLine("No Producto: " + Producto[MAOpcion].manumproducto + "-" +Producto[MAOpcion].manombreproducto);
            //Console.WriteLine("Precio Unitario: " + Producto[MAOpcion].mapreciounitario1 + " Lempiras ");
            //Console.WriteLine("Aplica ISV: " + Producto[MAOpcion].maaplicaisv);
            //Console.WriteLine("ISV: " + Producto[MAOpcion].maisv + "%");
            //Console.WriteLine("Cantidad Maxima: " + Producto[MAOpcion].macantidad);
            //Console.WriteLine("Tipo Unidad: " + Producto[MAOpcion].matipounidad);
            ObjProductos(Producto[MAOpcion].manumproducto, Producto[MAOpcion].manombreproducto, Producto[MAOpcion].mapreciounitario1, Producto[MAOpcion].MAAplicaDescuento1, Producto[MAOpcion].maaplicaisv, Producto[MAOpcion].maisv);

        }
        public MAProducto ObjProductos(int pnoprodcuto, string pnombre, double pprecio, string PAplicadescuento, string PAplicaImpuesto, double PImpuesto)
        {
            MAProducto Datos = new MAProducto();
            manumproducto = pnoprodcuto;
            manombreproducto = pnombre;
            mapreciounitario1 = pprecio;
            MAAplicaDescuento1 = PAplicadescuento;
            maaplicaisv = PAplicaImpuesto;
            maisv = PImpuesto;
            return Datos;
        }
    }  
    
}
