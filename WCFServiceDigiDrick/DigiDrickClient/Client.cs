

namespace IVL.DigiDrick.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.ServiceModel;
    using DigiDrick.ModelLib;

    /// <summary>
    /// Test client for DigiDrick
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Starting a console to allow user to enter simulated raw water variables and calculates predicted dose and DModX.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        [STAThread]
        public static void Main(string[] args)
        {
            // Initialize variables
            float Result;
            string model = "C:/Users/joel0921/PycharmProjects/DigiDrick/plsmodel.p";
            string python = "C:/Users/joel0921/AppData/Local/Continuum/Anaconda3/python.exe";
            string scripts = "C:/Users/joel0921/PycharmProjects/DigiDrick/";
            bool exit = false;

            DigiDrickClient.ServiceReferenceDM.DigiDrickModelClient DigiSimulator;

            // Setup console window
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            // Client Configuration
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress("http://localhost:8081/DigiDrickModel");
            
            using (DigiSimulator  = new DigiDrickClient.ServiceReferenceDM.DigiDrickModelClient(binding, address))
            {
                Console.WriteLine("Initiating new model");
                Console.WriteLine("Calling Model setup");
                
                DigiSimulator.ModelSetup(model, python, scripts);

                while (!exit)
                {
                    Console.WriteLine("Please enter an input raw water vector, e.g. 1.3, 2.24, 3, 4 (enter 'exit' to exit): ");
                    string Response = Console.ReadLine();
                    if (Response == "exit")
                    {
                        exit = true;
                    }
                    else
                    {
                        try
                        {
                            float[] input = Response.Split(',').Select(float.Parse).ToArray();  // Pass input to array
                            Console.WriteLine("Calling DModXCalc");
                            Result = DigiSimulator.ExecuteDModXCalc(input);
                            Console.WriteLine("DModX = " + Result.ToString());

                            Console.WriteLine("Calling DoseCalc");
                            Result = DigiSimulator.ExecuteDoseCalc(input);
                            Console.WriteLine("Dose = " + Result.ToString());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: {0}", e.Message);

                        }
                    }
                }
            }
        }
    }
}
