using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public class Fax
    {
        public Fax(int faxErrorCode, string errorDescription)
        {
            FaxErrorCode = faxErrorCode;
            ErrorDescription = errorDescription;
        }

        public int FaxErrorCode { get; set; }
        public string ErrorDescription { get; set; }

        void Send()
        {
            
        }

        void Get()
        {
            
        }
    }
}
