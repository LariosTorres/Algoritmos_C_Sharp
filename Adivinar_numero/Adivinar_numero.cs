namespace Adivinar_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adivina el numero random (Es un numero entre el numero 1 y 100)");
            Random random = new Random();
            int numero_adivinar = random.Next(1, 100);
            int respuesta = 0;

            while (respuesta != numero_adivinar)
            {
                Console.WriteLine("Adivina el numero");
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta == numero_adivinar) { Console.Write("Correcto"); break; }
                else if (respuesta < numero_adivinar) { Console.WriteLine("El numero es mayor"); }
                else { Console.WriteLine("El numero es menor"); }
            }
        }
    }
}
