// Exercício do site URI "Experiências"


int N = int.Parse(Console.ReadLine());
int R = 0;
int S = 0;
int C = 0;
int Cont = 0;
int Quant = 0;
double MediaRatos = 0;
double MediaCoelhos = 0;
double MediaSapos = 0;

for (int i = 1; i <= N; i ++)
{
    string [] Cobaia = Console.ReadLine().Split(' ');
    Quant = int.Parse(Cobaia[0]);
    char Animal = char.Parse(Cobaia[1]);

    Cont = Cont + Quant;

    if (Animal == 'R')
    {
        R = R + Quant;
    }
    if (Animal == 'C')
    {
        C = C + Quant;
    }
    if (Animal == 'S')
    {
        S = S + Quant;
    }
}
Console.WriteLine("Total: " + Cont + " cobaias");
Console.WriteLine("Total de coelhos: " + C);
Console.WriteLine("Total de ratos: " + R);
Console.WriteLine("Total de sapos: " + S);

MediaCoelhos = C * 100.00 / Cont;
MediaRatos = R * 100.00 / Cont;
MediaSapos = S * 100.00 / Cont;

Console.WriteLine("Percentual de coelhos: " + MediaCoelhos.ToString("F2") + " %");
Console.WriteLine("Percentual de ratos: " + MediaRatos.ToString("F2") + " %");
Console.WriteLine("Percentual de sapos: " + MediaSapos.ToString("F2") + " %");