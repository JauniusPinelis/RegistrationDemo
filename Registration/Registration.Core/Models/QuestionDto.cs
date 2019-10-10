using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Core.Models
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }
        public DropdownDto Dropdown { get; set; }
    }
}
