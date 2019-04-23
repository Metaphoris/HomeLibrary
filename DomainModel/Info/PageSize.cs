namespace DomainModel
{
    public sealed class PageSize
    {
        public int PageSizeID { get; set; }
        public decimal Length { get; set; }
        public decimal Heigth { get; set; }

        public override string ToString()
        {
            return $"{Length} x {Heigth}";
        }
    }
}