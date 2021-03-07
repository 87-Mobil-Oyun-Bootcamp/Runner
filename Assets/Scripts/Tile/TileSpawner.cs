using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner
{
    Transform tileContainer;

    List<GameObject> currentLevelTileObjects = new List<GameObject>();
    List<Tile> currentLevelTiles = new List<Tile>();

    int initialTileCount = 0;
    int currentTileIndex = -1;

    public TileSpawner(Transform tileContainer, int initialTileCount)
    {
        this.tileContainer = tileContainer;
        this.initialTileCount = initialTileCount;
    }

    public void SetTiles(List<GameObject> tilePrefabs)
    {
        currentLevelTileObjects.AddRange(tilePrefabs);

        tilePrefabs.DoForAll((item) =>
        {
            currentLevelTiles.Add(item.GetComponent<Tile>());
        });

        tilePrefabs.DoForAll((item, index) =>
        {
            currentLevelTiles.Add(item.GetComponent<Tile>());
        });
    }

    public void InitialSpawnTile()
    {
        for (int i = 0; i < initialTileCount; i++)
        {
            if (currentLevelTileObjects.Count < i)
            {
                break;
            }

            HandleSpawnTile(i);
        }
    }

    public void SpawnNextTile()
    {
        if (currentLevelTileObjects.Count <= currentTileIndex + 1)
        {
            currentTileIndex = -1;
        }

        HandleSpawnTile(currentTileIndex + 1);
    }

    void HandleSpawnTile(int index)
    {
        float endPositionZ = 0f;

        if (Tile.currentTiles.Count > 0)
        {
            var lastTile = Tile.currentTiles[Tile.currentTiles.Count - 1];

            endPositionZ = lastTile.transform.position.z + lastTile.size * .5f;
        }

        SpawnTile(currentLevelTileObjects[index], new Vector3(0f, 0f, endPositionZ + currentLevelTiles[index].size * .5f));
    }

    void SpawnTile(GameObject tileObject, Vector3 position)
    {
        Object.Instantiate(tileObject, position, Quaternion.identity, tileContainer);
        currentTileIndex++;
    }
}
