using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Tooling.Models
{
    public class EmailTemplate
    {
        public const string SObjectTypeName = "EmailTemplate";

        public string Id { get; set; }
        public string ApiVersion { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
        public object Metadata { get; set; }
        public string Name { get; set; }
        public string NamespacePrefix { get; set; }
        public string Subject { get; set; }
    }

}
