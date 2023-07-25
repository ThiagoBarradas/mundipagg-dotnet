﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateBankAccountRefundingRequest
    {   
        public string HolderName { get; set; }       
        
        public string HolderType { get; set; }       
        
        public string HolderDocument { get; set; }

        public string Bank { get; set; }

        public string BranchNumber { get; set; }

        public string BranchCheckDigit { get; set; }

        public string AccountNumber { get; set; }

        public string AccountCheckDigit { get; set; }  
        
        public string Type { get; set; }
    }
}