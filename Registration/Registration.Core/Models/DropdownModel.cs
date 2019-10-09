using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Core.Models
{
    public class DropdownModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<DropdownFieldModel> SelectFields { get; set; }
    }
}
