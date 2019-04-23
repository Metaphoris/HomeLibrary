using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class CollectionLiterature : Literature
    {
        public List<SingleLiterature> Collection { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Содержимое:");

            foreach (SingleLiterature singleLiterature in Collection)
                sb.Append(singleLiterature.CollectionToString());

            return sb.ToString();
        }
    }
}