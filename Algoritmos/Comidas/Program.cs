bool continuar = true;
int j;
List<string> seleccion = new List<string>();
string[] desayuno = {"Cafe con Leche","Cafe negro","Calentado","Empanada","Pandebono",
    "Hamburguesa","Cuca Rosada" };
string[] almuerzo = {"Arroz","Pastas","Calentado","Bandeja paisa","Carne a la llanera",
    "Lechona","Sopa","Mondogo","Chorizo con chimichurry","Lazaña","Hamburguesas","Cazuela de mariscos","Tacos",
    "Costillas","Jugo","Gaseosa","Limonada"};
string[] cena = {"Hamburguesa","Pizaa","Sushi","Pastas","Picada","PanChocha","Salchipapas","Punta de anca",
    "Michelada","Gaseosa"};
while(continuar)
{
    Console.WriteLine("Eliga la opcion que desee...");
    Console.WriteLine("1.DESAYUNO");
    Console.WriteLine("2.ALMUERZO");
    Console.WriteLine("3.CENA");
    Console.WriteLine("4.SALIR");
    string opcionComida = Console.ReadLine();
    int opcion;
    if (!int.TryParse(opcionComida, out opcion))
    {
        Console.WriteLine("Por favor, ingrese un número válido.");
        continue;
    }
    switch (opcion)
    {
        case 1:
            for (j = 0; j < desayuno.Length; j++)
            {
                Console.WriteLine($"¿Quieres {desayuno[j]}? (si/no): ");
                string respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    seleccion.Add(desayuno[j]);
                }
            }
            break;
        case 2:
            for (j = 0; j < almuerzo.Length; j++)
            {
                Console.WriteLine($"¿Quieres {almuerzo[j]}? (si/no): ");
                string respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    seleccion.Add(almuerzo[j]);
                }
            }
            break;
        case 3:
            for (j = 0; j < cena.Length; j++)
            {
                Console.WriteLine($"¿Quieres {cena[j]}? (si/no): ");
                string respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    seleccion.Add(cena[j]);
                }
            }
            break;
        case 4:
            continuar = false;
            break;
    }
    Console.WriteLine("Los productos que elegiste son: ");
    for (j = 0; j < seleccion.Count; j++)
    {
        Console.WriteLine(seleccion[j]);
    }
}
