using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mach.Banking.Fio
{
    [System.AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class FioColumnAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
