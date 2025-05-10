Console.Clear();
// V = valor
int v1,v2,v3;
Console.WriteLine("--- Maior De Três ---\n");

Console.Write("Digite o primeiro número...:");
v1 =  Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número....:");
v2 =  Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro número...:");
v3 =  Convert.ToInt32(Console.ReadLine());

int maiorValor;

if (v1 > v2)
{
 if (v1 > v3)
 {
     maiorValor = v1;
}
 else
 {
     maiorValor = v3;
 }
 }
 else
 {
 if (v2 > v3)
 {
        maiorValor = v2;
    }
    else
    {
        maiorValor = v3;
    }
 }
Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine($"Maior Valor: {maiorValor}\n");

Console.ResetColor();