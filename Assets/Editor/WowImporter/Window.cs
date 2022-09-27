using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;

/*
 * 이렇게 작동시키자.
 * 0. ProjectPath/Exporter 경로에 Wow Exporter 구성요소가 있는지 확인
 * 1. 없는경우 github 에 다운로드요청 -> modifier node에 api 통신용 코드 주입)
 * 1-2. 있는경우 패스, 인젝션 필요없음
 * 2. Run Unity -> Wow Exporter
 * 3. Reg Process Info to Unity, and Wow Exporter Open Local Server 
 */


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
    public static class NetworkingHelper
    {
        public static UnityEngine.Networking.UnityWebRequest CreateDefaultPostRequest()
        {
            using (var request = new UnityEngine.Networking.UnityWebRequest("url", "POST"))
            {
                request.uploadHandler = NetworkingHelper.CreateUploadHandler("");
                request.downloadHandler = NetworkingHelper.CreateDownloadHandler(); 
                return request;
            }
        }
        public static UnityEngine.Networking.UploadHandlerRaw CreateUploadHandler(string json)
        {
            var handler = new UnityEngine.Networking.UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(json));
            return handler;
        }
        public static UnityEngine.Networking.DownloadHandler CreateDownloadHandler()
        {
            UnityEngine.Networking.DownloadHandler handler = null;
            handler = new UnityEngine.Networking.DownloadHandlerBuffer();
            return handler;
        }
    }

    public static class APIImpls
    {
        public static IEnumerator SetExportDirectory()
        {
            using (var request = NetworkingHelper.CreateDefaultPostRequest())
            {
                yield return null;
            } 
        }
    }

    internal class Window
    { 
         
    }
}
