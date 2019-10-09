using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Core.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }
        public DropdownModel Dropdown { get; set; }
    }
}
