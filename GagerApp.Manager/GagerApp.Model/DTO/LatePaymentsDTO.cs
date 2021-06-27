using System;
using System.Collections.Generic;
using System.Text;

namespace GagerApp.Model.DTO
{
    public class LatePaymentsDTO
    {
        public DateTime Date
        {
            get; set;
        }

        public float Sum
        {
            get; set;
        }

        public string TelefonNumber
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

    }
}
