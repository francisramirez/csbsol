using Bucles.whiles;

namespace Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //Imprimir1al100();
            // //CalcularPromedio();
            //// CalcularNotas();

            // CalcularNumerosPositivos numerosPositivos = new CalcularNumerosPositivos();

            // //numerosPositivos.ImprimirNumerosPositivos();


            // numerosPositivos.CalcularPromedio();

            int[] myArray = { 1, 2, 3, 4, 5 };

            int lenth = myArray.Length;

            int[] reverse = new int[lenth];


            //for (int i = 0; i < lenth; i++)
            //{
            //    reverse[lenth - i - 1] = myArray[i];
            //}

            //foreach (int ivalue in reverse)
            //{
            //    Console.WriteLine(ivalue);
            //}



        }

        static void Imprimir1al100()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i}");
            }
        }
        static void CalcularPromedio()
        {
            int suma = 0;
            int promedio = 0;
            int valorIngresado = 0;
            int cantidadElementos = 0;
            string valor = string.Empty;

            Console.WriteLine("ingrese la cantidad de elmentos");
            cantidadElementos = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= cantidadElementos; i++)
            {
                Console.WriteLine($"Ingrese el valor: {i}");
                valor = Console.ReadLine();

                if (int.TryParse(valor, out valorIngresado))
                {
                    suma = suma + valorIngresado;
                }
                else
                {
                    Console.WriteLine("El valor ingresado es inválido");
                }
            }

            promedio = (suma / cantidadElementos);

            Console.WriteLine($"La suma es: {suma} y el promedio es {promedio}");
        }

        static void CalcularNotas()
        {
            int aprobados = 0;
            int reprobados = 0;
            int cantidadNota = 0;
            int nota = 0;
            string valor = string.Empty;


            Console.WriteLine("Ingrese la cantidad de notas: ");
            valor = Console.ReadLine();

            try
            {
                if (int.TryParse(valor, out cantidadNota))
                {
                    for (int i = 1; i <= cantidadNota; i++)
                    {
                        Console.WriteLine($"Ingrese la nota: {i}");
                        valor = Console.ReadLine();

                        if (int.TryParse(valor, out nota))
                        {
                            if (nota >= 7)
                            {
                                aprobados++;
                                // aprobados = aprobados + 1;

                            }
                            else
                            {
                                reprobados++;
                                //reprobados = reprobados + 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("El formato de dato de la nota es inválido.");
                            continue;
                        }


                    }


                    // Imprimir la cantidades de aprobados o reprobados //

                    Console.WriteLine($"Aprobados: {aprobados} y Reprobados: {reprobados}");
                }
                else
                {
                    Console.WriteLine("El formato de la cantidad de nota ingresada es inválido.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error calculando las notas.  { ex.Message }");
            }


        }
    }
}
