namespace NalogRu.BillJson.Models
{
    /// <summary>
    /// дополнительный реквизит пользователя
    /// </summary>
    /// <remarks>
    /// TAGS: 1084
    /// <![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/be0c5f9845adc7d099a6538edd7604b2561f36dd/ ]]>
    /// </remarks>>
    public record Properties
    {
        /// <summary>
        /// наименование дополнительного реквизита пользователя
        /// </summary>
        /// <remarks>TAGS: 1085</remarks>
        public string PropertyName { get; init; } = string.Empty;
        /// <summary>
        /// Значение дополнительного реквизита пользователя
        /// </summary>
        /// <remarks>TAGS: 1086</remarks>
        public string PropertyValue { get; init; } = string.Empty;
    };
}