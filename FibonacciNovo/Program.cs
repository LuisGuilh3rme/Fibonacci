int ant = 1, prox = 0;

Console.WriteLine("Digite a quantidade de posições");
int quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidade; i++)
{
    Console.Write("{0} ", prox + ant);
    prox = ant + prox;
    ant = prox - ant;
}