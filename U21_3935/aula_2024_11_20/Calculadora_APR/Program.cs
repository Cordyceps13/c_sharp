using System;

class Program{
    static void Main(){
        Carimbo.ExibirInformacoes();

        int num1, num2;
        string operacao;

        // Exibindo as opções para o usuário
        Console.WriteLine("Calculadora simples em C#");
        Console.WriteLine("Escolha uma operação (+, -, *, /):");
        operacao = Console.ReadLine();

        // Solicitar os dois números
        Console.WriteLine("Introduza o primeiro número:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduza o segundo número:");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Realizar o cálculo com base na operação escolhida
        switch (operacao)
        {
            case "+":
                Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                break;
            case "/":
                // Verificar se o divisor não é zero
                if (num2 != 0 && num1 != 0)
                {
                    Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não permitida!");
                }
                break;
            default:
                Console.WriteLine("Operação inválida! Escolha +, -, * ou /.");
                break;
        }

        // Esperar o usuário pressionar uma tecla para finalizar
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
