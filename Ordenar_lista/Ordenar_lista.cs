List<int> numeros = [5, -20, 4, -8, -1, 7, 3, 1, 0, -1];
Console.Write("Los numeros de la lista son: ");
ordenado(numeros);
impresion(numeros);


static void ordenado(List<int> lista)
{
    int tamaño = lista.Count - 2;
    int detener_while = 7;


    while (detener_while >= 1)
    {
        int k = 1;
        for (int j = 0; j <= tamaño; j++)
        {
            if (lista[j] > lista[k])
            {
                Swap(lista, j, k);
                detener_while++;
            }
            else
            {
                detener_while--;
            }
            k++;
        }
    }
}


static void impresion(List<int> lista)
{
    foreach (int i in lista)
    {
        Console.Write($" {i}");
    }
}


static void Swap(List<int> lista, int numeroA, int numeroB)
{
    int temporal = lista[numeroA];
    lista[numeroA] = lista[numeroB];
    lista[numeroB] = temporal;
}
