using System;


namespace MyFirstExpMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            Console.WriteLine("Server is Running behind");
            Console.WriteLine(msg.ToString());
        }
    }
}