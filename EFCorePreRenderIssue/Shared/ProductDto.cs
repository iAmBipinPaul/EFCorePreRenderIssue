namespace EFCorePreRenderIssue.Shared
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitId { get; set; }
        public UnitDto Unit { get; set; }
    }
}
