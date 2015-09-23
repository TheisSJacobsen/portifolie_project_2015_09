using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioMVC.Models
{
    public class RogueModel
    {
        public string fullName { get; set; }
        public string description { get; set; }
        public string address { get; set; }
        public string image { get; set; }


        public string portfolioDescription { get; set; }

        public string eduName { get; set; }
        public string eduSchool { get; set; }
        public DateTime eduStart { get; set; }
        public DateTime eduFinish { get; set; }
        public string eduAddress { get; set; }

        public string workName { get; set; }
        public DateTime workStart { get; set; }
        public DateTime workFinish { get; set; }
        public string workAddress { get; set; }
        public string referencePerson { get; set; }
        public string referenceNumber { get; set; }

        public RogueModel()
        {

        }
    }
}