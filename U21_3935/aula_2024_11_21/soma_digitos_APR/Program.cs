using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduz um número: ");
        string input = Console.ReadLine()!;
        Console.WriteLine("--------------------------------");

        // Verificar se a entrada é válida
        if (!int.TryParse(input, out int num) || num < 0)
        {
            Console.WriteLine("Input inválido. Por favor, introduz um número inteiro positivo.");
            return;
        }

        int soma = 0;
        int temp = num;
        int i = 1;
        // Calcular a soma dos dígitos
        while (temp > 0)
        {
            Console.WriteLine($"{i}ª Volta");
            int resto = temp % 10; // Obter o último dígito
            soma += resto;         // Adicionar o dígito à soma
            temp /= 10;               // Remover o último dígito
            Console.WriteLine($"RESTO: {resto}");
            Console.WriteLine($"SOMA: {soma}");            
            Console.WriteLine($"TEMP: {temp}");
            i++;
            Console.WriteLine("--------------------------------");
        }

        Console.WriteLine($"A soma dos dígitos do número {num} é: {soma}");
    }
}
