using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpClient _tcpClient;
        private Stream _stream;

        private void Connect()
        {
            var ip = IPAddress.Parse(ipAddress);

            _tcpClient = new TcpClient(ip,port);
            
            Console.WriteLine("Connected to server");
            }
        public void Run()
        {
            Connect();
            _stream.Start();
        }
        public void Send(string message)
        {
            var data = Encoding.ASCII.GetBytes(message);
            _stream.Write(data, 0, data.Length);
            Console.WriteLine("Message sent");
        }
        public void Receive()
        {
            var response = new byte[1024];
            var read = _stream.Read(response, 0, response.Length);
            Console.WriteLine("message received");
        }
        public void disconnect()
        {
            _stream.Close();
            _tcpClient.Close();
            Console.WriteLine("Disconnected");
        }
        
    }
}
