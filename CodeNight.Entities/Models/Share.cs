using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNight.Entities
{
    [Table("Shares")]
    public class Share
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ShareText { get; set; }
        public int LikeCount { get; set; }
        public string ShareImagFileName { get; set; }
        public string ShareVideoFileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Owner { get; set; }

        public List<Comments> Comments { get; set; }
        public List<Liked> Likes { get; set; }

        public Share()
        {
            Comments = new List<Comments>();
            Likes = new List<Liked>();
        }

    }
}
