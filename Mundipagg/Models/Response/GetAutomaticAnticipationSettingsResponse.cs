using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetAutomaticAnticipationSettingsResponse
    {
        public bool Enabled { get; set; }

        public string Type { get; set; }

        public int VolumePercentage { get; set; }

        public int? Delay { get; set; }

        public List<int> Days { get; set; }
    }
}
