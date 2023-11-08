using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public interface IError
    {
        int ErrorCode { get; set; }
        string Description { get; set; }
        void SendMail();
    }
}
