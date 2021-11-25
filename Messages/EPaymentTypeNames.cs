using System;

namespace NalogRu.BillJson.Messages
{
    using Models;

    /// <summary>
    /// Значения реквизита "признак способа расчета" (тег 1214)
    /// и перечень оснований для присвоения соответствующих значений реквизиту,
    /// а также формат данных этого реквизита ФД в печатной форме
    /// </summary>
    /// <remarks>
    /// TAGS: 1214
    /// <![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/f5f1ab57b729060b906f8beaa1ea6d119c9607a4/ ]]>
    /// </remarks>
    public static class EPaymentTypeNames
    {
        #region Const Names

        public const string FULL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_LONG =
            @"Полная предварительная оплата до момента передачи предмета расчета";

        public const string FULL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_SHORT = @"ПРЕДОПЛАТА 100%";


        public const string PARTIAL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_LONG =
            @"Частичная предварительная оплата до момента передачи предмета расчета";

        public const string PARTIAL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_SHORT = @"ПРЕДОПЛАТА";

        public const string PREPAYMENT_LONG = @"Аванс";
        public const string PREPAYMENT_SHORT = @"АВАНС";

        public const string FULL_PAYMENT_INCLUDE_PREPAYMENT_LONG =
            @"Полная оплата, в том числе с учетом аванса (предварительной оплаты) в момент передачи предмета расчета";

        public const string FULL_PAYMENT_INCLUDE_PREPAYMENT_SHORT = @"ПОЛНЫЙ РАСЧЕТ";

        public const string PARTIAL_PAYMENT_WITH_CREDIT_IN_FUTURE_LONG =
            @"Частичная оплата предмета расчета в момент его передачи с последующей оплатой в кредит";

        public const string PARTIAL_PAYMENT_WITH_CREDIT_IN_FUTURE_SHORT = @"ЧАСТИЧНЫЙ РАСЧЕТ И КРЕДИТ";

        public const string OBJECT_TRANSFER_WITHOUT_PAYMENT_WITH_CREDIT_IN_FUTURE_LONG =
            @"Передача предмета расчета без его оплаты в момент его передачи с последующей оплатой в кредит";

        public const string OBJECT_TRANSFER_WITHOUT_PAYMENT_WITH_CREDIT_IN_FUTURE_SHORT = @"ПЕРЕДАЧА В КРЕДИТ";


        public const string CREDIT_PAYMENT_LONG =
            @"Оплата предмета расчета после его передачи с оплатой в кредит (оплата кредита)";

        public const string CREDIT_PAYMENT_SHORT = @"ОПЛАТА КРЕДИТА";

        #endregion

        public static string GetName(EPaymentType value, bool shortName = true)
        {
            return value switch
            {
                EPaymentType.FullPrepaymentBeforeTransfer => shortName
                    ? FULL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_SHORT
                    : FULL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_LONG,
                EPaymentType.PartialPrepaymentBeforeTransfer => shortName
                    ? PARTIAL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_SHORT
                    : PARTIAL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_LONG,
                EPaymentType.Prepayment => shortName
                    ? PREPAYMENT_SHORT
                    : PREPAYMENT_LONG,
                EPaymentType.FullPaymentIncludePrepayment => shortName
                    ? FULL_PAYMENT_INCLUDE_PREPAYMENT_SHORT
                    : FULL_PAYMENT_INCLUDE_PREPAYMENT_LONG,
                EPaymentType.PartialPaymentWithCreditInFuture => shortName
                    ? PARTIAL_PAYMENT_WITH_CREDIT_IN_FUTURE_SHORT
                    : PARTIAL_PAYMENT_WITH_CREDIT_IN_FUTURE_LONG,
                EPaymentType.TransferWithoutPaymentWithCreditInFuture => shortName
                    ? OBJECT_TRANSFER_WITHOUT_PAYMENT_WITH_CREDIT_IN_FUTURE_SHORT
                    : OBJECT_TRANSFER_WITHOUT_PAYMENT_WITH_CREDIT_IN_FUTURE_LONG,
                EPaymentType.CreditPayment => shortName
                    ? CREDIT_PAYMENT_SHORT
                    : CREDIT_PAYMENT_LONG,
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }

        public static EPaymentType Parse(string value, bool allowUndefined = false)
        {
            return value switch
            {
                FULL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_SHORT => EPaymentType.FullPrepaymentBeforeTransfer,
                FULL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_LONG => EPaymentType.FullPrepaymentBeforeTransfer,
                PARTIAL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_SHORT => EPaymentType.PartialPrepaymentBeforeTransfer,
                PARTIAL_PREPAYMENT_BEFORE_OBJECT_TRANSFER_LONG => EPaymentType.PartialPrepaymentBeforeTransfer,
                PREPAYMENT_SHORT => EPaymentType.Prepayment,
                PREPAYMENT_LONG => EPaymentType.Prepayment,
                FULL_PAYMENT_INCLUDE_PREPAYMENT_SHORT => EPaymentType.FullPaymentIncludePrepayment,
                FULL_PAYMENT_INCLUDE_PREPAYMENT_LONG => EPaymentType.FullPaymentIncludePrepayment,
                PARTIAL_PAYMENT_WITH_CREDIT_IN_FUTURE_SHORT => EPaymentType.PartialPaymentWithCreditInFuture,
                PARTIAL_PAYMENT_WITH_CREDIT_IN_FUTURE_LONG => EPaymentType.PartialPaymentWithCreditInFuture,
                OBJECT_TRANSFER_WITHOUT_PAYMENT_WITH_CREDIT_IN_FUTURE_SHORT => EPaymentType
                    .TransferWithoutPaymentWithCreditInFuture,
                OBJECT_TRANSFER_WITHOUT_PAYMENT_WITH_CREDIT_IN_FUTURE_LONG => EPaymentType
                    .TransferWithoutPaymentWithCreditInFuture,
                CREDIT_PAYMENT_SHORT => EPaymentType.CreditPayment,
                CREDIT_PAYMENT_LONG => EPaymentType.CreditPayment,
                _ => allowUndefined
                    ? EPaymentType.Undefined
                    : throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }
    }
}