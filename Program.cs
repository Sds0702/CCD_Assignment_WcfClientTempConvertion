using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WcfClientTempConvertion.ServiceReference1;

namespace WcfClientTempConvertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            // Ener arguments from console.
            Console.WriteLine("Temperature to be converted: ");
            /*var TInput = Console.ReadLine();
            double bInput = Convert.ToDouble(TInput);*/
            Console.WriteLine("1: Celsius to Fahrenheit conversion");
            Console.WriteLine("2: Celsius to Kelvin conversion");
            Console.WriteLine("3: Fahrenheit to Celsius conversion");
            Console.WriteLine("4: Fahrenheit to Kelvin conversion");
            Console.WriteLine("5: Kelvin to Celsius conversion");
            Console.WriteLine("6: Kelvin to Fahrenheit conversion");
            string CInput = Convert.ToString(Console.ReadLine());            
            if (CInput == "1")
            {
                //Celsius to Fahrenheit
                Console.Write("Enter the value:");
                double value;

                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("\n Enter a number, Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
                else 
                {
                    //Call the celsius to fahrenheit service operation
                    double res = client.CelsiustoFahrenheit(value);
                    Console.WriteLine("\nFahrenheit = {1}", value, res);

                    Console.WriteLine("\n Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
            }
            else if (CInput == "2")
            {
                //Celsius to Kelvin
                Console.Write("Enter the value:");
                double value;

                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("\n Enter a number, Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
                else
                {
                    //Call the Celsius to Kelvin service operation
                    double res = client.CelsiustoKelvin(value);
                    Console.WriteLine("\nKelvin = {1}", value, res);

                    Console.WriteLine("\n Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
            }
            else if (CInput == "3")
            {
                //Fahrenheit to Celsius
                Console.Write("Enter the value:");
                double value;

                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("\n Enter a number, Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
                else
                {
                    //Call the Fahrenheit to Celsius service operation
                    double res = client.FahrenheittoCelsius(value);
                    Console.WriteLine("\nCelsius = {1}", value, res);

                    Console.WriteLine("\n Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
            }
            else if (CInput == "4")
            {
                //Fahrenheit to Kelvin
                Console.Write("Enter the value:");
                double value;

                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("\n Enter a number, Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
                else
                {
                    //Call the Fahrenheit to Kelvin service operation
                    double res = client.FahrenheittoKelvin(value);
                    Console.WriteLine("\nKelvin = {1}", value, res);

                    Console.WriteLine("\n Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
            }
            else if (CInput == "5")
            {
                //Kelvin to Celsius
                Console.Write("Enter the value:");
                double value;

                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("\n Enter a number, Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
                else
                {
                    //Call the Kelvin to Celsius service operation
                    double res = client.KelvintoCelsius(value);
                    Console.WriteLine("\nCelsius = {1}", value, res);

                    Console.WriteLine("\n Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
            }
            else if(CInput == "6")
            {
                //Kelvin to Fahrenheit
                Console.Write("Enter the value:");
                double value;

                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("\n Enter a number, Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
                else
                {
                    //Call the Kelvin to Fahrenheit service operation
                    double res = client.KelvintoFahrenheit(value);
                    Console.WriteLine("\nCelsius = {1}", value, res);

                    Console.WriteLine("\n Press <Enter> terminate client.");
                    Console.ReadLine();
                    //Closing the client releases all communication resources.
                    //client.Close();
                }
            }
            client.Close();
        }
    }
}
