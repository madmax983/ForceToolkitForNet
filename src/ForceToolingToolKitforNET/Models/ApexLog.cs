using System;

namespace Salesforce.Tooling.Models
{
    public class ApexLog
    {
        public const string SObjectTypeName = "ApexLog";

        public string Id { get; set; }
        public string Application { get; set; }
        public int DurationMilliseconds { get; set; }
        public string Location { get; set; }
        public int LogLength { get; set; }
        public int LogUserId { get; set; }
        public string Operation { get; set; }
        public string Request { get; set; }
        public DateTime StartTime { get; set; }
        public string Status { get; set; }
    }
}
