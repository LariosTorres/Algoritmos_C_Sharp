Console.WriteLine("Ingresa un numero");
int numero_primo = int.Parse(Console.ReadLine());

Console.Write("Los numeros primos de " + numero_primo + " son:");

for (int i = 2; i <= numero_primo; i++)
{
    int num_divisiones = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            num_divisiones++;
        }
    }
    if (num_divisiones == 2)
    {

        Console.Write(" " + i);
    }
}
