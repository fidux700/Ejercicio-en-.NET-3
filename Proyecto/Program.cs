using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int resultado;
            int par = 0;
            int parMayor = 0;
            int imPar = 0;
            int contadorImpar = 0;
            int contadorPrimos = 0;
            int primoMenorMain = 0;

            System.Console.WriteLine("Ingrese un valor (Ingrese cero si desea finalizar el programa)");
            int numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                resultado = numero % 2;
                //NUMERO PAR 
                if (resultado == 0)
                {
                    par = numero;
                    if (par > parMayor)
                    {
                        parMayor = par;
                    }
                }
                //NUMERO IMPAR 
                else
                {
                    imPar = numero;
                    contadorImpar++;
                }
                //LLAMADA A LA FUNCION / CALCULO DE PRIMO MENOR 
                FuncionPrimo(numero);
                if (FuncionPrimo(numero) && contadorPrimos == 0)
                {
                    contadorPrimos++;
                    primoMenorMain = numero;
                }
                else if (FuncionPrimo(numero) && numero < primoMenorMain && contadorPrimos > 0)
                {
                    primoMenorMain = numero;
                }
                System.Console.WriteLine("\nIngrese un valor (Ingrese cero si desea finalizar el programa)");
                numero = int.Parse(Console.ReadLine());
            }

            //PUNTO A 
            System.Console.WriteLine($"\nEl numero mayor de los pares es: {parMayor}");
            //PUNTO B 
            System.Console.WriteLine($"La cantidad de numeros impares son: {contadorImpar}");
            //PUNTO C 
            System.Console.WriteLine($"El menor de los numeros primos es: {primoMenorMain}");

        }


        static bool FuncionPrimo(int a)
        {
            int contador = 0;

            //BUSQUEDA DEL NUMERO PRIMO 
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                return true;

            }
            else
            {
                //System.Console.WriteLine(false); 
                return false;
            }

        }
    }
}
