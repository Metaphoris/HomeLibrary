namespace DomainModel
{
    public class Age
    {
        public int AgeID { get; set; }

        public string Name { get; set; }

        public int YearStart { get; set; }

        public int? YearEnd { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}