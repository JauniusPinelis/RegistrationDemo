using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Registration.Infrastructure.Entities
{
    [Table("tblMeta_Question")]
    public class QuestionEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }
        public DropdownEntity Dropdown { get; set; }
    }
}
