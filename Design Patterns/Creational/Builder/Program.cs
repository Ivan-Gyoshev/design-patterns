using System;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            client.Execute();
        }
    }
}