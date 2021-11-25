namespace NalogRu.BillJson.Models
{
    /// <summary>
    /// Код документа
    /// </summary>
    /// <remarks>TAGS: 3, 4, 103</remarks>
    public enum ECodeType
    {
        Undefined = 0,
        /// <summary>
        /// для онлайн ККТ
        /// </summary>
        Online =3,
        /// <summary>
        /// бланк строгой отчетности (БСО)
        /// </summary>
        BSO =4,
        /// <summary>
        /// для автономных ККТ
        /// </summary>
        Standalone = 103
    }
}