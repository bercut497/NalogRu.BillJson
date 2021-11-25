namespace NalogRu.BillJson.Extensions
{
    using Models;
    using Messages;

    public static class ENdsTypeExtension
    {
        public static string ToName(this ENdsType value) => ENdsTypeNames.GetName(value);
        public static ENdsType ToENdsType(this string value, bool allowUndefined = false) => ENdsTypeNames.Parse(value, allowUndefined);
    }
}