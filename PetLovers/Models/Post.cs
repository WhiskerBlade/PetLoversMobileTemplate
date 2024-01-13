using PetLovers.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.Models
{
    public class Post
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }

        public ImageSource Image { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public int LovesCount { get; set; }
        public int CommentsCount { get; set; }

        public int ReSharedCount { get; set; }

        [NotMapped]
        public string TimeAgo => CreatedDate.ToTimeAgo();
    }
}
