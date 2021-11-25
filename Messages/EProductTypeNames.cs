namespace NalogRu.BillJson.Messages
{
    using Models;
    using System;
    using System.Security.Principal;

    /// <summary>
    /// Значения реквизита "признак предмета расчета" (тег 1212)
    /// в зависимости от сведений, содержащихся в реквизите
    /// "наименование предмета расчета" (тег 1030),
    /// а также формат данных этого реквизита ФД
    /// в печатной форме
    /// </summary>
    /// <remarks>
    /// TAGS: 1212
    ///<![CDATA[ http://www.consultant.ru/document/cons_doc_LAW_362322/06991cb206bc305c3c6fc273b146b19cff730266/ ]]>
    /// </remarks>
    public static class EProductTypeNames
    {
        #region const names

        #region descriptions

        public const string pt_1_description =
            @"о реализуемом товаре, за исключением подакцизного товара (наименование и иные сведения, описывающие товар)";

        public const string pt_2_description =
            @"о реализуемом подакцизном товаре (наименование и иные сведения, описывающие товар)";

        public const string pt_3_description =
            @"о выполняемой работе (наименование и иные сведения, описывающие работу)";

        public const string pt_4_description =
            @"об оказываемой услуге (наименование и иные сведения, описывающие услугу)";

        public const string pt_5_description =
            @"о приеме ставок при осуществлении деятельности по проведению азартных игр";

        public const string pt_6_description =
            @"о выплате денежных средств в виде выигрыша при осуществлении деятельности по проведению азартных игр";

        public const string pt_7_description =
            @"о приеме денежных средств при реализации лотерейных билетов, электронных лотерейных билетов, приеме лотерейных ставок при осуществлении деятельности по проведению лотерей";

        public const string pt_8_description =
            @"о выплате денежных средств в виде выигрыша при осуществлении деятельности по проведению лотерей";

        public const string pt_9_description =
            @"о предоставлении прав на использование результатов интеллектуальной деятельности или средств индивидуализации";

        public const string pt_10_description = @"об авансе, задатке, предоплате и кредите";

        public const string pt_11_description =
            @"о вознаграждении пользователя, являющегося платежным агентом (субагентом), банковским платежным агентом (субагентом), комиссионером, поверенным или иным агентом";

        public const string pt_12_description =
            @"о взносе в счет оплаты пени, штрафе, вознаграждении, бонусе и ином аналогичном предмете расчета";

        public const string pt_13_description =
            @"о предмете расчета, не относящемся к предметам расчета, которым может быть присвоено значение от ""0"" до ""12"" и от ""14"" до ""26""";

        public const string pt_14_description = @"о передаче имущественных прав";
        public const string pt_15_description = @"о внереализационном доходе";

        public const string pt_16_description =
            @"о суммах расходов, уменьшающих сумму налога (авансовых платежей) в соответствии с пунктом 3.1 статьи 346.21 Налогового кодекса Российской Федерации";

        public const string pt_17_description = @"о суммах уплаченного торгового сбора";
        public const string pt_18_description = @"о курортном сборе";
        public const string pt_19_description = @"о залоге";

        public const string pt_20_description =
            @"о суммах произведенных расходов в соответствии со статьей 346.16 Налогового кодекса Российской Федерации, уменьшающих доход";

        public const string pt_21_description =
            @"о страховых взносах на обязательное пенсионное страхование, уплачиваемых ИП, не производящими выплаты и иные вознаграждения физическим лицам";

        public const string pt_22_description =
            @"о страховых взносах на обязательное пенсионное страхование, уплачиваемых организациями и ИП, производящими выплаты и иные вознаграждения физическим лицам";

        public const string pt_23_description =
            @"о страховых взносах на обязательное медицинское страхование, уплачиваемых ИП, не производящими выплаты и иные вознаграждения физическим лицам";

        public const string pt_24_description =
            @"о страховых взносах на обязательное медицинское страхование, уплачиваемые организациями и ИП, производящими выплаты и иные вознаграждения физическим лицам";

        public const string pt_25_description =
            @"о страховых взносах на обязательное социальное страхование на случай временной нетрудоспособности и в связи с материнством, на обязательное социальное страхование от несчастных случаев на производстве и профессиональных заболеваний";

        public const string pt_26_description =
            @"о приеме и выплате денежных средств при осуществлении казино и залами игровых автоматов расчетов с использованием обменных знаков игорного заведения";

        #endregion

        #region long

        public const string pt_1_long = @"ТОВАР";
        public const string pt_2_long = @"ПОДАКЦИЗНЫЙ ТОВАР";
        public const string pt_3_long = @"РАБОТА";
        public const string pt_4_long = @"УСЛУГА";
        public const string pt_5_long = @"СТАВКА АЗАРТНОЙ ИГРЫ";
        public const string pt_6_long = @"ВЫИГРЫШ АЗАРТНОЙ ИГРЫ";
        public const string pt_7_long = @"ЛОТЕРЕЙНЫЙ БИЛЕТ";
        public const string pt_8_long = @"ВЫИГРЫШ ЛОТЕРЕИ";
        public const string pt_9_long = @"ПРЕДОСТАВЛЕНИЕ РИД";
        public const string pt_10_long = @"ПЛАТЕЖ";
        public const string pt_11_long = @"АГЕНТСКОЕ ВОЗНАГРАЖДЕНИЕ";
        public const string pt_12_long = @"ВЫПЛАТА";
        public const string pt_13_long = @"ИНОЙ ПРЕДМЕТ РАСЧЕТА";
        public const string pt_14_long = @"ИМУЩЕСТВЕННОЕ ПРАВО";
        public const string pt_15_long = @"ВНЕРЕАЛИЗАЦИОННЫЙ ДОХОД";
        public const string pt_16_long = @"СТРАХОВЫЕ ВЗНОСЫ";
        public const string pt_17_long = @"ТОРГОВЫЙ СБОР";
        public const string pt_18_long = @"КУРОРТНЫЙ СБОР";
        public const string pt_19_long = @"ЗАЛОГ";
        public const string pt_20_long = @"РАСХОД";
        public const string pt_21_long = @"ВЗНОСЫ НА ОБЯЗАТЕЛЬНОЕ ПЕНСИОННОЕ СТРАХОВАНИЕ ИП";
        public const string pt_22_long = @"ВЗНОСЫ НА ОБЯЗАТЕЛЬНОЕ ПЕНСИОННОЕ СТРАХОВАНИЕ";
        public const string pt_23_long = @"ВЗНОСЫ НА ОБЯЗАТЕЛЬНОЕ МЕДИЦИНСКОЕ СТРАХОВАНИЕ ИП";
        public const string pt_24_long = @"ВЗНОСЫ НА ОБЯЗАТЕЛЬНОЕ МЕДИЦИНСКОЕ СТРАХОВАНИЕ";
        public const string pt_25_long = @"ВЗНОСЫ НА ОБЯЗАТЕЛЬНОЕ СОЦИАЛЬНОЕ СТРАХОВАНИЕ";
        public const string pt_26_long = @"ПЛАТЕЖ КАЗИНО";

        #endregion

        #region short

        public const string pt_1_short = @"Т";
        public const string pt_2_short = @"АТ";
        public const string pt_3_short = @"Р";
        public const string pt_4_short = @"У";
        public const string pt_5_short = @"СТАВКА ИГРЫ";
        public const string pt_6_short = @"ВЫИГРЫШ АИ";
        public const string pt_7_short = @"СТАВКА ЛОТЕРЕИ";
        public const string pt_8_short = @"ВЛ";
        public const string pt_9_short = @"РИД";
        public const string pt_10_short = @"П";
        public const string pt_11_short = @"АВ";
        public const string pt_12_short = @"В";
        public const string pt_13_short = @"ИПР";
        public const string pt_14_short = "";
        public const string pt_15_short = "";
        public const string pt_16_short = "";
        public const string pt_17_short = "";
        public const string pt_18_short = "";
        public const string pt_19_short = "";
        public const string pt_20_short = "";
        public const string pt_21_short = @"ВЗНОСЫ НА ОПС ИП";
        public const string pt_22_short = @"ВЗНОСЫ НА ОПС";
        public const string pt_23_short = @"ВЗНОСЫ НА ОМС ИП";
        public const string pt_24_short = @"ВЗНОСЫ НА ОМС";
        public const string pt_25_short = @"ВЗНОСЫ НА ОСС";
        public const string pt_26_short = @"ПК";

        #endregion

        #endregion

        public static string GetLetterCode(EProductType value)
        {
            return value switch
            {
                EProductType.Type01 => pt_1_short,
                EProductType.Type02 => pt_2_short,
                EProductType.Type03 => pt_3_short,
                EProductType.Type04 => pt_4_short,
                EProductType.Type05 => pt_5_short,
                EProductType.Type06 => pt_6_short,
                EProductType.Type07 => pt_7_short,
                EProductType.Type08 => pt_8_short,
                EProductType.Type09 => pt_9_short,
                EProductType.Type10 => pt_10_short,
                EProductType.Type11 => pt_11_short,
                EProductType.Type12 => pt_12_short,
                EProductType.Type13 => pt_13_short,
                EProductType.Type14 => pt_14_short,
                EProductType.Type15 => pt_15_short,
                EProductType.Type16 => pt_16_short,
                EProductType.Type17 => pt_17_short,
                EProductType.Type18 => pt_18_short,
                EProductType.Type19 => pt_19_short,
                EProductType.Type20 => pt_20_short,
                EProductType.Type21 => pt_21_short,
                EProductType.Type22 => pt_22_short,
                EProductType.Type23 => pt_23_short,
                EProductType.Type24 => pt_24_short,
                EProductType.Type25 => pt_25_short,
                EProductType.Type26 => pt_26_short,
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }

        public static string GetName(EProductType value, bool shortName = true)
        {
            return value switch
            {
                EProductType.Type01 => shortName ? pt_1_short : pt_1_long,
                EProductType.Type02 => shortName ? pt_2_short : pt_2_long,
                EProductType.Type03 => shortName ? pt_3_short : pt_3_long,
                EProductType.Type04 => shortName ? pt_4_short : pt_4_long,
                EProductType.Type05 => shortName ? pt_5_short : pt_5_long,
                EProductType.Type06 => shortName ? pt_6_short : pt_6_long,
                EProductType.Type07 => shortName ? pt_7_short : pt_7_long,
                EProductType.Type08 => shortName ? pt_8_short : pt_8_long,
                EProductType.Type09 => shortName ? pt_9_short : pt_9_long,
                EProductType.Type10 => shortName ? pt_10_short : pt_10_long,
                EProductType.Type11 => shortName ? pt_11_short : pt_11_long,
                EProductType.Type12 => shortName ? pt_12_short : pt_12_long,
                EProductType.Type13 => shortName ? pt_13_short : pt_13_long,
                EProductType.Type14 => shortName ? pt_14_short : pt_14_long,
                EProductType.Type15 => shortName ? pt_15_short : pt_15_long,
                EProductType.Type16 => shortName ? pt_16_short : pt_16_long,
                EProductType.Type17 => shortName ? pt_17_short : pt_17_long,
                EProductType.Type18 => shortName ? pt_18_short : pt_18_long,
                EProductType.Type19 => shortName ? pt_19_short : pt_19_long,
                EProductType.Type20 => shortName ? pt_20_short : pt_20_long,
                EProductType.Type21 => shortName ? pt_21_short : pt_21_long,
                EProductType.Type22 => shortName ? pt_22_short : pt_22_long,
                EProductType.Type23 => shortName ? pt_23_short : pt_23_long,
                EProductType.Type24 => shortName ? pt_24_short : pt_24_long,
                EProductType.Type25 => shortName ? pt_25_short : pt_25_long,
                EProductType.Type26 => shortName ? pt_26_short : pt_26_long,
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }

        public static EProductType Parse(string value, bool allowUndefined = false)
        {
            return value switch
            {
                pt_1_short => EProductType.Type01,
                pt_1_long => EProductType.Type01,
                pt_1_description => EProductType.Type01,
                pt_2_short => EProductType.Type02,
                pt_2_long => EProductType.Type02,
                pt_2_description => EProductType.Type02,
                pt_3_short => EProductType.Type03,
                pt_3_long => EProductType.Type03,
                pt_3_description => EProductType.Type03,
                pt_4_short => EProductType.Type04,
                pt_4_long => EProductType.Type04,
                pt_4_description => EProductType.Type04,
                pt_5_short => EProductType.Type05,
                pt_5_long => EProductType.Type05,
                pt_5_description => EProductType.Type05,
                pt_6_short => EProductType.Type06,
                pt_6_long => EProductType.Type06,
                pt_6_description => EProductType.Type06,
                pt_7_short => EProductType.Type07,
                pt_7_long => EProductType.Type07,
                pt_7_description => EProductType.Type07,
                pt_8_short => EProductType.Type08,
                pt_8_long => EProductType.Type08,
                pt_8_description => EProductType.Type08,
                pt_9_short => EProductType.Type09,
                pt_9_long => EProductType.Type09,
                pt_9_description => EProductType.Type09,
                pt_10_short => EProductType.Type10,
                pt_10_long => EProductType.Type10,
                pt_10_description => EProductType.Type10,
                pt_11_short => EProductType.Type11,
                pt_11_long => EProductType.Type11,
                pt_11_description => EProductType.Type11,
                pt_12_short => EProductType.Type12,
                pt_12_long => EProductType.Type12,
                pt_12_description => EProductType.Type12,
                pt_13_short => EProductType.Type13,
                pt_13_long => EProductType.Type13,
                pt_13_description => EProductType.Type13,
                //pt_14_short => EProductType.Type14,
                pt_14_long => EProductType.Type14,
                pt_14_description => EProductType.Type14,
                //pt_15_short => EProductType.Type15,
                pt_15_long => EProductType.Type15,
                pt_15_description => EProductType.Type15,
                //pt_16_short => EProductType.Type16,
                pt_16_long => EProductType.Type16,
                pt_16_description => EProductType.Type16,
                //pt_17_short => EProductType.Type17,
                pt_17_long => EProductType.Type17,
                pt_17_description => EProductType.Type17,
                //pt_18_short => EProductType.Type18,
                pt_18_long => EProductType.Type18,
                pt_18_description => EProductType.Type18,
                //pt_19_short => EProductType.Type19,
                pt_19_long => EProductType.Type19,
                pt_19_description => EProductType.Type19,
                //pt_20_short => EProductType.Type20,
                pt_20_long => EProductType.Type20,
                pt_20_description => EProductType.Type20,
                pt_21_short => EProductType.Type21,
                pt_21_long => EProductType.Type21,
                pt_21_description => EProductType.Type21,
                pt_22_short => EProductType.Type22,
                pt_22_long => EProductType.Type22,
                pt_22_description => EProductType.Type22,
                pt_23_short => EProductType.Type23,
                pt_23_long => EProductType.Type23,
                pt_23_description => EProductType.Type23,
                pt_24_short => EProductType.Type24,
                pt_24_long => EProductType.Type24,
                pt_24_description => EProductType.Type24,
                pt_25_short => EProductType.Type25,
                pt_25_long => EProductType.Type25,
                pt_25_description => EProductType.Type25,
                pt_26_short => EProductType.Type26,
                pt_26_long => EProductType.Type26,
                pt_26_description => EProductType.Type26,
                _ => allowUndefined
                    ? EProductType.Undefined
                    : throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }
    }
}