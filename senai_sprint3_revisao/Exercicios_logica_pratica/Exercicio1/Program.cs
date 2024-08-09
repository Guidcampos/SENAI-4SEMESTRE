// Exercício 1
// Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o
// número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.
int numero;

Console.WriteLine($"Informe um numero:");
numero = int.Parse(Console.ReadLine()!);

if (numero % 2 == 0)
{
    Console.WriteLine($"O numero {numero} é PAR");
    
} else {

    Console.WriteLine($"O numero {numero} é IMPAR");
}