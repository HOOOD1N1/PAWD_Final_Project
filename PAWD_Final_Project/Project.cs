using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWD_Final_Project
{
    public class Project
    {  
        public string Title { get; set; }
        public bool Completed { get; set; }
        public DateTime deadline { get; set; }
        public DateTime reminder_hour { get; set; }
    }
}
