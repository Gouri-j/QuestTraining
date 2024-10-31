using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public class ClientBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpClient _tcpClient;
        private NetworkStream _stream;

        private void Connect()
        {
            var ip = IPAddress.Parse(ipAddress);
            _tcpClient = new TcpClient();
            _tcpClient.Connect(ip, port);
            _stream = _tcpClient.GetStream();
            Console.WriteLine("Connected to server");
        }

        public void Run(Action onConnect)
        {
            Connect();
            onConnect?.Invoke();
        }

        public void Send(string message)
        {
            if (_stream == null)
            {
                Console.WriteLine("Stream is not initialized.");
                return;
            }

            var data = Encoding.ASCII.GetBytes(message);
            _stream.Write(data, 0, data.Length);
            Console.WriteLine("Message sent");
        }

        public void Receive()
        {
            if (_stream == null)
            {
                Console.WriteLine("Stream is not initialized.");
                return;
            }

            var response = new byte[1024];
            var read = _stream.Read(response, 0, response.Length);
            var receivedMessage = Encoding.ASCII.GetString(response, 0, read);
            Console.WriteLine("Message received: " + receivedMessage);
        }

        public void Disconnect()
        {
            _stream?.Close();
            _tcpClient?.Close();
            Console.WriteLine("Disconnected");
        }
    }
}