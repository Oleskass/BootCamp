namespace Server 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это наш сервер");
            //запустим наш сервер
            OurServer server = new OurServer();
        }
    }
}