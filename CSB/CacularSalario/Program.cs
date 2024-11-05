

internal class Program
{

    private static void Main(string[] args)
    {
        //CalcularSalario();
        MayorDeDosNumeros();
    }

    /// <summary>
    /// Calcular el salario de un empleado.
    /// </summary>
    private static void CalcularSalario()
    {
        decimal sueldo = 0;
        decimal impuesto = 0;
        decimal itbis = 0.20m;
        decimal totalAPagar = 0;
        string? valor = string.Empty;
        decimal sueldoBase = 5000;

        // Pedimos el sueldo

        Console.WriteLine("Ingrese el sueldo del empleado.");
        valor = Console.ReadLine();

        if (string.IsNullOrEmpty(valor))
        {
            Console.WriteLine($"El sueldo no puede ser nulo.");
            return;
        }


        if (!decimal.TryParse(valor, out sueldo))
        {
            Console.WriteLine($"El sueldo {valor} no es válido.");
            return;
        }

        if (sueldo < 0)
        {
            Console.WriteLine($"El sueldo no puede ser negativo.");
            return;
        }

        if (sueldo > sueldoBase)
        {
            impuesto = (sueldo * itbis);
            totalAPagar = (sueldo - impuesto);
            Console.WriteLine($"impuesto: {impuesto} y sueldo después de impuesto: {totalAPagar}");
        }
        else
        {
            Console.WriteLine($"se le paga su salario completo.");
        }

    }

    public static void CalcularSumaProducto()
    {
        // Declarar sus variables de entrada //
        int num1 = 0;
        int num2 = 0;
        int suma = 0;
        int producto = 0;


        //Pedir numeros por teclados
        Console.WriteLine("Escriba el valor del num 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        //int.Parse(Console.ReadLine());

        Console.WriteLine("Escriba el valor del num 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        //Calcular la suma y el producto.
        suma = (num1 + num2);
        producto = (num1 * num2);


        // Imprimir valores //
        Console.WriteLine($"La suma es: {suma} y el producto es: {producto}");
    }

    public static void MayorDeDosNumeros()
    {
        // Declarar sus variables de entrada //
        int num1 = 0;
        int num2 = 0;
        string valor = string.Empty;

        //Pedir numeros por teclados
        Console.WriteLine("Escriba el valor del num 1: ");
        valor = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(valor))
        {
            Console.WriteLine("El num1 es requerido.");
            return;
        }

        if (!int.TryParse(valor, out num1))
        {
            Console.WriteLine("El num1 es inválido.");
            return;
        }

        //Pedir numeros por teclados
        Console.WriteLine("Escriba el valor del num 2: ");
        valor = Console.ReadLine();


        if (string.IsNullOrWhiteSpace(valor))
        {
            Console.WriteLine("El num2 es requerido.");
            return;
        }

        if (!int.TryParse(valor, out num2))
        {
            Console.WriteLine("El num2 es inválido.");
            return;
        }

        string message = (num1 > num2) ? $"El mayor es: { num1 }" : $"El mayor es: { num2 }";

        Console.WriteLine(message);

        //if (num1 > num2)
        //{
        //    Console.WriteLine($"El mayor es: {num1}");
        //}
        //else
        //{
        //    Console.WriteLine($"El mayor es: {num2}");
        //}


    }
}