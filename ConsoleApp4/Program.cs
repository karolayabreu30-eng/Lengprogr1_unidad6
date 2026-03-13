var agenda = new Dictionary<string, string>
{
    { "Trabajo", "555-0101" },
    { "Casa", "555-0202" },
    { "Celular", "555-0303" }
};

agenda.Remove("Casa");
Console.WriteLine($"Elementos restantes: {agenda.Count}");