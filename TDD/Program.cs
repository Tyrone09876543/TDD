using System;

namespace TDD
{
    public class TDD
    {
        public static void Main(string[] args)
        {
            MaquinaCafe maquinaCafe = new MaquinaCafe();
            string vaso;
            int cantidadVasos;
            int cantidadAzucar;

            do
            {
                do
                {
                    Console.WriteLine("\nSelecione un tipo de vaso:");
                    vaso = Console.ReadLine();
                    if (maquinaCafe.getTipoVaso(vaso) == null)
                    {
                        Console.WriteLine("Ese tipo de vaso no es valido");
                        continue;
                    }
                    break;
                } while (true);

                do
                {
                    Console.WriteLine("\nCantos vasos de cafe quiere");
                    cantidadVasos = Int32.Parse(Console.ReadLine());
                    if (cantidadVasos <= 0)
                    {
                        Console.WriteLine("Ingrese una cantidad de vasos valida");
                        continue;
                    }
                    break;
                } while (true);

                do
                {
                    Console.WriteLine("\nIngrese la cantidad de azucar que desee");
                    cantidadAzucar = Int32.Parse(Console.ReadLine());
                    if (cantidadAzucar < 0)
                    {
                        Console.WriteLine("Ingrese una cantidad de azucar valida");
                        continue;
                    }
                    break;
                } while (true);

                Console.WriteLine(maquinaCafe.getVasoDeCafe(maquinaCafe.getTipoVaso(vaso), cantidadVasos, cantidadAzucar));

                Console.WriteLine("\nIngrese 0 para salir");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            } while(true);
        }
    }
}
