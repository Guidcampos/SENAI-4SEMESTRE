// Exercício 5
// Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada
// letra do alfabeto aparece no texto.


Console.WriteLine($"Digite um texto");
string texto = Console.ReadLine()!.ToLower();
Console.Clear();


Dictionary<char, int> alfabeto = new Dictionary<char, int>();

for (char letra = 'a'; letra <= 'z'; letra++)
{
    alfabeto[letra] = 0;

}

foreach (char x in texto)
{
    // Console.WriteLine($"{x}");

    if (alfabeto.ContainsKey(x))
    {
        alfabeto[x]++;
    }
}

Console.WriteLine($"\nNo texto: \n");
Console.WriteLine($"{texto}");
Console.WriteLine($"");
Console.WriteLine($"Contem: ");
Console.WriteLine($"");


foreach (var letras in alfabeto)
{
    if (letras.Value != 0)
    {
        Console.WriteLine($"{letras.Value} {(letras.Value == 1 ? "Letra " : "Letras")} {letras.Key} ".ToUpper());
    }

}


