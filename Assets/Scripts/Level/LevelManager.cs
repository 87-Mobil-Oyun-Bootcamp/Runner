using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [Space]
    public LevelAttributesInfoAsset levelAttributesInfoAsset;

    [Space]
    [SerializeField]
    TileManager tileManager;

    public void CreateLevel(int level)
    {
        tileManager.SetCurrentLevelTiles(levelAttributesInfoAsset.levelInfoAssets[level - 1].tilePrefabs);
        tileManager.InitialSpawnTiles();
    }
}
