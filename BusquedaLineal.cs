namespace Busquedas;

public class BusquedaLineal
{
    public static int Buscar(int[] arreglo, int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == valor)
                return i;
        }
        return -1;
    }
}
