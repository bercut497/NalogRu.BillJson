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
    public static class EPaymentAgentNames
    {
        #region consts

        #region long

        public const string long_0 =
            "Оказание услуг покупателю (клиенту) пользователем, являющимся банковским платежным агентом";

        public const string long_1 =
            "Оказание услуг покупателю (клиенту) пользователем, являющимся банковским платежным субагентом";

        public const string long_2 = "Оказание услуг покупателю (клиенту) пользователем, являющимся платежным агентом";

        public const string long_3 =
            "Оказание услуг покупателю (клиенту) пользователем, являющимся платежным субагентом";

        public const string long_4 =
            "Осуществление расчета с покупателем (клиентом) пользователем, являющимся поверенным";

        public const string long_5 =
            "Осуществление расчета с покупателем (клиентом) пользователем, являющимся комиссионером";

        public const string long_6 =
            "Осуществление расчета с покупателем (клиентом) пользователем, являющимся агентом и не являющимся банковским платежным агентом (субагентом), платежным агентом (субагентом), поверенным, комиссионером";

        #endregion

        #region short

        public const string short_0 = "БАНК. ПЛ. АГЕНТ";
        public const string short_1 = "БАНК. ПЛ. СУБАГЕНТ";
        public const string short_2 = "ПЛ. АГЕНТ";
        public const string short_3 = "ПЛ. СУБАГЕНТ";
        public const string short_4 = "ПОВЕРЕННЫЙ";
        public const string short_5 = "КОМИССИОНЕР";
        public const string short_6 = "АГЕНТ";

        #endregion

        #endregion

        public static string GetName(EPaymentAgent value, bool shortName = true)
        {
            return value switch
            {
                EPaymentAgent.type01 => shortName ? short_0 : long_0,
                EPaymentAgent.type02 => shortName ? short_1 : long_1,
                EPaymentAgent.type04 => shortName ? short_2 : long_2,
                EPaymentAgent.type08 => shortName ? short_3 : long_3,
                EPaymentAgent.type16 => shortName ? short_4 : long_4,
                EPaymentAgent.type32 => shortName ? short_5 : long_5,
                EPaymentAgent.type64 => shortName ? short_6 : long_6,
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }

        public static EPaymentAgent Parse(string value, bool allowUndefined = false)
        {
            return value switch
            {
                short_0 => EPaymentAgent.type01,
                long_0 => EPaymentAgent.type01,
                short_1 => EPaymentAgent.type02,
                long_1 => EPaymentAgent.type02,
                short_2 => EPaymentAgent.type04,
                long_2 => EPaymentAgent.type04,
                short_3 => EPaymentAgent.type08,
                long_3 => EPaymentAgent.type08,
                short_4 => EPaymentAgent.type16,
                long_4 => EPaymentAgent.type16,
                short_5 => EPaymentAgent.type32,
                long_5 => EPaymentAgent.type32,
                short_6 => EPaymentAgent.type64,
                long_6 => EPaymentAgent.type64,
                _ => allowUndefined
                    ? EPaymentAgent.Undefined
                    : throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }
    }
}