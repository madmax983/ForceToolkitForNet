using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Tooling.Models
{
    public class QuickActionDefinition
    {
        public const string SObjectTypeName = "QuickActionDefinition";

        public string Id { get; set; }
        public string Description { get; set; }
        public string DeveloperName { get; set; }
        public int Height { get; set; }
        public string IconId { get; set; }
        public string Label { get; set; }
        public string Language { get; set; }
        public string MasterLabel { get; set; }
        public string NamespacePrefix { get; set; }
        public string SobjectType { get; set; }
        public string StandardLabel { get; set; }
        public string TargetField { get; set; }
        public string TargetRecordTypeId { get; set; }
        public string TargetSobjectType { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
    }
}
