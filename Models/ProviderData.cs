using System.Collections.Generic;

namespace NalogRu.BillJson.Models
{
    /// <summary>
    /// Значения реквизита "данные поставщика"
    /// </summary>
    /// <remarks>
    /// TAGS: 1224
    /// <![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/c04c2d666529b9cbb23093db564fb0e79a7a8839/ ]]>
    /// </remarks>
    public record ProviderData
    {
        /// <summary>
        /// телефон поставщика
        /// </summary>
        /// <remarks>TAGS: 1171</remarks>
        private IReadOnlyCollection<string> ProviderPhone { get; init; } = new List<string>();

        /// <summary>
        /// наименование поставщика
        /// </summary>
        /// <remarks>TAGS: 1225</remarks>
        private string ProviderName { get; init; } = string.Empty;
    }
}