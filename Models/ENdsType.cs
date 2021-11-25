namespace NalogRu.BillJson.Models
{
    /// <summary>
    /// Значения реквизита "ставка НДС"
    /// </summary>
    /// <remarks>
    /// TAGS: 1199
    /// <![CDATA[ https://www.consultant.ru/document/cons_doc_LAW_362322/338afff6ce138d548f34d24c40f7a7b1c2185ecc/ ]]>
    /// </remarks>
    /// <seealso cref="Messages.ENdsTypeNames"/>
    public enum ENdsType
    {
        Undefined = 0,
        Nds20 = 1,
        Nds10 = 2,
        Nds20120 = 3,
        Nds10110 = 4,
        Nds0 = 5,
        NoNds = 6
    }
}