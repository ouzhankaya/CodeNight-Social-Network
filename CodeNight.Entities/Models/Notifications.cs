using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNight.Entities
{
  public class Notifications
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime NotificationDate { get; set; }
        public byte NotificationSeen { get; set; }
        public User Users { get; set; }
    }
}
