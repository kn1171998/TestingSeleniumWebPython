using NUnitTestProject1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo2Test d = new Demo2Test();
            d.SetUp();
            d.demoSetupLogin();
            //Test Login UnSuccess
            // d.demo2("123","123");
           // d.TC01();
            //Test Login Success
            //d.demo2("admin", "admin");
            d.demo3();
        }
    }
}
