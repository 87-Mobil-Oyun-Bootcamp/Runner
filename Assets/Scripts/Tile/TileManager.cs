using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [Space]
    [SerializeField]
    Transform tileContainer;

    [Space]
    [SerializeField]
    PlayerController playerController;

    [Space]
    [SerializeField]
    int initialTileCount = 4;

    TileSpawner tileSpawner = null;
    TilePanner tilePanner;

    private void Awake()
    {
        tileSpawner = new TileSpawner(tileContainer, initialTileCount);
        tilePanner = new TilePanner(playerController);
    }

    private void Update()
    {
        tilePanner.Update();

        if (Tile.currentTiles.Count > 0 && Tile.currentTiles[0].transform.position.z < Tile.currentTiles[0].size * -0.75f)
        {
            Destroy(Tile.currentTiles[0].gameObject);
            tileSpawner.SpawnNextTile();
            Debug.Log("Spawned Next Tile!");
        }
    }

    public void SetCurrentLevelTiles(List<GameObject> tileObjects)
    {
        tileSpawner.SetTiles(tileObjects);
    }

    public void InitialSpawnTiles()
    {
        tileSpawner.InitialSpawnTile();
    }
}
