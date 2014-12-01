using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Tooling.Models
{
    public class QuickActionListItem
    {
        public const string SObjectTypeName = "QuickActionListItem";

        public string Id { get; set; }
        public string QuickActionDefinition { get; set; }
        public string QuickActionListId { get; set; }
        public int SortOrder { get; set; }
    }
}
