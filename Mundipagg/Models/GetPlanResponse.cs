using System;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetPlanResponse 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string StatementDescriptor { get; set; }
        public string Interval { get; set; }
        public int IntervalCount { get; set; }
        public string BillingType { get; set; }
        public List<string> PaymentMethods { get; set; }
        public List<int> Installments { get; set; }
        public string Status { get; set; }
        public string Currency { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<GetPlanItemResponse> Items { get; set; }
        public List<int> BillingDays { get; set; }
        public bool Shippable { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public int? TrialPeriodDays { get; set; }
        public int? MinimumPrice { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
} 