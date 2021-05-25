using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWD_Final_Project
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual int Projects_Count { get; set; }
        public int Completed_Projects_Count { get; set; }
    }
}
