using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQuerySystem
{
    public class Program
    {
        public static void Main()
        {
           Console.WriteLine("-------------Student Deatils are here implement using Linq and Tostring method --------------");
           StudentDetails s = new StudentDetails();
            s.ShowData();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-------------Person Deatils are here implement using Linq Query------------");
            Person p = new Person();
            p.showdata();
            Console.WriteLine("-----------------------------------------");
        }
    }


     
}
