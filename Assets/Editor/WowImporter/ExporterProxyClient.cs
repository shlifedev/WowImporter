using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
namespace Assets.Editor.WowImporter
{
    public enum API
    {
        SetExportDirectory = 0,
        GetModels = 100,
        GetItems = 101,
        GetTextures = 102,
        GetAudios = 103,
        GetVideos = 104,
        GetMaps = 105,
        GetTexts = 106,
        Export = 200
    }
    public class Controll<Message>
    {
        public API command;
        public Message jsonSerializeableMessage;
    }

    internal class ExporterProxyClient
    {

        enum ContentType
        {
            String
        }
        private UnityEngine.Networking.UploadHandlerRaw CreateUploadHandler(string json)
        {
            var handler = new UnityEngine.Networking.UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(json));
            return handler;
        }
        private UnityEngine.Networking.DownloadHandler CreateDownloadHandler()
        {
            UnityEngine.Networking.DownloadHandler handler = null;
            handler = new UnityEngine.Networking.DownloadHandlerBuffer();
            return handler;
        } 

        IEnumerator SetExportDirectory()
        {
            using (var request = new UnityEngine.Networking.UnityWebRequest("url", "POST"))
            {
                request.uploadHandler = CreateUploadHandler("");
                request.downloadHandler = CreateDownloadHandler();
                yield return request.SendWebRequest();
                var downloadedJson = request.downloadHandler.text;
            }
        }
        IEnumerator ReqFileList()
        { 
            using(var request = new UnityEngine.Networking.UnityWebRequest("url", "POST")){
                request.uploadHandler = CreateUploadHandler("");
                request.downloadHandler = CreateDownloadHandler();
                yield return request.SendWebRequest(); 
                var downloadedJson = request.downloadHandler.text;
            } 
     
        } 

        IEnumerator Download()
        {
            yield return null;
        } 
    }
}
