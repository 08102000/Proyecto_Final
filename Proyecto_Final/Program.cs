using System;
using System.Collections.Generic;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            //INICIO EL MÉTODO PARA DISPARAR TODOS LOS DÉMAS PROCESOS.
            Iniciar();

        }
        
        public static void Iniciar()
        {
            //DECLARACIÓN E INICIALIZACIÓN DE LA LISTA DEL MENU
            List<string> MenuPrincipal = new List<string>();
            MenuPrincipal.Add("SISTEMA DE FACTURACIÓN");
            MenuPrincipal.Add("1. INGRESO DE FACTURA");
            MenuPrincipal.Add("2. INGRESO DE CLIENTES");
            MenuPrincipal.Add("3. INGRESO DE PRODUCTOS");
            MenuPrincipal.Add("4. SALIR DEL SISTEMA");

            //LECTURA DE LA LISTA DEL MENU DE OPCIONES
            foreach (string Opcion in MenuPrincipal)
            {
                Console.WriteLine(Opcion);
            }
            Console.Write("Ingrese el Número de Opcion: ");
            int NumeroOpcion = int.Parse(Console.ReadLine());
            //EVALUAR SEGÚN LA OPCIÓN QUE SELECCIONO EL USUARIO
            switch (NumeroOpcion)
            {
                case 1:
                    MAClase_Factura ObjFactura = new MAClase_Factura();
                    ObjFactura.IngresoFactura();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("No Ingreso Ninguna Opción del Menú");
                    break;
            }
        }
    }
}
