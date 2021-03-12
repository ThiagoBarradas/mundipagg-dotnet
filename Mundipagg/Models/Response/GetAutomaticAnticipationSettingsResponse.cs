namespace Mundipagg.Models.Response
{
    public class GetAutomaticAnticipationSettingsResponse
    {
        public bool Enabled { get; set; }

        public string Type { get; set; }

        public decimal VolumePercentage { get; set; }

        public int Delay { get; set; }
    }
}
