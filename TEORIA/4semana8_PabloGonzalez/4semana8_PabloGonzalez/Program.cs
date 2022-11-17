// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        /*Console.Clear();
         */
        string[] aPalabras = { ¨ADIOS¨, ¨Arbol¨, ¨marcador¨,¨LAPTOP¨, ¨avion¨, ¨perro¨, ¨AZUL¨,¨cuatro¨, ¨Veinte¨, ¨gato¨}
        string nombre = ¨ejemplo variable¨;

        for (int inc = 0; inc < 10, inc++)
        {
            Console.WriteLine(¨Validando mayusculas¨ +aPalabras[inc]);
            if (aPalabras[inc].ToUpper() == aPalabras[inc])
            {
                Console.WriteLine(¨Validando mayusculas¨ +aPalabras[inc] + ¨es mayuscula. ¨);
            }

        }
    }
}
