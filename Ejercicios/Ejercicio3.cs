internal class Program
{
    //Ejercicio 3

    public static void Mostrar<T>(T[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    float[,] matrizFloat = new float[,]
    { 
        {3, 4, 5},
        {2.4F, 4.4F, 5}
    };
    dynamic[,] matrizDynamic = new dynamic[,]
    {
        {"SAL", "AGUA", "AZUCAR" , "VINO"},
        {"COLA", "CAFE", "ZUMO", "LECHE"}
    };

    Action<float[,]> accion = Mostrar;
    accion(matrizFloat);
    Action<dynamic[,]> accion2 = Mostrar;
    accion2(matrizDynamic);
}