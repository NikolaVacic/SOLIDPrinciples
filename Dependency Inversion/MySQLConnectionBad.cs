using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ova klasa je low level modul

namespace Dependency_Inversion
{
    class MySQLConnectionBad
    {
        public void connect() {
            // some logic goes here
            Console.WriteLine("Connecting...");
            Console.WriteLine("Connected to Database.");

        }

    }
}
