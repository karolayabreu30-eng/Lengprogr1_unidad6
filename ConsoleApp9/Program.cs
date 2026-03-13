var gastos = new Dictionary<string, double>
{
    { "Internet", 40.0 },
    { "Luz", 65.5 },
    { "Agua", 20.0 },
    { "Gas", 30.0 }
};

double total = 0;
foreach (var monto in gastos.Values)
{
    total += monto;
}

Console.WriteLine($"La suma total de gastos es: ${total}");
