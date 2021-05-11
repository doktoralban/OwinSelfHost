using Microsoft.Owin.Hosting;
using System.Threading;

namespace OwinSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:5600/";

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Thread.Sleep(Timeout.Infinite);
            }

        }


    }
}
