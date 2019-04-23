using System.ComponentModel.DataAnnotations;

namespace DomainModel
{
    public abstract class Literature
    {
        [Key]
        public int LiteratureID { get; set; }
    }
}