using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Salesforce.Common;
using Salesforce.Common.Models;
using Salesforce.Tooling;
using Salesforce.Tooling.Models;
using System.Threading.Tasks;
using System.Dynamic;

namespace ToolConsole
{
    class ToolProgram
    {
        private static readonly string SecurityToken = ConfigurationManager.AppSettings["SecurityToken"];
        private static readonly string ConsumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
        private static readonly string ConsumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
        private static readonly string Username = ConfigurationManager.AppSettings["Username"];
        private static readonly string Password = ConfigurationManager.AppSettings["Password"] + SecurityToken;
        private static readonly string IsSandboxUser = ConfigurationManager.AppSettings["IsSandboxUser"];

        static void Main()
        {
            try
            {
                var task = RunSample();
                task.Wait();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                var innerException = e.InnerException;
                while (innerException != null)
                {
                    Console.WriteLine(innerException.Message);
                    Console.WriteLine(innerException.StackTrace);

                    innerException = innerException.InnerException;
                }
            }
        }

        private static async Task RunSample()
        {
            var auth = new AuthenticationClient();

            // Authenticate with Salesforce
            Console.WriteLine("Authenticating with Salesforce");
            var url = IsSandboxUser.Equals("true", StringComparison.CurrentCultureIgnoreCase)
                ? "https://test.salesforce.com/services/oauth2/token"
                : "https://login.salesforce.com/services/oauth2/token";

            await auth.UsernamePasswordAsync(ConsumerKey, ConsumerSecret, Username, Password, url);
            Console.WriteLine("Connected to Salesforce");

            var client = new ToolingClient(auth.InstanceUrl, auth.AccessToken, auth.ApiVersion);

            //Query existing Apex Classes
            Console.WriteLine("Get Classes");

            string qry = "SELECT ID, Name FROM ApexClass";
            var apexClasses = new List<ApexClass>();
            var apexClassResults = await client.QueryAsync<ApexClass>(qry);
            var totalSize = apexClassResults.totalSize;

            Console.WriteLine("Queried " + totalSize + " records.");

            //Query existing Profiles

            //Query existing Apex Classes
            Console.WriteLine("Get Completions");

            string type = "apex";
            var completions = new Completions();
            var completionResults = await client.CompletionsAsync<Completions>(type);
 
            Console.WriteLine("Queried " + totalSize + " records.");
        }
    }
}
