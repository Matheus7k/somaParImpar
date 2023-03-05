using System.Collections;

internal class Program
{
    static int SomaPar(List<int> numeros)
    {
        int somaPar = 0;

        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                somaPar += numeros[i];
            }
        }
        return somaPar;
    }

    static int SomaImpar(List<int> numeros)
    {
        int somaImpar = 0;

        for(int i = 0; i < numeros.Count;i++)
        {
            if (numeros[i] % 2 != 0)
            {
                somaImpar += numeros[i];
            }
        }
        return somaImpar;
    }

    private static void Main(string[] args)
    {
        List<int> numeros = new();
        int numeroAtual;

        Console.WriteLine("Digite um numero maior que 999 para sair");
        Console.WriteLine("Digite quantos numeros você quiser: ");

        do
        {          
            numeroAtual = int.Parse(Console.ReadLine());
            if (numeroAtual < 1000 ||  numeroAtual > 0)
            {
                numeros.Add(numeroAtual);
            }
        } while (numeroAtual < 1000);

        Console.WriteLine($"Soma dos numeros pares: {SomaPar(numeros)}, soma dos numeros impares: {SomaImpar(numeros)}");
    }
}