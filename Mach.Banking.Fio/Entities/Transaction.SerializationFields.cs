using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Mach.Banking.Fio
{
    public partial class Transaction
    {
        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            Initialize();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Dictionary<string, PropertyInfo> fields = new Dictionary<string, PropertyInfo>();

            PropertyInfo[] properties = typeof(Transaction).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object[] attributes = property.GetCustomAttributes(typeof(FioColumnAttribute), false);
                if (attributes.Length > 0)
                {
                    FioColumnAttribute attr = attributes[0] as FioColumnAttribute;

                    fields.Add(attr.Name, property);
                }
            }

            foreach (TransactionItem item in _items)
            {
                if (item == null)
                    continue;

                if (fields.ContainsKey(item.Name))
                {
                    PropertyInfo info = fields[item.Name];

                    if (info.PropertyType == typeof(long))
                    {
                        long value = long.Parse(item.Value);
                        info.SetValue(this, value, null);
                    }

                    if (info.PropertyType == typeof(decimal))
                    {
                        decimal value = decimal.Parse(item.Value, CultureInfo.InvariantCulture);
                        info.SetValue(this, value, null);
                    }

                    if (info.PropertyType == typeof(string))
                    {
                        info.SetValue(this, item.Value, null);
                    }

                    if (info.PropertyType == typeof(DateTime))
                    {
                        DateTime date = DateTime.ParseExact(item.Value.Substring(0, item.Value.IndexOf("+")), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        info.SetValue(this, date, null);
                    }

                    string name = item.Name;
                }
            }
        }

        [DataMember(Name = "column0")]
        private TransactionItem column0
        {
            get { return GetColumn(0); }
            set { SetColumn(0, value); }
        }
        [DataMember(Name = "column1")]
        private TransactionItem column1
        {
            get { return GetColumn(1); }
            set { SetColumn(1, value); }
        }
        [DataMember(Name = "column2")]
        private TransactionItem column2
        {
            get { return GetColumn(2); }
            set { SetColumn(2, value); }
        }
        [DataMember(Name = "column3")]
        private TransactionItem column3
        {
            get { return GetColumn(3); }
            set { SetColumn(3, value); }
        }
        [DataMember(Name = "column4")]
        private TransactionItem column4
        {
            get { return GetColumn(4); }
            set { SetColumn(4, value); }
        }
        [DataMember(Name = "column5")]
        private TransactionItem column5
        {
            get { return GetColumn(5); }
            set { SetColumn(5, value); }
        }
        [DataMember(Name = "column6")]
        private TransactionItem column6
        {
            get { return GetColumn(6); }
            set { SetColumn(6, value); }
        }
        [DataMember(Name = "column7")]
        private TransactionItem column7
        {
            get { return GetColumn(7); }
            set { SetColumn(7, value); }
        }
        [DataMember(Name = "column8")]
        private TransactionItem column8
        {
            get { return GetColumn(8); }
            set { SetColumn(8, value); }
        }
        [DataMember(Name = "column9")]
        private TransactionItem column9
        {
            get { return GetColumn(9); }
            set { SetColumn(9, value); }
        }
        [DataMember(Name = "column10")]
        private TransactionItem column10
        {
            get { return GetColumn(10); }
            set { SetColumn(10, value); }
        }
        [DataMember(Name = "column11")]
        private TransactionItem column11
        {
            get { return GetColumn(11); }
            set { SetColumn(11, value); }
        }
        [DataMember(Name = "column12")]
        private TransactionItem column12
        {
            get { return GetColumn(12); }
            set { SetColumn(12, value); }
        }
        [DataMember(Name = "column13")]
        private TransactionItem column13
        {
            get { return GetColumn(13); }
            set { SetColumn(13, value); }
        }
        [DataMember(Name = "column14")]
        private TransactionItem column14
        {
            get { return GetColumn(14); }
            set { SetColumn(14, value); }
        }
        [DataMember(Name = "column15")]
        private TransactionItem column15
        {
            get { return GetColumn(15); }
            set { SetColumn(15, value); }
        }
        [DataMember(Name = "column16")]
        private TransactionItem column16
        {
            get { return GetColumn(16); }
            set { SetColumn(16, value); }
        }
        [DataMember(Name = "column17")]
        private TransactionItem column17
        {
            get { return GetColumn(17); }
            set { SetColumn(17, value); }
        }
        [DataMember(Name = "column18")]
        private TransactionItem column18
        {
            get { return GetColumn(18); }
            set { SetColumn(18, value); }
        }
        [DataMember(Name = "column19")]
        private TransactionItem column19
        {
            get { return GetColumn(19); }
            set { SetColumn(19, value); }
        }
        [DataMember(Name = "column20")]
        private TransactionItem column20
        {
            get { return GetColumn(20); }
            set { SetColumn(20, value); }
        }
        [DataMember(Name = "column21")]
        private TransactionItem column21
        {
            get { return GetColumn(21); }
            set { SetColumn(21, value); }
        }
        [DataMember(Name = "column22")]
        private TransactionItem column22
        {
            get { return GetColumn(22); }
            set { SetColumn(22, value); }
        }
        [DataMember(Name = "column23")]
        private TransactionItem column23
        {
            get { return GetColumn(23); }
            set { SetColumn(23, value); }
        }
        [DataMember(Name = "column24")]
        private TransactionItem column24
        {
            get { return GetColumn(24); }
            set { SetColumn(24, value); }
        }
        [DataMember(Name = "column25")]
        private TransactionItem column25
        {
            get { return GetColumn(25); }
            set { SetColumn(25, value); }
        }
        [DataMember(Name = "column26")]
        private TransactionItem column26
        {
            get { return GetColumn(26); }
            set { SetColumn(26, value); }
        }
    }
}
