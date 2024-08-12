static void escalera()
{
    Console.Write("Est programa es para imprimir una escalera\n");
    Console.WriteLine("Este programa muetra una escalera usando un caracter X\n¿Cuantos escalones quiere que tenga el programa?");

    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = n - 1; i >= 1; i--)
    {
        string a = "X";
        string repetir = new string(a[0], i);

        Console.WriteLine(repetir);
    }
}

static void escalera_invertida()
{
    Console.Write("Est programa es para imprimir una escalera invertida\n");
    Console.WriteLine("Este programa muetra una escalera usando un caracter X\n¿Cuantos escalones quiere que tenga el programa?");

    int n = Convert.ToInt32(Console.ReadLine());
    string espacio = " ";
    string espacio_suma = "";
    int m;
    for (int i =1; i <= n; i++)
    {
        m = i;
        Console.Write(espacio_suma);
        while(m != n)
        {
            Console.Write("X");
            m++;
        }
        Console.WriteLine();
        espacio_suma += espacio;
    }
}
static void piramide()
{
    Console.Write("Est programa es para imprimir una piramide\n");
    Console.WriteLine("Este programa muetra una escalera usando un caracter X\n¿Cuantos escalones quiere que tenga el programa?");

    int n = Convert.ToInt32(Console.ReadLine());
    int j = 1;

    for (int i = n - 1; i >= 1; i--)
    {
        string espacio = " ";
        string repetir = new string(espacio[0], i);
        string caracter = "X";
        string repetir2 = new string(caracter[0], j);
        Console.Write(repetir);
        Console.Write(repetir2);
        Console.WriteLine(repetir);

        j += 2;
    }
}
escalera();
escalera_invertida();
piramide();
