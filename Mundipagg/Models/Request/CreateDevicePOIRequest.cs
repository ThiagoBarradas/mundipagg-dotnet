namespace Mundipagg.Models.Request
{
    public class CreateDevicePOIRequest
    {
        public string SystemName { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string SerialNumber { get; set; }

        public string VersionNumber { get; set; }

        public string CommunicationType { get; set; }

        public string PartnerName { get; set; }
    }
}
