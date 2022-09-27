using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
public class WowMapLoader
{
    public class PlaceProps
    {
        public string ModelFile;
        public Vector3 Position;
        public Quaternion Rotation;
        public float ScaleFactor;
        public int ModelId;
        public string FileDataId;
        public int DoodadIndexes;
        public int DoodadSetName;
    }
    public class TilePlacementDictionary : Dictionary<string, List<PlaceProps>> {
        public List<PlaceProps> GetAllPlaceProps()
        {
            List<PlaceProps> props = new List<PlaceProps>();
            this.Values.ToList().ForEach(x => props.AddRange(x));
            return props;
        }
    }
    public class WowMapDictionary : Dictionary<string, TilePlacementDictionary> { }

    /**
     *  와우 좌표계
     */


    const int WOW_MAX_SIZE = 51200 / 3;
    const int MAP_SIZE = WOW_MAX_SIZE * 2;
    const int ADT_SIZE = WOW_MAX_SIZE / 6;
    const string BASE_PATH = "Assets/wow/maps/";
    static DirectoryInfo Dir => new DirectoryInfo(BASE_PATH);
    static List<string> MapNames
    {
        get
        {
            return Dir.GetDirectories().Select(x => x.Name).ToList();
        }
    }
    private static WowMapDictionary mapCache;
    public static WowMapDictionary WowMap
    {
        get
        {
            if (mapCache == null)
            {
                WowMapDictionary mapDict = new WowMapDictionary();
                MapNames.ForEach(mapName =>
                {

                    TilePlacementDictionary map = new TilePlacementDictionary();

                    List<PlaceProps> placeProps = null;
                    //basepath+mapname 경로에있는 파일들을 가져옴
                    var tileRaws = (new System.IO.DirectoryInfo(BASE_PATH + mapName))
                    .GetFiles("*.csv")
                    .Where(x => x.Name.Split('.')[0]
                    .EndsWith("ModelPlacementInformation"))
                    .Select(x => "Assets" + x.FullName
                    .Substring(Application.dataPath.Length)).ToList();

                    // 파일 raw 순회
                    tileRaws.ForEach(x =>
                {
                    var fileName = System.IO.Path.GetFileName(x);
                    var raw = System.IO.File.ReadAllText(x);
                    placeProps = ParseRows(raw);
                    map[fileName] = placeProps;
                });
                    mapDict[mapName] = map;
                });

                mapCache = mapDict;
            }
            return mapCache;
        }
    }

    public static TilePlacementDictionary GetMapData(string mapName) => WowMap[mapName];
    



    static List<PlaceProps> ParseRows(string raw)
    {
        List<PlaceProps> placements = new List<PlaceProps>(); 
        var lines = raw.Split('\n');
        for (int i = 1; i < lines.Length; i++)
        {
            int idx = 0;
            var row = lines[i].Split(';');
            var placementProp = new PlaceProps();
            var filePath = row[idx++];

            var combined = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(BASE_PATH), filePath);
            var dirInfo = new System.IO.DirectoryInfo(combined);
            var assetsPath = "Assets" + dirInfo.FullName.Substring(Application.dataPath.Length);
            placementProp.ModelFile = assetsPath;
            placementProp.Position = GetADTLocVec(new Vector3(float.Parse(row[idx++]), float.Parse(row[idx++]), float.Parse(row[idx++])));

            placements.Add(placementProp);
        }
        return placements;
    }
 
    static float GetADTLoc(float value)
    {
        return WOW_MAX_SIZE - value;
    }
    static Vector3 GetADTLocVec(Vector3 value)
    {
        return new Vector3(-GetADTLoc(value.x), value.y, GetADTLoc(value.z));
    }
}