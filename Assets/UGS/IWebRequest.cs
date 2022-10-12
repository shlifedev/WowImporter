using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.UGS
{ 
    public interface IWebRequest
    {
        void Get(string url, string body, System.Action<string> callback);
        void Post(string url, string body, System.Action<string> callback);
    }
}
