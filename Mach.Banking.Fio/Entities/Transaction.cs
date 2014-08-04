using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Mach.Banking.Fio
{

    [DataContract]
    public partial class Transaction
    {
        private TransactionItem[] _items;

        [FioColumn(Name = "ID pohybu")]
        public long Id { get; set; }
        [FioColumn(Name = "Datum")]
        public DateTime Date { get; set; }
        [FioColumn(Name = "Měna")]
        public string Currency { get; set; }
        [FioColumn(Name = "Objem")]
        public decimal Amount { get; set; }
        [FioColumn(Name = "Protiúčet")]
        public string AccountNumber { get; set; }
        [FioColumn(Name = "Název protiúčtu")]
        public string AccountName { get; set; }
        [FioColumn(Name = "Kód banky")]
        public string AccountBank { get; set; }
        [FioColumn(Name = "Název banky")]
        public string BankName { get; set; }
        [FioColumn(Name = "KS")]
        public int ConstantSymbol { get; set; }
        [FioColumn(Name = "VS")]
        public int VariableSymbol { get; set; }
        [FioColumn(Name = "SS")]
        public int SpecificSymbol { get; set; }
        [FioColumn(Name = "Uživatelská identifkace")]
        public string UserIdentification { get; set; }
        [FioColumn(Name = "Zpráva pro příjemce")]
        public string NoteForRecipient { get; set; }
        [FioColumn(Name = "Typ")]
        public string Type { get; set; }
        [FioColumn(Name = "Provedl")]
        public string User { get; set; }

        private void Initialize()
        {
            _items = new TransactionItem[27];
        }

        public Transaction()
        {
            Initialize();
        }

        private TransactionItem GetColumn(int index)
        {
            return _items.Length > index ? _items[index] : null;
        }

        private bool SetColumn(int index, TransactionItem item)
        {
            if (_items.Length > index)
            {
                _items[index] = item;
                return true;
            }

            return false;
        }
    }
}
