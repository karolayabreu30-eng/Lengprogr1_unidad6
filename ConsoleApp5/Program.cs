var frutas = new Dictionary<int, string> { { 1, "Manzana" }, { 2, "Pera" }, { 3, "Uva" }, { 4, "Mango" }, { 5, "Piña" } };

foreach (var clave in frutas.Keys)
{
    Console.WriteLine($"ID: {clave}");
}