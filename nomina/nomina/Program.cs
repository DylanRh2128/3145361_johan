double valorHora = 0, respuesta = 0, totalHoras = 0, horas = 0, dominicales = 0, totalHorasDominicales = 0, horaDominical = 0, totalPago = 0, total = 0, salario = 1500000;
string nombre, si;
bool valido, validoDominicales;

valorHora = salario / 160;
horaDominical = valorHora * 2;

Console.WriteLine("Ingresa el nombre: ");
nombre = Console.ReadLine();

Console.WriteLine("Ingrese el total de horas trabajadas: ");
string entrada = Console.ReadLine();
valido = double.TryParse(entrada, out horas);

if (!valido || horas < 0)
{
    Console.WriteLine("Por favor ingrese un número válido y positivo.");
}
else
{
    Console.WriteLine("¿Trabajó días dominicales? (si/no): ");
    si = Console.ReadLine();

    if (si.Length > 2)
    {
        Console.WriteLine("El dato ingresado no es válido.");
    }
    else
    {
        totalHoras = valorHora * horas;

        if (si.ToLower() == "si")
        {
            Console.WriteLine("Ingrese cuántas horas dominicales trabajó: ");
            string entradaDominicales = Console.ReadLine();
            validoDominicales = double.TryParse(entradaDominicales, out dominicales);

            if (!validoDominicales || dominicales < 0)
            {
                Console.WriteLine("Ingrese un dato válido.");
            }
            else
            {
                totalPago = (valorHora * horas) + (dominicales * horaDominical);
                totalHorasDominicales = horaDominical * dominicales;

                if (totalPago < salario)
                {
                    totalPago = salario;
                }

                Console.WriteLine($"\nResumen de la nómina de {nombre}");
                Console.WriteLine($"Horas normales: {horas} x {valorHora} = {totalHoras}");
                Console.WriteLine($"Horas dominicales: {dominicales} x {horaDominical} = {totalHorasDominicales}");
                Console.WriteLine($"Total a pagar: {totalPago}");
            }
        }
        else if (si.ToLower() == "no")
        {
            respuesta = 0;
            totalPago = totalHoras;

            Console.WriteLine($"\nResumen de la nómina de {nombre}");
            Console.WriteLine($"Horas normales: {horas} x {valorHora} = {totalHoras}");
            Console.WriteLine($"Horas dominicales: {respuesta} x {horaDominical} = {respuesta}");
            Console.WriteLine($"Total a pagar: {totalPago}");
        }
        else
        {
            Console.WriteLine("Respuesta inválida. Solo se permite 'si' o 'no'.");
        }
    }
}