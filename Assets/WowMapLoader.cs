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
    public class PlacementMap : Dictionary<string, List<PlaceProps>> { }

    const int WOW_MAX_SIZE = 51200 / 3;
    const int MAP_SIZE = WOW_MAX_SIZE * 2;
    const int ADT_SIZE = WOW_MAX_SIZE / 64; 

    private static List<string> cache;
    public static List<string> PlacementPaths
    {
        get
        {
            if (cache == null) cache = FindAllPlacementPaths();
            return cache;
        }
    }
    private static PlacementMap mapCache;
    public static PlacementMap PlacementPropMap
    {
        get
        {
            if (mapCache == null)
            {
                PlacementMap map = new PlacementMap();
                List<PlaceProps> placeProps = null;
                var paths = PlacementPaths;
                paths.ForEach(x =>
                {
                    var fileName = System.IO.Path.GetFileName(x);
                    var raw = System.IO.File.ReadAllText(x);
                    placeProps = ParseRows(raw);
                    map[fileName] = placeProps;
                });
                mapCache =  map;
            }
            return mapCache;
        }
    }

    const string BASE_PATH = "Assets/wow/maps/";
    static List<string> FindAllPlacementPaths()
    {
        var dirInfo = new DirectoryInfo(BASE_PATH);
        var files = dirInfo.GetFiles("*.csv", SearchOption.AllDirectories).Where(x =>
        {
            return x.Name.Split('.')[0].EndsWith("ModelPlacementInformation") == true;
        });
        var paths = files.ToList().Select(x => "Assets" + x.FullName.Substring(Application.dataPath.Length));
        return paths.ToList();
    }

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