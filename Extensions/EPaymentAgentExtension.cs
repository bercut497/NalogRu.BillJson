namespace NalogRu.BillJson.Messages
{
    using Models;
    using System;

    /// <summary>
    /// Значения реквизита "признак агента" (тег 1057), "признак
    /// агента по предмету расчета" (тег 1222) и описание формата
    /// данных этих реквизитов в печатной форме
    /// </summary>
    /// <remarks>
    /// TAGS: 1057 1222
    /// <![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/ffc2071e4b7f2d12acc8872998eb9b35011d7a3b/ ]]>
    /// </remarks>
    public static class EPaymentAgentExtension
    {
        public static string ToName(this EPaymentAgent value, bool shortName = true) 
            => EPaymentAgentNames.GetName(value, shortName);
        public static EPaymentAgent ToEPaymentAgent(this string value, bool allowUndefined = false) 
            => EPaymentAgentNames.Parse(value, allowUndefined);
    }
}