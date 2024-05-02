static void nivel_basico(){
        Console.WriteLine("Escribe algo");
        string texto = Console.ReadLine();
        string minuscula = texto.ToLower();
        string resultado = minuscula.Replace('a', '4').Replace('e', '3').Replace('i', '1').Replace('o', '0').Replace("u", "(_)");
        Console.WriteLine(resultado);
}

static void nivel_intermedio()
{
    var cities = new Dictionary<string, string>(){
        {"a", "4"},{"b", "I3"},{"c", "["},{"d", "|)"},{"e", "3"},{"f", "ph"},{"g", "6"}
        ,{"h", "#"},{"i", "1"},{"j", "]"},{"k", "|<"},{"l", "1"},{"m", "/\\/\\"},{"n", "|\\|"},{"o", "0"}
        ,{"p", "|>"},{"q", "0_"},{"r", "I2"},{"s", "5"},{"t", "7"},{"u", "(_)"},{"v", "\\/"},{"w", "\\/\\/"},{"x", "><"}
        ,{"y", "j"},{"z", "2"}
    };
    Console.WriteLine("Ingresa el texto que quiers codificar:");
    string palabra = Console.ReadLine();
        string minuscula = palabra.ToLower();
        foreach (var element in minuscula)
        {
            if (cities.ContainsKey(Convert.ToString(element)))
        {
                Console.Write(cities[Convert.ToString(element)]);
            }
            else
            {
                Console.Write(element);
            }
        }
}

Console.WriteLine("¿Que nivel quieres probar?\n1.- Nivel basico\n2.- Nivel intermedio");
int nivel = Convert.ToInt32(Console.ReadLine());
if (nivel == 1)
{
    nivel_basico();
}
else if (nivel == 2)
{
    nivel_intermedio();
}
else
{
    Console.WriteLine("No existe esa opcion");
}
