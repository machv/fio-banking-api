using System;
using System.IO;
using System.Net;
using System.Text;

namespace Mach.Banking.Fio
{
    public class FioBank
    {
        private const string _base = "https://www.fio.cz/ib_api/rest/";
        private readonly string _token;

        public FioBank(string token)
        {
            _token = token;
        }

        public AccountStatementResponse GetTransactions(DateTime from, DateTime to)
        {
            WebClient wc = new WebClient();
            string address = BuildAddress("periods", "transactions", from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));

            AccountStatementResponse statement;
            JsonSerializer serializer = new JsonSerializer();
            using (Stream stream = wc.OpenRead(address))
            {
                statement = serializer.Deserialize<AccountStatementResponse>(stream);
                return statement;
            }
        }

        private string BuildAddress(string action, string document, params string[] parameters)
        {
            StringBuilder address = new StringBuilder();
            address.Append(_base);
            address.Append(action);
            address.Append('/');
            address.Append(_token);
            address.Append('/');

            if (parameters != null)
            {
                foreach (string parameter in parameters)
                {
                    address.Append(parameter);
                    address.Append('/');
                }
            }

            if (document != null)
            {
                address.Append(document);
                address.Append(".json");
            }

            return address.ToString();
        }
    }
}
