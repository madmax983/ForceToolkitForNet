using System;

namespace Salesforce.Tooling.Models
{
    public class HeapDump
    {
        public const string SObjectTypeName = "HeapDump";

        public string Id { get; set; }
        public string className { get; set; }
        public object[] extents { get; set; }
        public DateTime heapDumpDate { get; set; }
        public string namespacePrefix { get; set; }
    }
}
