using System;

namespace PlainClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client theOneClient = new Client();
            theOneClient.start();
        }
    }
}
