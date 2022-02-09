using System;
using Newtonsoft.Json;


namespace MyFirstExpMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("BT", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);

            Message deserialize = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserialize);

            /*{ "UserName":"BT","MessageText":"Privet","TimeStamp":"2022-02-09T13:49:15.5627239Z"}
            BT < 09.02.2022 13:49:15 >: Privet*/
        }
    }
}