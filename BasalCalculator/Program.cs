using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using BasalCalculator.Entities;
using BasalCalculator.Validator;

namespace BasalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SexValidator sexValidator = new SexValidator();
            Console.Write("Qual o seu sexo? (M/F): ");
            char sex = char.Parse(Console.ReadLine());


            while (!sexValidator.ValidarSexo(sex))
            {
                Console.WriteLine("Resposta inválida! Por favor digite seu sexo: M = Masculino, F = Feminino");
                Console.Write("Qual o seu sexo? (M/F): ");
                sex = char.Parse(Console.ReadLine());
            }


            Console.Write("Qual o seu peso? ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Qual a sua altura? (em cm) ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Qual a sua idade? ");
            int age = int.Parse(Console.ReadLine());


            if (sexValidator.ValidarSexoMasculino(sex))
            {
                Man man = new Man(age, weight, height);
                int response = man.Calculator(age, weight, height);
                Console.WriteLine($"Seu gasto calórico diário é de {response}");
            }
            else if (sexValidator.ValidarSexoFeminino(sex))
            {
                Woman woman = new Woman(age, weight, height);
                int response = woman.Calculator(age, weight, height);
                Console.WriteLine($"Seu gasto calórico diário é de {response}");
            }

        }
    }
}