﻿using System;
using SQFramework.Spring;

namespace ControleDeEstoque.Services.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFactory.Initialize();

            Console.Write("\nPress ENTER to stop...");
            Console.ReadKey();

            ObjectFactory.Finalize();
        }
    }
}