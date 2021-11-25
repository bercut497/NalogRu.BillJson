namespace NalogRu.BillJson.Models
{
    public record ProductData
    {
        public long Gtin { get; init; }
        public int ProductIdType { get; init; }
        public string RawProductCode { get; init; }
        public long SerNum { get; init; }
    };
}