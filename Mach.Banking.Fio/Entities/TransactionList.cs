using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Mach.Banking.Fio
{
    [DataContract]
    public class TransactionList
    {
        [DataMember(Name = "transaction")]
        public List<Transaction> Transactions { get; set; }
    }
}
