

namespace IVL.DigiDrick.Host
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using IVL.DigiDrick.ModelLib;
    using System.ServiceModel;
    /// <summary>
    /// Host program for the DigiDrick services. Displays error messages.
    /// </summary>
    public class DigiDrickHost
    {

        [STAThread]
        public static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(DigiDrickModel)))
            {
                serviceHost.Open();

                Console.Clear();
                Console.Title ="****** Console Based WCF DigiDrick Host *****";

                // Keep the service running until Enter key is pressed.
                Console.WriteLine("The DigiDrick service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.WriteLine(" ------------ Logg ------------ ");
                Console.ReadLine();
            }
        }
    }
}
