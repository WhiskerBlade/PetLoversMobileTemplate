namespace PetLovers.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Text {  get; set; }
        public ImageSource Image { get; set; }

        public User User { get; set; }
    }
}
