using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Tooling.Models
{
    public class ValidationRule
    {
        public const string SObjectTypeName = "ValidationRule";

        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public object Metadata { get; set; }
        public string NamespacePrefix { get; set; }
        public string TableEnumOrId { get; set; }
        public string ValidationName { get; set; }
    }
}
