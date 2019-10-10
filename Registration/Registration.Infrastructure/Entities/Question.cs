using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Registration.Infrastructure.Entities
{
    [Table("tblData_Question")]
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }
        public Dropdown Dropdown { get; set; }
    }
}
