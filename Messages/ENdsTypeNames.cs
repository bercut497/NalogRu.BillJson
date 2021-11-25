using System;

namespace NalogRu.BillJson.Messages
{
    using Models;

    /// <summary>
    /// Значения реквизита "ставка НДС"
    /// </summary>
    /// <remarks>
    /// TAGS: 1199
    /// <![CDATA[ https://www.consultant.ru/document/cons_doc_LAW_362322/338afff6ce138d548f34d24c40f7a7b1c2185ecc/ ]]>
    /// </remarks>
    public static class ENdsTypeNames
    {
        #region Const names

        public const string NDS_20_SHORT = "НДС 20%";
        public const string NDS_10_SHORT = "НДС 10%";
        public const string NDS_20_120_SHORT = "НДС 20/120";
        public const string NDS_10_110_SHORT = "НДС 10/110";
        public const string NDS_0_SHORT = "НДС 0%";
        public const string NO_NDS_SHORT = "-";

        public const string NDS_20_LONG = "ставка НДС 20%";
        public const string NDS_10_LONG = "ставка НДС 10%";
        public const string NDS_20_120_LONG = "ставка НДС расч. 20/120";
        public const string NDS_10_110_LONG = "ставка НДС расч. 10/110";
        public const string NDS_0_LONG = "ставка НДС 0%";
        public const string NO_NDS_LONG = "НДС не облагается";

        #endregion

        public static string GetName(ENdsType value, bool shortName = true)
        {
            return value switch
            {
                ENdsType.Nds20 => shortName ? NDS_20_SHORT : NDS_20_LONG,
                ENdsType.Nds10 => shortName ? NDS_10_SHORT : NDS_10_LONG,
                ENdsType.Nds20120 => shortName ? NDS_20_120_SHORT : NDS_20_120_LONG,
                ENdsType.Nds10110 => shortName ? NDS_10_110_SHORT : NDS_10_110_LONG,
                ENdsType.Nds0 => shortName ? NDS_0_SHORT : NDS_0_LONG,
                ENdsType.NoNds => shortName ? NO_NDS_SHORT : NO_NDS_LONG,
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }

        public static ENdsType Parse(string value, bool allowUndefined = false)
        {
            return value switch
            {
                NDS_20_SHORT => ENdsType.Nds20,
                NDS_20_LONG => ENdsType.Nds20,
                NDS_10_SHORT => ENdsType.Nds10,
                NDS_10_LONG => ENdsType.Nds10,
                NDS_20_120_SHORT => ENdsType.Nds20120,
                NDS_20_120_LONG => ENdsType.Nds20120,
                NDS_10_110_SHORT => ENdsType.Nds10110,
                NDS_10_110_LONG => ENdsType.Nds10110,
                NDS_0_SHORT => ENdsType.Nds0,
                NDS_0_LONG => ENdsType.Nds0,
                NO_NDS_SHORT => ENdsType.NoNds,
                NO_NDS_LONG => ENdsType.NoNds,
                _ => allowUndefined
                    ? ENdsType.Undefined
                    : throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }
    }
}