using System;

namespace NalogRu.BillJson.Models
{
    public interface IMinimalBillInfo
    {
        public string LocalDateTime { get; }
        public long DateTime { get; }
        public long FiscalDriveNumber { get; }
        public long FiscalDocumentNumber { get; }
        public long FiscalSign { get; }
        public EOperationType EOperationType { get; }
        public ulong TotalSum { get; }
    }
}