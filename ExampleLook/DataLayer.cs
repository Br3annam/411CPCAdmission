using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLook
{
    public class DataLayer
    {
        //short had get and set
        public DateTime DOB { get; set; }
        public char Gender { get; set; }
        public string LastName { get; set; }
        public char PresentSuicide { get; set; }

        //constructor with default fields
        public DataLayer()
        {
            DOB = new DateTime(1995, 5, 23);
            Gender = 'f';
            LastName = "Cottage Cheese";
            PresentSuicide = 'y';
        }
    }

  
}
