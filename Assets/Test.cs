using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
public class Test : MonoBehaviour
{

    void Test()
    {
        WowMapLoader.WowMap.Keys.ToList().ForEach(map => {
            Debug.Log("map list (directory name) " + map + ","  +  WowMapLoader.WowMap[map].Keys.Count);
            WowMapLoader.WowMap[map].Keys.ToList().ForEach(tile => {
                Debug.Log($"{map} tile => {tile}");
                
            });
        });

    }
    private void Start()
    {
        Test();

    }
}
