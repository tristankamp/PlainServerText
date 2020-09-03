using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace PlainClient
{
    class Client
    {
        public void start()
        {
            Car Tesla = new Car("Cybertruck","grey", 123321);
            TcpClient socket = new TcpClient("localhost", 10001);
            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine(Tesla.ToString());
            sw.Flush();
            string line = sr.ReadLine();
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
