namespace Project3.Models
{
    /// <summary>
    /// This is used for storing the data from json to the sub classes
    /// </summary>
    public class Employmenttable
    {
        public string title { get; set; }
        public Professionalemploymentinformation[] professionalEmploymentInformation { get; set; }
    }
}
