// Exercício 2
// Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
// cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
// Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
// exemplo, bubble sort) para ordenar os nomes.

string[] nomes = new string[5];

Console.WriteLine($"Digite 5 nomes para atualizar a lista");

for (int i = 0; i < 5; i++)
{
     Console.WriteLine($"Insira {(i == 0 ? "um nome:" : "mais um nome:")} ");
    nomes[i] = Console.ReadLine()!;
    Console.Clear();
    ;
   
    
   
}

Array.Sort(nomes);
Console.WriteLine($"Aqui está sua lista atualizada: ");
Console.WriteLine($"");

foreach (var nome in nomes)
{
Console.WriteLine($"{nome}");   
}

