using System;
class codigoerro {
public static void Executar() {
string nome;
int nota = 0;
int aprov = 0, reprov = 0;
for(int i = 1; i <= 5; i++) {
Console.Write("Digite o nome do aluno: ");
nome = Console.ReadLine();
Console.Write("Digite a nota: ");
nota = int.Parse(Console.ReadLine());
if(nota >= 60)
aprov++;
if(nota < 60)
reprov++;
}

Console.Write($"{aprov} alunos foram aprovados e {reprov} foram reprovados.");
}
}