using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mach.Banking
{
    [DataContract]
    class AccountStatementResponse
    {
        [DataMember(Name = "accountStatement")]
        public AccountStatement AccountStatement { get; set; }
    }
}
