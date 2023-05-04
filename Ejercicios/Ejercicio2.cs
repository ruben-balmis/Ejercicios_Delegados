internal class Program
{
    //Ejercicio 2

    public delegate void Infinitivo();
    public static void Ser() => Console.WriteLine("To be");
    public static void Correr() => Console.WriteLine("Run");
    public static void Ver() => Console.WriteLine("See");
    public static void Pensar() => Console.WriteLine("Think");
    public static void Comer() => Console.WriteLine("Eat");

    private static void Main(string[] args)
    {
        Infinitivo infinitivo = Ser;
        infinitivo += Correr;
        infinitivo += Ver;
        infinitivo();
        Console.WriteLine("");
        infinitivo -= Ser;
        infinitivo -= Ver;
        infinitivo += Pensar;
        infinitivo += Comer;
        infinitivo();
    }   
}