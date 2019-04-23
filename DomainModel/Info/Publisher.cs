namespace DomainModel
{
    public sealed class Publisher
    {
        public int PublisherID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}