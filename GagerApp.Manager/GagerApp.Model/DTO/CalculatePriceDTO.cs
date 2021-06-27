using System;
using System.Collections.Generic;
using System.Text;

namespace GagerApp.Model.DTO
{
    public class CalculatePriceDTO
    {
        public string Name
        {
            get; set;
        }
        public string Col
        {
            get; set;
        }
        public float Price
        {
            get; set;
        }
        public float Sum
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
    }
}
