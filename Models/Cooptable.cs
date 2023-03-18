namespace Project3.Models
{
    public class Cooptable
    {
        /// <summary>
        /// 
        /// This table holds the data for the title and the individial coop information data
        /// </summary>
        public string title { get; set; }
        public Coopinformation[] coopInformation { get; set; }
    }
}
