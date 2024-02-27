using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            Console.WriteLine("Digite seu sexo (M para Masculino e F para Feminino): ");
            sexo = char.Parse(Console.ReadLine());
            if (sexo == 'M' || sexo == 'm' || sexo == 'F' || sexo == 'f')
            {
                Console.WriteLine("Sexo Válido.");
            } 
        else { Console.WriteLine("Sexo Inválido."); }


            Console.ReadKey();

        }



    }
}
