using System.ComponentModel.DataAnnotations;


namespace RazorpagesJoshua.Models
{
    public class Movie
    {
        public int ID { get; set; } 
        public string Title { get; set; }   = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public int Price { get; set; }

    }
}
