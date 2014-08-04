using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Mach.Banking
{
    /// <summary>
    /// Information about returned bank account statement.
    /// </summary>
    [DataContract]
    public class AccountStatementInfo
    {
        /// <summary>
        /// Gets or sets number of the account.
        /// </summary>
        /// <returns>Number of the account.</returns>
        [DataMember(Name = "accountId")]
        public string AccountNumber { get; set; }
        /// <summary>
        /// Gets or sets bank code.
        /// </summary>
        /// <returns>Bank code.</returns>
        [DataMember(Name = "bankId")]
        public string BankId { get; set; }
        /// <summary>
        /// Gets or sets currency code of this statement according to the ISO 4217 standard.
        /// </summary>
        /// <returns>Currency code.</returns>
        [DataMember(Name = "currency")]
        public string Currency { get; set; }
        /// <summary>
        /// Gets or sets international bank account number according to the ISO 13616 standard.
        /// </summary>
        /// <returns>International bank account number.</returns>
        [DataMember(Name = "iban")]
        public string Iban { get; set; }
        /// <summary>
        /// Gets or sets bank identification code according to the ISO 9362 standard.
        /// </summary>
        /// <returns>Bank identification code.</returns>
        [DataMember(Name = "bic")]
        public string Bic { get; set; }
        [DataMember(Name = "openingBalance")]
        public decimal OpeningBalance { get; set; }
        [DataMember(Name = "closingBalance")]
        public decimal ClosingBalance { get; set; }

        //[DataMember(Name = "dateEnd")]
        //public DateTime DateEnd { get; set; }
        [DataMember(Name = "yearList")]
        public int? Year { get; set; }
        [DataMember(Name = "idList")]
        public int? Id { get; set; }
        [DataMember(Name = "idFrom")]
        public long? LastItemId { get; set; }
        [DataMember(Name = "idTo")]
        public long? FirstItemId { get; set; }
        [DataMember(Name = "idLastDownload")]
        public long? LastDownloadId { get; set; }

        [DataMember(Name = "dateStart")]
        private string DateStartReturned { get; set; }

        [IgnoreDataMember]
        // This property is used by your code.
        public DateTime DateStart
        {
            // Replace "o" with whichever DateTime format specifier you need.
            get
            {
                return DateTime.ParseExact(DateStartReturned.Substring(0, DateStartReturned.IndexOf("+")), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }
            set
            {
                DateStartReturned = value.ToString("o");
            }
        }
    }
}