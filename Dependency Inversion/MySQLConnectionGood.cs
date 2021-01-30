using System;

// Database Connection Interface ima connect metod i ova klasa treba implementirati taj interfejs

namespace Dependency_Inversion
{
    class MySQLConnectionGood : DatabaseConnectionInterface
    {
        public void connect()
        {
            // some logic goes here
            Console.WriteLine("Connecting...");
            Console.WriteLine("Connected to MySQL database.");
        }
    }
}
