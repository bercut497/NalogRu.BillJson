using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NalogRu.BillJson.Models
{
    public record JsonBill : MinimalBillInfo
    {
        /// <summary>
        /// наименование пользователя
        /// </summary>
        /// <remarks>TAGS: 1048</remarks>
        public string User { get; init; } = string.Empty;

        /// <summary>
        /// адрес расчетов
        /// </summary>
        /// <remarks>TAGS: 1009</remarks>
        public string RetailPlaceAddress { get; init; } = string.Empty;

        /// <summary>
        /// ИНН пользователя
        /// </summary>
        /// <remarks>TAGS: 1018</remarks>
        public ulong? UserInn { get; init; } = null;

        /// <summary>
        /// покупатель (клиент)
        /// </summary>
        /// <remarks>TAGS: 1227</remarks>
        public string Buyer { get; init; } = string.Empty;

        /// <summary>
        /// ИНН покупателя (клиента)
        /// </summary>
        /// <remarks>TAGS: 1228</remarks>
        public ulong? BuyerInn { get; init; } = null;

        /// <summary>
        /// номер чека за смену
        /// </summary>
        /// <remarks>TAGS 1042</remarks>
        public long RequestNumber { get; init; }

        /// <summary>
        /// номер смены
        /// </summary>
        /// <remarks>TAGS 1038</remarks>
        public long ShiftNumber { get; init; }

        /// <summary>
        /// кассир
        /// </summary>
        /// <remarks>TAGS: 1021</remarks>
        public string Operator { get; init; } = string.Empty;

        /// <summary>
        /// сумма по чеку (БСО) наличными
        /// </summary>
        /// <remarks>TAGS: 1031</remarks>
        public ulong CashTotalSum { get; init; }

        /// <summary>
        /// сумма по чеку (БСО) безналичными
        /// </summary>
        /// <remarks>TAGS: 1081</remarks>
        public ulong ECashTotalSum { get; init; }

        /// <summary>
        /// регистрационный номер ККТ
        /// </summary>
        /// <remarks>TAGS: 1037</remarks>
        public long KktRegId { get; init; }

        /// <summary>
        /// предмет расчета
        /// </summary>
        /// <remarks>TAGS: 1059</remarks>
        public IReadOnlyCollection<JsonItem> Items { get; init; } = new Collection<JsonItem>();

        /// <summary>
        /// сумма расчета по чеку без НДС
        /// </summary>
        /// <remarks>TAGS: 1105</remarks>
        public long? NdsNo { get; init; }

        /// <summary>
        /// сумма НДС чека по ставке 20%
        /// </summary>
        /// <remarks>TAGS: 1102</remarks>
        public long? Nds18 { get; init; }

        /// <summary>
        /// сумма НДС чека по ставке 10%
        /// </summary>
        /// <remarks>TAGS: 1103</remarks>
        public long? Nds10 { get; init; }

        /// <summary>
        /// сумма расчета по чеку с НДС по ставке 0%
        /// </summary>
        /// <remarks>TAGS: 1104</remarks>
        public long? Nds0 { get; init; }

        /// <summary>
        /// сумма НДС чека по расч. ставке 20/120
        /// </summary>
        /// <remarks>TAGS: 1106</remarks>
        public long? Nds18118 { get; init; }

        /// <summary>
        /// сумма НДС чека по расч. ставке 10/110
        /// </summary>
        /// <remarks>TAGS: 1107</remarks>
        public long? Nds10110 { get; init; }

        /// <summary>
        /// Код документа
        /// </summary>
        /// <remarks>TAGS: 3, 4, 103</remarks>
        public ECodeType Code { get; init; } = ECodeType.Undefined;

        /// <summary>
        /// номер версии ФФД (CONST 2)
        /// </summary>
        /// <remarks>TAGS: 1209</remarks>
        public int FiscalDocumentFormatVer { get; init; }

        /// <summary>
        /// номер автомата
        /// </summary>
        /// <remarks>TAGS: 1036</remarks>
        public string MachineNumber { get; init; } = string.Empty;

        /// <summary>
        /// ИНН кассира
        /// </summary>
        /// <remarks>TAGS: 1203</remarks>
        public ulong? OperatorInn { get; init; } = null;

        /// <summary>
        /// место расчетов
        /// </summary>
        /// <remarks>TAGS: 1187</remarks>
        public string RetailPlace { get; init; }

        /// <summary>
        /// телефон или электронный адрес покупателя
        /// </summary>
        /// <remarks>TAGS: 1008</remarks>
        public string BuyerPhoneOrAddress { get; init; } = string.Empty;

        /// <summary>
        /// признак ККТ для расчетов только в Интернет
        /// </summary>
        /// <remarks>TAGS: 1108</remarks>
        public bool? InternetSign { get; init; } = null;

        /// <summary>
        /// адрес электронной почты отправителя чека
        /// </summary>
        /// <remarks>TAGS: 1117</remarks>
        public string SellerAddress { get; init; } = string.Empty;

        /// <summary>
        /// признак агента
        /// </summary>
        /// <remarks>TAGS: 1057</remarks>
        public EPaymentAgent PaymentAgentType { get; init; }

        /// <summary>
        /// сумма по чеку (БСО) предоплатой (зачетом аванса и (или) предыдущих платежей)
        /// </summary>
        /// <remarks>TAGS: 1215</remarks>
        public ulong PrepaidSum { get; init; }

        /// <summary>
        /// сумма по чеку (БСО) постоплатой (в кредит)
        /// </summary>
        /// <remarks>TAGS: 1216</remarks>
        public ulong CreditSum { get; init; }

        /// <summary>
        /// сумма по чеку (БСО) встречным предоставлением
        /// </summary>
        /// <remarks>TAGS: 1217</remarks>
        public ulong ProvisionSum { get; init; }

        /// <summary>
        /// применяемая система налогообложения
        /// </summary>
        /// <remarks>TAGS 1055</remarks>
        public EAppliedTaxationType TaxationType { get; init; }

        public override string LocalDateTime { get; init; }

        /// <summary>
        /// дата, время (UnixTime)
        /// </summary>
        /// <remarks>TAGS 1012</remarks>
        public override long DateTime { get; init; }

        /// <summary>
        /// номер ФН
        /// </summary>
        /// <remarks>
        /// TAGS: 1041
        /// param 'fn' as fiscal number in QR
        /// </remarks>
        public override long FiscalDriveNumber { get; init; }

        /// <summary>
        /// номер ФД
        /// </summary>
        /// <remarks>
        /// TAGS: 1040
        /// param 'i' as index in QR
        /// </remarks>
        public override long FiscalDocumentNumber { get; init; }

        /// <summary>
        /// фискальный признак документа
        /// </summary>
        /// <remarks>
        /// TAGS: 1077
        /// param 'fp' as fiscal print in QR
        /// </remarks>
        public override long FiscalSign { get; init; }

        /// <summary>
        /// признак расчета (1..4)
        /// </summary>
        /// <remarks>TAGS 1054</remarks>
        public override EOperationType EOperationType { get; init; }

        /// <summary>
        /// сумма расчета, указанного в чеке (БСО)
        /// </summary>
        /// <remarks>TAGS: 1020</remarks>
        public override ulong TotalSum { get; init; }

        /// <summary>
        /// телефон оператора перевода
        /// </summary>
        /// <remarks>TAGS: 1075</remarks>
        public IReadOnlyCollection<string> TransferOperatorPhone { get; init; } = new List<string>();

        /// <summary>
        /// операция платежного агента
        /// </summary>
        /// <remarks>TAGS: 1044</remarks>
        public string PaymentAgentOperation { get; init; } = String.Empty;

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
        /// наименование оператора перевода
        /// </summary>
        /// <remarks>TAGS: 1026</remarks>
        public string TransferOperatorName { get; init; } = String.Empty;

        /// <summary>
        /// адрес оператора перевода
        /// </summary>
        /// <remarks>TAGS: 1005</remarks>
        public string TransferOperatorAddress { get; init; } = String.Empty;

        /// <summary>
        /// ИНН оператора перевода
        /// </summary>
        /// <remarks>TAGS: 1016</remarks>
        public ulong? TransferOperatorInn { get; init; } = null;

        /// <summary>
        /// телефон поставщика
        /// </summary>
        /// <remarks>TAGS: 1071</remarks>
        public IReadOnlyCollection<string> ProviderPhone { get; init; } = new List<string>();

        private string _fnsUrl { get; init; } = String.Empty;

        /// <summary>
        /// адрес сайта ФНС
        /// </summary>
        /// <remarks>TAGS: 1060</remarks>
        public string FnsUrl { get => _fnsUrl; init => _fnsUrl = value; }
        public string Url { get => _fnsUrl; init => _fnsUrl = value; }
        public string FnsSiteUrl { get => _fnsUrl; init => _fnsUrl = value; }

        /// <summary>
        /// дополнительный реквизит чека (БСО)
        /// </summary>
        /// <remarks>TAGS: 1192</remarks>
        public string PropertiesData { get; init; } = String.Empty;

        /// <summary>
        /// дополнительный реквизит пользователя
        /// </summary>
        /// <remarks>TAGS: 1084</remarks>
        public IReadOnlyCollection<Properties> Properties { get; init; } = new List<Properties>();
    }
}