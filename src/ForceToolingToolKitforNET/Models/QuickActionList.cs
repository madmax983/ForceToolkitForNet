using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Tooling.Models
{
    public class QuickActionList
    {
        public const string SObjectTypeName = "QuickActionList";

        public string Id { get; set; }
        public string LayoutId { get; set; }
    }
}
