namespace NalogRu.BillJson.Models
{
    /// <summary>
    /// Значения реквизита "признак способа расчета"
    /// </summary>
    /// <remarks>
    /// TAGS: 1214
    ///<![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/f5f1ab57b729060b906f8beaa1ea6d119c9607a4/ ]]>
    /// </remarks>
    /// <seealso cref="Messages.EPaymentTypeNames"/>
    public enum EPaymentType
    {
        Undefined = 0,
        /// <summary>
        /// Полная предварительная оплата до момента передачи предмета расчета
        /// </summary>
        FullPrepaymentBeforeTransfer = 1,
        /// <summary>
        /// Частичная предварительная оплата до момента передачи предмета расчета
        /// </summary>
        PartialPrepaymentBeforeTransfer = 2,
        /// <summary>
        /// Аванс
        /// </summary>
        Prepayment = 3,
        /// <summary>
        /// Полная оплата, в том числе с учетом аванса (предварительной оплаты) в момент передачи предмета расчета
        /// </summary>
        FullPaymentIncludePrepayment = 4,
        /// <summary>
        /// Частичная оплата предмета расчета в момент его передачи с последующей оплатой в кредит
        /// </summary>
        PartialPaymentWithCreditInFuture = 5,
        /// <summary>
        /// Передача предмета расчета без его оплаты в момент его передачи с последующей оплатой в кредит
        /// </summary>
        TransferWithoutPaymentWithCreditInFuture = 6,
        /// <summary>
        /// Оплата предмета расчета после его передачи с оплатой в кредит (оплата кредита)
        /// </summary>
        CreditPayment = 7,
    }
}