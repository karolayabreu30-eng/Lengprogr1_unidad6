var colores = new Dictionary<string, string> { { "R", "Rojo" }, { "V", "Verde" }, { "A", "Azul" }, { "N", "Negro" }, { "B", "Blanco" } };

foreach (var valor in colores.Values)
{
    Console.WriteLine($"Color: {valor}");
}