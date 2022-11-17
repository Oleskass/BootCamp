using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    class OurServer
    {
        //чтобы принимать сообщения от клиентов
        TcpListener _server;

        public OurServer()
        {
            _server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555); //парсим - из строки это превращается в айпи адрес (тип данных)
            _server.Start(); //запускаем сервер

            LoopClients();
        }

        void LoopClients() //ф-я чтобы ловить наших клиентов, её постоянно держим открытой
        {
            while (true)
            {
                TcpClient _client = _server.AcceptTcpClient(); //как только на сервер TcpListener прилетает клиент (подключение) у нас сразу создаётся клиент, кот.мы будет обрабатывать на сервере
                //неск.клиентов, при помощи потоков - Thread, каждого отдельного клиента кладём в отдельный тред
                Thread thread = new Thread(() => HandleClient(_client)); // в нашем потоке Thread будет выполняться функция HandleClient с клиентом client
                thread.Start(); //сразу запускаем данный поток

            }
        }
        void HandleClient(TcpClient _client) //держим соединение от клиента к серверу
        {
            StreamReader _sReader = new StreamReader(_client.GetStream(), Encoding.UTF8);//получаем поток от клиента

            while (true) //чтобы работать с одним клиентов бесконечно
            {
                string? message = _sReader.ReadLine(); //считали от клиента сообщение и получили на сервере
                Console.WriteLine($"Клиент написал - {message}"); //вывели сообщение клиента на экран
            }
        }
    }
}