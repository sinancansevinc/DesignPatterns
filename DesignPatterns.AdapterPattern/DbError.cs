using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public class DbError : IError
    {
        public DbError(int errorCode, string description)
        {
            ErrorCode = errorCode;
            Description = description;
        }

        public int ErrorCode { get; set; }
        public string Description { get; set;}
        public void SendMail()
        {
            Console.WriteLine($"{ErrorCode} {Description} => Db error sent.");
        }
    }
}
