using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRequestLogic.Model
{
    public class Customer
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int CountOfTasks { get; set; } 

        public int DurationHours { get; set; }  

        public int ExcecutedTasks { get; set; }  

    }
}
