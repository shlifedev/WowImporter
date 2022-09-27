using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
public class WowPlacementImporter : MonoBehaviour
{

    private void Start()
    {
        var keys = WowMapLoader.PlacementPropMap.Keys.ToList();
        keys.ForEach(x => {
            Debug.Log("has key : " + x);
            
        });



    }
}
