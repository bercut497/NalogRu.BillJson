using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NalogRu.BillJson.Models
{
    public abstract record MinimalBillInfo : IMinimalBillInfo
    {
        public abstract string LocalDateTime { get; init; }
        public abstract long DateTime { get; init;}
        public abstract long FiscalDriveNumber { get;init; }
        public abstract long FiscalDocumentNumber { get; init;}
        public abstract long FiscalSign { get; init;}
        public abstract EOperationType EOperationType { get;init; }
        public abstract ulong TotalSum { get; init;}

        private const string PkKeyFormat = @"{0}:";

        private string CalculatePkId => new StringBuilder()
            .AppendFormat(PkKeyFormat, DateTime.ToString())
            .AppendFormat(PkKeyFormat, FiscalDriveNumber.ToString())
            .AppendFormat(PkKeyFormat, FiscalDocumentNumber.ToString())
            .AppendFormat(PkKeyFormat, FiscalSign.ToString())
            .Append((int)EOperationType)
            .ToString();
        
        private string _pkIdCache = null;

        public string Pkid => _pkIdCache ??= CalculatePkId;

        private const string LocalTimeFormat = @"t={0}";
        private const string TotalSumFormat = @"s={0:######0.00}";
        private const string FiscalDriveNumberFormat = @"fn={0}";
        private const string FiscalDocIndexFormat = @"i={0}";
        private const string FiscalPrintSignFormat = @"fp={0}";
        private const string OperationTypeFormat = @"n={0}";

        private string CalculateQrUrl =>
            new StringBuilder()
                .AppendFormat(LocalTimeFormat, LocalDateTime)
                .AppendFormat(TotalSumFormat, (((decimal)TotalSum) / 100).ToString(CultureInfo.InvariantCulture))
                .AppendFormat(FiscalDriveNumberFormat, FiscalDriveNumber.ToString())
                .AppendFormat(FiscalDocIndexFormat, FiscalDocumentNumber.ToString())
                .AppendFormat(FiscalPrintSignFormat, FiscalSign.ToString())
                .AppendFormat(OperationTypeFormat, ((int)EOperationType).ToString())
                .ToString();

        private string _qrCache = null;

        public string QrUrl => _qrCache ??= CalculateQrUrl;
        //"t=20190320T2303&s=5803.00&fn=9251440300007971&i=141637&fp=4087570038&n=1
        
        public DateTime UtcDateTimeValue 
            => new DateTime(1970, 01, 01, 0, 0, 0, 0, DateTimeKind.Utc)
                .AddSeconds(DateTime);

        private static readonly TimeZoneInfo RussianTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
        public DateTime RussianDateTimeValue 
            => TimeZoneInfo.ConvertTimeFromUtc(UtcDateTimeValue, RussianTimeZone);
    }
}