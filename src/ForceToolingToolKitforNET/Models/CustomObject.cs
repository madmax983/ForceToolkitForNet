using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Tooling.Models
{
    public class CustomObject
    {
        public const string SObjectTypeName = "CustomObject";

        public string Id { get; set; }
        public string CustomHelpId { get; set; }
        public string Description { get; set; }
        public string DeveloperName { get; set; }
        public string ExternalName { get; set; }
        public string ExternalRepository { get; set; }
        public string Language { get; set; }
        public string NamespacePrefix { get; set; }
        public string SharingModel { get; set; }
    }
}
