using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Salesforce.Common;
using Salesforce.Tooling;
using System.Threading.Tasks;
using System.Dynamic;

namespace ToolingConsole
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
            catch (Exception e)
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

            // retrieve all accounts
            Console.WriteLine("Get Classes");

            const string qry = "SELECT ID, Name FROM ApexClass";
            var classes = new List<ApexClass>();
            var results = await client.QueryAsync<ApexClass>(qry);
            var totalSize = results.totalSize;

            Console.WriteLine("Queried " + totalSize + " records.");

            // Create Tooling Information
            Console.WriteLine("Test Tooling API");
            var toolingInformation = await client.GetObjectsAsync<DescribeGlobalResult>();
            var metadataContainer = new MetadataContainer { Name = "TestContainer" };
            metadataContainer.Id = await client.CreateAsync(MetadataContainer.SObjectTypeName, metadataContainer);
            if (metadataContainer.Id == null)
            {
                Console.WriteLine("Failed to create test record.");
                return;
            }

            // Retrieve the sample record
            // How to retrieve a single record if the id is known
            Console.WriteLine("Retrieving the record by ID.");
            metadataContainer = await client.QueryByIdAsync<MetadataContainer>(MetadataContainer.SObjectTypeName, metadataContainer.Id);
            if (metadataContainer == null)
            {
                Console.WriteLine("Failed to retrieve the record by ID!");
                return;
            }

            Console.WriteLine("Retrieved the record by ID.");

            // Selecting multiple accounts into a dynamic
            Console.WriteLine("Querying multiple records.");
            var dynamicApexClass = await client.QueryAsync<dynamic>("SELECT ID, Name FROM ApexClass LIMIT 10");
            foreach (dynamic apexClasses in dynamicApexClass.records)
            {
                Console.WriteLine("ApexClass - " + apexClasses.Name);
            }
        }

        private class ApexClass
        {
            public const String SObjectTypeName = "ApexClass";

            public String Id { get; set; }
            public String Name { get; set; }
        }

        private class MetadataContainer
        {
            public const String SObjectTypeName = "MetadataContainer";

            public String Id { get; set; }
            public String Name { get; set; }
        }

        private class DescribeGlobalResult
        {
            public const String SObjectTypeName = "DescribeGlobalResult";

            public String Id { get; set; }
            public String Name { get; set; }
        }

    }
}
