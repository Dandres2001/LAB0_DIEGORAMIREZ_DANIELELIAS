using System;

namespace LAB0_DIEGORAMIREZ_DANIELELIAS.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
