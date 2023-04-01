﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Canon : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("Canon printing " + content);
        }
    }
}
