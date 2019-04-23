namespace DomainModel
{
    public class Discipline
    {
        public int DisciplineID { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}