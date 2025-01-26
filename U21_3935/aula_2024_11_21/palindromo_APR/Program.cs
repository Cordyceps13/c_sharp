using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduz um número: ");
        string input = Console.ReadLine()!;

        // Verificar se a entrada é válida
        if (!int.TryParse(input, out int num))
        {
            Console.WriteLine("Input inválido. Por favor introduz um número válido.");
            return;
        }

        //Fazer a inversão como uma string sem conversão
        // Inverter a string do número
        char[] reversedChars = input.ToCharArray();
        Array.Reverse(reversedChars);
        string reversedString = new string(reversedChars);

        // Verificar se o número original e o invertido são iguais
        if (input == reversedString)
        {
            Console.WriteLine($"O número '{num}' é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"O número '{num}' não é um palíndromo.");
        }

        //Fazer a inversão com a conversão de string para int
        // // Guardar o número original para comparação
        // int temp = num;
        // int reversedNumber = 0;

        // // Reverter o número
        // while (temp > 0)
        // {
        //     int remainder = temp % 10;
        //     reversedNumber = reversedNumber * 10 + remainder;
        //     temp /= 10;
        // }

        // // Comparar o número original com o número revertido
        // if (num == reversedNumber)
        // {
        //     Console.WriteLine($"O número '{num}' é um palindromo.");
        // }
        // else
        // {
        //     Console.WriteLine($"O número '{num}' não é um palindromo.");
        // }
    }
}
