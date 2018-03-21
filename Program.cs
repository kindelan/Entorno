using System;
using System.IO;


namespace CrearEntorno
{
    class Program
    {

            static void Main(string[] args)
        {
            string readText = File.ReadAllText(path: @"C:\Users\IGNACIO PEREZ\Desktop\Entorno.bat");
            Console.WriteLine(readText);

            string value = Environment.GetEnvironmentVariable("TestVariableName");
            Console.WriteLine(value);
            Console.ReadKey();

}
    }
    }

