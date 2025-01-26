using System;
namespace primeiro_prog_APR;

public partial class Form1 : Form
{
    // private string historico = "";
    private string input = "";
    private string operacao = "";
    private double resultado = 0.0;

    public Form1()
    {
        InitializeComponent();
        // Associar eventos de clique aos botões numéricos
        Button0.Click += BtnNumero_Click;
        Button1.Click += BtnNumero_Click;
        Button2.Click += BtnNumero_Click;
        Button3.Click += BtnNumero_Click;
        Button4.Click += BtnNumero_Click;
        Button5.Click += BtnNumero_Click;
        Button6.Click += BtnNumero_Click;
        Button7.Click += BtnNumero_Click;
        Button8.Click += BtnNumero_Click;
        Button9.Click += BtnNumero_Click;
        Button_dot.Click += BtnNumero_Click;
        Button_op.Click += BtnNumero_Click;
        Button_cp.Click += BtnNumero_Click;

        // Associar eventos de clique aos botões de operações simples
        Button_mais.Click += BtnOperacao_Click;
        Button_menos.Click += BtnOperacao_Click;
        ButtonX.Click += BtnOperacao_Click;
        Button_divisao.Click += BtnOperacao_Click;

        // Associar evento de clique aos botões de edição/finalização
        Button_apagar.Click += ButtonApagar_Click;
        ButtonC.Click += ButtonC_Click;
        Button_igual.Click += ButtonIgual_Click;

        // Associar evento de clique aos botões de oprações especiais
        Button_PI.Click += ButtonPI_Click;
        Button_raiz.Click += ButtonOperacaoEspecial_Click;
        Button_quadrado.Click += ButtonOperacaoEspecial_Click;
        Button_cubo.Click += ButtonOperacaoEspecial_Click;
    }

    // Processa cliques nos botões numéricos
    private void BtnNumero_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        input += btn.Text;
        AtualizarResultado(input);
    }

    // Processa cliques nos botões de operação
    private void BtnOperacao_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        input += $"{btn.Text}";
        AtualizarResultado(input);
    }
    // private void ButtonIgual_Click(object sender, EventArgs e)
    // {
    //     try
    //     {
    //         // Avalia a expressão acumulada no input
    //         double resultadoFinal = AvaliarExpressao(input);

    //         // Adiciona o resultado ao histórico
    //         AtualizarResultado($"{input} = {resultadoFinal}");

    //         // Reseta o input e histórico para a próxima operação
    //         input = resultadoFinal.ToString();
    //     }
    //     catch (Exception ex)
    //     {
    //         AtualizarResultado($"Erro: {ex.Message}");
    //         input = "";
    //     }
    // }

    // Processa o botão "="
    private void ButtonIgual_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(input)) return;
        resultado = double.Parse(input);
        double operando = double.Parse(input);

        switch (operacao)
        {
            case "+":
                resultado += operando;
                break;
            case "-":
                resultado -= operando;
                break;
            case "x":
                resultado *= operando;
                break;
            case "÷":
                if (operando == 0)
                {
                    AtualizarResultado("Erro: Divisão por zero");
                    return;
                }
                resultado /= operando;
                break;
            default:
                break;
        }
        AtualizarResultado(resultado.ToString());
    }
    // private double AvaliarExpressao(string expressao)
    // {
    //     DataTable tabela = new DataTable();
    //     return Convert.ToDouble(tabela.Compute(expressao, string.Empty));
    // }


    // Processa o botão "C" (limpar tudo)
    private void ButtonC_Click(object sender, EventArgs e)
    {
        input = "";
        operacao = "";
        resultado = 0;
        AtualizarResultado("");
    }

    // Processa o botão "⌫" (apagar último caractere)
    private void ButtonApagar_Click(object sender, EventArgs e)
    {
        if (input.Length > 0)
        {
            input = input.Substring(0, input.Length - 1);
            AtualizarResultado(input);
        }
    }

    // Processa o botão "." (ponto decimal)
    private void ButtonDot_Click(object sender, EventArgs e)
    {
        if (!input.Contains("."))
        {
            input += ".";
            AtualizarResultado(input);
        }
    }

    // Processa o botão "π"
    private void ButtonPI_Click(object sender, EventArgs e)
    {
        input = Math.PI.ToString();
        AtualizarResultado(input);
    }

    // Processa botões de operações especiais (√, x², x³)
    private void ButtonOperacaoEspecial_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(input)) return;

        double number = double.Parse(input);
        Button btn = (Button)sender;

        switch (btn.Text)
        {
            case "√":
                number = Math.Sqrt(number);
                break;
            case "x²":
                number = Math.Pow(number, 2);
                break;
            case "x³":
                number = Math.Pow(number, 3);
                break;
        }

        input = number.ToString();
        AtualizarResultado(input);
    }

    // Atualiza o campo de resultado na calculadora
    private void AtualizarResultado(string text)
    {
        Resultado.Text = text;
        // Resultado.Text = $"{op1} {op} {op2}";
    }
    // private void AtualizarInput(string op1, string op, string op2)
    // {
    //     // Resultado.Text = text;
    //     Resultado.Text = $"{op1} {op} {op2}";
    // }

}
