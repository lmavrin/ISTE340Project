namespace Project3.Models
{
    /// <summary>
    /// this class is used for holding all of the undergraduate data
    /// </summary>
    public class Undergraduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string[] concentrations { get; set; }
    }
}

