using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.UGS.IO
{
    internal interface IFileReader
    {
        T Read<T>(string fromSrc); 
    }
    internal interface IFileWriter
    {
        void Write<T>(T toSrc);
    }
}
