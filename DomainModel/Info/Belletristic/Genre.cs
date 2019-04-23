namespace DomainModel
{
    public class Genre
    {
        public int GenreID { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}