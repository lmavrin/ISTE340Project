using System;

namespace Project3.Models
{
    /// <summary>
    /// Class that is used for requesting and storing the error data
    /// </summary>
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
