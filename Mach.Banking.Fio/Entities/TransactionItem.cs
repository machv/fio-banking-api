using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Mach.Banking.Fio
{
    [DataContract]
    public class TransactionItem
    {
        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}
