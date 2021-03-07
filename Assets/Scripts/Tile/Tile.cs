using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [Space]
    public float size = 10f;

    public static List<Tile> currentTiles = new List<Tile>();

    private void OnEnable()
    {
        currentTiles.Add(this);
    }

    private void OnDisable()
    {
        currentTiles.Remove(this);    
    }
}
