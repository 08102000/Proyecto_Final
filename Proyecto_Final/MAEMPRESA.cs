using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class MAEMPRESA
    {
        private int MARTNEMPRESA;
        public int martnempresa
        {
            get { return MARTNEMPRESA; }
            set { MARTNEMPRESA = value; }
        }
        private string MANOMBRE;
        public string manombre
        {
            get { return MANOMBRE; }
            set { MANOMBRE = value; }
        }
        private string MADIRRECCION;
        public string madirreccion
        {
            get { return MADIRRECCION; }
            set { MADIRRECCION = value; }
        }
        private int MATELEFONO;
        public int matelefono
        {
            get { return MATELEFONO; }
            set { MATELEFONO = value; }
        }
        private string MAEMAILEMPRESA;
        public string maemailempresa
        {
            get { return MAEMAILEMPRESA; }
            set { MAEMAILEMPRESA = value; }
        }

        public MAEMPRESA()
        {
            manombre = " AMABARA STORE C.A ";
            madirreccion = "Tegucigalpa F.M, BLB SUYAPA";
            martnempresa = 081020001;
            matelefono = 22325577;
            maemailempresa = " Amabarastore@gmail.com ";
        }

        //METODO PARA IMPRIMIR LOS DATOS DE LA EMPRESA.
        public void ImprimirEmpresa()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("==========================" + manombre + "==================================");
            Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°" + madirreccion + " °°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            Console.WriteLine("===========================" + martnempresa + "=============================");
            Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°" + matelefono + " °°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            Console.WriteLine("===========================" + maemailempresa + "==============================");
        }
    }
}
