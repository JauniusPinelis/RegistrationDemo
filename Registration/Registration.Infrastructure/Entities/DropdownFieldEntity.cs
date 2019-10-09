using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Registration.Infrastructure.Entities
{
    [Table("tblMeta_RegistrationValue")]
    public class DropdownFieldEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Dropdown")]
        public int DropdownId { get; set; }

        public DropdownEntity Dropdown { get; set; }
        
    }
}
