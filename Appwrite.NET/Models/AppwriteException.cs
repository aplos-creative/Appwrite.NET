using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
    public class AppwriteException : Exception
    {
        public int? Code;
        public string Response = null;
        public AppwriteException(string message = null, int? code = null, string response = null)
        : base(message)
        {
            this.Code = code;
            this.Response = response;
        }
        public AppwriteException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
