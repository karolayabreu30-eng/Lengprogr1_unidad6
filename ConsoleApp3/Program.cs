var estudiantes = new Dictionary<string, int>
{
    { "Ana", 85 },
    { "Luis", 90 },
    { "Marta", 78 }
};

estudiantes["Marta"] = 95; // Modificación
Console.WriteLine($"Nueva nota de Marta: {estudiantes["Marta"]}");