namespace DomainModel
{
    public class CoverType
    {
        public int CoverTypeID { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}