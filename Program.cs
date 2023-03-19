internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Generic!");

        HeloGeneric G = new HeloGeneric();
        G.SapaUser<string>("Raimessnyazeta");
    }

    class HeloGeneric
    {
        public void SapaUser<type>(type x) 
        {
            Console.WriteLine("Halo User "+(dynamic) x );
        }
    }
}