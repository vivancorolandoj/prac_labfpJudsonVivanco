using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_labfpJudsonVivanco
{
    internal class Program
    {

        static string[] codigos = { "OC-101", "OC-102", "OC-103",
                                  "OC-104", "OC-105", "OC-106" };

        static string[] proveedores = { "TechCorp1", "LogiExpress", "InsumosGlobal",
                                      "TechCorp2", "AlfaSuministros", "ServiRedes"};

        static void Matriz_Financiera(string[] codigos, string[] proveedores)
        {
            float[] matriz = { 6, 2 };
            double [] precio = { 150.0, 450.0, 80.0, 1200.0, 25.0, 600.0 };
            int[] cantidad = { 10, 2, 50, 1, 100, 3 };
        }
            
            

        static int Validar_Datos()
        {
            double precio = 0;
            int cantidad = 0;
         while(true)
            {
                if(precio > 0 && cantidad > 0)
                {

                }
                else
                {
                        Console.WriteLine("ERROR");
                }
            }
            return cantidad;
        }


        static int Contador_Acumulador(string[] codigos, int contador)
        {
            int contador = 0;
            int acumulador = 0;
            for(int i = 0; i < codigos.Length; i++)
            {
                contador += codigos[i];
            }
            for (int i = 0; i < codigos.Length; i++)
            {
                acumulador = codigos;
            }
        }

        static int Ordenamiento_Directo()
        {
            for(int i = 0;i < codigos.Length; i++)
            {

            }
        }







        static void Main(string[] args)
        {

            Console.WriteLine("==============================");
            Console.WriteLine(" CONTROL DE ORDENES DE COMPRA ");
            Console.WriteLine("==============================");

            switch()
            {
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
            }
        }
    }
}

