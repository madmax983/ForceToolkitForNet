using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Tooling.Models
{
    public class CustomField
    {
        public const string SObjectTypeName = "CustomField";

        public string Id { get; set; }
        public string DeveloperName { get; set; }
        public object Metadata { get; set; }
        public string NamespacePrefix { get; set; }
        public string TableEnumOrId { get; set; }
    }
}
