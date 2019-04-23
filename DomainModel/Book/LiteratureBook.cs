using System.Text;

namespace DomainModel
{
    public class LiteratureBook : Book
    {
        public Literature Literature { get; set; }

        public Age Age { get; set; }

        public override string ToString()
        {
            return GetFullBookInfo();
        }

        public override string GetShortBookInfo()
        {
            return $"Название: {Title}\nАвтор: {Author}";
        }

        public override string GetFullBookInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Название: {Title}");
            sb.AppendLine($"Автор: {Author.ToString()}");
            sb.AppendLine($"ISBN: {ISBN}");
            sb.AppendLine($"Количество страниц: {PageCount.ToString()}");
            sb.AppendLine($"Тип обложки: {CoverType.ToString()}");
            sb.AppendLine($"Размер книги: {PageSize.ToString()}");
            sb.AppendLine($"Размер шрифта: {FontSize.ToString()}");
            sb.AppendLine($"Страна: {Country.ToString()}");
            sb.AppendLine($"Издатель: {Publisher.ToString()}");
            sb.AppendLine($"Иллюстрована: {(HasIllustrates ? "Да" : "Нет")}");
            sb.AppendLine($"Рекомендуемый возраст: {Age.ToString()}");
            sb.AppendLine(Literature.ToString());

            return sb.ToString();
        }
    }
}