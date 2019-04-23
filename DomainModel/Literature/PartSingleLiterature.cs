namespace DomainModel
{
    public class PartSingleLiterature : SingleLiterature
    {
        public int NextBookID { get; set; }
        public LiteratureBook NextBook { get; set; }

        public int PrevBookID { get; set; }
        public LiteratureBook PrevBook { get; set; }

        public override string ToString()
        {
            return $"Название: {Title}\nЖанр: {Genre}\nФорма: {Form}\nПредыдущая книга: {(NextBook != null ? NextBook.Title : "")}\nСледующая книга: {(PrevBook != null ? PrevBook.Title : "")}";
        }
    }
}