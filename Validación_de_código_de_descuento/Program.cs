namespace Validación_de_código_de_descuento
{
    public class Program
    {
        static void Main(string[] args)
        {
                // Arreglo con los códigos de descuento válidos, ordenados de menor a mayor
                int[] codigosDescuento = { 1001, 1020, 1045, 1070, 1100, 1150, 1200, 1250 };

                // Se pide al usuario que ingrese el código que desea validar
                Console.Write("Ingrese el código de descuento: ");
                int codigoIngresado = int.Parse(Console.ReadLine());

                // Variables para los límites del arreglo
                int inicio = 0;
                int fin = codigosDescuento.Length - 1;
                bool encontrado = false; // Para saber si el código fue encontrado

                // Ciclo que se repite mientras el rango de búsqueda sea válido
                while (inicio <= fin)
                {
                    int medio = (inicio + fin) / 2; // Se calcula el punto medio

                    // Se compara el valor del medio con el código ingresado
                    if (codigosDescuento[medio] == codigoIngresado)
                    {
                        encontrado = true; // Se encontró el código
                        Console.WriteLine($"Código válido. El código {codigoIngresado} existe en la posición {medio}.");
                        break; // Se detiene el ciclo
                    }
                    // Si el código buscado es menor, se busca en la mitad izquierda
                    else if (codigoIngresado < codigosDescuento[medio])
                    {
                        fin = medio - 1;
                    }
                    // Si el código buscado es mayor, se busca en la mitad derecha
                    else
                    {
                        inicio = medio + 1;
                    }
                }

                // Si no se encontró el código, se muestra un mensaje indicando que no es válido
                if (!encontrado)
                {
                    Console.WriteLine($"El código {codigoIngresado} no es válido o no existe.");
                }

                // Espera que el usuario presione una tecla antes de cerrar la consola
                Console.ReadKey();
            }
        }
    }