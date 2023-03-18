namespace Project3.Models
{
    /// <summary>
    /// This class is used for holding the graduate data
    /// </summary>
    public class Graduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string[] concentrations { get; set; }
        public string[] availableCertificates { get; set; }
    }
}
