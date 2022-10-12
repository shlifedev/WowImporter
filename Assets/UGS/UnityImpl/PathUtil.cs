using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.UGS.IO
{
    internal static class PathUtil
    {
        internal static string ToUnityAssetPath(string fullSrc)
        {
            var dataPath = UnityEngine.Application.dataPath;
            var length = dataPath.Length;
            return fullSrc.Substring(0, length) + "/Assets/";
        }
    }
}
