using System.Net.Sockets;
using System.Text;

namespace Client
{
    class OurClient
    {
        private TcpClient _client; //в классе переменная _client - это наш клиент
        private StreamWriter _sWriter; //поток, с помощью него будем отправлять данные с клиента на сервер

        public OurClient() //хотим подкючаться к классу по ipAdress и portNum
        {
            _client = new TcpClient("127.0.0.1", 5555); //клиент будет работать с этим адресом по вот такому порту
            _sWriter = new StreamWriter(_client.GetStream(), Encoding.UTF8); //нужно вытащить из нашего клиента поток и тогда мы можем записывать по нему данные

            HandleCommunication(); //как только мы установили соединение с сервером, мы сразу должны это соединение держать
        }

        //для того чтобы наше подключение было постоянным:
        void HandleCommunication()
        {
            while (true) //это бесконечный цикл, чтобы постоянно держать соединение с сервером
            {
                Console.Write("> "); //для красоты
                string? message = Console.ReadLine();
                _sWriter.WriteLine(message); //отправка сообщения серверу (от клиента), для этого используем наш поток, который мы создали
                _sWriter.Flush(); //нужно сообщение отправить НЕМЕДЛЕННО
            }
        }
    }
}