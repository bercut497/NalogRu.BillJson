namespace NalogRu.BillJson.Extensions
{
    using Models;
    using Messages;

    public static class EProductTypeExtension
    {
        public static string ToName(this EProductType value) => EProductTypeNames.GetName(value);
        public static string ToCode(this EProductType value) => EProductTypeNames.GetLetterCode(value);
        public static EProductType ToEProductType(this string value, bool allowUndefined = false) => EProductTypeNames.Parse(value, allowUndefined);
    }
}