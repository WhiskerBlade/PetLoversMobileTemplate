using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color {  get; set; }
        public ImageSource Image { get; set; }

        [NotMapped]
        public string BackgroundColor =>  Color.Replace("#", "#15");
    }
}
