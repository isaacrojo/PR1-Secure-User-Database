using System;
using System.Collections.Generic;

namespace Secure_User_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<Usuarios> names = new List<Usuarios>();

            Console.WriteLine("---------------Secure User Database-----------");
            Validator validator = new Validator();
            validator.Display();
    
        }

    }
}
