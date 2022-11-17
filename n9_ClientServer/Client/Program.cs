namespace Client //пространство имён - позволяет использовать олни и те же перемнные в разных файлах
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это наш клиент");
            OurClient ourClient = new OurClient();
        }
    }
}
