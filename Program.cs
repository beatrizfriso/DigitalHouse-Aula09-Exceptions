using System;
using System.Globalization;

double resultado = 0;

double somarValor(double valor)
{
    resultado += valor;
    return resultado;
}

double subtrairValor(double valor)
{
    resultado -= valor;
    return resultado;
}

double dividirValor(double valor)
{
    resultado = resultado / valor;
    Console.WriteLine(resultado);

    try
    {
            resultado = resultado / valor;
            throw new Exception("Valor inserido é inválido.");
            Console.WriteLine(resultado);
    }

    catch (Exception erro) when (valor == 0 || resultado == 0)
    {
        Console.WriteLine("CodError001 - Divisão por 0 não é possível.");
        Console.WriteLine(erro.GetType());
        Console.WriteLine(erro.Message);
        Console.WriteLine(erro.StackTrace);
        return resultado;
    }
}

double multiplicarValor(double valor)
{
    resultado = resultado * valor;
    return resultado;
}

double zerarResultado(double resultado)
{
    return resultado = 0;
}

double definirResultadoDaUltimaOperacaoMatematica()
{
    double novoValor;
    Console.WriteLine("Digite o novo valor: ");
    novoValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    resultado = novoValor;
    return resultado;
}

double pegarResultadoDaUltimaOperacaoMatematica()
{
    return resultado;
}

try
{
    for (; ; )
    {
        Console.WriteLine("Escolha qual operação deseja realizar: ");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair ");
        Console.WriteLine("3 - Dividir");
        Console.WriteLine("4 - Multiplicar");
        Console.WriteLine("5 - Zerar a calculadora");
        Console.WriteLine("6 - Definir resultado da ultima operação:");
        Console.WriteLine("7 - Pegar resultado da ultima operação:");
        double Operador = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (Operador == 1)
        {
            Console.WriteLine("Você digitou 1 - Somar");
            Console.WriteLine("Qual valor deseja somar?");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;
            Console.WriteLine("O resultado é: " + somarValor(valor).ToString("F1"), CultureInfo.InvariantCulture);
        }
        else if (Operador == 2)
        {
            Console.WriteLine("Você digitou 2 - Subtrair");
            Console.WriteLine("Qual valor deseja subtrair?");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("O resultado é: " + subtrairValor(valor));
        }
        else if (Operador == 3)
        {
            Console.WriteLine("Você digitou 3 - Dividir");
            Console.WriteLine("Qual valor deseja dividir?");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("O resultado é: " + dividirValor(valor));
        }
        else if (Operador == 4)
        {
            Console.WriteLine("Você digitou 4 - Multiplicar");
            Console.WriteLine("Qual valor deseja multiplicar?");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("O resultado é: " + multiplicarValor(valor));
        }
        else if (Operador == 5)
        {
            Console.WriteLine("Você digitou 5 - Zerar calculadora");
            zerarResultado(resultado);
        }
        else if (Operador == 6)
        {
            definirResultadoDaUltimaOperacaoMatematica();
        }
        else
        {
            pegarResultadoDaUltimaOperacaoMatematica();
        }

    }

}
catch (Exception erro)
{
    Console.WriteLine("CodError002 - O usuário não pode inserir qualquer valor além de números.");
    Console.WriteLine(erro.GetType());
    Console.WriteLine(erro.Message);
    Console.WriteLine(erro.StackTrace);
}
finally
{
    Console.WriteLine("Reinicie o programa...");
}