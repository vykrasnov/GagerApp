using System;
using System.Collections.Generic;
using System.Text;

namespace GagerApp.Model.DTO
{
    public class WorkerDTO
    {
        public string Name
        {
            get; set;
        }
        public double Number
        {
            get; set;
        }
      
        public DateTime StartTime
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public string Status
        {
            get; set;
        }
    }
}
