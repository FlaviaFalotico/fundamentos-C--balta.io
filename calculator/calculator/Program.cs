/*Projeto de calculadora desenvolvida durante às aulas do curso Fundamentos do C# da balta.io.*/

Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Bem-vindo!");
    Console.WriteLine();
    Console.WriteLine("Escolha a operação que deseja calcular:\n1 - Soma\n2 - Subtração\n" +
        "3 - Divisão\n4 - Multiplicação\n5 - Potenciação\n6 - Radiciação\n7 - Sair");
    
    Console.WriteLine("----------------------");
    Console.WriteLine("Selecione uma opção: ");

    short resposta = short.Parse(Console.ReadLine());//short é um tipo menor de número inteiro

    switch (resposta)
    {
        case 1:
            Soma();
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Divisao();
            break;
        case 4:
            Multiplicacao();
            break;
        case 5:
            Potenciacao();
            break;
        case 6:
            Radiciacao();
            break;
        case 7:
            Despedida();
            break;
        default:
            Menu();
            break;    }
}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    double soma = valor1 + valor2;
    Console.WriteLine();
    Console.WriteLine($"O resultado da soma é: {soma.ToString("F2")}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    double subtracao = valor1 - valor2;
    Console.WriteLine();
    Console.WriteLine($"O resultado da subtração é: {subtracao.ToString("F2")}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    double divisao = valor1 * valor2;
    Console.WriteLine();
    Console.WriteLine($"O resultado da divisão é: {divisao.ToString("F2")}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    double multiplicacao = valor1 * valor2;
    Console.WriteLine();
    Console.WriteLine($"O resultado da multiplicação é: {multiplicacao.ToString("F2")}");
    Console.ReadKey();
    Menu();
}

static void Potenciacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor (base): ");
    double valor1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor (expoente): ");
    double valor2 = double.Parse(Console.ReadLine());

    double potenciacao1 = Math.Pow(valor1, valor2);
    Console.WriteLine();
    Console.WriteLine($"O resultado da potenciação é: {potenciacao1.ToString("F2")}");
    Menu();
}

static void Radiciacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor (índice do radical): ");
    double valor1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor (radicando): ");
    double valor2 = double.Parse(Console.ReadLine());

    double radiciacao = Math.Pow(valor2, (1 / valor1));
    Console.WriteLine();
    Console.WriteLine($"O resultado da radiciação é: {radiciacao.ToString("F2")}");
    Console.ReadKey();
    Menu();
}

static void Despedida()
{
    Console.Clear();

    Console.WriteLine("Obrigado por utilizar a nossa calculadora.");
    Console.WriteLine("Volte Sempre!");
}