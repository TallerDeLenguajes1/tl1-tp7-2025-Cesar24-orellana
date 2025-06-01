using Personal;
using static Personal.Empleado;

Empleado[] empleados = new Empleado[3];
empleados[0] = new Empleado("Jorge", "Acosta", new DateTime(1985, 4, 19), 'C', new DateTime(2010, 2, 20), 650000, Cargos.Auxiliar);
empleados[1] = new Empleado("Juliana", "Ruiz", new DateTime(1997, 6, 10), 'S', new DateTime(2020, 4, 18), 650000, Cargos.Ingeniero);
empleados[2] = new Empleado("Martin", "Villagra", new DateTime(1991, 7, 30), 'c', new DateTime(2015, 1, 25), 650000, Cargos.Especialista);

double SalarioTotal = 0;
Empleado ProximoJubilarse = empleados[0];
Console.WriteLine("Informacion de Empleados:");
foreach (var empl in empleados)
{
    empl.MostrarDetalles();
    SalarioTotal += empl.Salario;

    if (empl.AniosJubilarse < ProximoJubilarse.AniosJubilarse) ProximoJubilarse = empl;
}
Console.WriteLine($"\nTotal en Salarios: ${SalarioTotal}");
Console.WriteLine("Empleado mas proximo a jubilarse");
ProximoJubilarse.MostrarDetalles();

//empleados.Add(new Empleado("Jorge", "Acosta", DateTime(24,04,1985), "S", DateTime(23,02,2020), 5435884, Cargos.Especialista))
//empleado.Empleado("Jorge", "Acosta", 24.04.1985, "S", 23.02.2020, 5435884, 1);
