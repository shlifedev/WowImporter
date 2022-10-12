using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine;

namespace Assets.UGS.UnityImpl
{
    internal class WebRequest : IWebRequest
    {
        IEnumerator Get(string url)
        {
            var request = UnityWebRequest.Get(url);
            var downloadHandler = new DownloadHandlerBuffer();
            yield return request.SendWebRequest();
        }

        public void Get(string url, string body, Action<string> callback)
        {
            
        }

        public void Post(string url, string body, Action<string> callback)
        {
            throw new NotImplementedException();
        }
    }
}
