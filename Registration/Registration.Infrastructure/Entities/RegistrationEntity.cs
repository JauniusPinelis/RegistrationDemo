using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Registration.Infrastructure.Entities
{
    [Table("tblData_Registration")]
    public class RegistrationEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsWorkNeeded { get; set; }

        public int WorkAppliedBy { get; set; }

        public bool IsBusinessClient { get; set; }

        public int CalculationType { get; set; }

        public bool IsImportantClient { get; set; }
    }
}
