namespace DomainModel
{
    public class SingleLiterature : Literature
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public Form Form { get; set; }
       
        public CollectionLiterature CollectionLiterature { get; set; }

        public override string ToString()
        {
            return $"Название: {Title}\nЖанр: {Genre}\nФорма: {Form}\n";
        }

        public string CollectionToString()
        {
            return $"   Название: {Title}\n   Жанр: {Genre}\n   Форма: {Form}\n";
        }
    }
}