using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneASP.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Pleaser sdaksdk")]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime ReleasedDate { get; set; }

        [UIHint("test")]
        public bool IsAvalible { get; set; }

        [Required]
        public Genre? Genre { get; set; }

    }

    public enum Genre
    {
        SciFi,
        Novel,
        Other
    }

    public class Books : List<Book>
    {
        public Books()
        {
            this.Add(new Book { Title = "Book title 1", Author = "Author1", Description = "Desc1", ReleasedDate = DateTime.Now });
            this.Add(new Book { Title = "Book title 2", Author = "Author2", Description = "Desc2", ReleasedDate = DateTime.Now });
            this.Add(new Book { Title = "Book title 3", Author = "Author3", Description = "Desc3", ReleasedDate = DateTime.Now });
            this.Add(new Book { Title = "Book title 4", Author = "Author4", Description = "Desc4", ReleasedDate = DateTime.Now });
            this.Add(new Book { Title = "Book title 5", Author = "Author5", Description = "Desc5", ReleasedDate = DateTime.Now });
        }
    }
}