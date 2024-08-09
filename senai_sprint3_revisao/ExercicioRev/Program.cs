//Exercicio 1 ---------------------------------------------------------------------
// int nota;

// Console.WriteLine($"Qual sua nota?");
// nota = int.Parse(Console.ReadLine());


// if (nota >= 7)
// {
//     Console.WriteLine($"Aluno aprovado");

// } else if (nota < 5)
// {
//     Console.WriteLine($"Aluno Reprovado");

// } else
// {
//     Console.WriteLine($"Aluno em recuperação");

// }

//Exercicio 2 ---------------------------------------------------------------------

// int numero;

// Console.WriteLine($"Tabuada de qual numero?");
// numero = int.Parse(Console.ReadLine()!);

//     Console.WriteLine("---------------------------" );
//     Console.WriteLine("Tabuada do " + numero);
//     Console.WriteLine("---------------------------" );
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {i*numero}");


// }

//Exercicio 3 ---------------------------------------------------------------------

// int contador = 1;
// int soma = 0;


// while (contador <= 100)
// {

//    if (contador % 2 == 0)
//    {
//       soma += contador;

//    }
//     contador++;
// }

// Console.WriteLine($"{soma}");

//Exercicio 4 ---------------------------------------------------------------------

// int nUsuario;
// int tentativas = 0;

// Random nAleatorio = new Random();

// int n = nAleatorio.Next(1, 100);

// do
// {

//     Console.WriteLine($"Adivinhe o numero entre 1 e 100:");
//     nUsuario = int.Parse(Console.ReadLine());

//     tentativas++;
//     Console.WriteLine(nUsuario > n ? $"Numero aleatorio menor" : nUsuario < n ? "Numero aleatorio maior" : $"Voce acertou em {tentativas} tentativas");

// } while (nUsuario != n);

//Exercicio 5 ---------------------------------------------------------------------

// Você vai criar um programa que armazena as notas de vários alunos em diferentes disciplinas. O programa deve calcular a média de cada aluno e determinar quais alunos têm médias acima de 7.0 (aprovados) e quais têm médias abaixo de 7.0 (reprovados). O programa deve usar foreach para iterar sobre as coleções de alunos e suas notas.

// Especificações:

// - Armazene as notas de 3 disciplinas para cada aluno.
// - Calcule a média de cada aluno.
// - Exiba a média e o status (aprovado/reprovado) de cada aluno.
// - Use foreach para iterar sobre os alunos e as disciplinas.

using System.Runtime;

string[] alunos = ["gabriel", "guilherme", "matheus"];
string[] disciplinas = ["Portugues", "Matematica", "Biologia"];
int[] notas0 = [7,8,9];
int[] notas1 = [7,7,6];
int[] notas2 = [5,8,3];
int alunoIndex = 0;

foreach (string aluno in alunos)
{
        Console.WriteLine($"");
        Console.WriteLine($"Boletim do {aluno}: " );
        Console.WriteLine($"");
        
        int disciplinaNotaIndex = 0;
        int soma = 0;
        int[] notas = [];
        int aprovado = 0;

    foreach (string disciplina in disciplinas)
    {
        
            notas = alunoIndex == 0 ? notas0 : alunoIndex == 1 ? notas1 : notas2;
           Console.WriteLine($"{disciplina} nota: {notas[disciplinaNotaIndex]}");

         soma = soma + notas[disciplinaNotaIndex];
         disciplinaNotaIndex++;
         

    }
        float media = (float)soma / (float)disciplinas.Length;
        alunoIndex++;

    Console.WriteLine($"Nota final: {soma} {(float)media}");
    Console.WriteLine($"");
    
}