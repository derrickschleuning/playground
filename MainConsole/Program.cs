﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("** Start **");
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
