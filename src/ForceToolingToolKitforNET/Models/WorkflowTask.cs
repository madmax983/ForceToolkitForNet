using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Tooling.Models
{
    public class WorkflowTask
    {
        public const string SObjectTypeName = "WorkflowTask";

        public string Id { get; set; }
        public string EntityDefinitionId { get; set; }
        public string FullName { get; set; }
        public object Metadata { get; set; }
        public string NamespacePrefix { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
        public string TableEnumOrId { get; set; }
    }
}
