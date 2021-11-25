namespace NalogRu.BillJson.Extensions
{
    using Models;
    using Messages;

    public static class EAppliedTaxationTypeExtension
    {
        public static EAppliedTaxationType ToEAppliedTaxationType(this string value, bool allowUndefined = false)
            => EAppliedTaxationTypeNames.Parse(value);

        public static string ToName(this EAppliedTaxationType value, bool shortName = true) =>
            EAppliedTaxationTypeNames.GetName(value, shortName);
    }
}