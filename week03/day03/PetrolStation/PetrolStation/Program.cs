﻿using System;
using System.Collections.Generic;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Station shell = new Station("Shell");
            List<Car> cars = new List<Car> { new Car("Mustang"), new Car("Rrari"), new Car("Humma") };

            for (int i = 0; i < cars.Count; i++)
            {
                shell.Refill(cars[i]);
                shell.PrintStatus();
                cars[i].PrintStatus();
            }

            Console.ReadLine();
        }
    }
}
