using System;

class Program
{
    static void Main()
    {
        // 12602035
        // Vitor Novaes de Assis
        // 2E1


        double num1, num2, num3;
        bool possuiNegativo;

        do
        {
            Console.Write("Informe o 1º número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o 2º número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o 3º número: ");
            num3 = double.Parse(Console.ReadLine());

            possuiNegativo = VerificaDados(num1, num2, num3);

            if (possuiNegativo)
            {
                Console.WriteLine("---------------------------------------------------");
                MensagemDeErro();
                Console.WriteLine("---------------------------------------------------");
            }

        } while (possuiNegativo);

        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine($"Valor da soma: {SomaNumeros(num1, num2, num3)}");
        Console.WriteLine($"Valor da média: {MediaNumeros(num1, num2, num3):0.#}");
        Console.WriteLine($"Maior valor: {MaiorDeTodos(num1, num2, num3)}");
        Console.WriteLine($"Menor valor: {MenorDeTodos(num1, num2, num3)}");
        Console.WriteLine("---------------------------------------------------");

        Console.ReadKey();
    }

    static bool VerificaDados(double n1, double n2, double n3)
    {
        return n1 < 0 || n2 < 0 || n3 < 0;
    }

    static void MensagemDeErro()
    {
        Console.WriteLine("Todos os números devem ser positivos.");
    }

    static double SomaNumeros(double n1, double n2, double n3)
    {
        return n1 + n2 + n3;
    }

    static double MediaNumeros(double n1, double n2, double n3)
    {
        return SomaNumeros(n1, n2, n3) / 3;
    }

    static double MaiorDeTodos(double n1, double n2, double n3)
    {
        return Math.Max(n1, Math.Max(n2, n3));
    }

    static double MenorDeTodos(double n1, double n2, double n3)
    {
        return Math.Min(n1, Math.Min(n2, n3));
    }
}