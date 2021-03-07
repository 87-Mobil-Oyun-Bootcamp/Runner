using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="LevelInfoAsset", menuName ="Level/Level Info Asset")]
public class LevelInfoAsset : ScriptableObject
{
    [Space]
    public List<GameObject> tilePrefabs = new List<GameObject>();
}
