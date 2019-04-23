using Microsoft.EntityFrameworkCore;
using DomainModel;

namespace Infrastructure
{
    public class ApplicationContext : DbContext
    {
        #region Info
        #region General
        public DbSet<Author> Author { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CoverType> CoverType { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<PageSize> PageSize { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        #endregion

        #region Belletristic
        public DbSet<Age> Age { get; set; }
        public DbSet<Form> Form { get; set; }
        public DbSet<Genre> Genre { get; set; }
        #endregion

        #region Educational
        public DbSet<Discipline> Discipline { get; set; }
        #endregion
        #endregion

        #region Book
        public DbSet<Literature> Literature { get; set; }
        public DbSet<SingleLiterature> SingleLiterature { get; set; }
        public DbSet<PartSingleLiterature> PartSingleLiterature { get; set; }
        public DbSet<CollectionLiterature> CollectionLiterature { get; set; }

        public DbSet<Book> Book { get; set; }
        public DbSet<LiteratureBook> LiteratureBook { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=/Всё/Программирование/HomeLibrary/Infrastructure/HomeLibrary.sqlite");
        }
    }
}