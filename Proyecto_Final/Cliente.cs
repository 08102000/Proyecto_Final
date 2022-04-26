using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Cliente
    {
        private int MACODIGOCLIENTE;
        public int macodigocliente
        {
            get
            {
                return MACODIGOCLIENTE;
            }
            set
            {
                MACODIGOCLIENTE = value;
            }
        }
        private string MANOMBRE;
        public string manombre
        {
            get
            {
                return MANOMBRE;
            }
            set
            {
                MANOMBRE = value;
            }
        }
        private string MADIRRECCION;
        public string madirreccion
        {
            get
            {
                return MADIRRECCION;
            }
            set
            {
                MADIRRECCION = value;
            }
        }
        private int MATELEFONO;
        public int matelefono
        {
            get
            {
                return MATELEFONO;
            }
            set
            {
                MATELEFONO = value;
            }
        }
        private string MAEMAIL;
        public string maemail
        {
            get
            {
                return MAEMAIL;
            }
            set
            {
                MAEMAIL = value;
            }
        }
        private int MARTN;
        public int martn
        {
            get
            {
                return MARTN;
            }
            set
            {
                MARTN = value;
            }
        }
        private int MADIASCREDITO;
        public int madiascredito
        {
            get
            {
                return MADIASCREDITO;
            }
            set
            {
                MADIASCREDITO = value;
            }
        }
        private string MAAPLICADESCUENTO;
        public string maaplicadescuento
        {
            get
            {
                return MAAPLICADESCUENTO;
            }
            set
            {
                MAAPLICADESCUENTO = value;
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
        private string MATERCERAEDAD;
        public string materceraedad
        {
            get
            {
                return MATERCERAEDAD;
            }
            set
            {
                MATERCERAEDAD = value;
            }
        }
        private string MACELULAR;
        public string macelular
        {
            get
            {
                return MACELULAR;
            }
            set
            {
                MACELULAR = value;
            }
        }
        public void ListaCliente()
        {
            List<Cliente> Clientes = new List<Cliente>
            {
               new Cliente { macodigocliente = 0000, manombre = "----------------------------", madirreccion="",matelefono=0000,maemail="",martn=0000,madiascredito=0000, maaplicadescuento="",madescuento=0,materceraedad="",macelular=""},
                new Cliente { macodigocliente = 1203, manombre = "Milton Amador", madirreccion="El Zamorano",matelefono=22334510,maemail="amador1508@gmail.com",martn=0810200065,madiascredito=30,maaplicadescuento="S",madescuento=3,materceraedad="N",macelular="32509723"},
                new Cliente { macodigocliente = 1151, manombre = "Mario Avila", madirreccion="Tegucigalpa, Col. kennedy",matelefono=2354713,maemail="avila@gmail.com",martn=7634452,madiascredito=60,maaplicadescuento="N",madescuento=0,materceraedad="S",macelular="98764312"},
                new Cliente { macodigocliente = 2345, manombre = "Walter Amador", madirreccion = "Col. Suyapa",matelefono=2255341,maemail="amador2224@gmail.com",martn=514253,madiascredito=90,maaplicadescuento="S",madescuento=3,materceraedad="N",macelular="98881777" },
                new Cliente { macodigocliente = 7831, manombre = "Isaac Caceres", madirreccion = "Maraita", matelefono=22223444,maemail="caceres@gmail.com",martn=5432172,madiascredito=20,maaplicadescuento="S",madescuento=3, materceraedad = "S",macelular="32508765"},
                new Cliente { macodigocliente = 1508, manombre = "Jeyson Sanabria", madirreccion = "Tatumbla",matelefono=22325550,maemail="sanabria@gmail.com",martn=65485321,madiascredito=100,maaplicadescuento="N",madescuento=0,materceraedad="N",macelular="33127654"},
                new Cliente { macodigocliente = 0615, manombre = "Olvin Andino", madirreccion = "El Zamorano",matelefono=22556677,maemail="andino@gmail.com",martn=8973643,madiascredito=45,maaplicadescuento="N",madescuento=0, materceraedad = "N",macelular="96347790"},
                new Cliente { macodigocliente = 6523, manombre = "Alexis Amador", madirreccion = "Danli",matelefono=22324455,maemail = "amador1908@gmail.com",martn=764584, madiascredito=75,maaplicadescuento="S",madescuento=3, materceraedad = "N",macelular="99532262"},
                new Cliente { macodigocliente = 1011, manombre = "Julio Suarez", madirreccion = "Col Villa Olimpica",matelefono=22437688,maemail="suarez@gmail.com",martn=65745332,madiascredito=110,maaplicadescuento="N",madescuento=0, materceraedad = "S",macelular="97624565"},
                new Cliente { macodigocliente = 5533, manombre = "Pedro Trochez", madirreccion = "Comayagua",matelefono=22301255,maemail = "trochez@gmail.com",martn=4532742,madiascredito=25,maaplicadescuento="N",madescuento=0, materceraedad = "N",macelular="87561254"},
                new Cliente { macodigocliente = 4237, manombre = "Antony Pereira", madirreccion = "El Paraiso",matelefono=22346678,maemail="pereira@gmai.com",martn=6745213, madiascredito=30,maaplicadescuento="S",madescuento=3,materceraedad="S",macelular="96775512"}
            };
            for (int RegCliente = 1; RegCliente < Clientes.Count; RegCliente++)
            {
                Console.WriteLine("Cliente: " + RegCliente + " ." + Clientes[RegCliente].manombre);
            }

        }
        public void SelectCliente(int Pindice)
        {
            List<Cliente> Clientes = new List<Cliente>
            {
                new Cliente { macodigocliente = 0000, manombre = "----------------------------", madirreccion="",matelefono=0000,maemail="",martn=0000,madiascredito=0000, maaplicadescuento="",madescuento=0,materceraedad="",macelular=""},
                new Cliente { macodigocliente = 1203, manombre = "Milton Amador", madirreccion="El Zamorano",matelefono=22334510,maemail="amador1508@gmail.com",martn=0810200065,madiascredito=30,maaplicadescuento="S",madescuento=20,materceraedad="N",macelular="32509723"},
                new Cliente { macodigocliente = 1151, manombre = "Mario Avila", madirreccion="Tegucigalpa, Col. kennedy",matelefono=2354713,maemail="avila@gmail.com",martn=7634452,madiascredito=60,maaplicadescuento="N",madescuento=20,materceraedad="S",macelular="98764312"},
                new Cliente { macodigocliente = 2345, manombre = "Walter Amador", madirreccion = "Col. Suyapa",matelefono=2255341,maemail="amador2224@gmail.com",martn=514253,madiascredito=90,maaplicadescuento="S",madescuento=20,materceraedad="N",macelular="98881777" },
                new Cliente { macodigocliente = 7831, manombre = "Isaac Caceres", madirreccion = "Maraita", matelefono=22223444,maemail="caceres@gmail.com",martn=5432172,madiascredito=20,maaplicadescuento="S",madescuento=20, materceraedad = "S",macelular="32508765"},
                new Cliente { macodigocliente = 1508, manombre = "Jeyson Sanabria", madirreccion = "Tatumbla",matelefono=22325550,maemail="sanabria@gmail.com",martn=65485321,madiascredito=100,maaplicadescuento="N",madescuento=20,materceraedad="N",macelular="33127654"},
                new Cliente { macodigocliente = 0615, manombre = "Olvin Andino", madirreccion = "El Zamorano",matelefono=22556677,maemail="andino@gmail.com",martn=8973643,madiascredito=45,maaplicadescuento="N",madescuento=20, materceraedad = "N",macelular="96347790"},
                new Cliente { macodigocliente = 6523, manombre = "Alexis Amador", madirreccion = "Danli",matelefono=22324455,maemail = "amador1908@gmail.com",martn=764584, madiascredito=75,maaplicadescuento="S",madescuento=20, materceraedad = "N",macelular="99532262"},
                new Cliente { macodigocliente = 1011, manombre = "Julio Suarez", madirreccion = "Col Villa Olimpica",matelefono=22437688,maemail="suarez@gmail.com",martn=65745332,madiascredito=110,maaplicadescuento="N",madescuento=20, materceraedad = "S",macelular="97624565"},
                new Cliente { macodigocliente = 5533, manombre = "Pedro Trochez", madirreccion = "Comayagua",matelefono=22301255,maemail = "trochez@gmail.com",martn=4532742,madiascredito=25,maaplicadescuento="N",madescuento=20, materceraedad = "N",macelular="87561254"},
                new Cliente { macodigocliente = 4237, manombre = "Antony Pereira", madirreccion = "El Paraiso",matelefono=22346678,maemail="pereira@gmai.com",martn=6745213, madiascredito=30,maaplicadescuento="S",madescuento=20,materceraedad="S",macelular="96775512"}
            };
            
            Console.WriteLine("No Cliente: " + Clientes[Pindice].macodigocliente + "-" + Clientes[Pindice].manombre);
            Console.WriteLine("Dirección: " + Clientes[Pindice].madirreccion + " Telefono: " + Clientes[Pindice].matelefono );
            Console.WriteLine("Email: " + Clientes[Pindice].maemail + " RTN: " + Clientes[Pindice].martn);
            Console.WriteLine("Dias Credito: " + Clientes[Pindice].madiascredito + " Aplica Descuento: " + Clientes[Pindice].maaplicadescuento);
            Console.WriteLine("Descuento: " + Clientes[Pindice].madescuento + "%" + " Tercera Edad: " + Clientes[Pindice].materceraedad);
            Console.WriteLine("Celular: " + Clientes[Pindice].macelular);
           
        }
    }
}
