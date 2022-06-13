double resultado = 0;

double somarValor(double valor)
{
    return resultado + valor;
}

double subtrairValor(double valor)
{
    return resultado - valor;
}

double dividirValor(double valor)
{
    return resultado / valor;
}

double multiplicarValor(double valor)
{
    return resultado * valor;
}

double zerarResultado(double resultado)
{
    return resultado;
}

Console.WriteLine("Escolha qual operação deseja realizar:");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair ");
Console.WriteLine("3 - Dividir");
Console.WriteLine("4 - Multiplicar");
Console.WriteLine("5 - Zerar a calculadora");

double Operador = Convert.ToDouble(Console.ReadLine());


void definirResultadoDaUltimaOperacaoMatematica(double resultadoDaOperacao)
{


}

double pegarResultadoDaUltimaOperacaoMatematica(double resultado)
{

    if (Operador == 1)
    {
        Console.WriteLine("Você digitou 1 - Somar");
        Console.WriteLine("Qual valor deseja somar?");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O resultado é: " + somarValor(valor));
        return resultado;
    }
    else if (Operador == 2)
    {
        Console.WriteLine("Você digitou 2 - Subtrair");
        Console.WriteLine("Qual valor deseja subtrair?");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O resultado é: " + subtrairValor(valor));
        return resultado;
    }
    else if (Operador == 3)
    {
        Console.WriteLine("Você digitou 3 - Dividir");
        Console.WriteLine("Qual valor deseja dividir?");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O resultado é: " + dividirValor(valor));
        return resultado;
    }
    else if (Operador == 4)
    {
        Console.WriteLine("Você digitou 4 - Multiplicar");
        Console.WriteLine("Qual valor deseja multiplicar?");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O resultado é: " + multiplicarValor(valor));
        return resultado;
    }
    else
    {
        Console.WriteLine("Você digitou 5 - Zerar calculadora");
        return resultado;
    }

}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Escolha qual operação deseja realizar:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair ");
    Console.WriteLine("3 - Dividir");
    Console.WriteLine("4 - Multiplicar");
    Console.WriteLine("5 - Zerar a calculadora");

    Operador = Convert.ToDouble(Console.ReadLine());

    pegarResultadoDaUltimaOperacaoMatematica(resultado);
}
