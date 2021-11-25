using System;
using System.Collections.ObjectModel;
using NalogRu.BillJson.Models;

namespace NalogRu.BillJson.Messages
{
    /// <summary>
    /// Способ кодирования типа систем налогообложения в реквизитах
    /// "системы налогообложения" (тег 1062) и
    /// <see cref="EAppliedTaxationType">"применяемая система налогообложения" (тег 1055)</see>
    /// а также описание форматов этих
    /// реквизитов ФД в печатной форме
    /// </summary>
    /// <remarks>
    /// TAGS: 1055, 1062
    /// <![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/7055f4c082d306e7c5b11804cdb66592aa5ef4a1/ ]]>
    /// </remarks>
    public static class EAppliedTaxationTypeNames
    {
        #region Constants

        /// <summary>Общая (ОСН)</summary>
        /// <remarks>General tax system</remarks>
        public const string GTS_LONG = "Общая";

        /// <summary>ОСН (Общая)</summary>
        /// <remarks>General tax system</remarks>
        public const string GTS_SHORT = "ОСН";

        /// <summary>Упрощенная доход (УСН доход)</summary>
        /// <remarks> Simple tax system (income) [STS]</remarks>
        public const string STS_INCOME_LONG = "Упрощенная доход";

        ///<summary>УСН доход (Упрощенная доход)</summary>
        /// <remarks> Simple tax system (income) [STS]</remarks>
        public const string STS_INCOME_SHORT = "УСН доход";

        /// <summary>Упрощенная доход минус расход (УСН доход - расход) </summary>
        /// <remarks> Simple tax system (income - expense) [STS]</remarks>
        public const string STS_INCOME_EXPENSE_LONG = "Упрощенная доход минус расход";

        /// <summary>УСН доход - расход (Упрощенная доход минус расход) </summary>
        /// <remarks> Simple tax system (income - expense) [STS]</remarks>
        public const string STS_INCOME_EXPENSE_SHORT = "УСН доход - расход";

        /// <summary>Единый налог на вмененный доход (ЕНВД)</summary>
        /// <remarks>A single tax on imputed income [UTII]</remarks>
        public const string STII_LONG = "Единый налог на вмененный доход";

        /// <summary> ЕНВД (Единый налог на вмененный доход)</summary>
        /// <remarks>A single tax on imputed income [UTII]</remarks>
        public const string STII_SHORT = "ЕНВД";

        /// <summary>Единый сельскохозяйственный налог (ЕСХН) </summary>
        /// <remarks>Unified agricultural tax [UAT]</remarks>
        public const string UATS_LONG = "Единый сельскохозяйственный налог";

        /// <summary>ЕСХН (Единый сельскохозяйственный налог)</summary>
        /// <remarks>Unified agricultural tax [UAT]</remarks>
        public const string UATS_SHORT = "ЕСХН";

        /// <summary>Патентная система налогообложения (Патент)  </summary>
        /// <remarks>Patent taxation system (Patent)</remarks>
        public const string PATENT_LONG = "Патентная система налогообложения";

        /// <summary>Патент (Патентная система налогообложения) </summary>
        /// <remarks>Patent taxation system (Patent)</remarks>
        public const string PATENT_SHORT = "Патент";

        #endregion

        public static EAppliedTaxationType Parse(string value, bool allowUndefined = false)
        {
            return value switch
            {
                GTS_LONG => EAppliedTaxationType.General,
                GTS_SHORT => EAppliedTaxationType.General,
                STS_INCOME_LONG => EAppliedTaxationType.SimpleIncome,
                STS_INCOME_SHORT => EAppliedTaxationType.SimpleIncome,
                STS_INCOME_EXPENSE_LONG => EAppliedTaxationType.SimpleIncomeExpense,
                STS_INCOME_EXPENSE_SHORT => EAppliedTaxationType.SimpleIncomeExpense,
                STII_LONG => EAppliedTaxationType.SingleTaxOnImputedIncome,
                STII_SHORT => EAppliedTaxationType.SingleTaxOnImputedIncome,
                UATS_LONG => EAppliedTaxationType.UnifiedAgriculturalTax,
                UATS_SHORT => EAppliedTaxationType.UnifiedAgriculturalTax,
                PATENT_LONG => EAppliedTaxationType.Patent,
                PATENT_SHORT => EAppliedTaxationType.Patent,
                _ => allowUndefined
                    ? EAppliedTaxationType.Undefined
                    : throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }

        public static string GetName(EAppliedTaxationType value, bool shortName = true)
        {
            return value switch
            {
                EAppliedTaxationType.General => shortName ? GTS_SHORT : GTS_LONG,
                EAppliedTaxationType.SimpleIncome => shortName ? STS_INCOME_SHORT : STS_INCOME_LONG,
                EAppliedTaxationType.SimpleIncomeExpense => shortName
                    ? STS_INCOME_EXPENSE_SHORT
                    : STS_INCOME_EXPENSE_LONG,
                EAppliedTaxationType.SingleTaxOnImputedIncome => shortName ? STII_SHORT : STII_LONG,
                EAppliedTaxationType.UnifiedAgriculturalTax => shortName ? UATS_SHORT : UATS_LONG,
                EAppliedTaxationType.Patent => shortName ? PATENT_SHORT : PATENT_LONG,
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }
    }
}