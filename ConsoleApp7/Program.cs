var stock = new Dictionary<string, int> { { "Laptop", 5 }, { "Mouse", 10 }, { "Teclado", 7 } };

string buscar = "Mouse";
if (stock.ContainsKey(buscar))
{
    Console.WriteLine($"Sí, tenemos {buscar} en inventario.");
}