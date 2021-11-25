using System;

namespace NalogRu.BillJson.Models
{
    /// <summary>
    /// применяемая система налогообложения
    /// </summary>
    /// <remarks>
    /// (bitfield)
    /// TAGS 1055
    ///<![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/7055f4c082d306e7c5b11804cdb66592aa5ef4a1/ ]]>
    /// </remarks>
    /// <seealso cref="Messages.EAppliedTaxationTypeNames"/>
    [Flags]
    public enum EAppliedTaxationType : byte
    {
        Undefined = 0,

        /// <summary>
        /// Общая (ОСН)
        /// </summary>
        General = 1,
        bit0 = General,

        /// <summary>
        /// Упрощенная доход (УСН доход)
        /// </summary>
        SimpleIncome = 2,
        bit1 = SimpleIncome,

        /// <summary>
        /// Упрощенная доход минус расход (УСН доход - расход)
        /// </summary>
        SimpleIncomeExpense = 4,
        bit2 = SimpleIncomeExpense,

        /// <summary>
        /// Единый налог на вмененный доход (ЕНВД)
        /// </summary>
        SingleTaxOnImputedIncome = 8,
        bit3 = SingleTaxOnImputedIncome,

        /// <summary>
        /// Единый сельскохозяйственный налог (ЕСХН)
        /// </summary>
        UnifiedAgriculturalTax = 16,
        bit4 = UnifiedAgriculturalTax,

        /// <summary>
        /// Патентная система налогообложения (Патент)
        /// </summary>
        Patent = 32,
        bit5 = Patent,
        [Obsolete("unused", true)]
        bit6 = 64, // not set ( always 0 )
        [Obsolete("unused", true)]
        bit7 = 128 // not set ( always 0 )
    }
}