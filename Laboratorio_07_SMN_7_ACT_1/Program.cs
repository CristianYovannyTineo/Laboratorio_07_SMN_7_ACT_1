// See https://aka.ms/new-console-template for more information

Console.Write("Ingrese el valor de n: ");
int n = Convert.ToInt32(Console.ReadLine());
double suma = 0;
for (int i = 1; i <= n; i++)
{
    double termino = (16 - i) / (3.0 * i); 
    Console.WriteLine($"Resultado: {termino}");
    suma += termino;
}
Console.WriteLine("=================================");
Console.WriteLine("Total : "+ suma);