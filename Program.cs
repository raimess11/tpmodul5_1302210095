using tpmodul5_1302210095;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Generic!");

        HeloGeneric G = new HeloGeneric();
        G.SapaUser<string>("Raimessnyazeta");

        DataGeneric<String> data = new DataGeneric<String>("1302210095");
        data.PrintData();
    }

    class HeloGeneric
    {
        public void SapaUser<type>(type x) 
        {
            Console.WriteLine("Halo User "+(dynamic) x );
        }
    }
}