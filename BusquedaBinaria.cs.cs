namespace Busquedas;

public class BusquedaBinaria
{
    public static int Buscar(int[] arreglo, int valor)
    {
        int izquierda = 0, derecha = arreglo.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = (izquierda + derecha) / 2;

            if (arreglo[medio] == valor)
                return medio;
            else if (valor < arreglo[medio])
                derecha = medio - 1;
            else
                izquierda = medio + 1;
        }

        return -1;
    }

    // Método Main como punto de entrada para la ejecución
    public static void Main()
    {
        int[] arreglo = { 1, 3, 5, 7, 9 };
        int resultado = Buscar(arreglo, 7);
        Console.WriteLine("Índice encontrado: " + resultado);
    }
}
