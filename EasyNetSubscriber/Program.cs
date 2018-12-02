﻿using System;
using EasyNetQ;
using EasyNetMessages;
namespace EasyNetSubscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost")){
                bus.Subscribe<TextMessage>("test", HandleTextMessage);
                Console.WriteLine("Listening for messages, Hit <return> to quit.");
                Console.ReadLine();
            }
        }
        static void HandleTextMessage(TextMessage textMessage){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("got Message: {0}", textMessage.Text);
            Console.ResetColor();
}
    }
}
