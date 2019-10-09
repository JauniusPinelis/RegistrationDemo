using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Core.Models
{
    public class RegistrationModel
    {
        public bool IsWorkNeeded { get; set; }
        public IEnumerable<string> IsWorkNeededSelectList { get; set; }
        public int WorkAppliedBy { get; set; }
        public IEnumerable<string> WorkAppliedBySelectList { get; set; }
        public bool IsBusinessClient { get; set; }
        public IEnumerable<string> IsBusinessClientSelectList { get; set; }
        public int CalculationType { get; set; }
        public IEnumerable<string> CalculationTypeSelectList { get; set; }
        public bool IsImportantClient { get; set; }
        public IEnumerable<string> IsImportantClientSelectList { get; set; }
    }
}
