var ciudades = new Dictionary<string, int> { { "Londres", 2000 }, { "París", 2024 }, { "Roma", 1998 } };

foreach (KeyValuePair<string, int> par in ciudades)
{
    Console.WriteLine($"Ciudad: {par.Key}, Año de visita: {par.Value}");
}
