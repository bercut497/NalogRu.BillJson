using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NalogRu.BillJson.Models
{
    /// <summary>
    /// предмет расчета
    /// <![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/8e7ceb183bf0386afb086185b6d269fe458ba9c1/ ]]>
    /// </summary>
    /// <remarks>TAGS: 1059</remarks>
    public record JsonItem
    {
        /// <summary>
        /// наименование предмета расчета
        /// </summary>
        /// <remarks>TAGS: 1030</remarks>
        public string Name { get; init; }

        /// <summary>
        /// цена за единицу предмета расчета с учетом скидок и наценок
        /// </summary>
        /// <remarks>TAGS: 1079</remarks>
        public int Price { get; init; }

        /// <summary>
        /// стоимость предмета расчета с учетом скидок и наценок
        /// </summary>
        /// <remarks>TAGS: 1043</remarks>
        public int Sum { get; init; }

        /// <summary>
        /// количество предмета расчета
        /// </summary>
        /// <remarks>TAGS: 1023</remarks>
        public decimal Quantity { get; init; }

        /// <summary>
        /// признак способа расчета
        /// </summary>
        /// <remarks>TAGS: 1214</remarks>
        public EPaymentType EPaymentType { get; init; }

        /// <summary>
        /// признак предмета расчета
        /// </summary>
        /// <remarks>TAGS: 1212</remarks>
        public EProductType? ProductType { get; init; } = Models.EProductType.Undefined;

        /// <summary>
        /// признак агента по предмету расчета
        /// </summary>
        /// <remarks>TAGS: 1222</remarks>
        public EPaymentAgent? PaymentAgentByProductType { get; init; } = EPaymentAgent.Undefined;

        /// <summary>
        /// Единица измерения товара
        /// </summary>
        /// <remarks>TAGS: 1197</remarks>
        public string Unit { get; init; } = string.Empty;

        /// <summary>
        /// код страны происхождения товара
        /// </summary>
        /// <remarks>TAGS: 1230</remarks>
        public string OriginCountryCode { get; init; } = string.Empty;

        /// <summary>
        /// номер таможенной декларации
        /// </summary>
        /// <remarks>TAGS: 1231</remarks>
        public string CustomEntryNum { get; init; } = string.Empty;

        /// <summary>
        /// размер НДС за единицу предмета расчета
        /// </summary>
        /// <remarks>TAGS: 1198</remarks>
        public ulong? UnitNds { get; init; }

        /// <summary>
        /// акциз
        /// </summary>
        /// <remarks>TAGS: 1229</remarks>
        public ulong? ExciseDuty { get; init; }

        /// <summary>
        /// сумма НДС за предмет расчета
        /// </summary>
        /// <remarks>TAGS: 1200</remarks>
        public ulong? NdsSum { get; init; }

        /// <summary>
        /// ставка НДС
        /// </summary>
        /// <remarks>1199</remarks>
        public ENdsType? Nds { get; init; } = ENdsType.Undefined;

        /// <summary>
        /// дополнительный реквизит предмета расчета
        /// </summary>
        /// <remarks>TAGS: 1293 1294</remarks>
        public string PropertiesItem { get; init; } = string.Empty;

        /// <summary>
        /// ИНН поставщика
        /// </summary>
        /// <remarks>TAGS: 1226</remarks>
        public string ProviderInn { get; init; } = string.Empty; // nullable

        public ProductData ProductCodeData { get; init; } = null;

        /// <summary>
        /// код товара (base64)
        /// </summary>
        /// <remarks>
        /// TAGS: 1162
        /// <![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/502084747398056ac2376a4830ea1d528a9e32c1/ ]]>
        /// </remarks>
        public string ProductCode { get; init; } = string.Empty;

        /// <summary>
        /// данные агента
        /// </summary>
        /// <remarks>TAGS: 1223</remarks>
        public PaymentAgentData PaymentAgentData { get; init; } = null;

        /// <summary>
        /// данные поставщика
        /// </summary>
        /// <remarks>TAGS: 1224</remarks>
        public ProviderData ProviderData { get; init; }

        #region custom fields

        public bool IsSumValid() => (int)(Price * Quantity) == Sum;
        public decimal PriceValue => ((decimal)Price) / 100;
        public decimal SumValue => ((decimal)Sum) / 100;

        #endregion
    }
}