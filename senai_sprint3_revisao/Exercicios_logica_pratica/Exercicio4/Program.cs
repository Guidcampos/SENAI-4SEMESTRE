// Exercício 4
// Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
// número até o número 10. Utilize um laço for para gerar os múltiplos do número.

  
void taboada(int n) {

        Console.WriteLine($"Taboada do {n}:");
        Console.WriteLine($"");
   for (int i = 1; i <= 10; i++)
   {
    
       Console.WriteLine($"{n} x {i}: {i*n}");
   } 

}
Console.WriteLine($"Insira um numero:");
int n = int.Parse( Console.ReadLine()!);
Console.Clear();
taboada(n);

