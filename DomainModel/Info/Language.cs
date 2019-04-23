namespace DomainModel
{
    public class Language
    {
        public int LanguageID { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}