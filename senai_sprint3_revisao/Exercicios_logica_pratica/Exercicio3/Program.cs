// Exercício 3
// Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.
// Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar
// os números pares.

int[] numeros = new int[10];
Random nAleatorio = new Random();
int soma = 0;
int pares = 0;

Console.WriteLine($"A lista gerada foi:");
Console.WriteLine($"");


for (int i = 0; i < 10; i++)
{
    int n = nAleatorio.Next(100);
    numeros[i] = n;
    
    if (numeros[i] % 2 == 0 )
    {
       soma+= numeros[i];
       pares++;
    }
}


foreach (var numero in numeros)
{
Console.WriteLine($"{numero}");   
}
Console.WriteLine($"");
Console.WriteLine($"Contendo {pares} numeros pares");
Console.WriteLine($"Sendo a soma desses numeros: {soma}");
