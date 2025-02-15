int num1, num2;
int opcion = 4;
Console.WriteLine("Ingrese el primer numero: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Que deseea hacer con eso dos nuemros");

Console.WriteLine("opciones: ");
Console.WriteLine("Presione (1) para Sumar ");
Console.WriteLine("Presione (2) para Sumar ");
Console.WriteLine("Presione (3) para Sumar ");
opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine($"La suma es: {num1 + num2}");
        break;
    case 2:
        Console.WriteLine($"La Resta es:  { num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"la multiplicacion es :{num1 * num2}");
        break;
    case 4:
        Console.WriteLine($"La suma es: {num1 / num2}");
        break;

}    