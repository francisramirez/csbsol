

namespace Bucles.whiles
{
    public class CalcularNumerosPositivos
    {
        public void ImprimirNumerosPositivos()
        {
            int n = 0;
            int index = 1;
            string value = string.Empty;

            try
            {
                Console.WriteLine("Digite la cantidad de numeros que desea calcular. ");
                value = Console.ReadLine();

                if (!int.TryParse(value, out n))
                {
                    Console.WriteLine("la cantidad de numeros es requerida.");
                    return;
                }

                if (n < 0)
                {
                    Console.WriteLine("Debe ingresar numeros positivos.");
                    return;
                }

                while (index <= n)
                {
                    //Imprimir el valor del indices //
                    Console.WriteLine(index);

                    index++;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error calculando el numero positivo: {ex.Message}");
            }
        }

        public void CalcularPromedio()
        {
            int index = 1;
            int suma = 0;
            int n = 0;
            int valorIntroduccido = 0;
            decimal promedio = 0;
            string value = string.Empty;

            try
            {
                Console.WriteLine("Ingrese la cantidad de numeros para el calculo del promedio");
                value = Console.ReadLine();

                if (!int.TryParse(value, out n))
                {
                    Console.WriteLine("la cantidad de numeros es requerida.");
                    return;
                }

                if (n < 0)
                {
                    Console.WriteLine("Debe ingresar numeros positivos.");
                    return;
                }

                while (index <= n) 
                {
                    Console.WriteLine($"Ingrese el valor: { index } ");
                    value = Console.ReadLine();

                    if (!int.TryParse(value, out valorIntroduccido))
                    {
                        Console.WriteLine("El valor es requerid0.");
                        return;
                    }

                    if (n < 0)
                    {
                        Console.WriteLine("El valor debe ser un numero positivo.");
                        return;
                    }

                    suma = (suma + valorIntroduccido);
                    index++;
                }

                promedio = (suma / n);

                Console.WriteLine($"La suma es: {suma} y el promedio es: {promedio}");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error calculando el promedio. {ex.Message}");
            }

        }

    }
}
