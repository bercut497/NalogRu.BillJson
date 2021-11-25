namespace NalogRu.BillJson.Models
{
    /// <summary>
    /// признак расчета
    /// </summary>
    /// <remarks>
    /// TAGS 1054
    /// <![CDATA[http://www.consultant.ru/document/cons_doc_LAW_362322/c3f6615226cb89c3d7f325ed9d064a64f45a481d/]]>
    /// </remarks>
    public enum EOperationType
    {
        Undefined = 0,
        /// <summary>
        /// приход
        /// </summary>
        income = 1,
        /// <summary>
        /// возврат прихода
        /// </summary>
        return_of_income = 2,
        /// <summary>
        /// расход
        /// </summary>
        consumption = 3,
        /// <summary>
        /// возврат расхода
        /// </summary>
        return_of_consumption = 4
    }
}