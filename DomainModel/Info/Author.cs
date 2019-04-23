namespace DomainModel
{
    public sealed class Author
    {
        public int AuthorID { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}