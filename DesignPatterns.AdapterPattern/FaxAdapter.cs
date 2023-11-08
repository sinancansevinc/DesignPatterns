using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public class FaxAdapter : IError
    {
        public FaxAdapter(Fax fax)
        {
            Fax = fax;
            ErrorCode = fax.FaxErrorCode;
            Description = fax.ErrorDescription;
        }

        public Fax Fax { get; set; }
        public int ErrorCode { get; set; }
        public string Description { get; set; }

        public void SendMail()
        {
            Console.WriteLine($"{ErrorCode} {Description} => Fax error sent.");
        }
    }
}
