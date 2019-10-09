using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Registration.Infrastructure.Entities
{
    [Table("tblMeta_Dropdown")]
    public class DropdownEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DropdownFieldEntity> SelectFields { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public QuestionEntity Question { get; set;}
    }
}
