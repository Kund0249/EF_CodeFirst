﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //context
            DBCON bCON = new DBCON();
            var data = bCON.TDEPARTMENTs.ToList();

        }
    }
}
