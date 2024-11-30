

using CacularSalario.Class;
using CacularSalario.Db;
using CacularSalario.Exception;

internal class Program
{
    static StudentDb db = new StudentDb();

    private static void Main(string[] args)
    {
        //CalcularSalario();
        //MayorDeDosNumeros();

        CaptuarInfoStudent();
        Console.WriteLine("-----------------------Estudiantes agregados-------------------");
        ImprimirEstudiantes();
       

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

        string message = (num1 > num2) ? $"El mayor es: {num1}" : $"El mayor es: {num2}";

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
    public static void CaptuarInfoStudent()
    {
        int cantidad = 0;
        Student student;
        string line = string.Empty;
        try
        {

            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i <= cantidad)
            {
                student = new Student();
                student.Id = i;

                Console.WriteLine("Ingrese el nombre: ");
                student.FirstName = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido: ");
                student.LastName = Console.ReadLine();

                Console.WriteLine("Ingrese el correo: ");
                student.Email = Console.ReadLine();

                Console.WriteLine("Ingrese el telfono: ");
                student.Phone = Console.ReadLine();

                Console.WriteLine("Ingrese el direccion: ");
                student.Address = Console.ReadLine();

                Console.WriteLine("Ingrese la fecha inscripcion: ");
                student.EnrollmentDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Ingrese el curso: ");
                student.Curso = Console.ReadLine();

                db.SaveStudent(student);
                i++;
                Console.Clear();
            }
        }
        catch (StudentException sex)
        {
            Console.WriteLine ($"Error validando el estudiante: {sex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en el sistema: {ex.Message}");
        }

    }

    public static void ImprimirEstudiantes()
    {
        var estudiantes = db.GetStudents();

        foreach (var estudiante in estudiantes)
        {
            string nombreCompleto = string.Concat(estudiante.FirstName, " ", estudiante.LastName);

            Console.WriteLine($"Id: {estudiante.Id} ");
            Console.WriteLine($"Nombre: {nombreCompleto} ");
            Console.WriteLine($"Curso: {estudiante.Curso} ");
            Console.WriteLine($"Fecha inscripcion: {estudiante.EnrollmentDate} ");
        }
    }
}