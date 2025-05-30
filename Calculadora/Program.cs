using EspacioCalculadora;

Calculadora calc1 = new Calculadora();
/* Calculadora calc2 = new Calculadora();
Calculadora calc3 = new Calculadora();
Calculadora calc4 = new Calculadora(); */

int opcion;
string StringOpcion;
double num = 0;
string StringNum = "";
Console.WriteLine("-- Calculadora --");
do
{
    Console.WriteLine("Que operacion desea Realizar");
    Console.WriteLine("1. Sumar\n2. Resta\n3. Multiplicacion\n4. Dividir\n0. Salir");
    StringOpcion = Console.ReadLine();
    bool Resultado = int.TryParse(StringOpcion, out opcion);
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Escriba un numero para sumar: ");
            StringNum = Console.ReadLine();
            bool ResultNum = double.TryParse(StringNum, out num);
            calc1.Sumar(num);
            Console.WriteLine($"El numero es: {calc1.Resultado}");
        break;
        case 2:
            Console.WriteLine("Escriba un numero para Restar: ");
            StringNum = Console.ReadLine();
            bool ResultNum2 = double.TryParse(StringNum, out num);
            calc1.Resta(num);
            Console.WriteLine($"El numero es: {calc1.Resultado}");
        break;
        case 3:
            Console.WriteLine("Escriba un numero para Multiplicar: ");
            StringNum = Console.ReadLine();
            bool ResultNum3 = double.TryParse(StringNum, out num);
            calc1.Multiplicacion(num);
            Console.WriteLine($"El numero es: {calc1.Resultado}");
        break;
        case 4:
            Console.WriteLine("Escriba un numero para Dividir: ");
            StringNum = Console.ReadLine();
            bool ResultNum4 = double.TryParse(StringNum, out num);
            calc1.Dividir(num);
            Console.WriteLine($"El numero es: {calc1.Resultado}");
        break;
        default:
            opcion = 0;
            calc1.limpiar();
        break;
    }
} while (opcion != 0);



// Prueba de codigo
/* calc2.Resta(5);
Console.WriteLine("El valor de resta es: " + calc2.Resultado);
calc3.Multiplicacion(5);
Console.WriteLine("El valor de producto es: " + calc3.Resultado);
calc4.Dividir(3);
Console.WriteLine("El valor de divicion es: " + calc4.Resultado);

calc2.limpiar();
calc3.limpiar();
calc4.limpiar(); */