﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uiApplication = new Application(new MacFactory());

            uiApplication.RenderUI();
        }
    }
}
