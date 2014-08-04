using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mach.Banking
{
    [DataContract]
    public class AccountStatement
    {
        [DataMember(Name = "info")]
        public AccountStatementInfo Info { get; set; }
    }
}
