namespace DomainModel
{
    public class Form
    {
        public int FormID { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}