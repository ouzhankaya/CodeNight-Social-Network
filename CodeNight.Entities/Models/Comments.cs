using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNight.Entities
{
    [Table("Comments")]
    public class Comments
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedDate { get; set; }
        public Share Share { get; set; }
        public User Owner { get; set; }
       

    }
}
