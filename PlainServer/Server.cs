using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlainServer
{
    class Server
    {
        public void start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 10001);
            server.Start();
            while (true)
            {
                TcpClient socket = server.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient tempsocket = socket;
                    DoClient(tempsocket);
                    socket.Close();
                });
            }

        }

        public void DoClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            string str = sr.ReadLine();


            sw.WriteLine(str);
            Console.WriteLine(str);


            sw.Flush();
        }
    }
}

