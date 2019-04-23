using System.ComponentModel.DataAnnotations;

namespace DomainModel
{
    public abstract class Book
    {
        [Key]
        public int BookID { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public string ISBN { get; set; }

        public int PageCount { get; set; }

        public CoverType CoverType { get; set; }

        public PageSize PageSize { get; set; }

        public int FontSize { get; set; }

        public Country Country { get; set; }

        public Publisher Publisher { get; set; }

        public bool HasIllustrates { get; set; }

        public abstract string GetShortBookInfo();

        public abstract string GetFullBookInfo();
    }
}