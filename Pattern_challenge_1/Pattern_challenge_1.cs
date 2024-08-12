for (int i = 0; i <= 4; i++)
{
    int j = 0;
    while (j <= 4)
    {
        int k = 0;
        while (k <= 4)
        {
            if (i == k || i + k == 4)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write(" ");
            }
            k++;
        }
        j++;
    }
    Console.WriteLine();
}
