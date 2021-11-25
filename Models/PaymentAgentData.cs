using System.Collections.Generic;

namespace NalogRu.BillJson.Models
{
    /// <summary>
    /// Значения реквизита "данные агента"
    /// </summary>
    /// <remarks>
    /// TAGS: 1223
    /// <![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/4f73d10f460d4c986eb5c8358f362137456be730/ ]]>
    /// </remarks>
    public class PaymentAgentData
    {
        /// <summary>
        /// телефон оператора перевода
        /// </summary>
        /// <remarks>TAGS: 1075</remarks>
        public IReadOnlyCollection<string> TransferOperatorPhone { get; init; } = new List<string>();

        /// <summary>
        /// оператора перевода
        /// </summary>
        /// <remarks>TAGS: 1026</remarks>
        public string TransferOperatorName { get; init; } = string.Empty;

        /// <summary>
        /// операция банковского платежного агента
        /// </summary>
        /// <remarks>TAGS: 1044</remarks>
        public string PaymentAgentOperation { get; init; } = string.Empty;

        /// <summary>
        /// телефон платежного агента
        /// </summary>
        /// <remarks>TAGS: 1073</remarks>
        public IReadOnlyCollection<string> PaymentAgentPhone { get; init; } = new List<string>();

        /// <summary>
        /// телефон оператора по приему платежей
        /// </summary>
        /// <remarks>TAGS: 1074</remarks>
        public IReadOnlyCollection<string> PaymentOperatorPhone { get; init; } = new List<string>();
        
        /// <summary>
        /// адрес оператора перевода
        /// </summary>
        /// <remarks>TAGS: 1005</remarks>
        public string TransferOperatorAddress { get; init; } = string.Empty;

        /// <summary>
        /// ИНН оператора перевода
        /// </summary>
        /// <remarks>TAGS: 1016</remarks>
        public ulong? TransferOperatorInn { get; init; } = null;
        
    }
}