using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Core.Models
{
    public class DropdownDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<DropdownFieldDto> SelectFields { get; set; }
    }
}
