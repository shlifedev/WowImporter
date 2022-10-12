using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.UGS.IO.Unity
{
    internal class FIleReader : IFileReader
    {
        public T Read<T>(string fromSrc)
        {
            var loadedFile = Resources.Load<TextAsset>(fromSrc);
            if (loadedFile) 
                return UnityEngine.JsonUtility.FromJson<T>(loadedFile.text); 
            else throw new Exception(string.Format("{0} file not found", fromSrc));
        } 
    }
}
