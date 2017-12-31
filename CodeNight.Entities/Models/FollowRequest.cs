using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNight.Entities
{
    [Table("FollowRequest")]
    public class FollowRequest
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime FollowDate { get; set; }
        public User RequestUsers { get; set; }
        public User ResponseUser { get; set; }
        public int FollowID { get; set; }
        public bool FollowApproval { get; set; }
    }
}
